using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1.Entidades;

namespace TrabajoPracticoPAV1.AD
{
    public class AD_Medicamentos
    {


        public static DataTable ObtenerTabla(string nombreTabla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM " + nombreTabla;

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

        public static DataTable ObtenerListadoMedicamentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Medicamentos";

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

        public static bool AgregarMedicamentoBD(Medicamentos med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Medicamentos (Descripcion,IdLaboratorio,FechaUltimaCompra,Precio,CantidadMinimaxSucursal,IdUnidadMedida,IdTipoMedicamento) VALUES(@nombre,@idlab,@fecha,@precio,@cantmin,@idunidad,@idtipo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", med.DescripcionMedicamentos);
                cmd.Parameters.AddWithValue("@idlab", med.Id_LaboratorioMedicamentos);
                cmd.Parameters.AddWithValue("@fecha", med.Fecha_Ultimna_CompraMedicamentos);
                cmd.Parameters.AddWithValue("@precio", med.PrecioMedicamentos);
                cmd.Parameters.AddWithValue("@cantmin", med.CantidadMinimaXSucursal_Medicamentos);
                cmd.Parameters.AddWithValue("@idunidad", med.Id_UnidadMedidaMedicamentos);
                cmd.Parameters.AddWithValue("@idtipo", med.Id_TipoMedicamentos);
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamento");
            }
            finally
            {
                cn.Close();
            }


            return resultado;
        }

        public static DataTable ObtenerTiposDeMedicamentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetTiposDeMedicamentos";

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

        public static Medicamentos ObtenerMedicamento(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Medicamentos m = new Medicamentos();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Medicamentos where Id like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader(); //ejecuta la sentencia sql

                if (dr != null && dr.Read()) //si el datareader no es nulo, leeme el primer valor y si es true entra
                {
                    m.Id_Medicamentos = (int.Parse(dr["Id"].ToString()));
                    m.DescripcionMedicamentos = dr["Descripcion"].ToString();
                    m.Id_LaboratorioMedicamentos = int.Parse(dr["IdLaboratorio"].ToString());
                    m.Fecha_Ultimna_CompraMedicamentos = DateTime.Parse(dr["FechaUltimaCompra"].ToString());
                    m.PrecioMedicamentos = int.Parse(dr["Precio"].ToString());
                    m.CantidadMinimaXSucursal_Medicamentos = int.Parse(dr["CantidadMinimaxSucursal"].ToString());
                    m.Id_UnidadMedidaMedicamentos = int.Parse(dr["IdUnidadMedida"].ToString());
                    m.Id_TipoMedicamentos = int.Parse(dr["IdTipoMedicamento"].ToString());

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
            return m;

        }

        public static bool ActualizarMedicamento(Medicamentos med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Medicamentos SET Descripcion = @nombre, IdLaboratorio = @idlab, FechaUltimaCompra = @fecha, Precio = @precio, CantidadMinimaxSucursal = @cantmin, IdUnidadMedida = @idunidad, IdTipoMedicamento = @idtipo WHERE Id like @id_m";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", med.DescripcionMedicamentos);
                cmd.Parameters.AddWithValue("@idlab", med.Id_LaboratorioMedicamentos);
                cmd.Parameters.AddWithValue("@fecha", med.Fecha_Ultimna_CompraMedicamentos);
                cmd.Parameters.AddWithValue("@precio", med.PrecioMedicamentos);
                cmd.Parameters.AddWithValue("@cantmin", med.CantidadMinimaXSucursal_Medicamentos);
                cmd.Parameters.AddWithValue("@idunidad", med.Id_UnidadMedidaMedicamentos);
                cmd.Parameters.AddWithValue("@idtipo", med.Id_TipoMedicamentos);
                cmd.Parameters.AddWithValue("@id_m", med.Id_Medicamentos);


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


        public static DataTable ObtenerMedicamentoPorId(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * from Medicamentos where Id like '" + id + "'";

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

        public static bool EliminarMedicamento(Medicamentos m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Medicamentos WHERE Id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", m.Id_Medicamentos);
          
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

        public static DataTable obtenerMedicamentosPorConsulta(int idConsulta)
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getMedicamentosPorConsulta";
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

        public static DataTable obtenerDatosMedicamentos()
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getMedicamentos";
            SqlConnection cn = new SqlConnection(CadenaDB);

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
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

