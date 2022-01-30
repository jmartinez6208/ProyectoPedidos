using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PresentacionMovil.Adaptadores;
using PresentacionMovil.wcfCategorias;
using PresentacionMovil.wcfProductoTienda;
using PresentacionMovil.wcfUsuario;
using PresentacionMovil.wcfPedido;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PresentacionMovil
{
    [Activity(Label = "ProductosActivity")]
    public class ProductosActivity : Activity
    {
        private CategoriaWCF wsCategoria = new CategoriaWCF();
        private List<CategoriaEntidades> listaCategorias = new List<CategoriaEntidades>();
        private CategoriaEntidades categoria = new CategoriaEntidades();

        private ProductoTiendaWCF wsProductoTienda = new ProductoTiendaWCF();
        private List<ProductosTiendaEntidades> listaProductos = new List<ProductosTiendaEntidades>();

        private UsuarioWCF wcfUsuario = new UsuarioWCF();
        private UsuarioEntidades usuarioEntidad = new UsuarioEntidades();

        private PedidoWCF wcfPedido = new PedidoWCF();
        private PedidoEntidades pedidoEntidad = new PedidoEntidades();

        private int creada = 0;

        private int idCliente, idPedido;
        private int intento;

        Spinner categoriasSpinner;
        ListView productosListView;
        AutoCompleteTextView buscadorProducto;
        Button botonCarrito;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_productos);
            // Create your application here
            referenciaBotones();
            inicializarDatos();
            if (intento == 1)
            {
                CrearPedidoNuevo();
            }
        }

        private void inicializarDatos()
        {
            intento = Intent.Extras.GetInt("origen", 0);
            idPedido = Intent.Extras.GetInt("idPedidoCarrito", 0);
            idCliente = (int)PedidosActivity.usuarioEntidad.Id;
            usuarioEntidad = wcfUsuario.DevolverUsuarioPorId(idCliente, true);

            listaCategorias = wsCategoria.DevolverListaCategoria().ToList();
            var items = new List<string>();
            foreach (var item in listaCategorias)
            {
                items.Add(item.Nombre);
            }
            var adaptador = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items);
            categoriasSpinner.Adapter = adaptador;

            //Autocomplete Buscar Producto
            var listaProductosBuscar = wsProductoTienda.DevolverProductosPorNombre(buscadorProducto.Text).ToList();
            var nombreProductos = new List<string>();
            foreach (var item in listaProductosBuscar)
            {
                nombreProductos.Add(item.NombreProducto);
            }
            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, nombreProductos);
            buscadorProducto.Adapter = adapter;
            buscadorProducto.KeyPress += (object sender, View.KeyEventArgs e) =>
            {
                if ((e.KeyCode == Keycode.Enter))
                {
                    productosListView.Adapter = new ProductosTiendaAdapter(this, listaProductosBuscar);
                }
            };
            
            // ListView

        }

        public override void OnBackPressed()
        {
            var intent = new Intent(this, typeof(PedidosActivity));
            intent.PutExtra("username", usuarioEntidad.User);
            StartActivity(intent);
        }

        private void referenciaBotones()
        {
            categoriasSpinner = (Spinner)FindViewById<Spinner>(Resource.Id.spinnerCategorias);
            categoriasSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(categoriasSpinner_ItemSelected);
            productosListView = (ListView)FindViewById<ListView>(Resource.Id.listViewProductos);
            productosListView.ItemClick += clickItemListView;

            //Autocomplete - Buscar Producto 
            buscadorProducto = FindViewById<AutoCompleteTextView>(Resource.Id.buscarProducto);

            botonCarrito = (Button)FindViewById<Button>(Resource.Id.btnCarrito);
            botonCarrito.Click += clickCarrito;

        }

        private void clickCarrito(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CarritoActivity));
            intent.PutExtra("idPedido", idPedido);
            StartActivity(intent);
            this.Finish();
        }

        private void clickItemListView(object sender, AdapterView.ItemClickEventArgs e)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            DialogProducto dialogProducto = new DialogProducto();
            dialogProducto.Show(transaction, "Dialog Fragment");
            var id = (int)e.Id;
            //idPedido = pedidoEntidad.Id;
            dialogProducto.RecuperarIdProducto(id);
            dialogProducto.RecuperarIdPedido(idPedido);
        }

        private void CrearPedidoNuevo()
        {
            pedidoEntidad.IdCliente = idCliente;
            pedidoEntidad.IdClienteSpecified = true;
            pedidoEntidad.IdRepartidor = 8;
            pedidoEntidad.IdRepartidorSpecified = true;
            DateTime fechaCreacion = DateTime.Now;
            string fecha = fechaCreacion.ToString("dd/MM/yyyy");
            pedidoEntidad.FechaCreacion = fecha;
            pedidoEntidad.Estado = "nuevo";
            pedidoEntidad.Total = 0;
            pedidoEntidad = wcfPedido.Nuevo(pedidoEntidad);
            if (pedidoEntidad.Id > 0)
            {
                idPedido = pedidoEntidad.Id;
                Toast.MakeText(Application.Context, pedidoEntidad.Id.ToString(), ToastLength.Short).Show();
            }
        }

        private void categoriasSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var categoriasSpinner = sender as Spinner;
            var nombreCategoria = categoriasSpinner.GetItemAtPosition(e.Position).ToString();
            categoria = wsCategoria.DevolverCategoriaPorNombre(nombreCategoria);
            listaProductos = wsProductoTienda.DevolverListaProductosPorCategoria(categoria.Id,true).ToList();
            productosListView.Adapter = new ProductosTiendaAdapter(this, listaProductos);
        }

        private void buscarProducto_ItemEntered(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var txtBuscarProducto = sender as AutoCompleteTextView;
            var producto = txtBuscarProducto.Text;
            listaProductos = wsProductoTienda.DevolverProductosPorNombre(producto).ToList();
            productosListView.Adapter = new ProductosTiendaAdapter(this, listaProductos);
        }

        
    }
}