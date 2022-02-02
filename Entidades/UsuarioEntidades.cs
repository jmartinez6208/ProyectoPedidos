using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioEntidades
    {
        public int Id { get; set; }
        public int IdTipoUsuario { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
        public string FechaCreacion { get; set; }

        public string TipoUsuario{ get; set; }

        public UsuarioEntidades() { }

        public UsuarioEntidades(int id, int idTipoUsuario, string nombre, string user, string contraseña, string fechaCreacion)
        {
            Id = id;
            IdTipoUsuario = idTipoUsuario;
            Nombre = nombre;
            User = user;
            Contraseña = contraseña;
            FechaCreacion = fechaCreacion;
        }

        public UsuarioEntidades(int id, int idTipoUsuario, string nombre, string user, string contraseña, string fechaCreacion, string tipo)
        {
            Id = id;
            IdTipoUsuario = idTipoUsuario;
            Nombre = nombre;
            User = user;
            Contraseña = contraseña;
            FechaCreacion = fechaCreacion;
            TipoUsuario = tipo;
        }


    }
}
