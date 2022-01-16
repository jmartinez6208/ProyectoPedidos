using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using Entidades;
using Negocio;

namespace ServiciosAsmx
{
    /// <summary>
    /// Descripción breve de UsuarioAsmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class UsuarioAsmx : System.Web.Services.WebService
    {

        [WebMethod]
        public UsuarioEntidades Nuevo(UsuarioEntidades usuario)
        {
            return UsuarioNegocio.Nuevo(usuario);
        }

        [WebMethod]
        public UsuarioEntidades DevolverUsuario(string username)
        {
            return UsuarioNegocio.DevolverUsuario(username);
        }
    }
}
