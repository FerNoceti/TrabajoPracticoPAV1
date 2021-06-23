using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using TrabajoPracticoPAV1.AD;

namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    public partial class btnGenerar : Form
    {
        public btnGenerar()
        {
            InitializeComponent();
        }

        private void Estadisticas_Empleados_Sucursal_Load(object sender, EventArgs e)
        {

            this.rpEmpleadoSucursal.RefreshReport();
            desactivarCampoSucEspecifica();
        }

        private void rpEmpleadoSucursal_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Empleados.obtenerCantEmpleadoPorSucursal();
            cargarReporte(tabla);
            //rpEmpleadoSucursal.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSucursalEspecifica.Checked)
            {
                activarCampoSucEspecifica();
            }
            else
            {
                desactivarCampoSucEspecifica();
            }
        }

        private void activarCampoSucEspecifica()
        {
            txtIdSucursalEsp.Enabled = true;
        }

        private void desactivarCampoSucEspecifica()
        {
            txtIdSucursalEsp.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if(cbSucursalEspecifica.Checked)
            {
                if(txtIdSucursalEsp.Text.Equals(""))
                {
                    MessageBox.Show("Error: Campos mal ingresados");
                    tabla = AD_Empleados.obtenerCantEmpleadoPorSucursal();

                }
                else
                {
                    tabla = AD_Empleados.obtenerCantEmpleadoPorSucursalEspecifisa(int.Parse(txtIdSucursalEsp.Text.Trim()));
                }
            }
            else
            {
                tabla = AD_Empleados.obtenerCantEmpleadoPorSucursal();
            }
            cargarReporte(tabla);
        }

        private void cargarReporte(DataTable tabla)
        {
            rpEmpleadoSucursal.LocalReport.DataSources.Clear();
            rpEmpleadoSucursal.LocalReport.DataSources.Add(new ReportDataSource("DSEmpleadosSucursal", tabla));
            rpEmpleadoSucursal.LocalReport.Refresh();
            rpEmpleadoSucursal.RefreshReport();
        }
    }
}
