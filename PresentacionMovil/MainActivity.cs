using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using System;

using PresentacionMovil.wcfUsuario;
//using PresentacionMovil.asmxUsuario;
using Android.Widget;

namespace PresentacionMovil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private UsuarioWCF clienteWCF = new UsuarioWCF();
        //private UsuarioAsmx clienteAsmx = new UsuarioAsmx();
        private UsuarioEntidades usuarioEntidad;
        private EditText usuario, contraseña;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Campos Login
            usuario = (EditText)FindViewById(Resource.Id.txtUsuario);
            contraseña = (EditText)FindViewById(Resource.Id.txtContrasena);
            botones();

         
        }

        private void botones()
        {
            var registrarseBoton = FindViewById(Resource.Id.btnRegistrarse);
            registrarseBoton.Click += Registrarse_Click;
            var iniciarSesionBoton = FindViewById(Resource.Id.btnIngresar);
            iniciarSesionBoton.Click += Iniciar_Click;
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RegistroActivity));
            StartActivity(intent);
        }
        private void Iniciar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (usuario.Text.Equals("") || contraseña.Text.Equals(""))
            {
                Toast.MakeText(Application.Context, "Campos incompletos", ToastLength.Short).Show();
            }
            else
            {
                try
                {
                    usuarioEntidad = clienteWCF.Login(usuario.Text, contraseña.Text);

                    if (usuarioEntidad != null)
                    {
                        var tipoUsuario = usuarioEntidad.IdTipoUsuario;
                        //Si es un Usuario Tipo Cliente
                        if (tipoUsuario.Equals(2))
                        {

                            var intent = new Intent(this, typeof(PedidosActivity));
                            intent.PutExtra("username", usuarioEntidad.User);
                            StartActivity(intent);
                            this.Finish();
                            
                        }
                        //Si es un Usuario Tipo Repartidor
                        if (tipoUsuario.Equals(3))
                        {
                            var intent = new Intent(this, typeof(RepartidorActivity));
                            intent.PutExtra("username", usuarioEntidad.User);
                            StartActivity(intent);
                            this.Finish();
                        }
                    }
                    else
                    {
                        Toast.MakeText(Application.Context, "El usuario o contraseña son incorrectos", ToastLength.Short).Show();
                    }
                }
                catch (Exception ez)
                {
                    Toast.MakeText(Application.Context, "El usuario: " + usuario.Text + " no existe", ToastLength.Short).Show();
                }

            }

        }


    }
}