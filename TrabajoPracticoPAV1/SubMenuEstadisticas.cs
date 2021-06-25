using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1.Formularios.Estadisticas;

namespace TrabajoPracticoPAV1
{
    public partial class SubMenuEstadisticas : Form
    {
        public SubMenuEstadisticas()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void perrosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ingresosObtenidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void porEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Estadisticas_Empleados_Edad()).ShowDialog();
        }

        private void porSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new btnGenerar()).ShowDialog();
        }

        private void ingresosPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas_Ingresos_Sucursal ingresos = new Estadisticas_Ingresos_Sucursal();
            ingresos.ShowDialog();
        }

        private void ingresosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas_Ingresos_Fecha ingresos = new Estadisticas_Ingresos_Fecha();
            ingresos.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estadisticas_Perros_Sucursal perros = new Estadisticas_Perros_Sucursal();
            perros.ShowDialog();
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas_Perros_Razas perros = new Estadisticas_Perros_Razas();
            perros.ShowDialog();
        }

        private void porSucursalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estadisticas_Consultas_Sucursal consultas= new Estadisticas_Consultas_Sucursal();
            consultas.ShowDialog();
        }

        private void porFechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estadisticas_Consultas_Fecha consultas = new Estadisticas_Consultas_Fecha();
            consultas.ShowDialog();
        }
    }
}
