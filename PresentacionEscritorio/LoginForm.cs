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

using PresentacionEscritorio.wcfUsuario;


namespace PresentacionEscritorio
{
    public partial class LoginForm : Form
    {
        //propiedades
        private UsuarioWCFClient wcfUsuario = new UsuarioWCFClient();
        public static UsuarioEntidades usuarioEntidad;
        private const int ADMIN = 1;

        private String usuario, contraseña;

        public LoginForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text.Equals("Usuario"))
            {
                textBox_Usuario.Text = "";
            }
        }

        private void textBox_Usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text.Equals(""))
            {
                textBox_Usuario.Text = "Usuario";
            }
        }

        private void textBox_Contraseña_Leave(object sender, EventArgs e)
        {
            if (textBox_Contraseña.Text.Equals(""))
            {
                textBox_Contraseña.Text = "Contraseña";
                textBox_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void textBox_Contraseña_Enter(object sender, EventArgs e)
        {
            if (textBox_Contraseña.Text.Equals("Contraseña"))
            {
                textBox_Contraseña.Text = "";
                textBox_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (iniciarSesion())
            {
                GeneralForm ventana = new GeneralForm();
                this.Visible = false;
                ventana.Show();
            }
        }

        private bool iniciarSesion()
        {
            try
            {
                if (validarCampos())
                {
                    usuarioEntidad = wcfUsuario.Login(usuario, contraseña);
                    if (usuarioEntidad != null && usuarioEntidad.IdTipoUsuario == ADMIN)
                    {
                        MessageBox.Show("Bienvenido Admin " + usuarioEntidad.Nombre);
                        return true;
                    }
                        MessageBox.Show("Usuario o contraseña incorrecta!");
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private bool validarCampos()
        {
            usuario = this.textBox_Usuario.Text.ToString();
            contraseña = this.textBox_Contraseña.Text.ToString();
            if (usuario.Equals("Usuario") || contraseña.Equals("Contraseña"))
            {
                MessageBox.Show("Campos vacíos, ingrese usuario y contraseña!");
                return false;
            }
            return true;
        }
    }
}
