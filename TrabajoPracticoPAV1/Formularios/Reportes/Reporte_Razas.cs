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

namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    public partial class Reporte_Razas : Form
    {
        public Reporte_Razas()
        {
            InitializeComponent();
        }

        private void Reporte_Razas_Load(object sender, EventArgs e)
        {
            this.reportViewerRazasHembras.RefreshReport();
            this.reportViewerRazasMachos.RefreshReport();
            this.reportViewerRazas.RefreshReport();
        }

        private void reportViewerRazas_Load(object sender, EventArgs e)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = AD_Razas.ObtenerListadoRazas();

            ReportDataSource ds1 = new ReportDataSource("DatosRazasCompleto", tabla1);

            reportViewerRazas.LocalReport.DataSources.Clear();
            reportViewerRazas.LocalReport.DataSources.Add(ds1);
            reportViewerRazas.LocalReport.Refresh();
            reportViewerRazas.Visible = false;
        }

        private void reportViewerRazasMachos_Load(object sender, EventArgs e)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = AD_Razas.ObtenerDatosRazasMacho();

            ReportDataSource ds2 = new ReportDataSource("DatosRazasM", tabla2);

            reportViewerRazasMachos.LocalReport.DataSources.Clear();
            reportViewerRazasMachos.LocalReport.DataSources.Add(ds2);
            reportViewerRazasMachos.LocalReport.Refresh();
            reportViewerRazasMachos.Visible = false;
        }

        private void reportViewerRazasHembras_Load(object sender, EventArgs e)
        {
            DataTable tabla3 = new DataTable();
            tabla3 = AD_Razas.ObtenerDatosRazasHembra();
            
            ReportDataSource ds3 = new ReportDataSource("DatosRazasH", tabla3);

            reportViewerRazasHembras.LocalReport.DataSources.Clear();
            reportViewerRazasHembras.LocalReport.DataSources.Add(ds3);
            reportViewerRazasHembras.LocalReport.Refresh();
            reportViewerRazasHembras.Visible = false;
        }

        private void btnFiltroReporte_Click(object sender, EventArgs e)
        {
            if (rdbRazasHembras.Checked)
            {
                reportViewerRazasHembras.Visible = true;        
                reportViewerRazasMachos.Visible = false;
                reportViewerRazas.Visible = false;
            }
            if (rdbRazasMachos.Checked)
            {
                reportViewerRazasHembras.Visible = false;
                reportViewerRazasMachos.Visible = true;
                reportViewerRazas.Visible = false;
            }
            if (rdbRazasCompleto.Checked)
            {
                reportViewerRazasHembras.Visible = false;
                reportViewerRazasMachos.Visible = false;
                reportViewerRazas.Visible = true;
            }
          
        }
    }
}
