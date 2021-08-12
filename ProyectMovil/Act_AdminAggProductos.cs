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
    [Activity(Label = "Ingresar_producto")]
    public class Act_AdminAggProductos : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.vista_aggProductos);

            var regresar = FindViewById<ImageButton>(Resource.Id.imageButton1);

            regresar.Click += delegate {
                Intent intente = new Intent(this, typeof(Act_Login));
                StartActivity(intente);
            };
        }
    }
}