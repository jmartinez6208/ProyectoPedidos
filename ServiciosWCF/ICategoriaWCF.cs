using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;

namespace ServiciosWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICategoriaWCF" in both code and config file together.
    [ServiceContract]
    public interface ICategoriaWCF
    {

        [OperationContract]
        bool EliminarCategoriaPorId(int identificador);

        [OperationContract]
        CategoriaEntidades Nuevo(CategoriaEntidades categoria);

        [OperationContract]
        CategoriaEntidades Actualizar(CategoriaEntidades categoria);

        [OperationContract]
        List<CategoriaEntidades> DevolverListaCategoria();

        [OperationContract]
        CategoriaEntidades DevolverCategoriaPorNombre(string nombreCategoria);

    }
}
