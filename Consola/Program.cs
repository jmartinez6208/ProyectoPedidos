using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Negocio;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoEntidades producto = new ProductoEntidades();
            List<ProductoEntidades> lista = new List<ProductoEntidades>();

            producto = ProductosNegocio.DevolverProductoPorId(1);

            lista = ProductosNegocio.DevolverListaProductos();

        
            if (producto != null)
            {
                Console.WriteLine(producto.Id);
                Console.WriteLine(producto.Nombre);
                //Console.WriteLine(producto.img.PhysicalDimension);  
            }

            Console.ReadLine();



        }

        static byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
