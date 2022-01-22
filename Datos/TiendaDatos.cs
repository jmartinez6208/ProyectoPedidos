using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public static class TiendaDatos
    {
        public static TiendaEntidades DevolverTiendaPorId(int identificador)
        {

            TiendaEntidades tiendaEntidades = new TiendaEntidades();

            using (var ctx = new DataClasses1DataContext())
            {
                var tiendaLQ = ctx.Tiendas.FirstOrDefault(t => t.id == identificador);
                tiendaEntidades.Id = tiendaLQ.id;
                tiendaEntidades.Nombre = tiendaLQ.nombre;
                tiendaEntidades.Descripcion = tiendaLQ.descripcion;
            }

            return tiendaEntidades;
        }
    }
}
