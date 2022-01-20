using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoEntidades
    {
        public int Id{ get; set; }
        public int IdCategoria{ get; set; }
        public string Nombre { get; set; }
        public long Imagen{ get; set; }

        public ProductoEntidades() { }

        public ProductoEntidades(int id, int idCategoria, string nombre)
        {
            Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
        }

        public ProductoEntidades(int id, int idCategoria, string nombre, long imagen)
        {
            Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
            Imagen = imagen;
        }


    }
}
