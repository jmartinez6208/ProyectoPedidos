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

using PresentacionMovil.wcfCategorias;
using PresentacionMovil.wcfUsuario;
using PresentacionMovil.wcfProductoTienda;

using PresentacionMovil.Adaptadores;

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
        private UsuarioEntidades usuarioEntidad = new UsuarioEntidades();

        Spinner categoriasSpinner;
        ListView productosListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_productos);
            // Create your application here
            botones();
            inicializarDatos();
        }

        private void inicializarDatos()
        {
            listaCategorias = wsCategoria.DevolverListaCategoria().ToList();
            var items = new List<string>();
            foreach (var item in listaCategorias)
            {
                items.Add(item.Nombre);
            }
            var adaptador = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items);
            categoriasSpinner.Adapter = adaptador;

            // ListView
            
        }

        private void botones()
        {
            categoriasSpinner = (Spinner)FindViewById<Spinner>(Resource.Id.spinnerCategorias);
            categoriasSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(categoriasSpinner_ItemSelected);
            productosListView = (ListView)FindViewById<ListView>(Resource.Id.listViewProductos);

        }

        private void categoriasSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var categoriasSpinner = sender as Spinner;
            var nombreCategoria = categoriasSpinner.GetItemAtPosition(e.Position).ToString();
            categoria = wsCategoria.DevolverCategoriaPorNombre(nombreCategoria);
            listaProductos = wsProductoTienda.DevolverListaProductosPorCategoria(categoria.Id,true).ToList();
            productosListView.Adapter = new ProductosTiendaAdapter(this, listaProductos);
        }
    }
}