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
    [Activity(Label = "CarritoActivity")]
    public class CarritoActivity : Activity
    {

        private PedidoWCF wcfPedido = new PedidoWCF();
        private PedidoEntidades pedidoEntidad = new PedidoEntidades();

        private DetallePedido wcfDetallePedido = new DetallePedido();
        private List<DetallePedidoEntidades> detallePedidoEntidad = new List<DetallePedidoEntidades>();

        ListView listaDetalles;
        TextView pedido, fecha, total;
        Button confirmar;

        private int idPedido;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_carrito);
            // Create your application here
            botones();
            inicializarDatos();
        }

        public override void OnBackPressed()
        {
            var intent = new Intent(this, typeof(ProductosActivity));
            intent.PutExtra("origen", 2);
            intent.PutExtra("idPedidoCarrito", pedidoEntidad.Id);
            StartActivity(intent);
        }

        private void inicializarDatos()
        {
            idPedido = Intent.Extras.GetInt("idPedido");
            Toast.MakeText(Application.Context, idPedido.ToString(), ToastLength.Short).Show();

            //ListView
            detallePedidoEntidad = wcfDetallePedido.DevolerListaDetallesPorPedido(idPedido, true).ToList();
            listaDetalles.Adapter = new CarritoAdapter(this, detallePedidoEntidad);

            //TextView
            pedidoEntidad = wcfPedido.DevolverPedidoPorId(idPedido, true);
            pedido.Text = "Pedido: " + pedidoEntidad.Id;
            fecha.Text = "Fecha: " + pedidoEntidad.FechaCreacion;
            total.Text = "Total: $" + pedidoEntidad.Total.ToString();
        }

        private void botones()
        {
            listaDetalles = (ListView)FindViewById<ListView>(Resource.Id.listViewCarrito);
            listaDetalles.ItemClick += eliminarProducto;
            pedido = FindViewById<TextView>(Resource.Id.txtTituloCarrito);
            fecha = FindViewById<TextView>(Resource.Id.txtFechaCarrito);
            total = FindViewById<TextView>(Resource.Id.txtTotalCarrito);

            confirmar = FindViewById<Button>(Resource.Id.btnConfirmarCarrito);
            confirmar.Click += clickConfirmarCarrito;
        }

        private void eliminarProducto(object sender, AdapterView.ItemClickEventArgs e)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Eliminar Producto");
            alert.SetMessage("Desea eliminar el producto de su pedido?");

            alert.SetPositiveButton("Eliminar", (senderAlert, args) =>
            {
                try
                {
                    bool boolxd = true;
                    bool bool2xd = true;
                    wcfDetallePedido.EliminarDetallePedidoPorId((int)e.Id, true, out boolxd, out bool2xd);
                    Toast.MakeText(Application.Context, "Producto eliminado del pedido", ToastLength.Short).Show();
                    inicializarDatos();
                    /*detallePedidoEntidad = wcfDetallePedido.DevolerListaDetallesPorPedido(idPedido, true).ToList();
                    listaDetalles.Adapter = new CarritoAdapter(this, detallePedidoEntidad);*/
                   
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "No se puede eliminar el producto.", ToastLength.Short).Show();
                    throw;
                }
                
            });

            alert.SetNegativeButton("No", (senderAlert, args) =>
            {
            });

            Dialog dialog = alert.Create();
            dialog.Show();
        }

        private void clickConfirmarCarrito(object sender, EventArgs e)
        {
            if (detallePedidoEntidad.Count <= 0)
            {
                Toast.MakeText(Application.Context, "No se puede confirmar un pedido sin productos en el carrito.", ToastLength.Short).Show();
            }
            else
            {
                try
                {
                    bool boolxd = true;
                    bool bool2xd = true;
                    wcfPedido.ActualizarEstado(pedidoEntidad.Id, true, "pendiente", out boolxd, out bool2xd);
                    Toast.MakeText(Application.Context, "Pedido: " + pedidoEntidad.Id.ToString() + " confirmado correctamente.", ToastLength.Short).Show();

                    var idPedido = (int)pedidoEntidad.Id;
                    var intent = new Intent(this, typeof(DetallePedidoActivity));
                    intent.PutExtra("idPedidoDet", idPedido);
                    StartActivity(intent);
                    this.Finish();

                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "No se pudo confirmar el pedido.", ToastLength.Short).Show();
                    throw;
                }
            }
            
        }

        
    }
}