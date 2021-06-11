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
    public class AD_Perros
    {
        public static DataTable ObtenerListadoPerrosReducido()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Nombre,Peso,Altura FROM Perros";

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
        public static bool AgregarPerroABD(Perro per)
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Perros(NroHistoriaClinica, IdSucursal, Nombre, FechaNacimiento, IdRaza, Peso, Altura, IdDueño, IdSexo) VALUES(@nroHistoria,@idSucursal,@nombre,@fechaNac,@idRaza,@Peso,@altura,@idDueño,@idSexo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroHistoria", per.HistoriaClinica);
                cmd.Parameters.AddWithValue("@idSucursal", per.Sucursal);
                cmd.Parameters.AddWithValue("@nombre", per.NombrePerro);
                cmd.Parameters.AddWithValue("@fechaNac", per.FechaNacimientoPerro);
                cmd.Parameters.AddWithValue("@idRaza", per.RazaPerro);
                cmd.Parameters.AddWithValue("@peso", per.PesoPerro);
                cmd.Parameters.AddWithValue("@altura", per.AlturaPerro);
                cmd.Parameters.AddWithValue("@idDueño", per.DueñoPerro);
                cmd.Parameters.AddWithValue("@idSexo", per.SexoPerro);
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

        public static Perro obtenerPerro(int idHistoriaClinica)
        {

        //private string Nombre;
        //private int Peso;
        //private int Altura;
        //private DateTime FechaNacimiento;
        //private int IdSexo;
        //private int IdRaza;
        //private int IdDueño;
        //private int IdSucursal;
        //private int HistClinica;

        Perro resultado = new Perro();
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "selectPerro";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idHistoriaClinica", idHistoriaClinica);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;



                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    resultado.NombrePerro = dr["Nombre"].ToString();
                    resultado.HistoriaClinica = int.Parse(dr["NroHistoriaClinica"].ToString());
                    resultado.DueñoPerro = int.Parse(dr["IdDueño"].ToString());

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

        internal static DataTable obtenerPerrosPorSucursal(int idSucursal)
        {
            DataTable resultado;
            string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string storedProcedure = "getPerrosPorSucursal";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idSucursal", idSucursal);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;



                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                resultado = tabla;
                return resultado;
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
        public static DataTable ObtenerListadoPerros()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Perros";

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
        //public static DataTable ObtenerListadoPerrosPorFiltros(int IdRaz, int IdDueño)
        //{
        //    DataTable tabla = new DataTable();
        //    string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
        //    SqlConnection cn = new SqlConnection(cadenaDB);
        //    string consulta = "SELECT p.* FROM Perros p";
        //    consulta += "WHERE 1 = 1";
        //    if (IdRaz != -1)
        //    {
        //        consulta += $" AND p.IdRaza={ IdRaz }";
        //    }
        //    if (IdDueño != -1)
        //    {
        //        consulta += $" AND p.IdDueño={ IdDueño }";
        //    }
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

                
        //        cmd.Parameters.Clear();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;

                

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tabla);

        //        return tabla;


        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }



        //}
    }

}
