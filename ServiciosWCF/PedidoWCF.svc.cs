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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PedidoWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PedidoWCF.svc o PedidoWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PedidoWCF : IPedidoWCF
    {
        public PedidoEntidades Actualizar(PedidoEntidades pedido)
        {
            return PedidoNegocio.Actualizar(pedido);
        }

        public bool ActualizarEstado(int idPedido, string estado)
        {
            return PedidoNegocio.ActualizarEstado(idPedido, estado);
        }

        public bool AsignarRepartidor(int idPedido, string estado, int idRepartidor)
        {
            return PedidoNegocio.AsignarRepartidor(idPedido, estado, idRepartidor);
        }

        public List<PedidoEntidades> DevolverListaPedidos()
        {
            return PedidoNegocio.DevolverListaPedidos();
        }

        public List<PedidoEntidades> DevolverListaPedidosEstadoPendiente()
        {
            return PedidoNegocio.DevolverListaPedidosEstadoPendiente();
        }

        public List<PedidoEntidades> DevolverListaPedidosPorCliente(int idCliente)
        {
            return PedidoNegocio.DevolverListaPedidosPorCliente(idCliente);
        }

        public List<PedidoEntidades> DevolverListaPedidosPorRepartidor(int idRepartidor)
        {
            return PedidoNegocio.DevolverListaPedidosPorRepartidor(idRepartidor);
        }

        public PedidoEntidades DevolverPedidoPorId(int identificador)
        {
            return PedidoNegocio.DevolverPedidoPorId(identificador);
        }

        public bool EliminarPedidoPorId(int identificador)
        {
            return PedidoNegocio.EliminarPedidoPorId(identificador);
        }

        public bool EliminarPedidosIncompletos()
        {
            return PedidoNegocio.EliminarPedidosIncompletos();
        }

        public bool EliminarPedidosPorEstado()
        {
            return PedidoNegocio.EliminarPedidosPorEstado();
        }

        public PedidoEntidades Nuevo(PedidoEntidades pedido)
        {
            return PedidoNegocio.Nuevo(pedido);
        }

        public bool actualizarTotalConseguido(int idPedido, double subtotal)
        {
            return PedidoNegocio.actualizarTotalConseguido(idPedido, subtotal);
        }
    }
}
