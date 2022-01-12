using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallePedidoEntidades
    {
        public int IdPedidoPertenece{ get; set; }
        public int IdProductoTienda{ get; set; }
        public int Cantidad{ get; set; }
        public double Subtotal{ get; set; }
        public char Conseguido{ get; set; }

        public DetallePedidoEntidades(int idPedidoPertenece, int idProductoTienda, int cantidad, double subtotal, char conseguido)
        {
            IdPedidoPertenece = idPedidoPertenece;
            IdProductoTienda = idProductoTienda;
            Cantidad = cantidad;
            Subtotal = subtotal;
            Conseguido = conseguido;
        }
    }
}
