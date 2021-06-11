using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1.Formularios.Reportes;

namespace TrabajoPracticoPAV1
{
    public partial class SubMenuReportes : Form
    {
        public SubMenuReportes()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Empleados empleados = new Reporte_Empleados();
            empleados.ShowDialog();
        }

        private void perrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Perros perros = new Reporte_Perros();
            perros.ShowDialog();
        }

        private void razasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Razas razas = new Reporte_Razas();
            razas.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Consultas consultas = new Reporte_Consultas();
            consultas.ShowDialog();
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Laboratorios labs = new Reporte_Laboratorios();
            labs.ShowDialog();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteMedicamentos medicamentos = new ReporteMedicamentos();
            medicamentos.ShowDialog();
        }
    }
}
