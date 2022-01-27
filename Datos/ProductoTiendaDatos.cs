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
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).Img
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
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).Img
                    ));
            }

            return listaProductosTienda;
        }

        public static List<ProductosTiendaEntidades> DevolverProductosPorNombre(string nombreProducto)
        {
            List<ProductosTiendaEntidades> listaProductosTienda = new List<ProductosTiendaEntidades>();
            List<Productos_Tiendas> listaProductosLQ = new List<Productos_Tiendas>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from pt in ctx.Productos_Tiendas
                                join pr in ctx.Productos on pt.idProducto equals pr.id
                                where pr.nombre.Contains(nombreProducto)
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
                    ProductoDatos.DevolverProductoPorId((int)item.idProducto).Img
                    ));
            }

            return listaProductosTienda;
        }

        public static ProductosTiendaEntidades DevolverProductoPorId(int idProducto)
        {
            ProductosTiendaEntidades producto = new ProductosTiendaEntidades();
            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = ctx.Productos_Tiendas.FirstOrDefault(p => p.id == idProducto);

                    producto.Id = (int)resultado.id;
                    producto.IdTienda = (int)resultado.idTienda;
                    producto.IdProducto = (int)resultado.idProducto;
                    producto.Stock = (int)resultado.stock;
                    producto.Precio = (float)resultado.precio;
                    producto.NombreProducto = ProductoDatos.DevolverProductoPorId((int)resultado.idProducto).Nombre;
                    producto.NombreTienda = TiendaDatos.DevolverTiendaPorId((int)resultado.idTienda).Nombre;
                    producto.IdCategoria = ProductoDatos.DevolverProductoPorId((int)resultado.idProducto).IdCategoria;
                    //producto.Imagen = ProductoDatos.DevolverProductoPorId((int)resultado.idProducto).Imagen;
                    producto.Img = ProductoDatos.DevolverProductoPorId((int)resultado.idProducto).Img;
            }
            return producto;

        }

    }    
}
