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

using PresentacionMovil.wcfDetallePedido;
using PresentacionMovil.wcfProductoTienda;
using PresentacionMovil.wcfTienda;

using Square.Picasso;

namespace PresentacionMovil.Adaptadores
{
    class DetallePedidoRepartidorAdapter : BaseAdapter<DetallePedidoEntidades>
    {
        private Activity _context;
        private List<DetallePedidoEntidades> _detallePedidos;

        private ProductoTiendaWCF wcfProductoTienda = new ProductoTiendaWCF();
        private TiendaWCF wcfTienda = new TiendaWCF();

        public DetallePedidoRepartidorAdapter(Activity context, List<DetallePedidoEntidades> detallePedidos)
        {
            _context = context;
            _detallePedidos = detallePedidos;
        }

        public override DetallePedidoEntidades this[int position] => _detallePedidos[position];

        public override int Count => _detallePedidos.Count;

        public override long GetItemId(int position)
        {
            return this[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = this[position];
            var producto = wcfProductoTienda.DevolverProductoPorId(item.IdProductoTienda, true);
            var tienda = wcfTienda.DevolverTiendaPorId(producto.IdTienda, true);

            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Resource.Layout.fila_carrito, null);
            }

            if (item.Conseguido.Equals('s'))
            {
                convertView.FindViewById<TextView>(Resource.Id.txtConseguidoProductoCarrito).Text = "CONSEGUIDO";
            }

            convertView.FindViewById<TextView>(Resource.Id.txtCantidadProductoCarrito).Text = "Cantidad: " + item.Cantidad.ToString();
            convertView.FindViewById<TextView>(Resource.Id.txtSubtotalProductoCarrito).Text = "Subtotal: $" + item.Subtotal.ToString();
            convertView.FindViewById<TextView>(Resource.Id.txtNombreProductoCarrito).Text = producto.NombreProducto;
            convertView.FindViewById<TextView>(Resource.Id.txtDireccionTiendaCarrito).Text = tienda.Ubicacion;
            convertView.FindViewById<TextView>(Resource.Id.txtTiendaProductoCarrito).Text = producto.NombreTienda;
            var imagen = convertView.FindViewById<ImageView>(Resource.Id.imgProductoCarrito);

            var imgURL = producto.Img;

            Picasso.Get()
            .Load(imgURL)
            .Into(imagen);
            return convertView;
        }
    }

}