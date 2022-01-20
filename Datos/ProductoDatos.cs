using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public class ProductoDatos
    {
        public static ProductoEntidades DevolverProductoPorId(int identificador)
        {
            ProductoEntidades productoEntidades = new ProductoEntidades();

            using (var ctx = new DataClasses1DataContext())
            {
                var productoLQ = ctx.Productos.FirstOrDefault(p => p.id == identificador);
                productoEntidades.Id = productoLQ.id;
                productoEntidades.IdCategoria = productoLQ.idCategoria;
                productoEntidades.Nombre = productoLQ.nombre;
                productoEntidades.Imagen = (long)productoLQ.imagen;
            }

            return productoEntidades;
        }

        public static List<ProductoEntidades> DevolverListaProductos()
        {
            List<ProductoEntidades> listaProductosEntidad = new List<ProductoEntidades>();
            List<Productos> listaProductosLQ = new List<Productos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Productos
                                select p;

                listaProductosLQ = resultado.ToList();
            }

            foreach (var item in listaProductosLQ)
            {
                listaProductosEntidad.Add(new ProductoEntidades(
                    item.id,
                    (int)item.idCategoria,
                    item.nombre,
                    (long)item.imagen
                    ));
            }

            return listaProductosEntidad;
        }

        public static List<ProductoEntidades> DevolverListaProductosPorCategoria(int idCategoria)
        {
            List<ProductoEntidades> listaProductosCategoria = new List<ProductoEntidades>();
            List<Productos> listaProductosCategoriaLQ = new List<Productos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Productos
                                where p.idCategoria == idCategoria
                                select p;

                listaProductosCategoriaLQ = resultado.ToList();
            }

            foreach (var item in listaProductosCategoriaLQ)
            {
                listaProductosCategoria.Add(new ProductoEntidades(
                    item.id,
                    item.idCategoria,
                    item.nombre,
                    (long)item.imagen
                    ));
            }
            return listaProductosCategoria;
        }

        public static List<ProductoEntidades> BuscarProducto(string nombreProducto)
        {
            List<ProductoEntidades> productosEncontrados = new List<ProductoEntidades>();
            List<Productos> listaProductosCategoriaLQ = new List<Productos>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Productos
                                where p.nombre.Contains(nombreProducto)
                                select p;

                listaProductosCategoriaLQ = resultado.ToList();
            }

            foreach (var item in listaProductosCategoriaLQ)
            {
                productosEncontrados.Add(new ProductoEntidades(
                    item.id,
                    item.idCategoria,
                    item.nombre,
                    (long)item.imagen
                    ));
            }
            return productosEncontrados;
        }

    }
}
