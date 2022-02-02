using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PresentacionEscritorio.wcfUsuario;


namespace PresentacionEscritorio

{
    public partial class Repartidor : Form
    {
        //propiedades
        private UsuarioWCFClient wcfUsuario = new UsuarioWCFClient();
        private UsuarioEntidades usuarioEntidad = new UsuarioEntidades();
        private const int REPARTIDOR = 3;

        public Repartidor()
        {
            InitializeComponent();
            CargarTablaRepartidores();
        }

        private void GuardarRepartidor()
        {
            usuarioEntidad.Nombre = this.txtNombreYApellido.Text;
            usuarioEntidad.User = this.txtUsuario.Text;
            usuarioEntidad.Contraseña = this.txtContraseña.Text;
            usuarioEntidad.IdTipoUsuario = REPARTIDOR;
            DateTime fechaCreacion = DateTime.Now;
            string fecha = fechaCreacion.ToString("dd/MM/yyyy");
            usuarioEntidad.FechaCreacion = fecha;

            usuarioEntidad = wcfUsuario.Nuevo(usuarioEntidad);
            txtId.Text = usuarioEntidad.Id.ToString();
            MessageBox.Show("Los datos se almacenaron corerectamente");
            usuarioEntidad = new UsuarioEntidades();
            LimpiarCampos();
            CargarTablaRepartidores();
        }

        private void CargarCampos(int identificador)
        {
            usuarioEntidad = wcfUsuario.DevolverUsuarioPorId(identificador);
            this.txtId.Text = usuarioEntidad.Id.ToString();
            this.txtNombreYApellido.Text = usuarioEntidad.Nombre.ToString();
            this.txtUsuario.Text = usuarioEntidad.User.ToString();
            this.txtContraseña.Text = usuarioEntidad.Contraseña.ToString();
        }

        private void LimpiarCampos()
        {
            this.txtId.Text = "";
            this.txtNombreYApellido.Text = "";
            this.txtUsuario.Text = "";
            this.txtContraseña.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarTablaRepartidores()
        {
            this.dataGridView_Repartidores.DataSource = wcfUsuario.DevolverListaRepartidores();
        }

        private void Repartidor_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_Repartidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRepartidor();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            EliminarRepartidor();
        }

        private void EliminarRepartidor()
        {
            int id = Convert.ToInt32(this.txtId.Text);
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                wcfUsuario.EliminarRepartidorPorId(id);
                CargarTablaRepartidores();
                LimpiarCampos();
                usuarioEntidad = new UsuarioEntidades();
            }
        }

        private void dataGridView_Repartidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_Repartidores.CurrentRow.Cells["Id"].Value.ToString());
            CargarCampos(id);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            usuarioEntidad = new UsuarioEntidades();
            LimpiarCampos();
        }
    }
}
