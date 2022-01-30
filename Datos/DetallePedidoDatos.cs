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
                    //Restar valor del detalle al total
                    PedidoDatos.RestarSubtotalDetalle((int)detallePedidoLQ.idPedido, (double)detallePedidoLQ.subtotal);
                    //Reponer stock
                    ProductoTiendaDatos.ReponerStock((int)detallePedidoLQ.idProductoTienda, (int)detallePedidoLQ.cantidad);
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

        public static bool EliminarDetallesPorId(int identificador)
        {
            List<Detalle_Pedidos> listaPedidosLQ = new List<Detalle_Pedidos>();

            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var resultado = from p in ctx.Detalle_Pedidos
                                    where p.idPedido == identificador
                                    select p;

                    listaPedidosLQ = resultado.ToList();

                    foreach (var item in listaPedidosLQ)
                    {
                        ctx.Detalle_Pedidos.DeleteOnSubmit(item);
                        ctx.SubmitChanges();
                    }

                    return true;

                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public static List<DetallePedidoEntidades> DevolerListaDetallesPorPedido(int idPedido)
        {
            List<DetallePedidoEntidades> listaDetallesPedido = new List<DetallePedidoEntidades>();
            List<Detalle_Pedidos> listaDetalleLQ = new List<Detalle_Pedidos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from dp in ctx.Detalle_Pedidos
                                where dp.idPedido.Equals(idPedido)
                                select dp;

                listaDetalleLQ = resultado.ToList();
            }

            foreach (var item in listaDetalleLQ)
            {
                listaDetallesPedido.Add(new DetallePedidoEntidades(
                    item.id,
                    (int)item.idPedido,
                    (int)item.idProductoTienda,
                    (int)item.cantidad,
                    (double)item.subtotal,
                    (char)item.conseguido                    
                    ));
            }

            return listaDetallesPedido;
        }

        public static bool MarcarConseguido(int idDetallePedido)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var detallePedidoLQ = ctx.Detalle_Pedidos.FirstOrDefault(p => p.id == idDetallePedido);
                    detallePedidoLQ.conseguido = 's';
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
