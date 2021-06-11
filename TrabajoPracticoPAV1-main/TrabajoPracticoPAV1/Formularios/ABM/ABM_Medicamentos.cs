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
    public partial class ABM_Medicamentos : Form
    {
        public ABM_Medicamentos()
        {
            InitializeComponent();
        }

        private void ABM_Medicamentos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboLab();
            CargarComboTipoMedicamento();
            CargarComboUnidad();

            CargarGrilla();
        }
        
        private void LimpiarCampos()
        {
            txtNombreM.Text = "";
            txtCantMin.Text = "";
            //txtUltimaCompra.Text = "";
            txtUltimaCompra2.Text = DateTime.Now.ToString();
            txtPrecio.Text = "";
            cbLab.SelectedItem = null;
            cbTipoM.SelectedItem = null;
            cbUnidad.SelectedItem = null;

            txtIdMed.Text = "-1";
            txtIdMed.Visible = false;

            btnActualizarMed.Enabled = false;
            btnBorrarMed.Enabled = false;

        }


        private void CargarComboLab()
        {

            try
            {
                cbLab.DataSource = AD_Medicamentos.ObtenerTabla("Laboratorios");
                cbLab.DisplayMember = "RazonSocial";
                cbLab.ValueMember = "Id";
                cbLab.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de laboratorios");
            }

        }
        private void CargarComboTipoMedicamento()
        {

            try
            {
                cbTipoM.DataSource = AD_Medicamentos.ObtenerTiposDeMedicamentos();
                cbTipoM.DisplayMember = "Nombre";
                cbTipoM.ValueMember = "Id";
                cbTipoM.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de tipo de medicamentos");
            }

        }
        private void CargarComboUnidad()
        {

            try
            {
                cbUnidad.DataSource = AD_Medicamentos.ObtenerTabla("UnidadMedidas");
                cbUnidad.DisplayMember = "Nombre";
                cbUnidad.ValueMember = "Id";
                cbUnidad.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de unidades");
            }

        }
        private void CargarGrilla()
        {

            try
            {
                gdrMedicamentos.DataSource = AD_Medicamentos.ObtenerListadoMedicamentos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener medicamentos");
            }

        }

        private Medicamentos ObtenerDatosMedicamento()
        {
            Medicamentos m = new Medicamentos();


            if (txtNombreM.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
            }
            else
            {
                 m.DescripcionMedicamentos = txtNombreM.Text.Trim(); //guarda sin espacios al final o principio
            }

            if (cbLab.SelectedValue == null || cbTipoM.SelectedValue == null || cbUnidad.SelectedValue == null)
            {
                MessageBox.Show("Seleccione alguna opcion en los combos box");
            }
            else
            {
                m.Id_LaboratorioMedicamentos = (int)cbLab.SelectedValue;
                m.Id_TipoMedicamentos = (int)cbTipoM.SelectedValue;
                m.Id_UnidadMedidaMedicamentos = (int)cbUnidad.SelectedValue;
            }


            /*try
            {
                if (txtUltimaCompra.Text == null)
                {
                    MessageBox.Show("Ingrese la fecha de nacimiento");
                }
                else
                {
                    m.Fecha_Ultimna_CompraMedicamentos = DateTime.Parse(txtUltimaCompra.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fecha incorrecta");
            }*/

            m.Fecha_Ultimna_CompraMedicamentos = DateTime.Parse(txtUltimaCompra2.Text);
            

            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el precio");
            }
            else
            {
                m.PrecioMedicamentos = (int.Parse(txtPrecio.Text)); //guarda sin espacios al final o principio
            }

            if (txtCantMin.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la cantidad minima por sucursal");
            }
            else
            {
                m.CantidadMinimaXSucursal_Medicamentos = (int.Parse(txtCantMin.Text)); //guarda sin espacios al final o principio
            }

            return m;
        }

        private void btnGuardarMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable tablaResultado = AD_Medicamentos.ObtenerMedicamentoPorId(int.Parse(txtIdMed.Text.Trim()));
                if (tablaResultado.Rows.Count > 0)
                {
                    MessageBox.Show("Id de medicamento ya existe");
                }
                else
                {
                    Medicamentos m = ObtenerDatosMedicamento();
                    bool resultado = AD_Medicamentos.AgregarMedicamentoBD(m);
                    if (resultado)
                    {
                        MessageBox.Show("Medicamento agregado con éxito");
                        LimpiarCampos();
                        CargarComboLab();
                        CargarComboTipoMedicamento();
                        CargarComboUnidad();
                        CargarGrilla();
                        txtNombreM.Focus();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar medicamento");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener id del medicamento");
            }
            
        }



        private void gdrMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarMed.Enabled = true;

            try
            {
                DataGridViewRow filaSeleccionada = gdrMedicamentos.Rows[indice];
                string id = filaSeleccionada.Cells["Id"].Value.ToString();
                txtIdMed.Text = id;
                Medicamentos m = AD_Medicamentos.ObtenerMedicamento(int.Parse(id));
                //LimpiarCampos();
                CargarCampos(m);
                txtIdMed.Visible = true;
                btnBorrarMed.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Toque sobre un medicamento");
            }
            
        }

        private void CargarCampos(Medicamentos m)
        {
            txtIdMed.Text = m.Id_Medicamentos.ToString();
            txtNombreM.Text = m.DescripcionMedicamentos;
            txtPrecio.Text = m.PrecioMedicamentos.ToString();
            txtCantMin.Text = m.CantidadMinimaXSucursal_Medicamentos.ToString();
            /*DateTime fecha = m.Fecha_Ultimna_CompraMedicamentos;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();

            txtUltimaCompra.Text = dia + mes + año;*/

            txtUltimaCompra2.Text = m.Fecha_Ultimna_CompraMedicamentos.ToString();

            cbLab.SelectedValue = m.Id_LaboratorioMedicamentos;
            cbTipoM.SelectedValue = m.Id_TipoMedicamentos;
            cbUnidad.SelectedValue = m.Id_UnidadMedidaMedicamentos;
        }

        private void btnActualizarMed_Click(object sender, EventArgs e)
        {
          
            Medicamentos m = ObtenerDatosMedicamentos();
            bool resultado = AD_Medicamentos.ActualizarMedicamento(m);
            if (resultado)
            {
                MessageBox.Show("Medicamento actualizado correctamente");
                LimpiarCampos();
                CargarGrilla();
                CargarComboLab();
                CargarComboTipoMedicamento();
                CargarComboUnidad();
                
            }
            else
            {
                MessageBox.Show("Error al actualizar medicamento");
            }
        }

        private Medicamentos ObtenerDatosMedicamentos()
        {
            Medicamentos m = new Medicamentos();


            m.Id_Medicamentos = int.Parse(txtIdMed.Text);

            if (txtNombreM.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
            }
            else
            {
                m.DescripcionMedicamentos = txtNombreM.Text.Trim(); //guarda sin espacios al final o principio
            }

            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el Precio");
            }
            else
            {
                m.PrecioMedicamentos = int.Parse(txtPrecio.Text);
            }

            /*if (txtUltimaCompra.Text == null)
            {
                MessageBox.Show("Ingrese la fecha de ultima compra");
            }
            else
            {
                m.Fecha_Ultimna_CompraMedicamentos = DateTime.Parse(txtUltimaCompra.Text);
            }*/

            if (txtCantMin.Text == null)
            {
                MessageBox.Show("Ingrese la cantidad minima por sucursal");
            }
            else
            {
                m.CantidadMinimaXSucursal_Medicamentos = int.Parse(txtCantMin.Text);
            }

            m.Id_LaboratorioMedicamentos = (int)cbLab.SelectedValue;
            m.Id_TipoMedicamentos = (int)cbTipoM.SelectedValue;
            m.Id_UnidadMedidaMedicamentos = (int)cbUnidad.SelectedValue;

            return m;
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Medicamentos.ObtenerMedicamentoPorId(int.Parse(txtIdMed.Text.Trim()));
                if (tablaResultado.Rows.Count > 0)
                {
                    Medicamentos m = ObtenerDatosMedicamento();
                    m.Id_Medicamentos = int.Parse(txtIdMed.Text);
                    bool resultado = AD_Medicamentos.EliminarMedicamento(m);
                    if (resultado)
                    {
                        MessageBox.Show("Medicamento eliminado con éxito");
                        LimpiarCampos();
                        CargarGrilla();
                        CargarComboLab();
                        CargarComboTipoMedicamento();
                        CargarComboUnidad();
                        txtNombreM.Focus();
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar medicamento");
            }
            
        }

        
     
    }
}
