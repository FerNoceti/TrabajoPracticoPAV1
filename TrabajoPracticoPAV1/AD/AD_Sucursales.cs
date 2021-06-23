using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TrabajoPracticoPAV1.Entidades;

namespace TrabajoPracticoPAV1.AD
{
    public class AD_Sucursales
    {
       public static DataTable obtenerDatosSucursales()
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getSucursales";
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

        internal static DataTable obtenerIngresosPorFecha()
        {
            DataTable resultado = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getIngresosPorMesAño";
            SqlConnection cn = new SqlConnection(CadenaDB);
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                cn.Open();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
                return resultado;
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

        internal static DataTable obtenerIngresosPorSucursal()
        {
            DataTable resultado = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getIngresosPorSucursal";
            SqlConnection cn = new SqlConnection(CadenaDB);
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                cn.Open();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
                return resultado;
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

        public static DataTable obtenerSucursalesReducido()
        {
            DataTable resultado = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getSucursalesReducido";
            SqlConnection cn = new SqlConnection(CadenaDB);
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                cn.Open();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
                return resultado;
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

        public static DataTable obtenerSupervisores(int id)
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getSupervisoresPorSucursal";
            SqlConnection cn = new SqlConnection(CadenaDB);

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", id);

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

        public static bool agregarSucursal(Sucursal s)
        {
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "insertSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", s.NombreSucursal);
                if(s.TipoDocumentoSupervisor !=0)
                {
                    cmd.Parameters.AddWithValue("@TipoDocSupervisor", s.TipoDocumentoSupervisor);
                    cmd.Parameters.AddWithValue("@NroDocSupervisor", s.NroDocumentoSupervisor);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TipoDocSupervisor", System.Data.SqlTypes.SqlInt32.Null);
                    cmd.Parameters.AddWithValue("@NroDocSupervisor", "NULL");
                }

                if(s.TipoDocumentoSuplente != 0)
                {
                    cmd.Parameters.AddWithValue("@TipoDocSuplente", s.TipoDocumentoSuplente);
                    cmd.Parameters.AddWithValue("@NroDocSuplente", s.NroDocumentoSuplente);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TipoDocSuplente", System.Data.SqlTypes.SqlInt32.Null);
                    cmd.Parameters.AddWithValue("@NroDocSuplente", "NULL");
                }



                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

        }

        internal static Sucursal obtenerSucursal(int id)
        {
            Sucursal resultado = new Sucursal();
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "selectSucursal";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;



                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    resultado.Id = (int)dr["Id"];
                    resultado.NombreSucursal = dr["Nombre"].ToString();

                    if (dr["TipoDocumentoSuperv"].ToString() != "")
                    {
                        resultado.TipoDocumentoSupervisor = (int)dr["TipoDocumentoSuperv"];
                        resultado.NroDocumentoSupervisor = dr["NroDocumentoSuperv"].ToString();
                    }
                    if (dr["TipoDocumentoSupl"].ToString() != "")
                    {
                        resultado.TipoDocumentoSuplente = (int)dr["TipoDocumentoSupl"]; ;
                        resultado.NroDocumentoSuplente = dr["NroDocumentoSupl"].ToString();
                    }
                    return resultado;
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

            return resultado;
        }

        public static int obtenerUltimoIdSucursale()
        {
            int resultado;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "selectMaxIdSucursal";


                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
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
        }

        internal static bool actualizarSucursal(Sucursal sucursal)
        {
            bool resultado = false;
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "updateSucursal";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", sucursal.Id);
                cmd.Parameters.AddWithValue("@Nombre", sucursal.NombreSucursal);
                if (sucursal.TipoDocumentoSupervisor != 0)
                {
                    cmd.Parameters.AddWithValue("@TipoDocumentoSupervisor", sucursal.TipoDocumentoSupervisor);
                    cmd.Parameters.AddWithValue("@NroDocumentoSupervisor", sucursal.NroDocumentoSupervisor);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TipoDocumentoSupervisor", System.Data.SqlTypes.SqlInt32.Null);
                    cmd.Parameters.AddWithValue("@NroDocumentoSupervisor", sucursal.NroDocumentoSupervisor);
                }
                if (sucursal.TipoDocumentoSuplente != 0)
                {
                    cmd.Parameters.AddWithValue("@TipoDocumentoSuplente", sucursal.TipoDocumentoSuplente);
                    cmd.Parameters.AddWithValue("@NroDocumentoSuplente", sucursal.NroDocumentoSuplente);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TipoDocumentoSuplente", System.Data.SqlTypes.SqlInt32.Null);
                    cmd.Parameters.AddWithValue("@NroDocumentoSuplente", sucursal.NroDocumentoSuplente);
                }



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

        internal static bool eliminarSucursal(int id)
        {
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(CadenaDB);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "deleteSucursal";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
    }

}

