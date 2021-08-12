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

namespace ProyectMovil
{
    [Activity(Label = "Activity_registro")]
    public class Act_Registrar : Activity
    {
        ConexionBD conex = new ConexionBD();
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.vista_registrar);

            var txt_nombre = FindViewById<EditText>(Resource.Id.editText1);
            var txt_apellido = FindViewById<EditText>(Resource.Id.editText2);
            var txt_usuario = FindViewById<EditText>(Resource.Id.editText3);
            var txt_cedula = FindViewById<EditText>(Resource.Id.editText4);
            var txt_telefono = FindViewById<EditText>(Resource.Id.editText5);
            var txt_passw = FindViewById<EditText>(Resource.Id.editText6);
            var txt_edad = FindViewById<EditText>(Resource.Id.editText7);
            var txt_correo = FindViewById<EditText>(Resource.Id.editText8);

            var btncancelar = FindViewById<Button>(Resource.Id.button1);
            var btningresar = FindViewById<Button>(Resource.Id.button2);
            var btnprueba = FindViewById<Button>(Resource.Id.button3);



            btningresar.Click += delegate
            {
                if
                (
                    txt_nombre.Text == "" || txt_apellido.Text == "" || 
                    txt_usuario.Text == "" || txt_cedula.Text == "" ||
                    txt_telefono.Text == "" || txt_passw.Text == "" ||
                    txt_edad.Text == "" || txt_correo.Text == ""
                )
                {
                    //Muestra un mensaje en pantalla
                    Toast.MakeText(this, "Llene todos los campos por favor", ToastLength.Short).Show();
                }
                else
                {
                    conex.IngresarProductos(txt_nombre.Text, txt_apellido.Text, txt_cedula.Text, txt_telefono.Text, txt_usuario.Text, txt_passw.Text, txt_edad.Text, txt_correo.Text);
                    Toast.MakeText(this, "Se registro correctamente, ¡Inicia Sesión!", ToastLength.Short).Show();
                    //Limpia los campos
                    txt_nombre.Text = "";
                    txt_apellido.Text = "";
                    txt_usuario.Text = "";
                    txt_cedula.Text = "";
                    txt_telefono.Text = "";
                    txt_passw.Text = "";
                    txt_edad.Text = "";
                    txt_correo.Text = "";
                }
            };

            btncancelar.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };



            btnprueba.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_InicioPrueb));
                StartActivity(intent);
            };
        }
    }
}