using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace Negocio
{
    public static class UsuarioNegocio
    {
        public static UsuarioEntidades Nuevo(UsuarioEntidades usuario)
        {
             return UsuarioDatos.Nuevo(usuario);
        }

        public static UsuarioEntidades DevolverUsuario(string username)
        {
            return UsuarioDatos.DevolverUsuario(username);
        }

        public static UsuarioEntidades Login(string username, string password)
        {
            return UsuarioDatos.Login(username, password);
        }

        public static UsuarioEntidades DevolverUsuarioPorId(int identificador) 
        {
            return UsuarioDatos.DevolverUsuarioPorId(identificador);
        }

    }
}
