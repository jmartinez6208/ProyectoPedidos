using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentacionEscritorio
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
            customizeDesing();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void customizeDesing()
        {
            panelSubMenuReportes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuReportes.Visible == true)
                panelSubMenuReportes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GestorRepartidores_Load(object sender, EventArgs e)
        {

        }

        private void GestorRepartidores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            openChildForm(new Reporte3());

            hideSubMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuReportes);
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {

           openChildForm(new Reporte1 ());
            hideSubMenu();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            openChildForm(new Reporte2());

            hideSubMenu();
        }

        private void panelContenedorHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Bottom;
            panelContenedorHijo.Controls.Add(childForm);
            panelContenedorHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedorHijo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRepartidores_Click(object sender, EventArgs e)
        {
            openChildForm(new Repartidor());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            openChildForm(new PedidosForm());
        }
    }
}
