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
    public partial class Estadisticas_Empleados_Edad : Form
    {
        public Estadisticas_Empleados_Edad()
        {
            InitializeComponent();
        }

        private void Estadisticas_Empleados_Matricula_Load(object sender, EventArgs e)
        {

            this.rpEmpleadoEdad.RefreshReport();
        }

        //private void rpEmpleadoMatricula_Load(object sender, EventArgs e)
        //{
        //    DataTable tabla = AD_Empleados.obtenerCantEmpleadoPorSucursal();
        //    rpEmpleadoEdad.LocalReport.DataSources.Clear();
        //    rpEmpleadoEdad.LocalReport.DataSources.Add(new ReportDataSource("DSEmpleadosSucursal", tabla));
        //    rpEmpleadoEdad.LocalReport.Refresh();
        //    rpEmpleadoEdad.RefreshReport();
        //}

        private void rpEmpleadoEdad_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Empleados.obtenerCantEmpleadoPorEdad();
            rpEmpleadoEdad.LocalReport.DataSources.Clear();
            rpEmpleadoEdad.LocalReport.DataSources.Add(new ReportDataSource("DSEmpleadosEdad", tabla));
            rpEmpleadoEdad.LocalReport.Refresh();
            rpEmpleadoEdad.RefreshReport();
        }
    }
}
