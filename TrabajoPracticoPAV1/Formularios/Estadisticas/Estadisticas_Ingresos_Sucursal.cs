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


namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    public partial class Estadisticas_Ingresos_Sucursal : Form
    {
        public Estadisticas_Ingresos_Sucursal()
        {
            InitializeComponent();
        }

        private void Estadisticas_Ingresos_Sucursal_Load(object sender, EventArgs e)
        {

            this.rpIngresosSucursal.RefreshReport();
            desactivarCampos();
        }

        private void desactivarCampos()
        {
            txtMonto.Enabled = false;
        }

        private void activarCampos()
        {
            txtMonto.Enabled = true;
        }

        private void rpingresosSucursal_Load(object sender, EventArgs e)
        {
            DataTable tablaIngresosSucursal = AD_Sucursales.obtenerIngresosPorSucursal();
            DataTable tablaSucursales = AD_Sucursales.obtenerSucursalesReducido();

            cargarReporte(tablaIngresosSucursal, tablaSucursales);
        }

        private void cbMayorA_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMayorA.Checked)
            {
                activarCampos();
            }
            else
            {
                desactivarCampos();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable tablaIngresosSucursal = AD_Sucursales.obtenerIngresosPorSucursal();
            DataTable tablaSucursales = AD_Sucursales.obtenerSucursalesReducido();

            if (cbMayorA.Checked)
            {
                if(txtMonto.Text.Equals(""))
                {
                    MessageBox.Show("Error: Datos mal ingresados");
                }
                else
                {
                    tablaIngresosSucursal = AD_Sucursales.obtenerIngresosPorSucursalMayorA(int.Parse(txtMonto.Text.Trim()));
                }
            }
            cargarReporte(tablaIngresosSucursal, tablaSucursales);
        }

        private void cargarReporte(DataTable tablaIngresosSucursal, DataTable tablaSucursales)
        {
            rpIngresosSucursal.LocalReport.DataSources.Clear();
            rpIngresosSucursal.LocalReport.DataSources.Add(new ReportDataSource("DSIngresosSucursal", tablaIngresosSucursal));
            rpIngresosSucursal.LocalReport.DataSources.Add(new ReportDataSource("DSSucursales", tablaSucursales));

            rpIngresosSucursal.LocalReport.Refresh();
            rpIngresosSucursal.RefreshReport();
        }
    }
}
