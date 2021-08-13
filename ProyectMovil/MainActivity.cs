using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;

namespace ProyectMovil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ConexionBD conex = new ConexionBD();
        int con = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            var txt_usuario = FindViewById<EditText>(Resource.Id.editText1);
            var txt_passw = FindViewById<EditText>(Resource.Id.editText2);
            var btn_ingresar = FindViewById<Button>(Resource.Id.button1);
            var btn_registro = FindViewById<Button>(Resource.Id.button2);

            
            //Llamamos al boton para hacer la verificacion
            btn_ingresar.Click += delegate
            {
                //Validacion para q los campos no sean en blanco
                if (txt_usuario.Text == "" || txt_passw.Text == "")
                {
                    //Muestra un mensaje en pantalla
                    Toast.MakeText(this, "Llene todos los campos por favor", ToastLength.Short).Show();
                    //Limpia los campos
                    txt_usuario.Text = "";
                    txt_passw.Text = "";
                }
                else if (conex.ingresar(txt_usuario.Text, txt_passw.Text) != 1)
                {

                    //Muestra un mensaje en pantalla
                    Toast.MakeText(this, "Usuario no existe", ToastLength.Short).Show();

                    //Limpia los campos
                    txt_usuario.Text = "";
                    txt_passw.Text = "";
                }
                //Si el usuario y contraseña son correctos ingresa al programa
                else if (conex.ingresar(txt_usuario.Text, txt_passw.Text) == 1)
                {
                    Intent intent = new Intent(this, typeof(Act_InicioPrueb));
                    StartActivity(intent);
                    Toast.MakeText(this, "Ingreso Exitoso, Bienvenido", ToastLength.Short).Show();
                    txt_usuario.Text = "";
                    txt_passw.Text = "";
                }
                else
                {
                    Toast.MakeText(this, "Ingreso erronéo, intentelo de nuevo", ToastLength.Short).Show();
                }
                txt_usuario.Text = "";
                txt_passw.Text = "";



                //if (conex.ingresar(usuario.Text, pass.Text) == 1)
                //{
                //    Intent intent = new Intent(this, typeof(Activity_inicio));
                //    StartActivity(intent);
                //    Toast.MakeText(this, "Conexion exitosa", ToastLength.Short).Show();
                //}
                //else
                //{
                //    Toast.MakeText(this, "Conexion erronea", ToastLength.Short).Show();
                //}



            };

            btn_registro.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act_Registrar));
                StartActivity(intent);
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}