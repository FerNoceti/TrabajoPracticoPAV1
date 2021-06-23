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
        }

        private void rpingresosSucursal_Load(object sender, EventArgs e)
        {
            DataTable tablaIngresosSucursal = AD_Sucursales.obtenerIngresosPorSucursal();
            DataTable tablaSucursales = AD_Sucursales.obtenerSucursalesReducido();

            rpIngresosSucursal.LocalReport.DataSources.Clear();
            rpIngresosSucursal.LocalReport.DataSources.Add(new ReportDataSource("DSIngresosSucursal", tablaIngresosSucursal));
            rpIngresosSucursal.LocalReport.DataSources.Add(new ReportDataSource("DSSucursales", tablaSucursales));

            rpIngresosSucursal.LocalReport.Refresh();
        }
    }
}
