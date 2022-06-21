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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductoTiendaWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductoTiendaWCF.svc or ProductoTiendaWCF.svc.cs at the Solution Explorer and start debugging.
    public class ProductoTiendaWCF : IProductoTiendaWCF
    {
        public List<ProductosTiendaEntidades> DevolverListaProductos()
        {
            return ProductoTiendaNegocio.DevolverListaProductos();
        }

        public List<ProductosTiendaEntidades> DevolverListaProductosPorCategoria(int idCategoria)
        {
            return ProductoTiendaNegocio.DevolverListaProductosPorCategoria(idCategoria);
        }

        public ProductosTiendaEntidades DevolverProductoPorId(int idProducto)
        {
            return ProductoTiendaNegocio.DevolverProductoPorId(idProducto);
        }

        public List<ProductosTiendaEntidades> DevolverProductosPorNombre(string nombreProducto)
        {
            return ProductoTiendaNegocio.DevolverProductosPorNombre(nombreProducto);
        }


    }
}
