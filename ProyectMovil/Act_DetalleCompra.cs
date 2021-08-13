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
    [Activity(Label = "detalle")]
    public class Act_DetalleCompra : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.vista_comprarProductos);

            var btncancelar = FindViewById<Button>(Resource.Id.button1);

            btncancelar.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_InicioPrueb));
                StartActivity(intent);
            };
        }
    }
}