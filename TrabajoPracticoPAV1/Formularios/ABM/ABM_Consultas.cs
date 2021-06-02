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
using TrabajoPracticoPAV1.Entidades_ABM__Dueño__Consulta__Vacuna_;

namespace TrabajoPracticoPAV1.Formularios.ABM
{
    public partial class ABM_Consultas : Form
    {
        public ABM_Consultas()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txtIdConsulta.Text = "";
            txtHistoriaClinica.Text = "";
            txtNumeroDoc.Text = "";
            txtFechaEntrada.Text = "";
            txtFechaSalida.Text = "";
            cmbSucursal.SelectedIndex = -1; 
            cmbTipoDoc.SelectedIndex = -1;

        }
        private bool VerificarCamposLlenos()
        {
            if (cmbSucursal.SelectedIndex > 0 && txtIdConsulta.Text.Length > 0 && txtNumeroDoc.Text.Length >0 && txtHistoriaClinica.Text.Length > 0 && txtFechaEntrada.Text.Length > 0 && txtFechaSalida.Text.Length > 0 && cmbTipoDoc.SelectedIndex > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CargarComboTipoDoc()
        {
            try
            {
                cmbTipoDoc.DataSource = AD_Consulta.ObtenerTipoDocumento();
                cmbTipoDoc.DisplayMember = "Nombre";
                cmbTipoDoc.ValueMember = "Id";
                cmbTipoDoc.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void CargarCombosSucursal()
        {
            try
            {
                cmbSucursal.DataSource = AD_Consulta.ObtenerSucursal();
                cmbSucursal.DisplayMember = "Nombre";
                cmbSucursal.ValueMember = "Id";
                cmbSucursal.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {
            if (VerificarCamposLlenos())
            {
                Consulta p = ObtenerDatosConsulta();

                bool resultado = AD_Consulta.AgregarPersonaABD(p);
                if (resultado)
                {
                    MessageBox.Show("Consulta guardada con exito.");
                    //HAGO ESTO PARA QUE UNA VEZ CARGADO EL USUARIO SE ME LIMPIEN LOS CAMPOS
                    LimpiarCampos();
                    CargarComboTipoDoc();
                    CargarCombosSucursal();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la consulta con exito.");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todos los campos.");

            }
                
            
        }
        private void CargarGrilla()
        {
            try
            {
                gridConsultas.DataSource = AD_Consulta.ObtenerListadoConsultas();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private Consulta ObtenerDatosConsulta()
        {
            Consulta p = new Consulta();
           
            p.Id_Sucursal = (int)cmbSucursal.SelectedValue;
            p.Id_Consulta = txtIdConsulta.Text.Trim();
            p.NroHistoriaClinica = txtHistoriaClinica.Text.Trim();
            p.TipoDocumentoEmpleado = (int)cmbTipoDoc.SelectedValue;
            p.NumeroDeDocumento = txtNumeroDoc.Text.Trim();
            //DateParse ME TRANSFORMA UN string A FORMATO date
            p.FechaDeEntrada = DateTime.Parse(txtFechaEntrada.Text);
            p.FechaDeSalida = DateTime.Parse(txtFechaSalida.Text);
            return p;
        }

        private void gridConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            int indice = e.RowIndex;
            if (indice > 0)
            {
                DataGridViewRow filaSeleccionada = gridConsultas.Rows[indice];
                string idConsulta = filaSeleccionada.Cells["Nro_Consulta"].Value.ToString();
                string idSucursal = filaSeleccionada.Cells["Sucursal"].Value.ToString();
                Consulta p = AD_Consulta.ObtenerConsulta(idConsulta, idSucursal);
                LimpiarCampos();
                CargarConsultas(p);
                btnActualizarConsulta.Enabled = true;
                btnEliminarConsulta.Enabled = true;
            }

        }
        private void ObtenerUltimaConsulta(string a )
        {
            int id = AD_Consulta.ObtenerUltimoIdConsulta(a);
            txtIdConsulta.Text = (id + 1).ToString();
        }
        private void ABM_Consultas_Load(object sender, EventArgs e)
        {
            btnActualizarConsulta.Enabled = false;
            btnEliminarConsulta.Enabled = false;
            CargarComboTipoDoc();
            CargarCombosSucursal();
            LimpiarCampos();
            CargarGrilla();
        }
        private void CargarConsultas(Consulta c)
        {
            txtIdConsulta.Text = c.Id_Consulta;
            txtHistoriaClinica.Text = c.NroHistoriaClinica;
            txtNumeroDoc.Text = c.NumeroDeDocumento;
            DateTime fechaEntrada = c.FechaDeEntrada;
            string diaE = "";
            string mesE = "";
            string añoE = "";
            diaE = fechaEntrada.Date.Day.ToString();
            if (diaE.Length == 1)
            {
                diaE = "0" + diaE;
            }
            mesE = fechaEntrada.Date.Month.ToString();
            if (mesE.Length == 1)
            {
                mesE = "0" + mesE;
            }
            añoE = fechaEntrada.Date.Year.ToString();


            txtFechaEntrada.Text = diaE + mesE + añoE;
            DateTime fechaSalida = c.FechaDeEntrada;
            string diaF = "";
            string mesF = "";
            string añoF = "";
            diaF = fechaSalida.Date.Day.ToString();
            if (diaF.Length == 1)
            {
                diaF = "0" + diaF;
            }
            mesF = fechaSalida.Date.Month.ToString();
            if (mesF.Length == 1)
            {
                mesF = "0" + mesF;
            }
            añoF = fechaSalida.Date.Year.ToString();


            txtFechaSalida.Text = diaF + mesF + añoF;
            cmbTipoDoc.SelectedValue = c.TipoDocumentoEmpleado;
            cmbSucursal.SelectedValue = c.Id_Sucursal;



        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cmbSucursal.SelectedIndex.ToString();
            ObtenerUltimaConsulta(a);
        }

        private void btnActualizarConsulta_Click(object sender, EventArgs e)
        {
            
            
            if (VerificarCamposLlenos())
            {
                Consulta p = ObtenerDatosConsulta();
                bool resultado = AD_Consulta.ActualizarConsulta(p);
                if (resultado)
                {
                    MessageBox.Show("Datos de la consulta actualizados con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    btnActualizarConsulta.Enabled = false;

                }
                else
                {
                    MessageBox.Show("No se pudieron actualizar los datos de la consulta con exito");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todos los campos.");
            }
            
        }

        private void btnEliminarConsulta_Click(object sender, EventArgs e)
        {
            Consulta p = ObtenerDatosConsulta();
            bool resultado = AD_Consulta.EliminarConsulta(p);
            CargarGrilla();
            if (resultado)
            {
                MessageBox.Show("La consulta ha sido eliminada del sistema con exito");
                LimpiarCampos();
                CargarGrilla();
                btnActualizarConsulta.Enabled = false;
                btnEliminarConsulta.Enabled = false;

            }
            else
            {
                MessageBox.Show("La consulta no se pudo eliminar del sistema con exito");
            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
