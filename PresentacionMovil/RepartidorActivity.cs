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

            //Text
            nombre.Text = "Bienvenido " + repartidorEntidad.Nombre;

            //ListView
            //pedidoEntidad = wcfPedido.DevolverListaPedidosPorCliente(usuarioEntidad.Id, true).ToList();
            //pedidosListView.Adapter = new PedidosAdapter(this, pedidoEntidad);
        }

        private void botones()
        {
            nombre = FindViewById<TextView>(Resource.Id.txtRepartidor);            
            misPedidos = FindViewById<Button>(Resource.Id.btnRepartidorMisPedidos);

            listaPedidos = FindViewById<ListView>(Resource.Id.listViewPedidosRepartidor);

        }
    }
}