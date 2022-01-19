using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Negocio;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PedidoEntidades> listaEntidades = PedidoNegocio.DevolverListaPedidos();

            foreach (var item in listaEntidades)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Total);
            }

            Console.ReadLine();
        }
    }
}
