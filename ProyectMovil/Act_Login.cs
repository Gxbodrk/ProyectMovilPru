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
    [Activity(Label = "Activity_ingreso")]
    public class Act_Login : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.vista_inicioAdmin);

            var agregar = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var inicio_regreso = FindViewById<ImageButton>(Resource.Id.imageButton1);

            agregar.Click += delegate
            {
                Intent inte = new Intent(this, typeof(Act_AdminAggProductos));
                StartActivity(inte);
            };

            inicio_regreso.Click += delegate
            {
                Intent inte = new Intent(this, typeof(Act_Inicio));
                StartActivity(inte);
            };
        }
    }
}