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
    [Activity(Label = "comprar")]
    public class Act_Comprar : Activity
    {

        List<string> Categorias = new List<string>();
        List<string> Licores = new List<string>();
        List<string> Tabacos = new List<string>();
        List<string> Bielas = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            

            // Create your application here
            SetContentView(Resource.Layout.comprar);
            //Colocar nombres a las listas
            Categorias.Add("Licores");
            Categorias.Add("Tabacos");
            Categorias.Add("Bielas");

            Licores.Add("Ron");
            Licores.Add("Wiski");
            Licores.Add("Tequila");
            Licores.Add("Chivas");

            Tabacos.Add("Malboro");
            Tabacos.Add("Elephant");
            Tabacos.Add("Malboro blanco");
            Tabacos.Add("Lark");

            Bielas.Add("Pilsener");
            Bielas.Add("Club");
            Bielas.Add("Siembra");
            Bielas.Add("Biela aresanal");

            var spnCategoria = FindViewById<Spinner>(Resource.Id.spinner1);
            var spnPlatos = FindViewById<Spinner>(Resource.Id.spinner2);
            var txvPrecio = FindViewById<TextView>(Resource.Id.textView6);
            var nbpCantidad = FindViewById<NumberPicker>(Resource.Id.numberPicker1);

            var btnpedido = FindViewById<Button>(Resource.Id.button1);
            var inicio = FindViewById<Button>(Resource.Id.button2);

            //botom
            var detalle = FindViewById<Button>(Resource.Id.button1);

            detalle.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_DetalleCompra));
                StartActivity(intent);

                //AlertDialog.Builder dialogo = new AlertDialog.Builder(this);
                //AlertDialog alert = dialogo.Create();
                //alert.SetTitle("Seleccionar producto");
                //alert.SetIcon(Android.Resource.Drawable.BottomBar);
                //alert.SetMessage("Estas seguro de guardar");

                //alert.SetButton("NO",(s,ev) =>
                //{
                //    Toast.MakeText(this, "informacion no ingresada", ToastLength.Short).Show();
                //});

                //alert.SetButton2("SI", (s, ev) =>
                //{
                //    Toast.MakeText(this,"ingresando informacion", ToastLength.Short).Show();
                //});
            };

            //Crear lista a spinner

            var adaptar = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, Categorias);
            //Cargar adaptador al spinner
            spnCategoria.Adapter = adaptar;

            nbpCantidad.MaxValue = 100;
            nbpCantidad.MinValue = 1;

            inicio.Click += delegate {
                Intent intent = new Intent(this, typeof(Act_Inicio));
                StartActivity(intent);
            };

            spnCategoria.ItemSelected += delegate
            {
                if (spnCategoria.SelectedItem.ToString() == "Licores")
                {
                    var adaptar2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, Licores);
                    spnPlatos.Adapter = adaptar2;
                    if (spnPlatos.SelectedItemPosition.ToString() == "0")
                    {
                        txvPrecio.Text = "10";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "1")
                    {
                        txvPrecio.Text = "15";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "2")
                    {
                        txvPrecio.Text = "30";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "3")
                    {
                        txvPrecio.Text = "50";
                    }
                }
                if (spnCategoria.SelectedItem.ToString() == "Tabacos")
                {
                    var adaptar2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, Tabacos);
                    spnPlatos.Adapter = adaptar2;

                    if (spnPlatos.SelectedItemPosition.ToString() == "0")
                    {
                        txvPrecio.Text = "2,50";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "1")
                    {
                        txvPrecio.Text = "3,00";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "2")
                    {
                        txvPrecio.Text = "3,50";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "3")
                    {
                        txvPrecio.Text = "5,00";
                    }
                }
                if (spnCategoria.SelectedItem.ToString() == "Bielas")
                {
                    var adaptar2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, Bielas);
                    spnPlatos.Adapter = adaptar2;

                    if (spnPlatos.SelectedItemPosition.ToString() == "0")
                    {
                        txvPrecio.Text = "2,50";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "1")
                    {
                        txvPrecio.Text = "4,50";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "2")
                    {
                        txvPrecio.Text = "2,50";
                    }
                    if (spnPlatos.SelectedItemPosition.ToString() == "3")
                    {
                        txvPrecio.Text = "5,50";
                    }
                }
            };

            spnPlatos.ItemSelected += delegate
            {
                if (spnPlatos.SelectedItemPosition.ToString() == "0" && spnCategoria.SelectedItem.ToString() == "Licores")
                {
                    txvPrecio.Text = "10";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "1" && spnCategoria.SelectedItem.ToString() == "Licores")
                {
                    txvPrecio.Text = "15";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "2" && spnCategoria.SelectedItem.ToString() == "Licores")
                {
                    txvPrecio.Text = "30";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "3" && spnCategoria.SelectedItem.ToString() == "Licores")
                {
                    txvPrecio.Text = "50";
                }

                //Bielas
                if (spnPlatos.SelectedItemPosition.ToString() == "0" && spnCategoria.SelectedItem.ToString() == "Bielas")
                {
                    txvPrecio.Text = "2,50";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "1" && spnCategoria.SelectedItem.ToString() == "Bielas")
                {
                    txvPrecio.Text = "4,50";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "2" && spnCategoria.SelectedItem.ToString() == "Bielas")
                {
                    txvPrecio.Text = "2,50";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "3" && spnCategoria.SelectedItem.ToString() == "Bielas")
                {
                    txvPrecio.Text = "5,50";
                }

                //Tabacos
                if (spnPlatos.SelectedItemPosition.ToString() == "0" && spnCategoria.SelectedItem.ToString() == "Tabacos")
                {
                    txvPrecio.Text = "2,50";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "1" && spnCategoria.SelectedItem.ToString() == "Tabacos")
                {
                    txvPrecio.Text = "3,00";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "2" && spnCategoria.SelectedItem.ToString() == "Tabacos")
                {
                    txvPrecio.Text = "3,50";
                }
                if (spnPlatos.SelectedItemPosition.ToString() == "3" && spnCategoria.SelectedItem.ToString() == "Tabacos")
                {
                    txvPrecio.Text = "5,00";
                }



            };
        }
    }
}