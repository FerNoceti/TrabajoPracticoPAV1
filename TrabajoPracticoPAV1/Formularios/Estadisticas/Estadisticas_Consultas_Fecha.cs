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
    public partial class Estadisticas_Consultas_Fecha : Form
    {
        public Estadisticas_Consultas_Fecha()
        {
            InitializeComponent();
        }

        private void Estadisticas_Consultas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Consulta.ObtenerEstadisticasFecha();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Consultas", tabla));
            reportViewer1.LocalReport.Refresh();
        }
    }
}
