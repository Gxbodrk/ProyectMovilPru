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
using System.Data.SqlClient;
using System.Data;

namespace ProyectMovil
{
    class ConexionBD
    {
        static string url = "Data Source=192.168.0.107;Initial Catalog=MovilProyect;User ID=sa;Password=1598";
        SqlConnection con = new SqlConnection(url);

        int valor=0;

        //logeo
        public int ingresar(string user, string pass)   
        {
            string consulta = "select usu_usuario, usu_passw, usu_id from tbl_usuario where usu_usuario='" + user + "' and usu_passw='" + pass + "'";
            valor = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con); 
            SqlDataReader rs = cmd.ExecuteReader();



            while (rs.Read())
            {
                if (rs["usu_usuario"].ToString().Equals(user) && rs["usu_passw"].ToString().Equals(pass))
                {
                    if (rs["usu_id"].ToString().Equals("1"))
                    {
                        valor = 1;
                    }
                    if (rs["usu_id"].ToString().Equals("2"))
                    {
                        valor = 2;
                    }
                }
                else
                {
                    valor = 0;
                }
            }
            rs.Close();
            con.Close();



            return valor;
        }

        //registrar
        public void IngresarProductos(string nombre, string apellido, string cedula, string telefono, string usuario, string passw,string edad, string correo)
        {

            string consulta = "INSERT INTO tbl_usuario(usu_nombre, usu_apellido, usu_cedula, usu_telefono, usu_usuario, usu_passw, usu_edad, usu_correo) " +
                                              "VALUES (@nombre, @apellido, @cedula, @telefono, @usuario, @passw, @edad, @correo)";
            con.Open();
            SqlCommand command = new SqlCommand(consulta, con);

            command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            command.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = apellido;
            command.Parameters.Add("@cedula", SqlDbType.VarChar, 50).Value = cedula;
            command.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = telefono;
            command.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
            command.Parameters.Add("@passw", SqlDbType.VarChar, 50).Value = passw;
            command.Parameters.Add("@edad", SqlDbType.VarChar, 50).Value = edad;
            command.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = correo;


            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();

        }


    }
}