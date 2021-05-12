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
    }
    
}
