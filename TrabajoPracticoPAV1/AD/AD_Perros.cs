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
    }
}
