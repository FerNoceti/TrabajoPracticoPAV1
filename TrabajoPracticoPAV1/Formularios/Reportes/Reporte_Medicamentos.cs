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
    public partial class ReporteMedicamentos : Form
    {
        public ReporteMedicamentos()
        {
            InitializeComponent();
        }

        private void ReporteMedicamentos_Load(object sender, EventArgs e)
        {
            this.reportViewerMedicamentos.RefreshReport();
        }

        private void reportViewerMedicamentos_Load(object sender, EventArgs e)
        {
            /*DataTable tabla1 = new DataTable();
            tabla1 = AD_Medicamentos.ObtenerListadoMedicamentos();

            ReportDataSource ds1 = new ReportDataSource("DatosMedicamentos", tabla1);

            reportViewerMedicamentos.LocalReport.DataSources.Clear();
            reportViewerMedicamentos.LocalReport.DataSources.Add(ds1);
            reportViewerMedicamentos.LocalReport.Refresh();*/

            DataTable tabla = AD_Medicamentos.obtenerDatosMedicamentos();
            cargarReporteMedicamentos(tabla);
        }
        private void cargarReporteMedicamentos(DataTable tabla)
        {
            reportViewerMedicamentos.LocalReport.DataSources.Clear();
            reportViewerMedicamentos.LocalReport.DataSources.Add(new ReportDataSource("DatosMedicamentos", tabla));
            reportViewerMedicamentos.LocalReport.Refresh();

            reportViewerMedicamentos.RefreshReport();
        }

        private void btnFiltrosMedicamentos_Click(object sender, EventArgs e)
        {
            string letra = txtFiltroMedicamento.Text;
            int nroFiltro = 0;
            if (rdbComienze.Checked)
            {
                nroFiltro = 1;
            }
            if (rdbTermine.Checked)
            {
                nroFiltro = 2;
            }
            if (rdbTodos.Checked)
            {
                nroFiltro = 3;
            }
            
            DataTable tabla = AD_Medicamentos.ObtenerDatosMedicamentosPorFiltros(nroFiltro, letra);
            cargarReporteMedicamentos(tabla);

        }

        
    }
}
