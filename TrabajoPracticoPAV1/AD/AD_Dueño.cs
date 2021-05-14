using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1.Entidades;
using TrabajoPracticoPAV1.Formularios.ABM;

namespace TrabajoPracticoPAV1.AD
{
    class AD_Dueño
    {
        public static bool AgregarDueñoABD(Dueño per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Dueños (Nombre, Apellido, Telefono) VALUES (@nombre, @apellido, @telefono)";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombre", per.NombreDueño);
                cmd.Parameters.AddWithValue("@apellido", per.ApellidoDueño);
                cmd.Parameters.AddWithValue("@telefono", per.TelefonoDueño);
                
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


        public static Dueño ObtenerDueño(string id)
        {
            Dueño p = new Dueño();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Dueños where Id like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.NombreDueño = dr["Nombre"].ToString();
                    p.ApellidoDueño = dr["Apellido"].ToString();
                    p.TelefonoDueño = dr["Telefono"].ToString();
                    p.IdDueño = dr["Id"].ToString();
                    



                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }


            return p;
        }
        public static DataTable ObtenerListadoDueñosReducido()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];

            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Id, Nombre, Apellido, Telefono FROM Dueños";

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
        public static bool ActualizarDueño(Dueño per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Dueños SET Nombre = @nombre, Apellido = @apellido, Telefono = @telefono WHERE Id like @id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", per.IdDueño);
                cmd.Parameters.AddWithValue("@nombre", per.NombreDueño);
                cmd.Parameters.AddWithValue("@apellido", per.ApellidoDueño);
                cmd.Parameters.AddWithValue("@telefono", per.TelefonoDueño);
                
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
        public static bool EliminarDueño(Dueño per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Dueños WHERE Id like @id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", per.IdDueño);

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
        public static int ObtenerUltimoIdDueño()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(Id) FROM Dueños";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                int resultado = (int)cmd.ExecuteScalar();
                return resultado;

            }
            catch (Exception ex)
            {

                return 0;
            }
            finally
            {
                cn.Close();
            }


            
        }
    }   
        
}
