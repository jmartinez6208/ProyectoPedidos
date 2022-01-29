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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "DetallePedido" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DetallePedido.svc o DetallePedido.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class DetallePedido : IDetallePedido
    {
        public bool EliminarDetallePedidoPorId(int identificador)
        {
            return DetallePedidoNegocio.EliminarDetallePedidoPorId(identificador);
        }

        public DetallePedidoEntidades Nuevo(DetallePedidoEntidades detallePedido)
        {
            return DetallePedidoNegocio.Nuevo(detallePedido);
        }

        public List<DetallePedidoEntidades> DevolerListaDetallesPorPedido(int idPedido)
        {
            return DetallePedidoNegocio.DevolerListaDetallesPorPedido(idPedido);
        }
    }
}
