using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public static class UsuarioDatos
    {
        public static UsuarioEntidades Nuevo(UsuarioEntidades usuario)
        {
            try
            {
                Usuarios usuarioLQ = new Usuarios();
                //usuarioLQ.id = usuario.Id;
                usuarioLQ.nombre = usuario.Nombre;
                usuarioLQ.usuario = usuario.User;
                usuarioLQ.contraseña = GetSHA256(usuario.Contraseña);
                usuarioLQ.idTipoUsuario = usuario.IdTipoUsuario;
                usuarioLQ.fechaCreacion = usuario.FechaCreacion;

                using (var ctx = new DataClasses1DataContext())
                {
                    ctx.Usuarios.InsertOnSubmit(usuarioLQ);
                    ctx.SubmitChanges();
                }

                usuario.Id = usuarioLQ.id;
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UsuarioEntidades DevolverUsuario(string username)
        {
            try
            {
                UsuarioEntidades usuario = new UsuarioEntidades();
                using (var ctx = new DataClasses1DataContext())
                {
                    var usuarioLQ = ctx.Usuarios.FirstOrDefault(u => u.usuario == username);

                    if(usuarioLQ != null)
                    {
                        usuario.Id = usuarioLQ.id;
                        usuario.IdTipoUsuario = (int)usuarioLQ.idTipoUsuario;
                        usuario.Nombre = usuarioLQ.nombre;
                        usuario.User = usuarioLQ.usuario;
                        usuario.Contraseña = usuarioLQ.contraseña;
                        usuario.FechaCreacion = usuarioLQ.fechaCreacion;
                        return usuario;
                    }
                    return null;
                    
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}
