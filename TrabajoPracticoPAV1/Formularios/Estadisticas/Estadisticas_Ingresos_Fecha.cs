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
    public partial class Estadisticas_Ingresos_Fecha : Form
    {
        public Estadisticas_Ingresos_Fecha()
        {
            InitializeComponent();
        }

        private void Estadisticas_Ingresos_Fecha_Load(object sender, EventArgs e)
        {

            this.rpingresosPorFecha.RefreshReport();
        }

        private void rpingresosPorFecha_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Sucursales.obtenerIngresosPorFecha();
            rpingresosPorFecha.LocalReport.DataSources.Clear();
            rpingresosPorFecha.LocalReport.DataSources.Add(new ReportDataSource("DSIngresosPorFecha", tabla));
            rpingresosPorFecha.LocalReport.Refresh();
        }
    }
}
