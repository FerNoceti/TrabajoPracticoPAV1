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

        }
             
        private void rvPerros_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Perros.ObtenerListadoPerros();
            rvPerros.LocalReport.DataSources.Clear();
            rvPerros.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tabla));
            rvPerros.LocalReport.Refresh();
            
        }
       


        
    }

}
