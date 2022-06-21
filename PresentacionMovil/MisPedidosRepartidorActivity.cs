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

using PresentacionMovil.wcfUsuario;
using PresentacionMovil.wcfPedido;
using PresentacionMovil.Adaptadores;

namespace PresentacionMovil
{
    [Activity(Label = "MisPedidosRepartidorActivity")]
    public class MisPedidosRepartidorActivity : Activity
    {
        private UsuarioWCF wcfUsuario = new UsuarioWCF();
        private UsuarioEntidades repartidorEntidad = new UsuarioEntidades();

        private PedidoWCF wcfPedido = new PedidoWCF();
        private List<PedidoEntidades> pedidoEntidad = new List<PedidoEntidades>();


        TextView nombre;
        ListView listaPedidos;
        Button btnListo;

        private string userRepartidor;
        private int idRepartidor;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_mispedidos_repartidor);
            // Create your application here

            botones();
            inicializarDatos();

        }

        private void inicializarDatos()
        {
            userRepartidor = Intent.Extras.GetString("username", "na");
            repartidorEntidad = wcfUsuario.DevolverUsuario(userRepartidor);
            idRepartidor = repartidorEntidad.Id;

            //Text
            nombre.Text = "Bienvenido " + repartidorEntidad.Nombre;

            //ListView
            pedidoEntidad = wcfPedido.DevolverListaPedidosPorRepartidor(idRepartidor,true).ToList();
            listaPedidos.Adapter = new PedidosRepartidorAdapter(this, pedidoEntidad);
        }

        private void botones()
        {
            nombre = FindViewById<TextView>(Resource.Id.txtRepartidorMisPedidos);
            btnListo = FindViewById<Button>(Resource.Id.btnListoMisPedidos);
            btnListo.Click += clickListo;

            listaPedidos = FindViewById<ListView>(Resource.Id.listViewPedidosMisPedidos);
            listaPedidos.ItemClick += clickListaPedido;
        }

        private void clickListaPedido(object sender, AdapterView.ItemClickEventArgs e)
        {
            var idPedido = (int)e.Id;
            var pedido = wcfPedido.DevolverPedidoPorId(idPedido, true);
            if (pedido.Estado.Equals("asignado"))
            {
                try
                {
                    var intent = new Intent(this, typeof(DetallePedidoRepartidor));
                    intent.PutExtra("idPedido", idPedido);
                    StartActivity(intent);
                    this.Finish();
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "No se puede abrir el pedido.", ToastLength.Short).Show();
                    throw;
                }
            }
        }

        public override void OnBackPressed()
        {
            var intent = new Intent(this, typeof(RepartidorActivity));
            intent.PutExtra("username", repartidorEntidad.User);
            StartActivity(intent);
            this.Finish();
        }
        private void clickListo(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RepartidorActivity));
            intent.PutExtra("username", repartidorEntidad.User);
            StartActivity(intent);
            this.Finish();
        }
    }
}