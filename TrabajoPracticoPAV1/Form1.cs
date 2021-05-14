﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void dueñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Dueños ventana = new ABM_Dueños();
            ventana.Show();
        }

        private void vacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Vacunas ventana = new ABM_Vacunas();
            ventana.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Consultas ventana = new ABM_Consultas();
            ventana.Show();
        }
    }
}
