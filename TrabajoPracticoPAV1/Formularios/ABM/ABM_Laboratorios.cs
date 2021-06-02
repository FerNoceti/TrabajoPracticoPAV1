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
            CargarGrilla();
            btnActualizarLab.Enabled = false;
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
            txtId.Enabled = false;
            
        }
        
        private void CargarGrilla()
        {
            try
            {
                dgvLaboratorios.DataSource = AD_Laboratorios.ObtenerListadoLaboratorios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardarLab_Click(object sender, EventArgs e)
        {
            Laboratorio lab = ObtenerDatosLaboratorio();
            bool resultado = AD_Laboratorios.AregarLaboratorioABD(lab);

            if (resultado)
            {
                MessageBox.Show("Laboratorio agregado con exito");
                LimpiarCampos();
                CargarCombosBarrios();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar el laboratorio");
            }
        }

        private Laboratorio ObtenerDatosLaboratorio()
        {
            Laboratorio lab = new Laboratorio();
            lab.IdLaboratorios = int.Parse(txtId.Text.Trim());
            lab.RazonSocialLaboratorio = txtRazonSocial.Text.Trim();
            lab.CalleLaboratorio = txtCalle.Text.Trim();
            lab.NumeroCalleLaboratorio = txtNumeroCalle.Text.Trim();
            lab.IdBarrioLaboratorio = (int)cmbBarrio.SelectedValue;

            return lab;
        }

        private void btnActualizarLab_Click(object sender, EventArgs e)
        {
            Laboratorio lab = ObtenerDatosLaboratorio();
            bool resultado = AD_Laboratorios.ActualizarLabABD(lab);
            if (resultado)
            {
                MessageBox.Show("Laboratorio actualizado con exito");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar");
            }
            btnActualizarLab.Enabled = false;
        }


        private void CargarCampos(Laboratorio lab)
        {
            txtId.Text = lab.IdLaboratorios.ToString();
            txtRazonSocial.Text = lab.RazonSocialLaboratorio;
            txtCalle.Text = lab.CalleLaboratorio;
            txtNumeroCalle.Text = lab.NumeroCalleLaboratorio;
            cmbBarrio.SelectedValue = lab.IdBarrioLaboratorio;
        }

        private void dgvLaboratorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgvLaboratorios.Rows[indice];
            int id = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
            Laboratorio lab = AD_Laboratorios.ObtenerDatosLaboratorio(id);
            LimpiarCampos();
            CargarCampos(lab);
            btnActualizarLab.Enabled = true;
        }

        private void dgvLaboratorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

