﻿using System;
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
            ABM_Empleados formEmpleados = new ABM_Empleados(this);
            formEmpleados.Show();
        }
    }
}
