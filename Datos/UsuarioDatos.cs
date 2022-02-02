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

        public static UsuarioEntidades Actualizar(UsuarioEntidades usuarioEntidad)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var usuarioLQ = ctx.Usuarios.FirstOrDefault(p => p.id == usuarioEntidad.Id);
                    usuarioLQ.id = usuarioEntidad.Id;
                    usuarioLQ.idTipoUsuario = usuarioEntidad.IdTipoUsuario;
                    usuarioLQ.nombre = usuarioEntidad.Nombre;
                    usuarioLQ.fechaCreacion = usuarioEntidad.FechaCreacion;
                    usuarioLQ.usuario = usuarioEntidad.User;
                    usuarioLQ.contraseña = GetSHA256(usuarioEntidad.Contraseña);
                    ctx.SubmitChanges();
                }
                return usuarioEntidad;
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

        public static UsuarioEntidades DevolverUsuarioPorId(int identificador)
        {
            try
            {
                UsuarioEntidades usuario = new UsuarioEntidades();
                using (var ctx = new DataClasses1DataContext())
                {
                    var usuarioLQ = ctx.Usuarios.FirstOrDefault(u => u.id == identificador);

                    if (usuarioLQ != null)
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

        public static UsuarioEntidades Login(string username, string password)
        {
            try
            {
                UsuarioEntidades usuario = new UsuarioEntidades();
                using (var ctx = new DataClasses1DataContext())
                {
                    var passwordEncriptada = GetSHA256(password);
                    var usuarioLQ = ctx.Usuarios.FirstOrDefault(u => u.usuario == username && u.contraseña == passwordEncriptada);

                    if (usuarioLQ != null)
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
            catch (Exception)
            {

                throw;
            }
        }

        public static string DevolverTipoUsuario(int id)
        {
            try
            {
                string tipoUsuario = "";
                using (var ctx = new DataClasses1DataContext())
                {
                    var resultado = ctx.TipoUsuarios.FirstOrDefault(n => n.id == id);
                    tipoUsuario = resultado.tipo;
                    return tipoUsuario;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<UsuarioEntidades> DevolverListaRepartidores()
        {
            try
            {
                List<UsuarioEntidades> listaCasosEntidad = new List<UsuarioEntidades>();
                using (var ctx = new DataClasses1DataContext())
                {
                    var resultado = from r in ctx.Usuarios
                                    where r.idTipoUsuario == 3
                                    select r;

                    foreach (var item in resultado)
                    {
                        listaCasosEntidad.Add(new UsuarioEntidades(
                            item.id,
                            (int)item.idTipoUsuario,
                            item.nombre,
                            item.usuario,
                            item.contraseña,
                            item.fechaCreacion,
                            UsuarioDatos.DevolverTipoUsuario((int)item.idTipoUsuario)));
                    }

                    return listaCasosEntidad;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool EliminarRepartidorPorId(int identificador)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var repartidorLQ = ctx.Usuarios.FirstOrDefault(p => p.id == identificador);
                    ctx.Usuarios.DeleteOnSubmit(repartidorLQ);
                    ctx.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
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
