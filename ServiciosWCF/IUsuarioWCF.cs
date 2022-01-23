using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarioWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarioWCF
    {
        [OperationContract]
        [FaultContract(typeof(UsuarioWCF))]
        UsuarioEntidades DevolverUsuario(string username);

        [OperationContract]
        [FaultContract(typeof(UsuarioWCF))]
        UsuarioEntidades Nuevo(UsuarioEntidades usuario);

        [OperationContract]
        [FaultContract(typeof(UsuarioWCF))]
        UsuarioEntidades Login(string username, string password);
    }
}
