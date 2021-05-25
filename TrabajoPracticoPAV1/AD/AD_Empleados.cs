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
    public class AD_Empleados
    {
        public static bool existeEmpleado(int tipoDoc, string nroDoc)
        {
            DataTable tabla = new DataTable();
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "selectEmpleado";
            SqlConnection cn = new SqlConnection(cadenaDB);
            try
            {
            
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;
                cmd.Connection = cn;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDoc", tipoDoc);
                cmd.Parameters.AddWithValue("@NroDoc", nroDoc);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if(tabla.Rows.Count == 1)
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

        public static Empleado obtenerEmpleado(int tipoDoc, string nroDoc)
        {


            Empleado resultado = new Empleado();
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "selectEmpleado";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDoc", tipoDoc);
                cmd.Parameters.AddWithValue("@NroDoc", nroDoc);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    resultado.TipoDocumento = (int)dr["TipoDocumento"];
                    resultado.NroDocumento = dr["NroDocumento"].ToString();
                    resultado.Nombre = dr["Nombre"].ToString();
                    resultado.Apellido = dr["Apellido"].ToString();
                    resultado.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                    resultado.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                    if (dr["IdSucursal"].ToString() != "")
                    {
                        resultado.Sucursal = (int)dr["IdSucursal"];
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

        public static DataTable obtenerDatosEmpleados()
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getEmpleadosYSucursales";
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

        public static bool agregarEmpleadoABD(Empleado e)
        {
            bool resultado = false;
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "insertEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDocumento", e.TipoDocumento);
                cmd.Parameters.AddWithValue("@NroDocumento", e.NroDocumento);
                cmd.Parameters.AddWithValue("@Nombre", e.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", e.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", e.FechaNacimiento);
                cmd.Parameters.AddWithValue("@FechaIngreso", e.FechaIngreso);
                cmd.Parameters.AddWithValue("@IdSucursal", e.Sucursal);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

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

        public static DataTable obtenerDatosEmpleadosNoSupervisores()
        {
            DataTable tabla = new DataTable();
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            string storedProcedure = "getEmpleadosNoSupervisores";
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

        public static bool actualizarEmpleado(Empleado e, int tipoDocViejo, string nroDocViejo)
        {

            bool resultado = false;
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "updateEmpleado";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDocViejo", tipoDocViejo);
                cmd.Parameters.AddWithValue("@NroDocViejo", nroDocViejo);
                cmd.Parameters.AddWithValue("@TipoDocumento", e.TipoDocumento);
                cmd.Parameters.AddWithValue("@NroDocumento", e.NroDocumento);
                cmd.Parameters.AddWithValue("@Nombre", e.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", e.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", e.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sucursal", e.Sucursal);


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

        public static bool eliminarEmpleado(Empleado empl)
        {
            string CadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(CadenaDB);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "deleteEmpleado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDoc", empl.TipoDocumento);
                cmd.Parameters.AddWithValue("@NroDoc", empl.NroDocumento);

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

        
    }
}
