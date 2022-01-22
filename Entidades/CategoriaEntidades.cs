using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CategoriaEntidades
    {
        public int Id{ get; set; }

        public string Nombre{ get; set; }
        public string Descripcion{ get; set; }

        public CategoriaEntidades()
        {
        }

        public CategoriaEntidades(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }

    }
}
