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
    [Activity(Label = "Act_InicioPrueb")]
    public class Act_InicioPrueb : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.vista_Inicio);

            var btn_CagCerveza = FindViewById<Button>(Resource.Id.button1);
            var btn_CagLicoreria = FindViewById<Button>(Resource.Id.button2);
            var btn_CagSinAhl = FindViewById<Button>(Resource.Id.button3);
            var btn_CagSnack = FindViewById<Button>(Resource.Id.button4);
            var btn_CagOtro = FindViewById<Button>(Resource.Id.button5);

            btn_CagCerveza.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_DetalleCompra));
                StartActivity(intent);
            };

            btn_CagLicoreria.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_DetalleCompra));
                StartActivity(intent);
            };

            btn_CagSinAhl.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_DetalleCompra));
                StartActivity(intent);
            };

            btn_CagSnack.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_DetalleCompra));
                StartActivity(intent);
            };

            btn_CagOtro.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_DetalleCompra));
                StartActivity(intent);
            };
        }
    }
}