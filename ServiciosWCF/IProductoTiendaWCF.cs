using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;

namespace ServiciosWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductoTiendaWCF" in both code and config file together.
    [ServiceContract]
    public interface IProductoTiendaWCF
    {
        [OperationContract]
        List<ProductosTiendaEntidades> DevolverListaProductos();

        [OperationContract]
        List<ProductosTiendaEntidades> DevolverListaProductosPorCategoria(int idCategoria);

    }
}
