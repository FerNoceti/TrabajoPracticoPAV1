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
    public partial class ABM_Vacunas : Form
    {
        public ABM_Vacunas()
        {
            InitializeComponent();
        }

        private void btnAgregarVacuna_Click(object sender, EventArgs e)
        {
            if (VerificarCamposLlenos())
            {
                Vacuna p = ObtenerDatosVacuna();
                bool resultado = AD_Vacunas.AgregarVacunaABD(p);
                if (resultado)
                {
                    MessageBox.Show("Vacuna agregada con exito.");
                    //HAGO ESTO PARA QUE UNA VEZ CARGADO EL USUARIO SE ME LIMPIEN LOS CAMPOS
                    LimpiarCampos();
                    CargarGrilla();
                    ObtenerUltimaVacuna();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar a la vacuna con exito.");
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos");

            }

        }
        private void CargarVacunas(Vacuna d)
        {
            txtNumIdVacuna.Text = d.IdVacuna;
            txtNombreVacuna.Text = d.NombreVacuna;
            txtDosisVacuna.Text = d.DosisVacuna.ToString();
            txtDescipcionVacuna.Text = d.DescripcionVacuna;


        }
        private void ABM_Vacunas_Load(object sender, EventArgs e)
        {
            btnActualizarVacuna.Enabled = false;
    
            btnBorrarVacuna.Enabled = false;

         
            LimpiarCampos();
            CargarGrilla();
            ObtenerUltimaVacuna();

        }
        private bool VerificarCamposLlenos()
        {
            if (txtNumIdVacuna.Text.Length > 0 && txtNombreVacuna.Text.Length > 0 && txtDosisVacuna.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ObtenerUltimaVacuna()
        {
            int id = AD_Vacunas.ObtenerUltimoIdVacuna();
            txtNumIdVacuna.Text = (id + 1).ToString();
        }
        private void LimpiarCampos()
        {
            txtNombreVacuna.Text = "";
            txtDosisVacuna.Text = "";
            txtDescipcionVacuna.Text = "";

        }
        private Vacuna ObtenerDatosVacuna()
        {
            Vacuna p = new Vacuna();
            p.IdVacuna = txtNumIdVacuna.Text.Trim();
            p.NombreVacuna = txtNombreVacuna.Text.Trim();
            p.DosisVacuna = float.Parse(txtDosisVacuna.Text.Trim());
            p.DescripcionVacuna = txtDescipcionVacuna.Text.Trim();

            return p;
        }
        private void CargarGrilla()
        {
            try
            {
                gridVacunas.DataSource = AD_Vacunas.ObtenerListadoVacunasReducido();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnActualizarVacuna_Click(object sender, EventArgs e)
        {
            if (VerificarCamposLlenos())
            {
                Vacuna p = ObtenerDatosVacuna();
                bool resultado = AD_Vacunas.ActualizarVacuna(p);
                if (resultado)
                {
                    MessageBox.Show("Datos de la vacuna actualizados con exito");
                    LimpiarCampos();
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("No se pudieron actualizar los datos de la vacuna con exito");
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBorrarVacuna_Click(object sender, EventArgs e)
        {
            Vacuna p = ObtenerDatosVacuna();
            bool resultado = AD_Vacunas.EliminarVacuna(p);
            if (resultado)
            {
                MessageBox.Show("La vacuna ha sido eliminada del sistema con exito");
                LimpiarCampos();
                CargarGrilla();
                ObtenerUltimaVacuna();
                btnActualizarVacuna.Enabled = false;
                btnBorrarVacuna.Enabled = false;

            }
            else
            {
                MessageBox.Show("La vacuna no se pudo dar de baja con exito");
            }

        }

        private void gridVacunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gridVacunas.Rows[indice];
            string id = filaSeleccionada.Cells["Id_Vacuna"].Value.ToString();
            Vacuna p = AD_Vacunas.ObtenerVacuna(id);
            LimpiarCampos();
            CargarVacunas(p);
            btnActualizarVacuna.Enabled = true;
            btnBorrarVacuna.Enabled = true;
        }
    }
}
