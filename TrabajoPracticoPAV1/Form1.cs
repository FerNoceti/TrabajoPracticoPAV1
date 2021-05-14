using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1;
using TrabajoPracticoPAV1.Formularios;
using TrabajoPracticoPAV1.Formularios.ABM;
using TrabajoPracticoPAV1.AD;
using TrabajoPracticoPAV1.Formularios.ABM;

namespace TrabajoPracticoPAV1
{
    public partial class Principal : Form
    {
        Form formPadre;

        public Principal(Form formPadre)
        {
            this.formPadre = formPadre;
            
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            formPadre.Hide();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Close();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Empleados formEmpleados = new ABM_Empleados();
            formEmpleados.ShowDialog();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Sucursales formSucursales = new ABM_Sucursales();
            formSucursales.ShowDialog();
        }
        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Laboratorios ventana = new ABM_Laboratorios();
            ventana.ShowDialog();
        }

        private void sintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Sintomas ventana = new ABM_Sintomas();
            ventana.ShowDialog();
        }
        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Barrios formBarrios = new ABM_Barrios(this);
            formBarrios.ShowDialog();
        }

        private void perrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Perros ventana_perros = new ABM_Perros();
            ventana_perros.ShowDialog();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Usuarios ventana_Usu = new ABM_Usuarios();
            ventana_Usu.ShowDialog();
        }
        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Medicamentos ventana = new ABM_Medicamentos();
            ventana.ShowDialog();
        }

        private void razasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Razas ventana = new ABM_Razas();
            ventana.ShowDialog();
        }

        private void dueñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Dueños ventana = new ABM_Dueños();
            ventana.ShowDialog();
        }

        private void vacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Vacunas ventana = new ABM_Vacunas();
            ventana.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Consultas ventana = new ABM_Consultas();
            ventana.Show();
        }
    }
}
