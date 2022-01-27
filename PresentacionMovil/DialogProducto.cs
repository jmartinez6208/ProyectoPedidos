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
using PresentacionMovil.wcfPedido;
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
        TextView nombreProducto, stock, precio;
        Button botonPedir, btnCancelar;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.dialog_producto, container, false);

            //inicializacion de componentes
            imagen = view.FindViewById<ImageView>(Resource.Id.imgProductoSeleccionado);
            nombreProducto = view.FindViewById<TextView>(Resource.Id.txtNombreProductoSeleccionado);
            cantidad = view.FindViewById<EditText>(Resource.Id.txtCantidad);
            stock = view.FindViewById<TextView>(Resource.Id.txtStock);
            precio = view.FindViewById<TextView>(Resource.Id.txtPrecio);
            botonPedir = view.FindViewById<Button>(Resource.Id.btnPedirProducto);
            btnCancelar = view.FindViewById<Button>(Resource.Id.btnCancelarProducto);

            botonPedir.Click += PedirProducto;
            btnCancelar.Click += CerrarCuadro;

            CargarProducto();
            return view;
        }

        private void CerrarCuadro(object sender, EventArgs e)
        {
            this.Dismiss();
        }

        private void PedirProducto(object sender, EventArgs e)
        {
            creacionPedido();
            this.Dismiss();
        }

        private void creacionPedido()
        {
              
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
            stock.Text = "Stock: " +productoTiendaEntidad.Stock.ToString();
            precio.Text = "Precio: $" + productoTiendaEntidad.Precio.ToString();
        }

    }
}