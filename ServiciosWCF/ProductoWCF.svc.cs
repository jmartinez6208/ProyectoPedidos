using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Negocio;

namespace ServiciosWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductoWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductoWCF.svc or ProductoWCF.svc.cs at the Solution Explorer and start debugging.
    public class ProductoWCF : IProductoWCF
    {
        public List<ProductoEntidades> BuscarProducto(string nombreProducto)
        {
            return ProductosNegocio.BuscarProducto(nombreProducto);
        }

        public List<ProductoEntidades> DevolverListaProductos()
        {
            return ProductosNegocio.DevolverListaProductos();
        }

        public List<ProductoEntidades> DevolverListaProductosPorCategoria(int idCategoria)
        {
            return ProductosNegocio.DevolverListaProductosPorCategoria(idCategoria);
        }

        public ProductoEntidades DevolverProductoPorId(int identificador)
        {
            return ProductosNegocio.DevolverProductoPorId(identificador);
        }
    }
}
