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
    public partial class ABM_Sucursales : Form
    {
        private Empleado supervisorSugerido;
        private Empleado suplenteSugerido;
        private bool seAgregaSupervisor;
        private bool seAgregaSuplente;
        public ABM_Sucursales()
        {
            InitializeComponent();

        }

        private void ABM_Sucursales_Load(object sender, EventArgs e)
        {
            btnEliminarSucursal.Enabled = false;
            btnActualizarSucursal.Enabled = false;
            cargarGrilla();
            cargarComboTipoDocumentos();
            limpiarCampos();
            cargarIdSucursal();
        }

        private void cargarIdSucursal()
        {
            int idNueva = AD_Sucursales.obtenerUltimoIdSucursale() + 1;
            txtIdSucursal.Text = idNueva.ToString();
        }

        private void limpiarCampos()
        {

            //Sucursal
            txtNombreSucursal.Text = "";
            txtIdSucursal.Text = (AD_Sucursales.obtenerUltimoIdSucursale() + 1).ToString();

            //Supérvisor
            txtNombreSupervisor.Text = "";
            txtApellidoSupervisor.Text = "";
            txtNroDocumentoSupervisor.Text = "";
            cmbTipoDocSupervisor.SelectedIndex = -1;

            //Suplente
            txtNombreSuplente.Text = "";
            txtApellidoSuplente.Text = "";
            txtNroDocumentoSuplente.Text = "";
            cmbTipoDocSuplente.SelectedIndex = -1;



        }

        private void cargarComboTipoDocumentos()
        {
            cmbTipoDocSupervisor.DataSource = AD_Varios.obtenerTipoDocumentos();
            cmbTipoDocSupervisor.DisplayMember = "Nombre";
            cmbTipoDocSupervisor.ValueMember = "Id";
            cmbTipoDocSupervisor.SelectedIndex = -1;

            cmbTipoDocSuplente.DataSource = AD_Varios.obtenerTipoDocumentos();
            cmbTipoDocSuplente.DisplayMember = "Nombre";
            cmbTipoDocSuplente.ValueMember = "Id";
            cmbTipoDocSuplente.SelectedIndex = -1;
        }

        private void cargarGrilla()
        {
            try
            {
                DataGridViewRow fila;
                DataTable tabla = AD_Sucursales.obtenerSucursalesReducido();
                gdrSucursales.DataSource = tabla;
                for (int i = 0; i < gdrSucursales.Rows.Count; i++)
                {
                    fila = gdrSucursales.Rows[i];
                    int id = int.Parse(fila.Cells["Id"].Value.ToString());
                    DataTable supervisores = AD_Sucursales.obtenerSupervisores(id);

                    if (supervisores.Rows.Count != 0)
                    {
                        fila.Cells["Supervisor"].Value = supervisores.Rows[0][0].ToString();
                        fila.Cells["Suplente"].Value = supervisores.Rows[0][1].ToString();
                    }

                }

                foreach (DataGridViewColumn column in gdrSucursales.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla de sucursales\n" + ex);
            }
        }

        private void gdrSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = gdrSucursales.Rows[indice];
                int id = (int)fila.Cells["Id"].Value;
                Sucursal sucursal = AD_Sucursales.obtenerSucursal(id);
                limpiarCampos();
                cargarCampos(sucursal);
                btnAgregarSucursal.Enabled = false;
                btnEliminarSucursal.Enabled = true;
                btnActualizarSucursal.Enabled = true;
            }
        }

        private void cargarCampos(Sucursal sucursal)
        {
            //Sucursal
            txtNombreSucursal.Text = sucursal.NombreSucursal;
            txtIdSucursal.Text = sucursal.Id.ToString();

            //Supérvisor
            if(sucursal.TipoDocumentoSupervisor != 0)
            {
                cmbTipoDocSupervisor.SelectedValue = sucursal.TipoDocumentoSupervisor;
                txtNroDocumentoSupervisor.Text = sucursal.NroDocumentoSupervisor;
            }
            resetearSupervisorNoValidado();
            buscarSupervisor();

            //Suplente
            if(sucursal.TipoDocumentoSuplente != 0)
            {
                cmbTipoDocSuplente.SelectedValue = sucursal.TipoDocumentoSuplente;
                txtNroDocumentoSuplente.Text = sucursal.NroDocumentoSuplente;
            }
            resetearSuplenteNoValidado();
            buscarSuplente();
        }

        private void resetearBotones()
        {
            btnAgregarSucursal.Enabled = true;
            btnActualizarSucursal.Enabled = false;
            btnEliminarSucursal.Enabled = false;
        }

        private void btnBuscarSupervisor_Click(object sender, EventArgs e)
        {
            buscarSupervisor();
        }

        private void buscarSupervisor()
        {
            try
            {
                bool ingresoDatosValido = validarDatosSupervisor();
                if (ingresoDatosValido)
                {
                    bool existeEmpleado = AD_Empleados.existeEmpleado(int.Parse(cmbTipoDocSupervisor.SelectedValue.ToString()), txtNroDocumentoSupervisor.Text);
                    if (existeEmpleado)
                    {
                        this.supervisorSugerido = AD_Empleados.obtenerEmpleado(int.Parse(cmbTipoDocSupervisor.SelectedValue.ToString()), txtNroDocumentoSupervisor.Text);
                        txtNombreSupervisor.Text = supervisorSugerido.Nombre;
                        txtApellidoSupervisor.Text = supervisorSugerido.Apellido;

                        btnBuscarSupervisor.Enabled = false;
                        lbSupervisorListo.Visible = true;
                        this.seAgregaSupervisor = true;
                    }
                    else
                    {
                        lbSupervError.Text = "Empleado No Encontrado";
                        lbSupervError.Visible = true;
                    }
                }
                else
                {
                    lbSupervError.Text = "Datos Incompletos";
                    lbSupervError.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar los datos del supervisor en la base de datos.");
            }
        }


        private bool validarDatosSupervisor()
        {
            bool resultado = true;
            if (txtNroDocumentoSupervisor.Text == "" || cmbTipoDocSupervisor.SelectedIndex == -1)
            {
                resultado = false;
            }
            return resultado;
        }

        private Sucursal obtenerDatosSucursal()
        {
            try
            {
                Sucursal s = new Sucursal();

                s.Id = int.Parse(txtIdSucursal.Text);
                s.NombreSucursal = txtNombreSucursal.Text;

                if (seAgregaSupervisor)
                {
                    s.TipoDocumentoSupervisor = (int)cmbTipoDocSupervisor.SelectedValue;
                    s.NroDocumentoSupervisor = txtNroDocumentoSupervisor.Text;
                }

                if (seAgregaSuplente)
                {
                    s.TipoDocumentoSuplente = (int)cmbTipoDocSuplente.SelectedValue;
                    s.NroDocumentoSuplente = txtNroDocumentoSuplente.Text;
                }
                return s;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private bool validarDatosSuplente()
        {
            bool resultado = true;
            if (txtNroDocumentoSuplente.Text == "" || cmbTipoDocSuplente.SelectedIndex == -1)
            {
                resultado = false;
            }
            return resultado;
        }

        private void btnCancelarOperacion_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cargarComboTipoDocumentos();
            resetearBotones();
        }

        private void buscarSuplente()
        {
            try
            {
                bool ingresoDatosValido = validarDatosSuplente();
                if (ingresoDatosValido)
                {
                    bool existeEmpleado = AD_Empleados.existeEmpleado(int.Parse(cmbTipoDocSuplente.SelectedValue.ToString()), txtNroDocumentoSuplente.Text);
                    if (existeEmpleado)
                    {
                        this.suplenteSugerido = AD_Empleados.obtenerEmpleado(int.Parse(cmbTipoDocSuplente.SelectedValue.ToString()), txtNroDocumentoSuplente.Text);
                        txtNombreSuplente.Text = suplenteSugerido.Nombre;
                        txtApellidoSuplente.Text = suplenteSugerido.Apellido;


                        btnBuscarSuplente.Enabled = false;
                        lbSuplenteListo.Visible = true;
                        this.seAgregaSuplente = true;
                    }
                    else
                    {
                        lbSuplError.Text = "Empleado No Encontrado";
                        lbSuplError.Visible = true;
                    }
                }
                else
                {
                    lbSuplError.Text = "Datos Incompletos";
                    lbSuplError.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar los datos del suplente en la base de datos.");
            }
        }
        private void btnBuscarSuplente_Click(object sender, EventArgs e)
        {
            buscarSuplente();
        }



        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                bool datosSucursalValidos = validarDatosSucursal();
                if(datosSucursalValidos)
                {
                    Sucursal sucursalNueva = obtenerDatosSucursal();
                    bool resultado = AD_Sucursales.agregarSucursal(sucursalNueva);
                    if (resultado)
                    {
                        MessageBox.Show("Sucursal agregada con exito");
                        limpiarCampos();
                        cargarIdSucursal();
                        cargarGrilla();
                        resetearBotones();
                    }
                    else
                    {
                        MessageBox.Show("Error, no se pudo agregar la nueva sucursal");
                    }
                }
                else
                {
                    MessageBox.Show("Error, rellene los campos obligatorios primero");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mientras se intentaba realizar la operacion");
            }

            //bool resultado = 
        }

        private bool validarDatosSucursal()
        {
            if (txtNombreSucursal.Text == "") return false;
            return true;
        }

        private void resetearSupervisorNoValidado()
        {
            this.seAgregaSupervisor = false;
            btnBuscarSupervisor.Enabled = true;
            lbSupervError.Visible = false;
            lbSupervisorListo.Visible = false;
        }

        private void resetearSuplenteNoValidado()
        {
            this.seAgregaSuplente = false;
            btnBuscarSuplente.Enabled = true;
            lbSuplError.Visible = false;
            lbSuplenteListo.Visible = false;
        }

        private void cmbTipoDocSupervisor_SelectedValueChanged(object sender, EventArgs e)
        {
            resetearSupervisorNoValidado();
        }

        private void cmbTipoDocSuplente_SelectedValueChanged(object sender, EventArgs e)
        {
            resetearSuplenteNoValidado();
        }

        private void txtNroDocumentoSupervisor_TextChanged(object sender, EventArgs e)
        {
            resetearSupervisorNoValidado();
        }

        private void txtNroDocumentoSuplente_TextChanged(object sender, EventArgs e)
        {
            resetearSuplenteNoValidado();
        }

        private void btnActualizarSucursal_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = obtenerDatosSucursal();
            bool resultado = AD_Sucursales.actualizarSucursal(sucursal);
            if (resultado)
            {
                MessageBox.Show("Sucursal actualizada con exito");
                cargarGrilla();
                cargarComboTipoDocumentos();
                limpiarCampos();
                resetearBotones();
            }
            else
            {
                MessageBox.Show("Error al actualizar persona");
            }
        }

        private void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdSucursal.Text);
            bool resultado = AD_Sucursales.eliminarSucursal(id);
            if (resultado)
            {
                MessageBox.Show("Sucursal eliminada con exitos");
                limpiarCampos();
                cargarGrilla();
                cargarComboTipoDocumentos();
                resetearBotones();

            }
            else
            {
                MessageBox.Show("No se pudo eliminar la sucursal seleccionada");
            }
        }
    }
    }