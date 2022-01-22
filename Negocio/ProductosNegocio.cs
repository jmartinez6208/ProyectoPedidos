using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public static class ProductosNegocio
    {
        public static ProductoEntidades DevolverProductoPorId(int identificador)
        {
            return ProductoDatos.DevolverProductoPorId(identificador);
        }

        public static List<ProductoEntidades> DevolverListaProductos()
        {
            return ProductoDatos.DevolverListaProductos();
        }

        public static List<ProductoEntidades> DevolverListaProductosPorCategoria(int idCategoria) 
        {
            return ProductoDatos.DevolverListaProductosPorCategoria(idCategoria);
        }

        public static List<ProductoEntidades> BuscarProducto(string nombreProducto)
        {
            return ProductoDatos.BuscarProducto(nombreProducto);
        }

    }
}
