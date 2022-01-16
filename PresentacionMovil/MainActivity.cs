﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using System;

//using PresentacionMovil.wcfUsuario;
using PresentacionMovil.asmxUsuario;
using Android.Widget;

namespace PresentacionMovil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //UsuarioWCF clienteWCF = new UsuarioWCF();
        UsuarioAsmx clienteAsmx = new UsuarioAsmx();
        UsuarioEntidades usuarioEntidad;
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
            try
            {
                usuarioEntidad = clienteAsmx.DevolverUsuario(usuario.Text);
                var tipoUsuario = usuarioEntidad.IdTipoUsuario;
                if (usuarioEntidad != null)
                {
                    //Usuario Tipo Cliente
                    if (usuarioEntidad.Contraseña.Equals(contraseña.Text) && tipoUsuario.Equals(2))
                    {
                        
                        var intent = new Intent(this, typeof(PedidosActivity));
                        StartActivity(intent);

                    //Usuario Tipo Repartidor
                    }
                    else if (usuarioEntidad.Contraseña.Equals(contraseña.Text) && tipoUsuario.Equals(3))
                    {
                        //intent Repartidor
                    }
                    else
                    {
                        Toast.MakeText(Application.Context, "Contraseña incorrecta", ToastLength.Short).Show();
                    }
                }
                else
                {
                    Toast.MakeText(Application.Context, "El usuario: " + usuario.Text + " no existe", ToastLength.Short).Show();
                }
            }
            catch (Exception ez)
            {
                string mensaje = ez.Message.ToString();
                throw;
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

       /* public async bool Login(string user, string password)
        {
            var usuarioValido = clienteWCF.DevolverUsuario(user);
    
            await clienteWCF.DevolverUsuarioAsync(
                
                
                );*/

    }
}