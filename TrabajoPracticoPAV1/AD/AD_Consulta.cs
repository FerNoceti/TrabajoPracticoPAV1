using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1.Entidades_ABM__Dueño__Consulta__Vacuna_;

namespace TrabajoPracticoPAV1.AD
{
    class AD_Consulta
    {
        public static int ObtenerUltimoIdConsulta(string id_Sucursal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(Id) FROM Consultas WHERE IdSucursal like @sucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sucursal", id_Sucursal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                int resultado = (int)cmd.ExecuteScalar();
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
        public static bool AgregarPersonaABD(Consulta per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Consultas (NroHistoriaClinica, IdSucursal, TipoDocumentoEmpl, NroDocumentoEmpl, FechaEntrada, FechaSalida) VALUES (@historiaClinica, @sucursal, @tipoDoc, @numDoc, @fechaE, @fechaS)";
                cmd.Parameters.Clear();              
                cmd.Parameters.AddWithValue("@sucursal", per.Id_Sucursal);
                cmd.Parameters.AddWithValue("@historiaClinica", per.NroHistoriaClinica);
                cmd.Parameters.AddWithValue("@tipoDoc", per.TipoDocumentoEmpleado);
                cmd.Parameters.AddWithValue("@numDoc", per.NumeroDeDocumento);
                cmd.Parameters.AddWithValue("@fechaE", per.FechaDeEntrada);
                cmd.Parameters.AddWithValue("@fechaS", per.FechaDeSalida);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            

            }
            catch (Exception)
            {
                MessageBox.Show("Asegurese de haber seleccionado el DNI de un empleado ya registrado y un numero de historia clinica ya registrado");
                
            }
            finally
            {
                cn.Close();
            }


            return resultado;
        }
        public static DataTable ObtenerTipoDocumento()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];

            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TipoDocumentos";

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerListadoConsultas()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];

            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Id, NroHistoriaClinica, IdSucursal, TipoDocumentoEmpl, NroDocumentoEmpl, FechaEntrada, FechaSalida FROM Consultas";

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static Consulta ObtenerConsulta(string idConsulta, string sucursal)
        {
            Consulta p = new Consulta();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Consultas where Id like @idConsulta AND IdSucursal like @idSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idConsulta", idConsulta);
                cmd.Parameters.AddWithValue("@idSucursal", sucursal);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    
                    p.Id_Consulta = dr["Id"].ToString();
                    p.NroHistoriaClinica = dr["NroHistoriaClinica"].ToString();
                    p.TipoDocumentoEmpleado = int.Parse(dr["TipoDocumentoEmpl"].ToString());
                    p.NumeroDeDocumento = dr["NroDocumentoEmpl"].ToString();
                    p.FechaDeEntrada = DateTime.Parse(dr["FechaEntrada"].ToString());
                    p.FechaDeSalida = DateTime.Parse(dr["FechaSalida"].ToString());
                    p.Id_Sucursal = int.Parse(dr["IdSucursal"].ToString());





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


            return p;
        }
        public static DataTable ObtenerSucursal()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];

            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Sucursales";

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool ActualizarConsulta(Consulta per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Consultas SET NroHistoriaClinica = @historiaClinica, IdSucursal = @sucursal, TipoDocumentoEmpl = @tipoDoc, NroDocumentoEmpl = @numDoc, FechaEntrada = @fechaE, FechaSalida = @fechaS WHERE Id like @consulta";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@consulta", per.Id_Consulta);
                cmd.Parameters.AddWithValue("@sucursal", per.Id_Sucursal);
                cmd.Parameters.AddWithValue("@historiaClinica", per.NroHistoriaClinica);
                cmd.Parameters.AddWithValue("@tipoDoc", per.TipoDocumentoEmpleado);
                cmd.Parameters.AddWithValue("@numDoc", per.NumeroDeDocumento);
                cmd.Parameters.AddWithValue("@fechaE", per.FechaDeEntrada);
                cmd.Parameters.AddWithValue("@fechaS", per.FechaDeSalida);

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
        public static bool EliminarConsulta(Consulta per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Consultas WHERE Id like @id AND IdSucursal like @sucursal";
                cmd.Parameters.Clear();
                if (int.Parse(per.Id_Consulta) != 0)
                {
                    cmd.Parameters.AddWithValue("@id", per.Id_Consulta);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@id", System.Data.SqlTypes.SqlInt32.Null);

                }
                //cmd.Parameters.AddWithValue("@id", per.Id_Consulta);
                //cmd.Parameters.AddWithValue("@sucursal", per.Id_Sucursal);
                if (per.Id_Sucursal != 0)
                {
                    cmd.Parameters.AddWithValue("@sucursal", per.Id_Sucursal);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@sucursal", System.Data.SqlTypes.SqlInt32.Null);

                }


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
