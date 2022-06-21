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

using Square.Picasso;

using PresentacionMovil.wcfProductoTienda;

namespace PresentacionMovil.Adaptadores
{
    class ProductosTiendaAdapter : BaseAdapter<ProductosTiendaEntidades>
    {

        private Activity _context;
        private List<ProductosTiendaEntidades> _productostienda;

        public ProductosTiendaAdapter(Activity context, List<ProductosTiendaEntidades> productosTienda)
        {
            _context = context;
            _productostienda = productosTienda;
        }

        public override ProductosTiendaEntidades this[int position] => _productostienda[position];

        public override int Count => _productostienda.Count;

        public override long GetItemId(int position)
        {
            return this[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = this[position];

            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Resource.Layout.fila_productos, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.txtNombreProducto).Text = item.NombreProducto;
            convertView.FindViewById<TextView>(Resource.Id.txtPrecioProducto).Text = "$ " + item.Precio.ToString();
            convertView.FindViewById<TextView>(Resource.Id.txtTiendaProducto).Text = item.NombreTienda;
            var imagen = convertView.FindViewById<ImageView>(Resource.Id.imgProducto);

            var imgURL = item.Img;

            Picasso.Get()
            .Load(imgURL)
            .Into(imagen);
            return convertView;
        }
    }
}