﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    public partial class Reporte_Empleados : Form
    {
        public Reporte_Empleados()
        {
            InitializeComponent();
        }

        private void Reporte_Empleados_Load(object sender, EventArgs e)
        {

            this.rvEmpleados.RefreshReport();
        }
    }
}