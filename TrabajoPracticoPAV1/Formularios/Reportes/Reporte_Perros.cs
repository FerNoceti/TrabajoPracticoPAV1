using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1.AD;

namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    public partial class Reporte_Perros : Form
    {
        public Reporte_Perros()
        {
            InitializeComponent();
        }

        private void Reporte_Perros_Load(object sender, EventArgs e)
        {
          


        }

        private void Reporte_Perros_Load_1(object sender, EventArgs e)
        {

            this.rvPerros.RefreshReport();
            CargarComboRaza();
            CargarComboDueños();

        }
        
            
       

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int indice = -1;
            int indic = -1;
    
            if (cmbRazas.SelectedValue!=null)
            {
                indice = int.Parse(cmbRazas.SelectedValue.ToString());
               
            }
            if (cmbDueño.SelectedValue != null)
            {
                indice = int.Parse(cmbDueño.SelectedValue.ToString());

            }
            DataTable tabla = AD_Perros.ObtenerListadoPerrosPorFiltros(indice,indic);
            CargarReportePerros(tabla);




        }
        private void CargarComboRaza()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);

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

                cmbRazas.DataSource = tabla;
                cmbRazas.DisplayMember = "Nombre";
                cmbRazas.ValueMember = "Id";
                cmbRazas.SelectedIndex = -1;
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
       private void CargarReportePerros(DataTable tabla)
        {
            rvPerros.LocalReport.DataSources.Clear();
            rvPerros.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tabla));
            rvPerros.LocalReport.Refresh();

        }

        private void rvPerros_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Perros.ObtenerListadoPerros();
            rvPerros.LocalReport.DataSources.Clear();
            rvPerros.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tabla));
            rvPerros.LocalReport.Refresh();
        }
        private void CargarComboDueños()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Dueños";

                cmd.Parameters.Clear();



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbDueño.DataSource = tabla;
                cmbDueño.DisplayMember = "Nombre";
                cmbDueño.ValueMember = "Id";
                cmbDueño.SelectedIndex = -1;
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


        //private void rvPerros_Load(object sender, EventArgs e)
        //{

        //    //DataTable tabla = new DataTable();
        //    //tabla = AD_Perros.ObtenerListadoPerros();

        //    //ReportDataSource ds = new ReportDataSource("DataSet1", tabla);

        //    //rvPerros.LocalReport.DataSources.Clear();
        //    //rvPerros.LocalReport.DataSources.Add(ds);
        //    //rvPerros.LocalReport.Refresh();
        //}
    }

}
