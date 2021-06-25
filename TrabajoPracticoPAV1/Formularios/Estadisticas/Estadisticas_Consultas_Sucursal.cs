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
    public partial class Estadisticas_Consultas_Sucursal : Form
    {
        public Estadisticas_Consultas_Sucursal()
        {
            InitializeComponent();
        }

        private void Estadisticas_Consultas_Load(object sender, EventArgs e)
        {

            this.reportConsultasPorSucursal.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


            DataTable tabla = new DataTable();
            tabla = AD_Consulta.ObtenerEstadisticasSucursales();
            reportConsultasPorSucursal.LocalReport.DataSources.Clear();
            reportConsultasPorSucursal.LocalReport.DataSources.Add(new ReportDataSource("DSConsultaSucursal", tabla));
            reportConsultasPorSucursal.LocalReport.Refresh();
        }
    }
}
