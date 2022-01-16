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
            UsuarioEntidades usuarioValidado = DevolverUsuario(usuario.User);
            if (usuarioValidado == null)
            {
                return UsuarioDatos.Nuevo(usuario);
            }
            return null;
            
        }

        public static UsuarioEntidades DevolverUsuario(string username)
        {
            return UsuarioDatos.DevolverUsuario(username);
        }


    }
}
