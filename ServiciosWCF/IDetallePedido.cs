using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDetallePedido" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDetallePedido
    {
        [OperationContract]
        DetallePedidoEntidades Nuevo(DetallePedidoEntidades detallePedido);

        [OperationContract]
        bool EliminarDetallePedidoPorId(int identificador);

        [OperationContract]
        List<DetallePedidoEntidades> DevolerListaDetallesPorPedido(int idPedido);

        [OperationContract]
        bool EliminarDetallesPorId(int identificador);

        [OperationContract]
        bool MarcarConseguido(int idDetallePedido);
    }
}
