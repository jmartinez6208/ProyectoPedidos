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


        private void botones()
        {
            bienvenido = (TextView)FindViewById(Resource.Id.txtUsuarioPedidos);
            pedidosListView = FindViewById<ListView>(Resource.Id.listViewPedidos);
            botonPedido = (Button) FindViewById<Button>(Resource.Id.btnNuevoPedido);
            botonPedido.Click += NuevoPedidoClick; 
        }

        private void NuevoPedidoClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(ProductosActivity));
            intent.PutExtra("idCliente",usuarioEntidad.Id);
            StartActivity(intent);
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