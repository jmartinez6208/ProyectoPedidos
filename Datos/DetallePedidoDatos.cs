using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public class DetallePedidoDatos
    {
        public static DetallePedidoEntidades Nuevo(DetallePedidoEntidades detallePedido)
        {
            try
            {
                Detalle_Pedidos detallePedidoLQ = new Detalle_Pedidos();
                detallePedidoLQ.id = detallePedido.Id;
                detallePedidoLQ.idPedido = detallePedido.IdPedidoPertenece;
                detallePedidoLQ.idProductoTienda = detallePedido.IdProductoTienda;
                detallePedidoLQ.cantidad = detallePedido.Cantidad;
                //Calculo subtotal
                var producto = ProductoTiendaDatos.DevolverProductoPorId(detallePedido.IdProductoTienda);
                double precio = producto.Precio;
                double subtotal = precio * detallePedido.Cantidad;
                detallePedidoLQ.subtotal = subtotal;
                //Calculo Total Pedido Cabecera
                PedidoDatos.actualizarTotal(detallePedido.IdPedidoPertenece, subtotal);
                detallePedidoLQ.conseguido = 'n';

                //Disminucion stock
                ProductoTiendaDatos.actualizarStock(producto.Id, detallePedido.Cantidad);

                using (var ctx = new DataClasses1DataContext())
                {
                    ctx.Detalle_Pedidos.InsertOnSubmit(detallePedidoLQ);
                    ctx.SubmitChanges();
                }
                detallePedido.Id = detallePedidoLQ.id;
                return detallePedido;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool EliminarDetallePedidoPorId(int identificador)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var detallePedidoLQ = ctx.Detalle_Pedidos.FirstOrDefault(p => p.id == identificador);
                    ctx.Detalle_Pedidos.DeleteOnSubmit(detallePedidoLQ);
                    ctx.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }


    }
}
