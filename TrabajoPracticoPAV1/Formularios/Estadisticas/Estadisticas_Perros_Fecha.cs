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

namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    public partial class Estadisticas_Perros_Fecha : Form
    {
        public Estadisticas_Perros_Fecha()
        {
            InitializeComponent();
        }

        private void Estadisticas_Perros_Fecha_Load(object sender, EventArgs e)
        {

            this.rpPerrosXFecha.RefreshReport();
        }

        private void rpPerrosXFecha_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Perros.obtenerPerrosXFecha();

            ReportDataSource ds = new ReportDataSource("DatosEstadisticasPerrosFecha", tabla);

            rpPerrosXFecha.LocalReport.DataSources.Clear();
            rpPerrosXFecha.LocalReport.DataSources.Add(ds);
            rpPerrosXFecha.LocalReport.Refresh();
        }
    }
}
