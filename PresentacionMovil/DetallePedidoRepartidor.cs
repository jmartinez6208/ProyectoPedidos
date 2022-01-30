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
    [Activity(Label = "DetallePedidoRepartidor")]
    public class DetallePedidoRepartidor : Activity
    {

        private PedidoWCF wcfPedido = new PedidoWCF();
        private PedidoEntidades pedidoEntidad = new PedidoEntidades();

        private DetallePedido wcfDetallePedido = new DetallePedido();
        private List<DetallePedidoEntidades> detallePedidoEntidad = new List<DetallePedidoEntidades>();

        private UsuarioWCF wcfUsuario = new UsuarioWCF();
        private UsuarioEntidades repartidorEntidad = new UsuarioEntidades();

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

            repartidorEntidad = wcfUsuario.DevolverUsuarioPorId(pedidoEntidad.IdRepartidor, true);

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

        public override void OnBackPressed()
        {
            var intent = new Intent(this, typeof(RepartidorActivity));
            intent.PutExtra("username", repartidorEntidad.User);
            StartActivity(intent);
            this.Finish();
        }

        private void conseguirDetalle(object sender, AdapterView.ItemClickEventArgs e)
        {
            var detallePedido = wcfDetallePedido.DevolverDetallePorId((int)e.Id, true);
            if (detallePedido.Conseguido.Equals('n'))
            {

                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Producto Conseguido");
                alert.SetMessage("Desea marcar el producto como conseguido?");

                alert.SetPositiveButton("Sí, lo tengo", (senderAlert, args) =>
                {
                    try
                    {
                        bool boolxd = true;
                        bool bool2xd = true;
                        wcfDetallePedido.MarcarConseguido(detallePedido.Id, true, 's', true, out boolxd, out bool2xd);
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

            if (detallePedido.Conseguido.Equals('s'))
            {
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Desmarcar producto conseguido");
                alert.SetMessage("Desea marcar el producto como NO conseguido?");

                alert.SetPositiveButton("Sí", (senderAlert, args) =>
                {
                    try
                    {
                        bool boolxd = true;
                        bool bool2xd = true;
                        wcfDetallePedido.MarcarConseguido(detallePedido.Id, true, 'n', true, out boolxd, out bool2xd);
                        wcfPedido.actualizarTotalConseguido(pedidoEntidad.Id, true, (detallePedido.Subtotal*-1), true, out boolxd, out bool2xd);
                        Toast.MakeText(Application.Context, "Producto descartado.", ToastLength.Short).Show();
                        inicializarDatos();
                    }
                    catch (Exception)
                    {
                        Toast.MakeText(Application.Context, "No se puede desmarcar.", ToastLength.Short).Show();
                        throw;
                    }

                });

                alert.SetNegativeButton("No", (senderAlert, args) =>
                {

                });

                Dialog dialog = alert.Create();
                dialog.Show();
            }
            
        }

        private void concluirButon(object sender, EventArgs e)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Finalizar Pedido");
            alert.SetMessage("Desea marcar su pedido como completado?");

            alert.SetPositiveButton("Sí, lo completé", (senderAlert, args) =>
            {
                try
                {
                    bool boolxd = true;
                    bool bool2xd = true;
                    wcfPedido.ActualizarEstado(idPedido, true, "completado", out boolxd, out bool2xd);
                    Toast.MakeText(Application.Context, "Pedido completado.", ToastLength.Short).Show();
                    var intent = new Intent(this, typeof(RepartidorActivity));
                    intent.PutExtra("username", repartidorEntidad.User);
                    StartActivity(intent);
                    this.Finish();
                }
                catch (Exception)
                {

                    throw;
                }
            });

            alert.SetNegativeButton("No", (senderAlert, args) =>
            {

            });

            Dialog dialog = alert.Create();
            dialog.Show();
            
        }
    }
}