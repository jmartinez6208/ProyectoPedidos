using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace Negocio
{
    public class DetallePedidoNegocio
    {
        public static DetallePedidoEntidades Nuevo(DetallePedidoEntidades detallePedido)
        {
            return DetallePedidoDatos.Nuevo(detallePedido);
        }

        public static bool EliminarDetallePedidoPorId(int identificador)
        {
            return DetallePedidoDatos.EliminarDetallePedidoPorId(identificador);
        }

        public static DetallePedidoEntidades DevolverDetallePorId(int identificador)
        {
            return DetallePedidoDatos.DevolverDetallePorId(identificador);
        }

        public static List<DetallePedidoEntidades> DevolerListaDetallesPorPedido(int idPedido)
        {
            return DetallePedidoDatos.DevolerListaDetallesPorPedido(idPedido);
        }

        public static bool EliminarDetallesPorId(int identificador)
        {
            return DetallePedidoDatos.EliminarDetallesPorId(identificador);
        }

        public static bool MarcarConseguido(int idDetallePedido)
        {
            return DetallePedidoDatos.MarcarConseguido(idDetallePedido);
        }
    }
}
