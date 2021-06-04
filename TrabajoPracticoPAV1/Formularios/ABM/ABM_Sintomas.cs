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
using TrabajoPracticoPAV1.Entidades;

namespace TrabajoPracticoPAV1.Formularios.ABM
{
    public partial class ABM_Sintomas : Form
    {
        public ABM_Sintomas()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void ABM_Sintomas_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            btnActualizarSint.Enabled = false;
        }


        private void CargarGrilla()
        {
            try
            {
                dgvSintomas.DataSource = AD_Sintomas.ObtenerListadoSintomas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtId.Enabled = false;
        }

        private void btnGuardarSint_Click(object sender, EventArgs e)
        {
            Sintoma sin = ObtenerDatosSintoma();
            bool resultado = AD_Sintomas.AgregarSintomaABD(sin);

            if (resultado)
            {
                MessageBox.Show("Sintoma agregado con exito");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar el sintoma");
            }
        }

        private Sintoma ObtenerDatosSintoma()
        {
            Sintoma sin = new Sintoma();
            sin.IdSintomas = int.Parse(txtId.Text.Trim());
            sin.NombreSintomas = txtNombre.Text.Trim();
            return sin;
        }

        private void btnActualizarSint_Click(object sender, EventArgs e)
        {
            Sintoma sin = ObtenerDatosSintoma();
            bool resultado = AD_Sintomas.ActualizarSinABD(sin);
            if (resultado)
            {
                MessageBox.Show("Sintoma actualizado con exito");
                LimpiarCampos();
                CargarGrilla();                
            }
            else
            {
                MessageBox.Show("Error al cargar");
            }
            btnActualizarSint.Enabled = false;

        }

        private void dgvSintomas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgvSintomas.Rows[indice];
            int id = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
            Sintoma sin = AD_Sintomas.ObtenerSintoma(id);
            LimpiarCampos();
            btnActualizarSint.Enabled = true;
            CargarCampos(sin);
        }

        private void CargarCampos(Sintoma sin)
        {
            txtId.Text = sin.IdSintomas.ToString();
            txtNombre.Text = sin.NombreSintomas.ToString();
        }
    }
}
