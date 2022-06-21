using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiposUsuarioEntidades
    {
        public TiposUsuarioEntidades(int id, string tipoUsuario)
        {
            Id = id;
            this.tipoUsuario = tipoUsuario;
        }

        public int Id { get; set; }
        public string tipoUsuario{ get; set; }

    }
}
