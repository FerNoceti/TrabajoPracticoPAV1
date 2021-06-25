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
    public class AD_Razas
    {
        public static DataTable ObtenerListadoRazas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Razas";

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
        public static DataTable ObtenerRazaPorNombre(string nombre_raza)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * from Razas where Nombre like '" + nombre_raza + "'";

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
        public static bool AgregarRazaBD(Razas raz)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Razas (PesoMinimoHembra,PesoMinimoMacho,PesoMaximoHembra,PesoMaximoMacho,AlturaMediaHembra,AlturaMediaMacho,NotaCuidados,Nombre) VALUES(@minHembra,@minMacho,@maxHembra,@maxMacho,@altHembra,@altMacho,@nota,@nombre)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@minHembra", Math.Round(raz.PesoMaximoHembras));
                cmd.Parameters.AddWithValue("@minMacho", Math.Round(raz.PesoMinimoMachos));
                cmd.Parameters.AddWithValue("@maxHembra", Math.Round(raz.PesoMaximoHembras));
                cmd.Parameters.AddWithValue("@maxMacho", Math.Round(raz.PesoMaximoMachos));
                cmd.Parameters.AddWithValue("@altHembra", raz.AltumaMediaHembras);
                cmd.Parameters.AddWithValue("@altMacho", raz.AlturaMediaMachos);
                cmd.Parameters.AddWithValue("@nota", raz.NotaCuidadosRazas);
                cmd.Parameters.AddWithValue("@nombre", raz.NombreRaza);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar raza");
            }
            finally
            {
                cn.Close();
            }


            return resultado;
        }

        public static bool ActualizarRaza(Razas raz)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Razas SET PesoMinimoHembra = @minHem, PesoMinimoMacho = @minMac, PesoMaximoHembra = @maxHem, PesoMaximoMacho = @maxMac, AlturaMediaHembra = @altHem, AlturaMediaMacho = @altMac, NotaCuidados = @nota, Nombre = @nombre WHERE Id like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@minHem",Math.Round(raz.PesoMinimoHembras,2));
                cmd.Parameters.AddWithValue("@minMac", Math.Round(raz.PesoMinimoMachos));
                cmd.Parameters.AddWithValue("@maxHem", Math.Round(raz.PesoMaximoHembras));
                cmd.Parameters.AddWithValue("@maxMac", Math.Round(raz.PesoMaximoMachos));
                cmd.Parameters.AddWithValue("@altHem", raz.AltumaMediaHembras);
                cmd.Parameters.AddWithValue("@altMac", raz.AlturaMediaMachos);
                cmd.Parameters.AddWithValue("@nota", raz.NotaCuidadosRazas);
                cmd.Parameters.AddWithValue("@nombre", raz.NombreRaza);
                cmd.Parameters.AddWithValue("@id", raz.Id_Razas);


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
        public static Razas ObtenerRaza(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Razas r = new Razas();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Razas where Id like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader(); //ejecuta la sentencia sql

                if (dr != null && dr.Read()) //si el datareader no es nulo, leeme el primer valor y si es true entra
                {
                    r.Id_Razas = (int.Parse(dr["Id"].ToString()));
                    r.NombreRaza = dr["Nombre"].ToString();
                    r.PesoMinimoHembras = float.Parse(dr["PesoMinimoHembra"].ToString());
                    r.PesoMinimoMachos = float.Parse(dr["PesoMinimoMacho"].ToString());
                    r.PesoMaximoHembras = float.Parse(dr["PesoMaximoHembra"].ToString());
                    r.PesoMaximoMachos = float.Parse(dr["PesoMaximoMacho"].ToString());
                    r.AltumaMediaHembras = int.Parse(dr["AlturaMediaHembra"].ToString());
                    r.AlturaMediaMachos = int.Parse(dr["AlturaMediaMacho"].ToString());
                    r.NotaCuidadosRazas = dr["NotaCuidados"].ToString();

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
            return r;

        }

        public static DataTable ObtenerRazaPorId(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * from Razas where Id like '" + id + "'";

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
        public static bool EliminarRaza(Razas r)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Razas WHERE Id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", r.Id_Razas);

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

        public static void buscarRaza(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Razas WHERE Nombre like %" + nombre +"%";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                
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

        public static DataTable ObtenerDatosRazasMacho()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Id, Nombre, PesoMinimoMacho, PesoMaximoMacho, AlturaMediaMacho FROM Razas";

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

        public static DataTable ObtenerDatosRazasHembra()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Id, Nombre, PesoMinimoHembra, PesoMaximoHembra, AlturaMediaHembra FROM Razas";

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

        public static DataTable Perros_x_razas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT R.Nombre as 'Raza' , Count(P.IdRaza) as 'Cantidad_Perros' FROM Perros P JOIN Razas R On(P.IdRaza = R.Id) GROUP BY R.Nombre";

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
        public static DataTable Perros_x_razas_hembras()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT R.Nombre as 'Raza' , Count(P.IdRaza) as 'Cantidad_Perros' FROM Perros P JOIN Razas R On(P.IdRaza = R.Id) where P.IdSexo = 2 GROUP BY R.Nombre";

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
        public static DataTable Perros_x_razas_machos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT R.Nombre as 'Raza' , Count(P.IdRaza) as 'Cantidad_Perros' FROM Perros P JOIN Razas R On(P.IdRaza = R.Id) where P.IdSexo = 1 GROUP BY R.Nombre";

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

    }
}
