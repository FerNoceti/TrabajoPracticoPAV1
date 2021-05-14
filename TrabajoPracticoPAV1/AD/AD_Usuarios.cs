using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrabajoPracticoPAV1.AD
{
    public class AD_Usuarios
    {
        public static bool validarUsuario(string nombreUsuario, string password)
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "selectUsuario";
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@password", password);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;



                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
  
            }
            return false;
        }

        public static DataTable ObtenerListadoUsuarios()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdTipoUsuario,NombreUsuario,FechaRegistro FROM Usuarios";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;


            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }



        }
        public static bool InsertarUsuario(string nombreDeUsuario, string contraseña, string nombre, string apellido, string email, string fecha, int tipoUsu)
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Usuarios (NombreUsuario, Nombre, Apellido, Email, Password, FechaRegistro, IdTipoUsuario) VALUES (@nombreUsu,@nombre,@apellido,@email, @pass, @fecha, @tipoUsuario)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("apellido", apellido);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", contraseña);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsu);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }


            return resultado;
        }
    }
}
