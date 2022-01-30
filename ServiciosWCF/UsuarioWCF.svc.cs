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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UsuarioWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UsuarioWCF.svc o UsuarioWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UsuarioWCF : IUsuarioWCF
    {
        public UsuarioEntidades DevolverUsuario(string username)
        {
            return UsuarioNegocio.DevolverUsuario(username);
        }

        public UsuarioEntidades DevolverUsuarioPorId(int identificador)
        {
            return UsuarioNegocio.DevolverUsuarioPorId(identificador);
        }

        public UsuarioEntidades Login(string username, string password)
        {
            return UsuarioNegocio.Login(username, password);
        }

        public UsuarioEntidades Nuevo(UsuarioEntidades usuario)
        {
            return UsuarioNegocio.Nuevo(usuario);
        }
    }
}
