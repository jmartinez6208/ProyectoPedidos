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
        public string FechaCreacion { get; set; }
        public string Estado{ get; set; }
        public double Total{ get; set; }

        public double TotalConseguido { get; set; }
        public PedidoEntidades() { }
        public PedidoEntidades(int id, int idCliente, int idRepartidor, string fechaCreacion, string estado, double total, double totalConseguido)
        {
            Id = id;
            IdCliente = idCliente;
            IdRepartidor = idRepartidor;
            FechaCreacion = fechaCreacion;
            Estado = estado;
            Total = total;
            TotalConseguido = totalConseguido;
        }
    }
}
