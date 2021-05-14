using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1.Entidades;

namespace TrabajoPracticoPAV1.AD
{
    public class AD_Sintomas
    {
        public static bool AgregarSintomaABD(Sintoma sin)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "insertSintoma";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", sin.NombreSintomas);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static object ObtenerListadoSintomas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "getSintomas";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static bool ActualizarSinABD(Sintoma sin)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "updateSintomas";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", sin.IdSintomas);
                cmd.Parameters.AddWithValue("@nombre", sin.NombreSintomas);



                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static Sintoma ObtenerSintoma(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            Sintoma sin = new Sintoma();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Sintomas where Id like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();

                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())

                {
                    sin.IdSintomas = int.Parse(dr["Id"].ToString());
                    sin.NombreSintomas = dr["NombreSintoma"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return sin;
        }
        
    }

}
