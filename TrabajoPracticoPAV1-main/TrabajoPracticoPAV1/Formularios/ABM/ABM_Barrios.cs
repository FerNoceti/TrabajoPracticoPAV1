using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1.AD;
using TrabajoPracticoPAV1.Entidades;

namespace TrabajoPracticoPAV1.Formularios.ABM
{
    public partial class ABM_Barrios : Form
    {

        

        public ABM_Barrios(Menu principal)
        {
            
            InitializeComponent();
        }

        public ABM_Barrios()
        {
            InitializeComponent();
        }

        private void ABM_Barrios_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarBarrio.Enabled = false;
            btnEliminarBarrio.Enabled = false;
            CargarComboCiudad();
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripción.Text = "";
        }
        
        private void CargarComboCiudad()
        {
            try
            {
                cmbCiudad.DataSource = AD_Varios.ObtenerCiudades();
                cmbCiudad.DisplayMember = "Nombre";
                cmbCiudad.ValueMember = "Id";
                cmbCiudad.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error al cargar combo ciudades");
            }
        }

        private void CargarGrilla()
        {
            try
            {
                gdrBarrios.DataSource = AD_Varios.ObtenerListadoBarriosReducido();
            }
            catch
            {
                MessageBox.Show("Error al obtener barrios");
            }
            
        }

        private void btnAgregarBarrio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese Nombre y Ciudad");
            }
            else
            {
                Barrio b = ObtenerDatosBarrio();
                bool resultado = AD_Varios.AgregarBarrioABD(b);
                if (resultado)
                {
                    MessageBox.Show("Barrio agregado con éxito");
                    LimpiarCampos();
                    CargarComboCiudad();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al agregar el barrio");
                }
            }
        }


        private Barrio ObtenerDatosBarrio()
        {
            Barrio b = new Barrio();
            b.NombreBarrio = txtNombre.Text.Trim();
            b.CiudadBarrio = (int)cmbCiudad.SelectedValue;
            b.DescripcionBarrio = txtDescripción.Text.Trim();
            return b;
        }

        private void gdrBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarBarrio.Enabled = true;
            btnEliminarBarrio.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrBarrios.Rows[indice];
            string id = filaSeleccionada.Cells["Id"].Value.ToString();
            Barrio b = AD_Varios.ObtenerBarrio(id);           
            LimpiarCampos();
            CargarCampos(b);
        }
        private void btnActualizarBarrio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(" ") || cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese Nombre y Ciudad");
            }
            else
            {
                Barrio b = ObtenerDatosBarrioAActualizar();
                bool resultado = AD_Varios.ActualizarBarrio(b);
                if (resultado)
                {
                    MessageBox.Show("Barrio actualizado con éxito");
                    LimpiarCampos();                   
                    CargarComboCiudad();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar barrio");
                }
            }
        }

        private Barrio ObtenerDatosBarrioAActualizar()
        {
            Barrio b = new Barrio();
            b.IdBarrio = Convert.ToInt32(txtId.Text);
            b.NombreBarrio = txtNombre.Text.Trim();
            b.CiudadBarrio = (int)cmbCiudad.SelectedValue;
            b.DescripcionBarrio = txtDescripción.Text.Trim();
            return b;
        }

        private void CargarCampos(Barrio b)
        {
            txtId.Text = b.IdBarrio.ToString();
            txtNombre.Text = b.NombreBarrio;
            cmbCiudad.SelectedValue = b.CiudadBarrio;
            txtDescripción.Text = b.DescripcionBarrio;
        }

        private void btnEliminarBarrio_Click(object sender, EventArgs e)
        {
            Barrio b = ObtenerDatosBarrio();
            bool resultado = AD_Varios.EliminarBarrio(b);
            if (resultado)
            {
                MessageBox.Show("Barrio eliminado con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboCiudad();
            }
            else
            {
                MessageBox.Show("Error al eliminar barrio");
            }
        }

        
        

    }
}
