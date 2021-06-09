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
    public partial class Reporte_Laboratorios : Form
    {
        public Reporte_Laboratorios()
        {
            InitializeComponent();
        }

        private void Reporte_Laboratorios_Load(object sender, EventArgs e)
        {

            this.reportViewerLabs.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Laboratorios.ObtenerListadoLaboratorios();

            ReportDataSource ds = new ReportDataSource("DatosLaboratorios", tabla);

            reportViewerLabs.LocalReport.DataSources.Clear();
            reportViewerLabs.LocalReport.DataSources.Add(ds);
            reportViewerLabs.LocalReport.Refresh();
        }
    }
}
