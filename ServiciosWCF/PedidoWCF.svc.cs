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

        public List<PedidoEntidades> DevolverListaPedidos()
        {
            return PedidoNegocio.DevolverListaPedidos();
        }

        public List<PedidoEntidades> DevolverListaPedidosPorCliente(int idCliente)
        {
            return PedidoNegocio.DevolverListaPedidosPorCliente(idCliente);
        }

        public PedidoEntidades DevolverPedidoPorId(int identificador)
        {
            return PedidoNegocio.DevolverPedidoPorId(identificador);
        }

        public bool EliminarPedidoPorId(int identificador)
        {
            return PedidoNegocio.EliminarPedidoPorId(identificador);
        }

        public PedidoEntidades Nuevo(PedidoEntidades pedido)
        {
            return PedidoNegocio.Nuevo(pedido);
        }
    }
}
