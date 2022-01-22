using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public static class CategoriaNegocio
    {
        public static CategoriaEntidades Nuevo(CategoriaEntidades categoria)
        {
            return CategoriaDatos.Nuevo(categoria);
        }

        public static CategoriaEntidades Actualizar(CategoriaEntidades categoria)
        {
            return CategoriaDatos.Actualizar(categoria);
        }

        public static List<CategoriaEntidades> DevolverListaCategoria()
        {
            return CategoriaDatos.DevolverListaCategoria();
        }

        public static bool EliminarCategoriaPorId(int identificador)
        {
            return CategoriaDatos.EliminarCategoriaPorId(identificador);
        }

        public static CategoriaEntidades DevolverCategoriaPorNombre(string nombreCategoria)
        {
            return CategoriaDatos.DevolverCategoriaPorNombre(nombreCategoria);
        }
    }
}
