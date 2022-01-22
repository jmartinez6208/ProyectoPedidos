using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductosTiendaEntidades
    { 
        public int Id{ get; set; }
        public int IdTienda{ get; set; }
        public int IdProducto{ get; set; }
        public int Stock{ get; set; }
        public double Precio{ get; set; }
        public string NombreProducto { get; set; }
        public string NombreTienda { get; set; }
        public int IdCategoria { get; set; }
        public long Imagen { get; set; }

        public ProductosTiendaEntidades()
        {
        }

        public ProductosTiendaEntidades(int id, int idTienda, int idProducto, int stock, double precio, 
            string nombreProducto, string nombreTienda, int idCategoria, long imagen)
        {
            Id = id;
            IdTienda = idTienda;
            IdProducto = idProducto;
            Stock = stock;
            Precio = precio;
            NombreProducto = nombreProducto;
            NombreTienda = nombreTienda;
            IdCategoria = idCategoria;
            Imagen = imagen;
        }
    }
}
