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
using PresentacionMovil.wcfDetallePedido;

namespace PresentacionMovil
{
    [Activity(Label = "CarritoActivity")]
    public class CarritoActivity : Activity
    {

        private PedidoWCF wcfPedido = new PedidoWCF();
        private PedidoEntidades pedidoEntidad = new PedidoEntidades();

        private DetallePedido wcfDetallePedido = new DetallePedido();
        private DetallePedidoEntidades detallePedidoEntidad = new DetallePedidoEntidades();

        ListView listaDetalles;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_carrito);
            // Create your application here
            botones();
            inicializarDatos();
        }

        private void botones()
        {
            listaDetalles = (ListView)FindViewById<ListView>(Resource.Id.listViewCarrito);

        }

        private void inicializarDatos()
        {
            var idPedido = Intent.Extras.GetInt("idPedido");
            Toast.MakeText(Application.Context, idPedido.ToString(), ToastLength.Short).Show();
        }
    }
}