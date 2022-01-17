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

using PresentacionMovil.asmxUsuario;
using PresentacionMovil.asmxPedido;
using PresentacionMovil.Adaptadores;

namespace PresentacionMovil
{
    [Activity(Label = "PedidosActivity")]
    public class PedidosActivity : Activity
    {
        private UsuarioAsmx clienteAsmx = new UsuarioAsmx();
        private UsuarioEntidades usuarioEntidad = new UsuarioEntidades();

        private PedidoAsmx pedidoAsmx = new PedidoAsmx();

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
        }

        private void inicializarDatos()
        {
            var username = Intent.Extras.GetString("username");
            usuarioEntidad = clienteAsmx.DevolverUsuario(username);
            bienvenido.Text = "Bienvenido " + usuarioEntidad.Nombre;

            
            var pedidoEntidad = pedidoAsmx.DevolverListaPedidos().ToList();
            pedidosListView.Adapter = new PedidosAdapter(this, pedidoEntidad);
        }
    }
}