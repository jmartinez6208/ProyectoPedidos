using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace Negocio
{
    public static class PedidoNegocio
    {

        public static List<PedidoEntidades> DevolverListaPedidosPorEstado(string estado)
        {
            return PedidoDatos.DevolverListaPedidosPorEstado(estado);
        }

        public static PedidoEntidades Nuevo(PedidoEntidades pedido)
        {
            if (pedido.Id == 0)
            {
                return PedidoDatos.Nuevo(pedido);
            }
            else {
                return PedidoDatos.Actualizar(pedido);
            }
            
        }

        public static PedidoEntidades Actualizar(PedidoEntidades pedido)
        {
            return PedidoDatos.Actualizar(pedido);
        }

        public static PedidoEntidades DevolverPedidoPorId(int identificador) 
        {
            return PedidoDatos.DevolverPedidoPorId(identificador);
        }

        public static List<PedidoEntidades> DevolverListaPedidos()
        {
            return PedidoDatos.DevolverListaPedidos();
        }

        public static List<PedidoEntidades> DevolverListaPedidosEstadoPendiente()
        {
            return PedidoDatos.DevolverListaPedidosEstadoPendiente();
        }

        public static bool EliminarPedidoPorId(int identificador)
        {
            return PedidoDatos.EliminarPedidoPorId(identificador);
        }

        public static List<PedidoEntidades> DevolverListaPedidosPorCliente(int idCliente)
        {
            return PedidoDatos.DevolverListaPedidosPorCliente(idCliente);
        }

        public static List<PedidoEntidades> DevolverListaPedidosPorRepartidor(int idRepartidor)
        {
            return PedidoDatos.DevolverListaPedidosPorRepartidor(idRepartidor);
        }

        public static bool ActualizarEstado(int idPedido, string estado)
        {
            return PedidoDatos.ActualizarEstado(idPedido, estado);
        }

        public static bool EliminarPedidosPorEstado()
        {
            return PedidoDatos.EliminarPedidosPorEstado();
        }

        public static bool EliminarPedidosIncompletos() 
        {
            return PedidoDatos.EliminarPedidosIncompletos();
        }

        public static bool AsignarRepartidor(int idPedido, string estado, int idRepartidor)
        {
            return PedidoDatos.AsignarRepartidor(idPedido, estado, idRepartidor);
        }

        public static bool actualizarTotalConseguido(int idPedido, double subtotal)
        {
            return PedidoDatos.actualizarTotalConseguido(idPedido, subtotal);
        }
    }
}
