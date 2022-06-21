using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public static class TiendaNegocio
    {
        public static TiendaEntidades DevolverTiendaPorId(int identificador)
        {
            return TiendaDatos.DevolverTiendaPorId(identificador);
        }
    }
}
