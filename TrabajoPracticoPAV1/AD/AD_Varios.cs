using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrabajoPracticoPAV1.AD
{
    public class AD_Varios
    {
        public static DataTable obtenerTipoDocumentos()
        {
            try
            {
                return obtenerTabla("getTipoDocumentos");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable obtenerSucursales()
        {
            try
            {
                return obtenerTabla("getSucursales");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable obtenerTabla(string storedProcedure)
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(CadenaDB);
	    try
            {
                SqlCommand cmd = new SqlCommand();
		cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;
                cn.Open();
                cmd.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerTabla(string nombreTabla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM @nombreTabla";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreTabla", nombreTabla);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;



            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
