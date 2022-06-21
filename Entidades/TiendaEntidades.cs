using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiendaEntidades
    {
        public int Id{ get; set; }
        public string Nombre{ get; set; }
        public string Descripcion{ get; set; }
        public string Ubicacion{ get; set; }

        public TiendaEntidades()
        {
        }

        public TiendaEntidades(int id, string nombre, string descripcion, string ubicacion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
        }
    }
}
