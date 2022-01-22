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

//using PresentacionMovil.asmxUsuario;
using PresentacionMovil.wcfUsuario;


namespace PresentacionMovil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class RegistroActivity : Activity
    {
        //private UsuarioAsmx clienteAsmx = new UsuarioAsmx();
        private UsuarioWCF clienteWCF = new UsuarioWCF();
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
            if (nombre.Text.Equals("") || usuario.Text.Equals("") || contraseña.Text.Equals(""))
            {
                Toast.MakeText(Application.Context, "Campos Incompletos", ToastLength.Short).Show();
                return false;
            }
            else 
            {
                try
                {
                    //usuario tipo cliente
                    usuarioEntidad.Nombre = nombre.Text;
                    usuarioEntidad.User = usuario.Text;
                    usuarioEntidad.Contraseña = contraseña.Text;
                    usuarioEntidad.IdTipoUsuario = 2;
                    usuarioEntidad.IdTipoUsuarioSpecified = true;

                    //seteando fecha actual
                    DateTime fechaCreacion = DateTime.Now;
                    string fecha = fechaCreacion.ToString("dd/MM/yyyy");
                    usuarioEntidad.FechaCreacion = fecha;
                    

                    UsuarioEntidades usuarioAux = clienteWCF.DevolverUsuario(usuarioEntidad.User);
                    if (usuarioAux != null)
                    {
                        Toast.MakeText(Application.Context, "Usuario ya existe en la base de datos", ToastLength.Short).Show();
                        return false;
                    }

                    usuarioEntidad = clienteWCF.Nuevo(usuarioEntidad);
                    if (usuarioEntidad != null)
                    {
                        Toast.MakeText(Application.Context, "Usuario registrado correctamente.", ToastLength.Short).Show();
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "No se pudo registrar el usuario!", ToastLength.Short).Show();
                    return false;
                    throw;
                }
                
            }
            

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
            this.Finish();
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