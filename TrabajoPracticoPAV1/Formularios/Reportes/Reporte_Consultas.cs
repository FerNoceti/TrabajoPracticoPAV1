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
    public partial class Reporte_Consultas : Form
    {
        public Reporte_Consultas()
        {
            InitializeComponent();
        }

        private void Reporte_Consultas_Load(object sender, EventArgs e)
        {

            this.reportViewerConsultas.RefreshReport();            
            cargarComboSucursales();
            limpiarCombo();
            DataTable tabla = new DataTable();
            cargarReporteConsulta(tabla);
        }

        private void cargarReporteConsulta(DataTable tabla)
        {
            
            tabla = AD_Consulta.ObtenerListadoConsultas();

            ReportDataSource ds = new ReportDataSource("DatosConsultas", tabla);

            reportViewerConsultas.LocalReport.DataSources.Clear();
            reportViewerConsultas.LocalReport.DataSources.Add(ds);
            reportViewerConsultas.LocalReport.Refresh();
            reportViewerConsultas.RefreshReport();
        }

        private void limpiarCombo()
        {           
            cmbSucursal.SelectedIndex = -1;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {

            limpiarCombo();
        }
        private void cargarComboSucursales()
        {
            try
            {
                cmbSucursal.DataSource = AD_Consulta.ObtenerSucursal();
                cmbSucursal.DisplayMember = "Nombre";
                cmbSucursal.ValueMember = "Id";
                cmbSucursal.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            int indice = -1;
            if (cmbSucursal.SelectedValue != null)
            {
                indice = int.Parse(cmbSucursal.SelectedValue.ToString());
            }
            DataTable tabla = AD_Consulta.ObtenerConsultasPorSucursal(indice);
            ReportDataSource ds = new ReportDataSource("DatosConsultas", tabla);

            reportViewerConsultas.LocalReport.DataSources.Clear();
            reportViewerConsultas.LocalReport.DataSources.Add(ds);
            reportViewerConsultas.LocalReport.Refresh();
            reportViewerConsultas.RefreshReport();
        }
    }
}
