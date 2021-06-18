using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using TrabajoPracticoPAV1.AD;

namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    public partial class Estadisticas_Empleados_Sucursal : Form
    {
        public Estadisticas_Empleados_Sucursal()
        {
            InitializeComponent();
        }

        private void Estadisticas_Empleados_Sucursal_Load(object sender, EventArgs e)
        {

            this.rpEmpleadoSucursal.RefreshReport();
        }

        private void rpEmpleadoSucursal_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Empleados.obtenerCantEmpleadoPorSucursal();
            rpEmpleadoSucursal.LocalReport.DataSources.Clear();
            rpEmpleadoSucursal.LocalReport.DataSources.Add(new ReportDataSource("DSEmpleadosSucursal", tabla));
            rpEmpleadoSucursal.LocalReport.Refresh();
            //rpEmpleadoSucursal.RefreshReport();
        }
    }
}
