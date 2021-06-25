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
    public partial class Estadisticas_Perros_Razas : Form
    {
        public Estadisticas_Perros_Razas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Perros_Razas_Load(object sender, EventArgs e)
        {

            this.reportViewer_Razas_Machos.RefreshReport();
            this.reportViewerRazas_Hembras.RefreshReport();
            this.reportViewerRazas_ambos.RefreshReport();
        }

        private void reportViewerRazas_ambos_Load(object sender, EventArgs e)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = AD_Razas.Perros_x_razas();

            ReportDataSource ds1 = new ReportDataSource("DatosEstadisticas_Perros_X_Raza", tabla1);

            reportViewerRazas_ambos.LocalReport.DataSources.Clear();
            reportViewerRazas_ambos.LocalReport.DataSources.Add(ds1);
            reportViewerRazas_ambos.LocalReport.Refresh();
            reportViewerRazas_ambos.Visible = false;
        }

        private void btnFiltroEstadistica_Click(object sender, EventArgs e)
        {
            if (rdbHembra.Checked)
            {
                reportViewerRazas_Hembras.Visible = true;
                reportViewer_Razas_Machos.Visible = false;
                reportViewerRazas_ambos.Visible = false;
            }
            if (rdbMachos.Checked)
            {
                reportViewerRazas_Hembras.Visible = false;
                reportViewer_Razas_Machos.Visible = true;
                reportViewerRazas_ambos.Visible = false;
            }
            if (rdbCompleto.Checked)
            {
                reportViewerRazas_Hembras.Visible = false;
                reportViewer_Razas_Machos.Visible = false;
                reportViewerRazas_ambos.Visible = true;
            }
        }

        private void reportViewerRazas_Hembras_Load_1(object sender, EventArgs e)
        {
            DataTable tabla3 = new DataTable();
            tabla3 = AD_Razas.Perros_x_razas_hembras();

            ReportDataSource ds3 = new ReportDataSource("DatosEstadisticas_Perros_X_Raza", tabla3);

            reportViewerRazas_Hembras.LocalReport.DataSources.Clear();
            reportViewerRazas_Hembras.LocalReport.DataSources.Add(ds3);
            reportViewerRazas_Hembras.LocalReport.Refresh();
            reportViewerRazas_Hembras.Visible = false;
        }

        private void reportViewer_Razas_Machos_Load_1(object sender, EventArgs e)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = AD_Razas.Perros_x_razas_machos();

            ReportDataSource ds2 = new ReportDataSource("DatosEstadisticas_Perros_X_Raza", tabla2);

            reportViewer_Razas_Machos.LocalReport.DataSources.Clear();
            reportViewer_Razas_Machos.LocalReport.DataSources.Add(ds2);
            reportViewer_Razas_Machos.LocalReport.Refresh();
            reportViewer_Razas_Machos.Visible = false;
        }
    }
}
