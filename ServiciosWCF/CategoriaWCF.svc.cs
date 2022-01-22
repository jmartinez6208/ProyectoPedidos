using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Negocio;

namespace ServiciosWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CategoriaWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CategoriaWCF.svc or CategoriaWCF.svc.cs at the Solution Explorer and start debugging.
    public class CategoriaWCF : ICategoriaWCF
    {
        public CategoriaEntidades Actualizar(CategoriaEntidades categoria)
        {
            return CategoriaNegocio.Actualizar(categoria);
        }

        public CategoriaEntidades DevolverCategoriaPorNombre(string nombreCategoria)
        {
            return CategoriaNegocio.DevolverCategoriaPorNombre(nombreCategoria);
        }

        public List<CategoriaEntidades> DevolverListaCategoria()
        {
            return CategoriaNegocio.DevolverListaCategoria();
        }

        public bool EliminarCategoriaPorId(int identificador)
        {
            return CategoriaNegocio.EliminarCategoriaPorId(identificador);
        }

        public CategoriaEntidades Nuevo(CategoriaEntidades categoria)
        {
            return CategoriaNegocio.Nuevo(categoria);
        }
    }
}
