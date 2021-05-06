using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1.AD;

namespace TrabajoPracticoPAV1.Formularios.ABM
{
    public partial class ABM_Empleados : Form
    {
        private Form prin;
        
        public ABM_Empleados(Form prin)
        {
            this.prin = prin;
            InitializeComponent();
        }

        private void ABM_Empleados_Load(object sender, EventArgs e)
        {
            prin.Enabled = false;
            cargarGrilla();
            cargarComboTipoDocumentos();
            cargarComboSucursales();
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNroDocumento.Text = "";
            
        }

        private void cargarComboTipoDocumentos()
        {
            cmbTipoDocumento.DataSource = AD_Varios.obtenerTipoDocumentos();
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.ValueMember = "Id";
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void cargarComboSucursales()
        {
            cmbSucursal.DataSource = AD_Varios.obtenerSucursales();
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "Id";
            cmbSucursal.SelectedIndex = -1;
        }


        private void cargarGrilla()
        {
            try
            {
                gdrEmpleados.DataSource = AD_Empleados.obtenerDatosEmpleados();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener los datos de los empleados");
            }

        }

        private void ABM_Empleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            prin.Enabled = true;
        }
    }
}
