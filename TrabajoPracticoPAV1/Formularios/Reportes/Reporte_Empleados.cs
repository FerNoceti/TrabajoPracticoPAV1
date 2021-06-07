using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoPracticoPAV1.AD;

namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    public partial class Reporte_Empleados : Form
    {
        public Reporte_Empleados()
        {
            InitializeComponent();
        }

        private void Reporte_Empleados_Load(object sender, EventArgs e)
        {

            this.rvEmpleados.RefreshReport();
            limpiarCampos();
            cargarComboSucursales();
            resetearComboSucursales();

        }

        private void limpiarCampos()
        {

            rbMatriculado.Checked = false;

            cmbSucursal.SelectedIndex = -1;
        }

        private void resetearComboSucursales()
        {
            cmbSucursal.SelectedIndex = -1;
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

        private void rvEmpleados_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Empleados.obtenerEmpleados();
            cargarReporteEmpleados(tabla);
        }

        private void cargarReporteEmpleados(DataTable tabla)
        {
            rvEmpleados.LocalReport.DataSources.Clear();
            rvEmpleados.LocalReport.DataSources.Add(new ReportDataSource("DSEmpleados", tabla));
            rvEmpleados.LocalReport.Refresh();
            //rvEmpleados.Refresh();
            rvEmpleados.RefreshReport();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            int indice = -1;
            if(cmbSucursal.SelectedValue != null)
            {
                indice = int.Parse(cmbSucursal.SelectedValue.ToString());
            }
            DataTable tabla = AD_Empleados.ObtenerDatosEmpleadosPorFiltros(rbMatriculado.Checked, indice);
            cargarReporteEmpleados(tabla);
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
