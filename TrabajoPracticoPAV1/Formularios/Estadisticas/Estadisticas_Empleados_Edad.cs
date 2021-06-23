using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoPracticoPAV1.AD;

namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    public partial class Estadisticas_Empleados_Edad : Form
    {
        public Estadisticas_Empleados_Edad()
        {
            InitializeComponent();
        }

        private void Estadisticas_Empleados_Matricula_Load(object sender, EventArgs e)
        {

            this.rpEmpleadoEdad.RefreshReport();
            desactivarRango();
        }

        //private void rpEmpleadoMatricula_Load(object sender, EventArgs e)
        //{
        //    DataTable tabla = AD_Empleados.obtenerCantEmpleadoPorSucursal();
        //    rpEmpleadoEdad.LocalReport.DataSources.Clear();
        //    rpEmpleadoEdad.LocalReport.DataSources.Add(new ReportDataSource("DSEmpleadosSucursal", tabla));
        //    rpEmpleadoEdad.LocalReport.Refresh();
        //    rpEmpleadoEdad.RefreshReport();
        //}

        private void rpEmpleadoEdad_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Empleados.obtenerCantEmpleadoPorEdad();
            cargarReporte(tabla);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPorRango.Checked)
            {
                activarRango();
            }
            else
            {
                desactivarRango();
            }
        }

        private void activarRango()
        {
            txtCotaInferior.Enabled = true;
            txtCotaSuperior.Enabled = true;
        }

        private void desactivarRango()
        {
            txtCotaInferior.Enabled = false;
            txtCotaSuperior.Enabled = false;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (cbPorRango.Checked)
            {
                if(txtCotaInferior.Text.Equals("") || txtCotaSuperior.Text.Equals("") 
                    || (int.Parse(txtCotaInferior.Text) > int.Parse(txtCotaSuperior.Text)))
                {
                    MessageBox.Show("Error: Ingreso incorrecto de rango");
                    tabla = AD_Empleados.obtenerCantEmpleadoPorEdad();
                }
                else
                {
                    tabla = AD_Empleados.obtenerCantEmpleadoPorRangoEdad(int.Parse(txtCotaInferior.Text),int.Parse(txtCotaSuperior.Text));

                }
            }
            else
            {
                tabla = AD_Empleados.obtenerCantEmpleadoPorEdad();
            }
            cargarReporte(tabla);
        }

        private void cargarReporte(DataTable tabla)
        {
            rpEmpleadoEdad.LocalReport.DataSources.Clear();
            rpEmpleadoEdad.LocalReport.DataSources.Add(new ReportDataSource("DSEmpleadosEdad", tabla));
            rpEmpleadoEdad.LocalReport.Refresh();
            rpEmpleadoEdad.RefreshReport();
        }
    }
}
