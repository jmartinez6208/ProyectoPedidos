using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public static class PedidoDatos
    {
        public static PedidoEntidades Nuevo(PedidoEntidades pedido)
        {
            try
            {
                Pedidos pedidosLQ = new Pedidos();
                pedidosLQ.id = pedido.Id;
                pedidosLQ.idCliente = pedido.IdCliente;
                pedidosLQ.idRepartidor = pedido.IdRepartidor;
                pedidosLQ.fechaCreacion = pedido.FechaCreacion;
                pedidosLQ.estado = pedido.Estado;
                pedidosLQ.total = pedido.Total;
                pedidosLQ.totalConseguido = pedido.TotalConseguido;

                using (var ctx = new DataClasses1DataContext())
                {
                    ctx.Pedidos.InsertOnSubmit(pedidosLQ);
                    ctx.SubmitChanges();
                }

                pedido.Id = pedidosLQ.id;
                return pedido;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PedidoEntidades Actualizar(PedidoEntidades pedido)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var pedidosLQ = ctx.Pedidos.FirstOrDefault(p => p.id == pedido.Id);
                    pedidosLQ.id = pedido.Id;
                    pedidosLQ.idCliente = pedido.IdCliente;
                    pedidosLQ.idRepartidor = pedido.IdRepartidor;
                    pedidosLQ.fechaCreacion = pedido.FechaCreacion;
                    pedidosLQ.estado = pedido.Estado;
                    pedidosLQ.total = pedido.Total;
                    pedidosLQ.totalConseguido = pedido.TotalConseguido;

                    ctx.SubmitChanges();
                }
                return pedido;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PedidoEntidades DevolverPedidoPorId(int identificador)
        {
            PedidoEntidades pedidoEntidades = new PedidoEntidades();

            using (var ctx = new DataClasses1DataContext())
            {
                var pedidosLQ = ctx.Pedidos.FirstOrDefault(p => p.id == identificador);
                pedidoEntidades.Id = pedidosLQ.id;
                pedidoEntidades.IdCliente = (int)pedidosLQ.idCliente;
                pedidoEntidades.IdRepartidor = (int)pedidosLQ.idRepartidor;
                pedidoEntidades.FechaCreacion = pedidosLQ.fechaCreacion;
                pedidoEntidades.Estado = pedidosLQ.estado;
                pedidoEntidades.Total = (double)pedidosLQ.total;
                pedidoEntidades.TotalConseguido = (double)pedidosLQ.totalConseguido;
            }

            return pedidoEntidades;
        }

        //Escritorio
        public static List<PedidoEntidades> DevolverListaPedidos()
        {
            List<PedidoEntidades> listaPedidosEntidad = new List<PedidoEntidades>();
            List<Pedidos> listaPedidosLQ = new List<Pedidos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Pedidos
                                select p;

                listaPedidosLQ = resultado.ToList();
            }

            foreach (var item in listaPedidosLQ)
            {
                listaPedidosEntidad.Add(new PedidoEntidades(
                    item.id,
                    (int)item.idCliente,
                    (int)item.idRepartidor,
                    item.fechaCreacion,
                    item.estado,
                    (double)item.total,
                    (double)item.totalConseguido
                    ));
            }

            return listaPedidosEntidad;
        }

        public static List<PedidoEntidades> DevolverListaPedidosEstadoPendiente()
        {
            List<PedidoEntidades> listaPedidosEntidad = new List<PedidoEntidades>();
            List<Pedidos> listaPedidosLQ = new List<Pedidos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Pedidos
                                where p.estado.Equals("pendiente")
                                select p;

                listaPedidosLQ = resultado.ToList();
            }

            foreach (var item in listaPedidosLQ)
            {
                listaPedidosEntidad.Add(new PedidoEntidades(
                    item.id,
                    (int)item.idCliente,
                    (int)item.idRepartidor,
                    item.fechaCreacion,
                    item.estado,
                    (double)item.total,
                    (double)item.totalConseguido
                    ));
            }

            return listaPedidosEntidad;
        }

        public static List<PedidoEntidades> DevolverListaPedidosPorEstado(string estado)
        {
            List<PedidoEntidades> listaPedidosEntidad = new List<PedidoEntidades>();
            List<Pedidos> listaPedidosLQ = new List<Pedidos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Pedidos
                                where p.estado.Equals(estado)
                                select p;

                listaPedidosLQ = resultado.ToList();
            }

            foreach (var item in listaPedidosLQ)
            {
                listaPedidosEntidad.Add(new PedidoEntidades(
                    item.id,
                    (int)item.idCliente,
                    (int)item.idRepartidor,
                    item.fechaCreacion,
                    item.estado,
                    (double)item.total,
                    UsuarioDatos.DevolverUsuarioPorId((int)item.idCliente).Nombre,
                    UsuarioDatos.DevolverUsuarioPorId((int)item.idRepartidor).Nombre,
                    (double)item.totalConseguido
                    ));
            }

            return listaPedidosEntidad;
        }

        public static bool EliminarPedidoPorId(int identificador)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var pedidoLQ = ctx.Pedidos.FirstOrDefault(p => p.id == identificador);
                    ctx.Pedidos.DeleteOnSubmit(pedidoLQ);
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

        public static bool EliminarPedidosPorEstado()
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var pedidoLQ = from p in ctx.Pedidos
                                   where p.estado.Equals("nuevo")
                                   select p;
                    ctx.Pedidos.DeleteAllOnSubmit(pedidoLQ);
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

        public static bool EliminarPedidosIncompletos()
        {
            List<Pedidos> listaPedidosLQ = new List<Pedidos>();

            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var resultado = from p in ctx.Pedidos
                                    where p.estado.Equals("nuevo")
                                    select p;

                    listaPedidosLQ = resultado.ToList();

                    foreach (var item in listaPedidosLQ)
                    {
                        DetallePedidoDatos.EliminarDetallesPorId(item.id);
                        ctx.Pedidos.DeleteOnSubmit(item);
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

        public static List<PedidoEntidades> DevolverListaPedidosPorCliente(int idCliente)
        {
            List<PedidoEntidades> listaPedidosCliente = new List<PedidoEntidades>();
            List<Pedidos> listaPedidosLQ = new List<Pedidos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Pedidos
                                where p.idCliente == idCliente
                                select p;

                listaPedidosLQ = resultado.ToList();
            }

            foreach (var item in listaPedidosLQ)
            {
                listaPedidosCliente.Add(new PedidoEntidades(
                    item.id,
                    (int)item.idCliente,
                    (int)item.idRepartidor,
                    item.fechaCreacion,
                    item.estado,
                    (double)item.total,
                    (double)item.totalConseguido
                    ));
            }

            return listaPedidosCliente;
        }

        public static List<PedidoEntidades> DevolverListaPedidosPorRepartidor(int idRepartidor)
        {
            List<PedidoEntidades> listaPedidosCliente = new List<PedidoEntidades>();
            List<Pedidos> listaPedidosLQ = new List<Pedidos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Pedidos
                                where p.idRepartidor == idRepartidor && (p.estado.Equals("asignado") || p.estado.Equals("completado"))  
                                orderby p.estado
                                select p;

                listaPedidosLQ = resultado.ToList();
            }

            foreach (var item in listaPedidosLQ)
            {
                listaPedidosCliente.Add(new PedidoEntidades(
                    item.id,
                    (int)item.idCliente,
                    (int)item.idRepartidor,
                    item.fechaCreacion,
                    item.estado,
                    (double)item.total,
                    (double)item.totalConseguido
                    ));
            }

            return listaPedidosCliente;
        }

        //Se aumenta el total cuando se agrega un detalle
        public static bool actualizarTotal(int idPedido, double subtotal)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var pedidoLQ = ctx.Pedidos.FirstOrDefault(p => p.id == idPedido);
                    pedidoLQ.total += subtotal;
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

        public static bool actualizarTotalConseguido(int idPedido, double subtotal)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var pedidoLQ = ctx.Pedidos.FirstOrDefault(p => p.id == idPedido);
                    pedidoLQ.totalConseguido += subtotal;
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

        public static bool RestarSubtotalDetalle(int idPedido, double subtotal)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var pedidoLQ = ctx.Pedidos.FirstOrDefault(p => p.id == idPedido);
                    pedidoLQ.total -= subtotal;
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

        public static bool ActualizarEstado(int idPedido, string estado)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var pedidoLQ = ctx.Pedidos.FirstOrDefault(p => p.id == idPedido);
                    pedidoLQ.estado = estado;
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

        public static bool AsignarRepartidor(int idPedido, string estado, int idRepartidor)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var pedidoLQ = ctx.Pedidos.FirstOrDefault(p => p.id == idPedido);
                    pedidoLQ.estado = estado;
                    pedidoLQ.idRepartidor = idRepartidor;
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
