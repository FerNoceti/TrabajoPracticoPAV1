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
    public class AD_Diagnostico
    {
        public static Diagnostico obtenerDiagnostico(int id)
        {
            Diagnostico diagnostico = new Diagnostico();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "selectDiagnostico";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idDiagnostico", id);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    diagnostico.IdDiagnostico = int.Parse(dr["Id"].ToString());
                    diagnostico.DescripcionDiagnostico = dr["Descripcion"].ToString();
                    diagnostico.PrecioDiagnostico = float.Parse(dr["precio"].ToString());

                    return diagnostico;
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


            return diagnostico;
        }

        public static DataTable obtenerDatosDiagnosticosPorConsulta(int idConsulta)
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getDiagnosticosPorConsulta";
            SqlConnection cn = new SqlConnection(CadenaDB);

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idConsulta", idConsulta);

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
