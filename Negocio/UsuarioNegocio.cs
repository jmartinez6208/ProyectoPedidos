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
            if (usuario.Id == 0)
            {
                return UsuarioDatos.Nuevo(usuario);
            }
            else
            {
                return UsuarioDatos.Actualizar(usuario);
            }  
        }

        public static bool EliminarRepartidorPorId(int identificador)
        {
            return UsuarioDatos.EliminarRepartidorPorId(identificador);
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

        public static List<UsuarioEntidades> DevolverListaRepartidores()
        {
            return UsuarioDatos.DevolverListaRepartidores();
        }


    }
}
