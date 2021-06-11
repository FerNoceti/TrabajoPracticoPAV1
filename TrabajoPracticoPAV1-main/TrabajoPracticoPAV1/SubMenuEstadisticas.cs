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
            Estadisticas_Consultas consultas = new Estadisticas_Consultas();
            consultas.ShowDialog();
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
    }
}
