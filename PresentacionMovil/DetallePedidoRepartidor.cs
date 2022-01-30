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
using PresentacionMovil.Adaptadores;

namespace PresentacionMovil
{
    [Activity(Label = "DetallePedidoRepartidor")]
    public class DetallePedidoRepartidor : Activity
    {

        private PedidoWCF wcfPedido = new PedidoWCF();
        private PedidoEntidades pedidoEntidad = new PedidoEntidades();

        private DetallePedido wcfDetallePedido = new DetallePedido();
        private List<DetallePedidoEntidades> detallePedidoEntidad = new List<DetallePedidoEntidades>();



        TextView titulo, fecha, total, conseguido;
        Button concluir;
        ListView listaDetalles;

        private int idPedido;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_detalle_repartidor);
            // Create your application here
            botones();
            inicializarDatos();
        }

        private void inicializarDatos()
        {
            idPedido = Intent.Extras.GetInt("idPedido",0);
            pedidoEntidad = wcfPedido.DevolverPedidoPorId(idPedido, true);
            

            //TextView
            titulo.Text = "Pedido por entregar: " + pedidoEntidad.Id;
            fecha.Text = "Fecha: " + pedidoEntidad.FechaCreacion;
            total.Text = "Total: $" + pedidoEntidad.Total;
            conseguido.Text = "Conseguido: $" + pedidoEntidad.TotalConseguido.ToString();

            //ListView
            detallePedidoEntidad = wcfDetallePedido.DevolerListaDetallesPorPedido(idPedido, true).ToList();
            listaDetalles.Adapter = new DetallePedidoRepartidorAdapter(this, detallePedidoEntidad);

        }

        private void botones()
        {
            titulo = FindViewById<TextView>(Resource.Id.txtTituloDetalleRepartidor);
            fecha = FindViewById<TextView>(Resource.Id.txtFechaDetalleRepartidor);
            total = FindViewById<TextView>(Resource.Id.txtTotalDetalleRepartidor);
            conseguido = FindViewById<TextView>(Resource.Id.txtConseguidoDetalleRepartidor);
            concluir = FindViewById<Button>(Resource.Id.btnConcluirEntrega);
            concluir.Click += concluirButon;

            listaDetalles = FindViewById<ListView>(Resource.Id.listViewDetalleRepartidor);
            listaDetalles.ItemClick += conseguirDetalle;
        }

        private void conseguirDetalle(object sender, AdapterView.ItemClickEventArgs e)
        {
            var idDetalle = (int)e.Id;
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("ProductoConseguido");
            alert.SetMessage("Desea marcar el producto como conseguido?");

            alert.SetPositiveButton("Sí, lo tengo", (senderAlert, args) =>
            {
                try
                {
                    bool boolxd = true;
                    bool bool2xd = true;
                    wcfDetallePedido.MarcarConseguido((int)e.Id, true, out boolxd, out bool2xd);
                    var detallePedido = wcfDetallePedido.DevolverDetallePorId((int)e.Id, true);
                    wcfPedido.actualizarTotalConseguido(pedidoEntidad.Id, true, detallePedido.Subtotal, true, out boolxd, out bool2xd);
                    Toast.MakeText(Application.Context, "Producto conseguido.", ToastLength.Short).Show();
                    inicializarDatos();
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "No se puede conseguir el producto.", ToastLength.Short).Show();
                    throw;
                }

            });

            alert.SetNegativeButton("No", (senderAlert, args) =>
            {
            });

            Dialog dialog = alert.Create();
            dialog.Show();
        }

        private void concluirButon(object sender, EventArgs e)
        {
            
        }
    }
}