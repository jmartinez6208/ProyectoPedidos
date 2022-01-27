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

using PresentacionMovil.wcfProductoTienda;
using Square.Picasso;

namespace PresentacionMovil
{
    [Obsolete]
    class DialogProducto : DialogFragment
    {
        private int idProductoTienda;
        private ProductoTiendaWCF wcfProductoTienda = new ProductoTiendaWCF();
        private ProductosTiendaEntidades productoTiendaEntidad = new ProductosTiendaEntidades();

        //Componentes
        ImageView imagen;
        EditText cantidad;
        TextView nombreProducto, stock;
        Button botonPedir;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.dialog_producto, container, false);

            //inicializacion de componentes
            imagen = view.FindViewById<ImageView>(Resource.Id.imgProductoSeleccionado);
            nombreProducto = view.FindViewById<TextView>(Resource.Id.txtNombreProductoSeleccionado);
            cantidad = view.FindViewById<EditText>(Resource.Id.txtCantidad);
            stock = view.FindViewById<TextView>(Resource.Id.txtStock);
            botonPedir = view.FindViewById<Button>(Resource.Id.btnPedirProducto);

            botonPedir.Click += PedirProducto;

            CargarProducto();

            Toast.MakeText(Application.Context, "id: " + idProductoTienda, ToastLength.Short).Show();
            
            return view;
        }

        private void PedirProducto(object sender, EventArgs e)
        {
            this.Dismiss();
        }

        public void RecuperarId(int id)
        {
            idProductoTienda = id;
        }

        private void CargarProducto()
        {
            productoTiendaEntidad = wcfProductoTienda.DevolverProductoPorId(idProductoTienda, true);

            var imgURL = productoTiendaEntidad.Img;

            Picasso.Get()
            .Load(imgURL)
            .Into(imagen);
            nombreProducto.Text = productoTiendaEntidad.NombreProducto;
            stock.Text = "Stock : " +productoTiendaEntidad.Stock.ToString();
        }
    }
}