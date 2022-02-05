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
    public partial class Reporte3 : Form
    {
        public Reporte3()
        {
            InitializeComponent();
        }

        private void Reporte3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PedidosBDDataSet4.TotalPorTiendas' Puede moverla o quitarla según sea necesario.
            this.TotalPorTiendasTableAdapter.Fill(this.PedidosBDDataSet4.TotalPorTiendas);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
