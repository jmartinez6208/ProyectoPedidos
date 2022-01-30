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
    [Activity(Label = "RepartidorActivity")]
    public class RepartidorActivity : Activity
    {

        private UsuarioWCF wcfUsuario = new UsuarioWCF();
        private UsuarioEntidades repartidorEntidad = new UsuarioEntidades();

        private PedidoWCF wcfPedido = new PedidoWCF();
        private List<PedidoEntidades> pedidoEntidad = new List<PedidoEntidades>();

        TextView nombre;
        ListView listaPedidos;
        Button misPedidos;

        private string userRepartidor;
        private int idRepartidor;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_repartidor);
            // Create your application here
            botones();
            inicializarDatos();
        }

        private void inicializarDatos()
        {
            userRepartidor = Intent.Extras.GetString("username","na");
            repartidorEntidad = wcfUsuario.DevolverUsuario(userRepartidor);
            idRepartidor = repartidorEntidad.Id;

            //Text
            nombre.Text = "Bienvenido " + repartidorEntidad.Nombre;

            //ListView
            pedidoEntidad = wcfPedido.DevolverListaPedidosEstadoPendiente().ToList();
            listaPedidos.Adapter = new PedidosRepartidorAdapter(this, pedidoEntidad);
        }

        private void botones()
        {
            nombre = FindViewById<TextView>(Resource.Id.txtRepartidor);            
            misPedidos = FindViewById<Button>(Resource.Id.btnRepartidorMisPedidos);

            listaPedidos = FindViewById<ListView>(Resource.Id.listViewPedidosRepartidor);
            listaPedidos.ItemClick += clickListaPedido;

        }

        private void clickListaPedido(object sender, AdapterView.ItemClickEventArgs e)
        {
            var idPedido = (int)e.Id;
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Tomar nuevo pedido");
            alert.SetMessage("Desea tomar este pedido?");

            alert.SetPositiveButton("Si", (senderAlert, args) =>
            {
                try
                {
                    bool boolxd = true;
                    bool bool2xd = true;
                    wcfPedido.AsignarRepartidor((int)e.Id, true, "asignado", idRepartidor, true ,out boolxd, out bool2xd);
                    Toast.MakeText(Application.Context, "Ha tomado el pedido: " + idPedido, ToastLength.Short).Show();
                    var intent = new Intent(this, typeof(DetallePedidoRepartidor));
                    intent.PutExtra("idPedido", idPedido);
                    StartActivity(intent);
                    this.Finish();
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "No se puede asginar el pedido.", ToastLength.Short).Show();
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
    }
}