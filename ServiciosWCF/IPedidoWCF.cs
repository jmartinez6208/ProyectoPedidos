using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPedidoWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPedidoWCF
    {
        [OperationContract]
        PedidoEntidades Nuevo(PedidoEntidades pedido);

        [OperationContract]
        PedidoEntidades Actualizar(PedidoEntidades pedido);

        [OperationContract]
        PedidoEntidades DevolverPedidoPorId(int identificador);

        [OperationContract]
        List<PedidoEntidades> DevolverListaPedidos();

        [OperationContract]
        List<PedidoEntidades> DevolverListaPedidosEstadoPendiente();

        [OperationContract]
        List<PedidoEntidades> DevolverListaPedidosPorRepartidor(int idRepartidor);

        [OperationContract]
        bool EliminarPedidoPorId(int identificador);

        [OperationContract]
        List<PedidoEntidades> DevolverListaPedidosPorCliente(int idCliente);

        [OperationContract]
        bool ActualizarEstado(int idPedido, string estado);

        [OperationContract]
        bool EliminarPedidosPorEstado();

        [OperationContract]
        bool EliminarPedidosIncompletos();

        [OperationContract]
        bool AsignarRepartidor(int idPedido, string estado, int idRepartidor);

        [OperationContract]
        bool actualizarTotalConseguido(int idPedido, double subtotal);
    }
}
