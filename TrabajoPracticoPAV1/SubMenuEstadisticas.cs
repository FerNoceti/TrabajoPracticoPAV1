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

        private void perrosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas_Perros perros = new Estadisticas_Perros();
            perros.ShowDialog();
        }

        private void ingresosObtenidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas_Ingresos ingresos = new Estadisticas_Ingresos();
            ingresos.ShowDialog();
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
            (new Estadisticas_Empleados_Sucursal()).ShowDialog();
        }

        private void porSucursalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estadisticas_Consultas_Sucursal consultas = new Estadisticas_Consultas_Sucursal();
            consultas.ShowDialog();
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas_Consultas_Fecha consultas = new Estadisticas_Consultas_Fecha();
            consultas.ShowDialog();
        }
    }
}
