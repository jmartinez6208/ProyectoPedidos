﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PresentacionEscritorio.wcfPedidos;
using PresentacionEscritorio.wcfDetallePedido;
using PresentacionEscritorio.wcfUsuario;

namespace PresentacionEscritorio
{
    public partial class PedidosForm : Form
    {

        private UsuarioWCFClient wcfUsuario = new UsuarioWCFClient();
        private UsuarioEntidades clienteEntidad = new UsuarioEntidades();
        private UsuarioEntidades repartidorEntidad = new UsuarioEntidades();
        private List<UsuarioEntidades> listaRepartidores = new List<UsuarioEntidades>();
        private List<UsuarioEntidades> listaClientes = new List<UsuarioEntidades>();

        private PedidoWCFClient wcfPedido = new PedidoWCFClient();
        private PedidoEntidades pedidoEntidad = new PedidoEntidades();

        private List<DetallePedidoClient> wcfDetallePedido = new List<DetallePedidoClient>();
        private List<DetallePedidoEntidades> listaDetallePedidos = new List<DetallePedidoEntidades>();

        private List<string> estadosPedido = new List<string>();


        public PedidosForm()
        {
            InitializeComponent();
            InicializarDatos();
        }

        private void InicializarDatos()
        {
            estadosPedido.Add("Nuevo");
            estadosPedido.Add("Pendiente");
            estadosPedido.Add("Asignado");
            estadosPedido.Add("Completado");
            CargarComboBox();

            CargarTabla();
        }

        private void CargarTabla()
        {
            string estado = comboBox_EstadoPedido.SelectedItem.ToString();
            dataGridView_Pedidos.DataSource = wcfPedido.DevolverListaPedidosPorEstado(estado);
        }

        private void CargarComboBox()
        {
            comboBox_Clientes.DataSource = wcfUsuario.DevolverListaClientes();
            comboBox_Clientes.DisplayMember = "nombre";
            comboBox_Clientes.ValueMember = "id";

            comboBox_Repartidores.DataSource = wcfUsuario.DevolverListaRepartidores();
            comboBox_Repartidores.DisplayMember = "nombre";
            comboBox_Repartidores.ValueMember = "id";

            comboBox_Clientes.SelectedIndex = -1;
            comboBox_Repartidores.SelectedIndex = -1;

            comboBox_EstadoPedido.DataSource = estadosPedido;
            comboBox_EstadoPedido.SelectedIndex = 1;

            comboBox_EstadoPedido.SelectedIndexChanged +=
            new System.EventHandler(ComboBoxEstadoPedidoCambio);
        }

        private void ComboBoxEstadoPedidoCambio(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox_Id.Text = "";
            textBox_Fecha.Text = "";
            textBox_Total.Text = "";
            textBox_Conseguido.Text = "";

            comboBox_Clientes.SelectedIndex = -1;
            comboBox_Repartidores.SelectedIndex = -1;
        }

        private void dataGridView_Pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_Pedidos.CurrentRow.Cells["Id"].Value.ToString());
            CargarCampos(id);
        }

        private void CargarCampos(int id)
        {
            pedidoEntidad = wcfPedido.DevolverPedidoPorId(id);

            textBox_Id.Text = pedidoEntidad.Id.ToString();
            textBox_Fecha.Text = pedidoEntidad.FechaCreacion.ToString();
            textBox_Total.Text = pedidoEntidad.Total.ToString();
            textBox_Conseguido.Text = pedidoEntidad.TotalConseguido.ToString();

            comboBox_Clientes.SelectedValue = pedidoEntidad.IdCliente;
            comboBox_Repartidores.SelectedValue = pedidoEntidad.IdRepartidor;


        }
    }
}