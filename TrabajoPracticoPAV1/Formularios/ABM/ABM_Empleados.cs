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
    public partial class ABM_Empleados : Form
    {
        private Empleado empleadoSeleccionado;
        private int tipoDocViejo;
        private string nroDocViejo;
        
        public ABM_Empleados()
        {
            InitializeComponent();
        }

        private void ABM_Empleados_Load(object sender, EventArgs e)
        {
            btnEliminarEmpleado.Enabled = false;
            btnActualizar.Enabled = false;
            cargarGrilla();
            cargarComboTipoDocumentos();
            cargarComboSucursales();
            limpiarCampos();

            cmbTipoDocumento.BackColor = Color.Black;
        }

        private Empleado obtenerDatosEmpleado()
        {
            Empleado e = new Empleado();
            try
            {
                e.Nombre = txtNombre.Text.Trim();
                e.Apellido = txtApellido.Text.Trim();
                e.FechaNacimiento = DateTime.Parse(txtFechaNac.Text);
                e.FechaIngreso = DateTime.Now;
                e.TipoDocumento = (int)cmbTipoDocumento.SelectedValue;
                e.NroDocumento = txtNroDocumento.Text.Trim();
                e.Sucursal = (int)cmbSucursal.SelectedValue;
                return e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return e;

        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNroDocumento.Text = "";
            txtFechaNac.Text = "";
            btnActualizar.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
            
        }

        private void cargarCampos(Empleado e)
        {
            txtNombre.Text = e.Nombre;
            txtApellido.Text = e.Apellido;

            txtNroDocumento.Text = e.NroDocumento;
            txtFechaNac.Text = e.FechaNacimiento.ToShortDateString();
            
            cmbTipoDocumento.SelectedValue = e.TipoDocumento;
            cmbSucursal.SelectedValue = e.Sucursal;
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
                DataTable tabla = AD_Empleados.obtenerDatosEmpleados();
                gdrEmpleados.DataSource = tabla;


                foreach (DataGridViewColumn column in gdrEmpleados.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener los datos de los empleados");
            }

        }

        private void ABM_Empleados_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private bool validarDatosEmpleado(Empleado empl)
        {
            if ((empl.Nombre == "") || (empl.Apellido == "") || (empl.NroDocumento == "")) return false;
            return true;
        }
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empl = obtenerDatosEmpleado();
                if (AD_Empleados.existeEmpleado(empl.TipoDocumento, empl.NroDocumento))
                {
                    MessageBox.Show("El empleado que esta ingresando ya se encuentra registrado");
                }
                else if(validarDatosEmpleado(empl))
                {
                    // ver el tema de la validacion de datos
                    bool resultado = AD_Empleados.agregarEmpleadoABD(empl);
                    if (resultado)
                    {
                        MessageBox.Show("Empleado agregado con exito");

                        limpiarCampos();
                        cargarComboTipoDocumentos();
                        cargarComboSucursales();
                        cargarGrilla();
                    }
                    else 
                    {
                        MessageBox.Show("Error al intentar guardar los datos registrados.");
                    }

                }
                else
                {
                    MessageBox.Show("Error, datos incompletos o inválidos");
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error al reconocer los datos ingresados, verifique que haya seguido el formato correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar agregar al nuevo empleado, revise que los datos hayan sido cargados corerctamente.\nError: \n\n " + ex);
            }

           
        }



        private void gdrEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if(e.RowIndex != -1)
            {
                DataGridViewRow fila = gdrEmpleados.Rows[indice];
                int tipoDocumento = (int)fila.Cells["TipoDocumento"].Value;
                tipoDocViejo = (int)fila.Cells["TipoDocumento"].Value;
                string nroDocumento = fila.Cells["NroDocumento"].Value.ToString();
                nroDocViejo = fila.Cells["NroDocumento"].Value.ToString();

                Empleado empl = AD_Empleados.obtenerEmpleado(tipoDocumento, nroDocumento);
                this.empleadoSeleccionado = empl;
                limpiarCampos();
                cargarCampos(empl);
                btnActualizar.Enabled = true;
                btnEliminarEmpleado.Enabled = true;
                btnAgregarEmpleado.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Empleado empl = obtenerDatosEmpleado();
            bool resultado = AD_Empleados.actualizarEmpleado(empl, tipoDocViejo, nroDocViejo);
            if (resultado)
            {
                MessageBox.Show("Persona actualizada con exito");
                cargarGrilla();
                cargarComboSucursales();
                cargarComboTipoDocumentos();
                limpiarCampos();
                btnAgregarEmpleado.Enabled = true;
                btnActualizar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al actualizar persona");
            }
        }

        private void btnCancelarOperacion_Click(object sender, EventArgs e)
        {
            cargarComboSucursales();
            cargarComboTipoDocumentos();
            limpiarCampos();

            btnActualizar.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
            btnAgregarEmpleado.Enabled = true;

        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            bool resultado = AD_Empleados.eliminarEmpleado(empleadoSeleccionado);
            if(resultado)
            {
                MessageBox.Show("Empleado Eliminado con exito");
                limpiarCampos();
                cargarComboTipoDocumentos();
                cargarComboSucursales();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado seleccionado");
            }
        }

        private void lbSucursal_Click(object sender, EventArgs e)
        {

        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
