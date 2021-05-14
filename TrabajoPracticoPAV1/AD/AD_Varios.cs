using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1.Entidades;

namespace TrabajoPracticoPAV1.AD
{
    public class AD_Varios
    {
        public static DataTable obtenerTipoDocumentos()
        {
            try
            {
                return obtenerTablaSP("getTipoDocumentos");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable ObtenerCiudades()
        {
            try
            {
                return obtenerTablaSP("getCiudades");
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
                return obtenerTablaSP("getSucursales");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable obtenerTablaSP(string storedProcedure)
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
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable ObtenerListadoBarriosReducido()
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getBarrios";
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
        }

        public static DataTable ObtenerTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
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
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;



            }
            catch (Exception)
            { 
            }

            return tabla;
        }

        public static bool AgregarBarrioABD(Barrio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "insertBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", b.NombreBarrio);
                cmd.Parameters.AddWithValue("@IdCiudad", b.CiudadBarrio);
                cmd.Parameters.AddWithValue("@Descripcion", b.DescripcionBarrio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static Barrio ObtenerBarrio(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Barrio b = new Barrio();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "selectBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    b.IdBarrio = int.Parse(dr["Id"].ToString());
                    b.NombreBarrio = dr["Nombre"].ToString();
                    b.CiudadBarrio = int.Parse(dr["IdCiudad"].ToString());
                    b.DescripcionBarrio = dr["Descripcion"].ToString();
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
            return b;
        }

        public static bool ActualizarBarrio(Barrio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "updateBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", b.IdBarrio);         
                cmd.Parameters.AddWithValue("@Nombre", b.NombreBarrio);
                cmd.Parameters.AddWithValue("@IdCiudad", b.CiudadBarrio);
                cmd.Parameters.AddWithValue("@Descripcion", b.DescripcionBarrio);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static bool EliminarBarrio(Barrio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Barrios WHERE Nombre LIKE @Nombre AND IdCiudad LIKE @IdCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", b.NombreBarrio);
                cmd.Parameters.AddWithValue("@IdCiudad", b.CiudadBarrio);
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
    }
}
