using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Drawing;
using System.IO;

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
                productoEntidades.Img = productoLQ.imagenWeb;
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
                    item.imagenWeb
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
                    item.imagenWeb
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
                                join pt in ctx.Productos_Tiendas on p.id equals pt.idProducto
                                select p;

                listaProductosCategoriaLQ = resultado.ToList();
            }

            foreach (var item in listaProductosCategoriaLQ)
            {
                productosEncontrados.Add(new ProductoEntidades(
                    item.id,
                    item.idCategoria,
                    item.nombre,
                    item.imagenWeb
                    ));
            }
            return productosEncontrados;
        }


        public static byte[] StrToByteArray(string str)
        {
            Dictionary<string, byte> hexindex = new Dictionary<string, byte>();
            for (int i = 0; i <= 255; i++)
                hexindex.Add(i.ToString("X2"), (byte)i);

            List<byte> hexres = new List<byte>();
            for (int i = 0; i < str.Length; i += 2)
                hexres.Add(hexindex[str.Substring(i, 2)]);

            return hexres.ToArray();
        }

        public static Image ConvertToImage(System.Data.Linq.Binary iBinary)
        {
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary))
            {
                rImage = Image.FromStream(ms);
            }
            return rImage;
        }

        byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }

    }
}
