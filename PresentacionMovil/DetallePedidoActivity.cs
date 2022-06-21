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
using PresentacionMovil.wcfUsuario;
using PresentacionMovil.Adaptadores;

namespace PresentacionMovil
{
    [Activity(Label = "DetallePedidoActivity")]
    public class DetallePedidoActivity : Activity
    {
        private PedidoWCF wcfPedido = new PedidoWCF();
        private PedidoEntidades pedidoEntidad = new PedidoEntidades();

        private DetallePedido wcfDetallePedido = new DetallePedido();
        private List<DetallePedidoEntidades> detallePedidoEntidades = new List<DetallePedidoEntidades>();

        private UsuarioWCF wcfUsuario = new UsuarioWCF();
        private UsuarioEntidades usuarioEntidad = new UsuarioEntidades();
        private UsuarioEntidades clienteEntidad = new UsuarioEntidades();

        TextView pedido, fecha, estado, repartidor, total, continuar;
        ListView listaDetallePedidos;
        Button btnListo;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_detallePedido);
            // Create your application here
            botones();
            inicializarDatos();
        }

        private void inicializarDatos()
        {
            var idPedido = Intent.Extras.GetInt("idPedidoDet");
            pedidoEntidad = wcfPedido.DevolverPedidoPorId(idPedido, true);

            usuarioEntidad = wcfUsuario.DevolverUsuarioPorId(pedidoEntidad.IdRepartidor, true);
            clienteEntidad = wcfUsuario.DevolverUsuarioPorId(pedidoEntidad.IdCliente, true);

            detallePedidoEntidades = wcfDetallePedido.DevolerListaDetallesPorPedido(idPedido, true).ToList();
            listaDetallePedidos.Adapter = new CarritoAdapter(this, detallePedidoEntidades);

            //TextView
            pedido.Text = "Pedido: " + pedidoEntidad.Id;
            fecha.Text = "Fecha: " + pedidoEntidad.FechaCreacion;
            repartidor.Text = "Repartidor: " + usuarioEntidad.Nombre;
            estado.Text = "Estado: " + pedidoEntidad.Estado;
            total.Text = "Total: $" + pedidoEntidad.Total.ToString();

            if (!pedidoEntidad.Estado.Equals("nuevo"))
            {
                continuar.Enabled = false;
            }

        }

        private void botones()
        {
            pedido = FindViewById<TextView>(Resource.Id.txtTituloDetallePedido);
            fecha = FindViewById<TextView>(Resource.Id.txtFechaDetallePedido);
            repartidor = FindViewById<TextView>(Resource.Id.txtRepartidorDetallePedido);
            estado = FindViewById<TextView>(Resource.Id.txtEstadoDetallePedido);
            total = FindViewById<TextView>(Resource.Id.txtTotalDetallePedido);            

            listaDetallePedidos = FindViewById<ListView>(Resource.Id.listViewDetallePedido);

            continuar = FindViewById<Button>(Resource.Id.btnConfirmarDetallePedido);
            continuar.Click += continuarClick;

            btnListo = FindViewById<Button>(Resource.Id.btnListoDetallePedido);
            btnListo.Click += listoClick;
        }

        public override void OnBackPressed()
        {
            var intent = new Intent(this, typeof(PedidosActivity));
            intent.PutExtra("username", clienteEntidad.User);
            StartActivity(intent);
            this.Finish();
        }

        private void continuarClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(ProductosActivity));
            intent.PutExtra("origen", 2);
            intent.PutExtra("idPedidoCarrito", pedidoEntidad.Id);
            StartActivity(intent);
        }

        private void listoClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(PedidosActivity));
            intent.PutExtra("username", clienteEntidad.User);
            StartActivity(intent);
            this.Finish();
        }
    }
}