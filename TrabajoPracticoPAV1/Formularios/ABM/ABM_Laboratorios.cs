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
    public partial class ABM_Laboratorios : Form
    {
        public ABM_Laboratorios()
        {
            InitializeComponent();
        }

        private void ABM_Laboratorios_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarCombosBarrios();
        }

        private void CargarCombosBarrios()
        {
            try
            {
                cmbBarrio.DataSource = AD_Varios.ObtenerTabla("Barrios");
                cmbBarrio.DisplayMember = "Nombre";
                cmbBarrio.ValueMember = "Id";
                cmbBarrio.SelectedItem = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los combos de los barrios");
            }
        }

        private void LimpiarCampos()
        {
            txtRazonSocial.Text = "";
            txtCalle.Text = "";
            txtNumeroCalle.Text = "";
            

           
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
