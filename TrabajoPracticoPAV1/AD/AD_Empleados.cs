using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrabajoPracticoPAV1.AD
{
    public class AD_Empleados
    {
        public static DataTable obtenerDatosEmpleados()
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getEmpleados";
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
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
            
            return tabla;
        }
    }
}
