using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1.AD;

namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    public partial class Estadisticas_Perros_Sucursal : Form
    {
        public Estadisticas_Perros_Sucursal()
        {
            InitializeComponent();
        }

        private void Estadisticas_Perros_Sucursal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Sucursales.Perros_x_sucursal();
            cargarReporteMedicamentos(tabla);
        }

        private void cargarReporteMedicamentos(DataTable tabla)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticasPerros_Sucursal", tabla));
            reportViewer1.LocalReport.Refresh();

            reportViewer1.RefreshReport();
        }


        private void btnFiltrosSucursal_Click(object sender, EventArgs e)
        {
            string letra = txtFiltroSucursal.Text;
            int nroFiltro = 0;
            if (rdbComienzee.Checked)
            {
                nroFiltro = 1;
            }
            if (rdbTerminee.Checked)
            {
                nroFiltro = 2;
            }
            if (rdbTodoo.Checked)
            {
                nroFiltro = 3;
            }

            DataTable tabla = AD_Sucursales.ObtenerDatos_Perros_x_Sucursal_PorFiltros(nroFiltro, letra);
            cargarReporteMedicamentos(tabla);
        }
    }
}
