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
    public partial class Reporte1 : Form
    {
        public Reporte1()
        {
            InitializeComponent();
        }

        private void Reporte1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PedidosBDDataSet1.vw_ProductosTop5' Puede moverla o quitarla según sea necesario.
            this.vw_ProductosTop5TableAdapter.Fill(this.PedidosBDDataSet1.vw_ProductosTop5);

            this.reportViewer1.RefreshReport();
        }
    }
}
