using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;

namespace ServiciosWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductoWCF" in both code and config file together.
    [ServiceContract]
    public interface IProductoWCF
    {
        [OperationContract]
        ProductoEntidades DevolverProductoPorId(int identificador);

        [OperationContract]
        List<ProductoEntidades> DevolverListaProductos();

        [OperationContract]
        List<ProductoEntidades> DevolverListaProductosPorCategoria(int idCategoria);

        [OperationContract]
        List<ProductoEntidades> BuscarProducto(string nombreProducto);
    }
}
