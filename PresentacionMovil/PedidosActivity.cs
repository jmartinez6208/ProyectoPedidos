using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PresentacionMovil.wcfPedido;
using PresentacionMovil.wcfUsuario;

//using PresentacionMovil.asmxUsuario;
//using PresentacionMovil.asmxPedido;
using PresentacionMovil.Adaptadores;

namespace PresentacionMovil
{
    [Activity(Label = "PedidosActivity")]
    public class PedidosActivity : Activity
    {

        private UsuarioWCF clienteWCF = new UsuarioWCF();
        //private UsuarioAsmx clienteAsmx = new UsuarioAsmx();
        public static UsuarioEntidades usuarioEntidad = new UsuarioEntidades();


        private PedidoWCF pedidoWCF = new PedidoWCF();
        //private PedidoAsmx pedidoAsmx = new PedidoAsmx();
        private List<PedidoEntidades> pedidoEntidad = new List<PedidoEntidades>();

        Button botonPedido;
        TextView bienvenido;
        ListView pedidosListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_pedidos);
            // Create your application here
            botones();
            inicializarDatos();
        }

        public override void OnBackPressed()
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Salir");
            alert.SetMessage(usuarioEntidad.Nombre + " desea salir de la sesión actual?");

            alert.SetPositiveButton("Si", (senderAlert, args) =>
            {
                try
                {
                    var intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                    this.Finish();
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "No se puede salir.", ToastLength.Short).Show();
                    throw;
                }

            });

            alert.SetNegativeButton("No", (senderAlert, args) =>
            {
                inicializarDatos();
            });

            Dialog dialog = alert.Create();
            dialog.Show();
        }

        private void botones()
        {
            bienvenido = (TextView)FindViewById(Resource.Id.txtUsuarioPedidos);
            pedidosListView = FindViewById<ListView>(Resource.Id.listViewPedidos);
            pedidosListView.ItemClick += clickItemListView;
            botonPedido = (Button) FindViewById<Button>(Resource.Id.btnNuevoPedido);
            botonPedido.Click += NuevoPedidoClick;
        }

        private void clickItemListView(object sender, AdapterView.ItemClickEventArgs e)
        {
            var idPedido = (int)e.Id;
            var intent = new Intent(this, typeof(DetallePedidoActivity));
            intent.PutExtra("idPedidoDet", idPedido);
            StartActivity(intent);
            this.Finish();
        }

        private void NuevoPedidoClick(object sender, EventArgs e)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Crear nuevo pedido?");
            alert.SetMessage("Si crea un nuevo pedido se eliminarán los pedidos que no haya confirmado.");

            alert.SetPositiveButton("Crear nuevo", (senderAlert, args) =>
            {
                try
                {
                    bool boolxd = true;
                    bool bool2xd = true;
                    pedidoWCF.EliminarPedidosIncompletos(out boolxd, out bool2xd);
                }
                catch (Exception)
                {

                    throw;
                }

                var intent = new Intent(this, typeof(ProductosActivity));
                intent.PutExtra("origen", 1);
                StartActivity(intent);
            });

            alert.SetNegativeButton("No", (senderAlert, args) =>
            {
                
            });

            Dialog dialog = alert.Create();
            dialog.Show();
        }

        private void inicializarDatos()
        {
            var username = Intent.Extras.GetString("username");
            usuarioEntidad = clienteWCF.DevolverUsuario(username);
            bienvenido.Text = "Bienvenido " + usuarioEntidad.Nombre;

            pedidoEntidad = pedidoWCF.DevolverListaPedidosPorCliente(usuarioEntidad.Id, true).ToList();
            pedidosListView.Adapter = new PedidosAdapter(this, pedidoEntidad);
        }
    }
}