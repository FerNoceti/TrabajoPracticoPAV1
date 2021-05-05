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
    }
}
