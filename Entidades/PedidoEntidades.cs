using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PedidoEntidades
    {
        public int Id{ get; set; }
        public int IdCliente{ get; set; }
        public int IdRepartidor{ get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado{ get; set; }
        public double Total{ get; set; }

        public PedidoEntidades() { }
        public PedidoEntidades(int id, int idCliente, int idRepartidor, DateTime fechaCreacion, string estado, double total)
        {
            Id = id;
            IdCliente = idCliente;
            IdRepartidor = idRepartidor;
            FechaCreacion = fechaCreacion;
            Estado = estado;
            Total = total;
        }
    }
}
