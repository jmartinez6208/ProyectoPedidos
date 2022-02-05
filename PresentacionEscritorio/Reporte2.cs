using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionEscritorio
{
    public partial class Reporte2 : Form
    {
        public Reporte2()
        {
            InitializeComponent();
        }

        private void Reporte2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        private void MostrarReporte()
        {
            // TODO: esta línea de código carga datos en la tabla 'PedidosBDDataSet2.vw_Repartidores' Puede moverla o quitarla según sea necesario.
            this.vw_RepartidoresTableAdapter.Fill(this.PedidosBDDataSet2.vw_Repartidores);
            this.vw_RepartidoresTableAdapter.FillByNombre(this.PedidosBDDataSet2.vw_Repartidores,txbNombre.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
