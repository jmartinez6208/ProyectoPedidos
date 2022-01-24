using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public static class ProductoTiendaNegocio
    {
        public static List<ProductosTiendaEntidades> DevolverListaProductos()
        {
            return ProductoTiendaDatos.DevolverListaProductos();
        }

        public static List<ProductosTiendaEntidades> DevolverListaProductosPorCategoria(int idCategoria)
        {
            return ProductoTiendaDatos.DevolverListaProductosPorCategoria(idCategoria);
        }

        public static List<ProductosTiendaEntidades> DevolverProductosPorNombre(string nombreProducto)
        {
            return ProductoTiendaDatos.DevolverProductosPorNombre(nombreProducto);
        }

        public static ProductosTiendaEntidades DevolverProductoPorId(int idProducto)
        {
            return ProductoTiendaDatos.DevolverProductoPorId(idProducto);

        }
    }
}
