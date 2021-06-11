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
    public class AD_Facturas
    {
        public static int obtenerUltimoNroFactura()
        {
            int resultado;
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "getMaxNroFactura";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                cn.Open();
                cmd.Connection = cn;

                resultado = (int)cmd.ExecuteScalar();
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

            return resultado;
        }

        public static bool existeFactura(int idConsulta)
        {
            DataTable tabla = new DataTable();
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "selectFactura";
            SqlConnection cn = new SqlConnection(cadenaDB);
            try
            {

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;
                cmd.Connection = cn;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idConsulta", idConsulta);

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
        }

        internal static bool ingresarFacturaNueva(Factura f)
        {
            bool resultado = false;
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "insertFactura";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idTipoFactura", f.IdTipoFactura);
                cmd.Parameters.AddWithValue("@idConsulta", f.IdConsulta);
                cmd.Parameters.AddWithValue("@fecha", f.FechaFactura);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
    }
}
