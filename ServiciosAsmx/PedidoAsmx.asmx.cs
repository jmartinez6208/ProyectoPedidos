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
    /// Summary description for PedidoAsmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PedidoAsmx : System.Web.Services.WebService
    {

        [WebMethod]
        public PedidoEntidades Nuevo(PedidoEntidades pedido)
        {
            return PedidoNegocio.Nuevo(pedido);
        }

        [WebMethod]
        public PedidoEntidades Actualizar(PedidoEntidades pedido)
        {
            return PedidoNegocio.Actualizar(pedido);
        }

        [WebMethod]
        public PedidoEntidades DevolverPedidoPorId(int identificador)
        {
            return PedidoNegocio.DevolverPedidoPorId(identificador);
        }

        [WebMethod]
        public List<PedidoEntidades> DevolverListaPedidos()
        {
            return PedidoNegocio.DevolverListaPedidos();
        }

        [WebMethod]
        public bool EliminarPedidoPorId(int identificador)
        {
            return PedidoNegocio.EliminarPedidoPorId(identificador);
        }

        [WebMethod]
        public List<PedidoEntidades> DevolverListaPedidosPorCliente(int idCliente)
        {
            return PedidoNegocio.DevolverListaPedidosPorCliente(idCliente);
        }
    }
}
