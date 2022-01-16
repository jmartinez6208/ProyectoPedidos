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
using AndroidX.AppCompat.App;

using PresentacionMovil.asmxUsuario;

namespace PresentacionMovil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class RegistroActivity : Activity
    {
        private UsuarioAsmx clienteAsmx = new UsuarioAsmx();
        private EditText nombre, usuario, contraseña;
        private UsuarioEntidades usuarioEntidad = new UsuarioEntidades();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_registro);

            //Capturar Campos
            nombre = (EditText)FindViewById(Resource.Id.txtRegistrarNombre);
            usuario = (EditText)FindViewById(Resource.Id.txtRegistrarUsuario);
            contraseña = (EditText)FindViewById(Resource.Id.txtRegistrarContrasena);

            botones();
        }

        private bool RegistrarUsuario()
        {
            //usuario tipo cliente
            usuarioEntidad.Nombre = nombre.Text;
            usuarioEntidad.User = usuario.Text;
            usuarioEntidad.Contraseña = contraseña.Text;
            usuarioEntidad.IdTipoUsuario = 2;

            //seteando fecha actual
            DateTime fechaCreacion = DateTime.Now;
            usuarioEntidad.FechaCreacion = fechaCreacion;

            usuarioEntidad = clienteAsmx.Nuevo(usuarioEntidad);
            if (usuarioEntidad != null)
            {
                Toast.MakeText(Application.Context, "Usuario registrado correctamente.", ToastLength.Short).Show();
                return true;
            }
            return false; 
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (RegistrarUsuario())
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
                this.Finish();
            }
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        //Referencias Botones
        private void botones()
        {
            var registrarBoton = FindViewById(Resource.Id.btnRegistrar);
            registrarBoton.Click += Registrar_Click;
            var cancelarBoton = FindViewById(Resource.Id.btnCancelar);
            cancelarBoton.Click += Cancelar_Click;
        }


    }
}