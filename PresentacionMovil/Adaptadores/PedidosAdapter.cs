using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using PresentacionMovil.asmxPedido;
using PresentacionMovil.wcfPedido;

namespace PresentacionMovil.Adaptadores
{

    class PedidosAdapter : BaseAdapter<PedidoEntidades>
    {

        private Activity _context;
        private List<PedidoEntidades> _pedidos;

        public PedidosAdapter(Activity context, List<PedidoEntidades> pedidos)
        {
            _context = context;
            _pedidos = pedidos;
        }

        public override PedidoEntidades this[int position] => _pedidos[position];

        public override int Count => _pedidos.Count;

        public override long GetItemId(int position)
        {
            return this[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = this[position];

            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Resource.Layout.fila_pedidos, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.txtIdPedido).Text = "Pedido: " + item.Id;
            convertView.FindViewById<TextView>(Resource.Id.txtFechaPedido).Text = item.FechaCreacion.ToString();
            convertView.FindViewById<TextView>(Resource.Id.txtRepartidorPedido).Text = "Repartidor: " + item.IdRepartidor;
            convertView.FindViewById<TextView>(Resource.Id.txtEstadoPedido).Text = "Estado: " + item.Estado;
            convertView.FindViewById<TextView>(Resource.Id.txtTotalPedido).Text = "Total: $" + item.Total.ToString();

            return convertView;
        }
    }
}