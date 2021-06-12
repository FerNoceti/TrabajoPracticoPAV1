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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
            DataTable tabla = new DataTable();
            tabla = ReporteFiltrado();
            
            ReportDataSource ds = new ReportDataSource("DatosLaboratorios", tabla);
            reportViewerLabs.RefreshReport();
            
            reportViewerLabs.LocalReport.DataSources.Clear();
            reportViewerLabs.LocalReport.DataSources.Add(ds);
            reportViewerLabs.LocalReport.Refresh();
            reportViewerLabs.RefreshReport();

        }

        private DataTable ReporteFiltrado()
        {
            DataTable tabla = new DataTable();
            if (rdbNumId.Checked == true)
            {
                tabla = AD_Laboratorios.ObtenerListadoLaboratoriosId(txtBusqueda.Text.Trim());
                return tabla;

            }
            else if (rdbRazonSocial.Checked == true)
            {
                tabla = AD_Laboratorios.ObtenerListadoLaboratoriosRS(txtBusqueda.Text.Trim());
                return tabla;

            }
            else if (rdbIdBarrio.Checked == true)
            {
                tabla = AD_Laboratorios.ObtenerListadoLaboratoriosIdBarrio(txtBusqueda.Text.Trim());
                return tabla;

            }
            else
            {
                

                tabla = AD_Laboratorios.ObtenerListadoLaboratorios();
                return tabla;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = false;
            txtBusqueda.Clear();
        }

        private void rdbNumId_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;

        }

        private void rdbRazonSocial_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

        private void rdbIdBarrio_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }
    }
}
