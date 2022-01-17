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
        public static PedidoEntidades Nuevo(PedidoEntidades pedido)
        {
            return PedidoDatos.Nuevo(pedido);
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

        public static bool EliminarPedidoPorId(int identificador)
        {
            return PedidoDatos.EliminarPedidoPorId(identificador);
        }

        public static List<PedidoEntidades> DevolverListaPedidosPorCliente(int idCliente)
        {
            return PedidoDatos.DevolverListaPedidosPorCliente(idCliente);
        }
    }
}
