using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public static class ProductoTiendaDatos
    {
        public static List<ProductosTiendaEntidades> DevolverListaProductosPorCategoria(int idCategoria)
        {
            List<ProductosTiendaEntidades> listaProductosTienda = new List<ProductosTiendaEntidades>();
            List<Productos_Tiendas> listaProductosLQ = new List<Productos_Tiendas>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from pt in ctx.Productos_Tiendas
                                join pr in ctx.Productos on pt.idProducto equals pr.id
                                where pr.idCategoria == idCategoria
                                select pt;

                listaProductosLQ = resultado.ToList();
            }

            foreach (var item in listaProductosLQ)
            {
                listaProductosTienda.Add(new ProductosTiendaEntidades(
                    (int)item.id,
                    (int)item.idTienda,
                    (int)item.idProducto,
                    (int)item.stock,
                    (float)item.precio,
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).Nombre,
                    TiendaDatos.DevolverTiendaPorId((int)item.idTienda).Nombre,
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).IdCategoria,
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).Imagen
                    ));
            }

            return listaProductosTienda;
        }

        public static List<ProductosTiendaEntidades> DevolverListaProductos()
        {
            List<ProductosTiendaEntidades> listaProductosTienda = new List<ProductosTiendaEntidades>();
            List<Productos_Tiendas> listaProductosLQ = new List<Productos_Tiendas>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Productos_Tiendas
                                select p;

                listaProductosLQ = resultado.ToList();
            }

            foreach (var item in listaProductosLQ)
            {
                listaProductosTienda.Add(new ProductosTiendaEntidades(
                    (int)item.id,
                    (int)item.idTienda,
                    (int)item.idProducto,
                    (int)item.stock,
                    (float)item.precio,
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).Nombre,
                    TiendaDatos.DevolverTiendaPorId((int)item.idTienda).Nombre,
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).IdCategoria,
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).Imagen
                    ));
            }

            return listaProductosTienda;
        }

    }    
}
