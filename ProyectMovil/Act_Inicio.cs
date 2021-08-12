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
    [Activity(Label = "Activity_inicio")]
    public class Act_Inicio : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.vista_inicioUsuario);
            // Create your application here
            var categoria = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var marca = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var tamaño = FindViewById<ImageButton>(Resource.Id.imageButton3);
            var ver = FindViewById<ImageButton>(Resource.Id.imageButton4);
            var compra = FindViewById<ImageButton>(Resource.Id.imageButton5);
            var salir = FindViewById<Button>(Resource.Id.button1);

            compra.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_Comprar));
                StartActivity(intent);
            };

            salir.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            ver.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_Login));
                StartActivity(intent);
            };

        }
    }
}