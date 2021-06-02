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
    public partial class ABM_Dueños : Form
    {
        public ABM_Dueños()
        {
            InitializeComponent();
        }
        private void ABM_Dueños_Load(object sender, EventArgs e)
        {
            btnActualizarDueño.Enabled = false;
            btnBorrarDueño.Enabled = false;
            LimpiarCampos();
            CargarGrilla();
            ObtenerUltimoDueño();
        }
        private void ObtenerUltimoDueño()
        {
            int id = AD_Dueño.ObtenerUltimoIdDueño();
            txtNumIdDueño.Text = (id + 1).ToString();
        }

        //ALTA DUEÑO
        public void btnAgregarDueño_Click(object sender, EventArgs e)
        {
            if (VerificarCamposLlenos())
            {
                Dueño p = ObtenerDatosDueño();
                bool resultado = AD_Dueño.AgregarDueñoABD(p);
                if (resultado)
                {
                    MessageBox.Show("Dueño agregado con exito.");
                    //HAGO ESTO PARA QUE UNA VEZ CARGADO EL USUARIO SE ME LIMPIEN LOS CAMPOS
                    LimpiarCampos();
                    CargarGrilla();
                    ObtenerUltimoDueño();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar al dueño con exito.");
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos.");

            }
        }
        private bool VerificarCamposLlenos()
        {
            if (txtNombreDueño.Text.Length > 0 && txtApellidoDueño.Text.Length > 0 && txtTelefonoDueño.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //MODIFICACION DUEÑO
        private void btnActualizarDueño_Click(object sender, EventArgs e)
        {
            Dueño p = ObtenerDatosDueño();
            if (VerificarCamposLlenos())
            {
                bool resultado = AD_Dueño.ActualizarDueño(p);
                if (resultado)
                {
                    MessageBox.Show("Datos del dueño actualizados con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    ObtenerUltimoDueño();
                    btnActualizarDueño.Enabled = false;

                }
                else
                {
                    MessageBox.Show("No se pudieron actualizar los datos del dueño con exito");
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos.");
            }
            
        }





        //BAJA DUEÑO

        //FUNCIONES VARIAS
        private Dueño ObtenerDatosDueño()
        {
            Dueño p = new Dueño();
            p.IdDueño = txtNumIdDueño.Text.Trim();
            p.NombreDueño = txtNombreDueño.Text.Trim();
            p.ApellidoDueño = txtApellidoDueño.Text.Trim();
            p.TelefonoDueño = txtTelefonoDueño.Text.Trim();

            return p;
        }
        private void LimpiarCampos()
        {
            txtNombreDueño.Text = "";
            txtApellidoDueño.Text = "";
            txtTelefonoDueño.Text = "";
            btnActualizarDueño.Enabled = false;
            btnBorrarDueño.Enabled = false;

        }
        private void CargarGrilla()
        {
            try
            {
                gridDueños.DataSource = AD_Dueño.ObtenerListadoDueñosReducido();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void gridDueños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridDueños_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gridDueños.Rows[indice];
            string id = filaSeleccionada.Cells["Id_Dueño"].Value.ToString();
            Dueño p = AD_Dueño.ObtenerDueño(id);
            LimpiarCampos();
            CargarDueños(p);
            btnActualizarDueño.Enabled = true;
            btnBorrarDueño.Enabled = true;
        }
        private void CargarDueños(Dueño d)
        {
            txtNumIdDueño.Text = d.IdDueño;
            txtNombreDueño.Text = d.NombreDueño;
            txtApellidoDueño.Text = d.ApellidoDueño;
            txtTelefonoDueño.Text = d.TelefonoDueño;


        }

        private void btnBorrarDueño_Click(object sender, EventArgs e)
        {
            Dueño p = ObtenerDatosDueño();
            bool resultado = AD_Dueño.EliminarDueño(p);
            if (resultado)
            {
                MessageBox.Show("El dueño ha sido eliminado del sistema con exito");
                LimpiarCampos();
                CargarGrilla();
                ObtenerUltimoDueño();
                btnActualizarDueño.Enabled = false;
                btnBorrarDueño.Enabled = false;

            }
            else
            {
                MessageBox.Show("El dueño no se pudo dar de baja con exito");
            }
        }
    }
}
