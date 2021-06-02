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
    public class AD_Laboratorios
    {
        public static bool AregarLaboratorioABD(Laboratorio lab)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "insertLaboratorios";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@razonSocial", lab.RazonSocialLaboratorio);
                cmd.Parameters.AddWithValue("@calle", lab.CalleLaboratorio);
                cmd.Parameters.AddWithValue("@numeroCalle", lab.NumeroCalleLaboratorio);
                cmd.Parameters.AddWithValue("@idBarrio", lab.IdBarrioLaboratorio);
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

        internal static object ObtenerListadoLaboratorios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "getLaboratorios";
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

        public static bool ActualizarLabABD(Laboratorio lab)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Laboratorios SET RazonSocial = @razonSocial, Calle = @calle, NroCalle = @numeroCalle, idBarrio = @idBarrio WHERE Id LIKE @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", lab.IdLaboratorios);
                cmd.Parameters.AddWithValue("@razonSocial", lab.RazonSocialLaboratorio);
                cmd.Parameters.AddWithValue("@calle", lab.CalleLaboratorio);
                cmd.Parameters.AddWithValue("@numeroCalle", lab.NumeroCalleLaboratorio);
                cmd.Parameters.AddWithValue("@idBarrio", lab.IdBarrioLaboratorio);


                cmd.CommandType = CommandType.Text;
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

        public static Laboratorio ObtenerDatosLaboratorio(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            Laboratorio lab = new Laboratorio();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Laboratorios where Id like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();

                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())

                {
                    lab.IdLaboratorios = int.Parse(dr["Id"].ToString());
                    lab.RazonSocialLaboratorio = dr["RazonSocial"].ToString();
                    lab.CalleLaboratorio = dr["Calle"].ToString();
                    lab.NumeroCalleLaboratorio = dr["NroCalle"].ToString();
                    lab.IdBarrioLaboratorio = int.Parse(dr["idBarrio"].ToString());
                }
                else
                {
  
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
            return lab;
        }
    }
    
}
    

    
