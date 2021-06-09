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
using TrabajoPracticoPAV1.Entidades;

namespace TrabajoPracticoPAV1.Formularios.ABM
{
    public partial class ABM_Consultas : Form
    {
        private bool formCargado = false;
        private int indiceDiagSelec;
        private int indiceMedSelec;

        public ABM_Consultas()
        {
            InitializeComponent();
        }

        private void ABM_Consultas_Load(object sender, EventArgs e)
        {
            CargarCombosSucursal();
            resetearBotones();
            LimpiarCampos();
            resetearComboSucursal();
            resetearCombEmpleado();
            CargarGrilla();
            cargarComboMedicamentos();
            cargarComboDiagnosticos();
            limpiarCamposMedicamentos();
            limpiarCamposDagnosticos();
            resetearBotonesMedicamentos();
            resetearBotonesDiagnosticos();
            formCargado = true;
        }

        private void limpiarCamposMedicamentos()
        {
            resetearComboMedicamentos();
            txtCantidadMedicamento.Text = "";
        }

        private void limpiarCamposDagnosticos()
        {
            resetearComboDiagnosticos();

        }

        private void resetearBotonesMedicamentos()
        {
            btnAgregarMedicamento.Enabled = true;
            btnEliminarMedicamento.Enabled = false;
            btnModificarMedicamento.Enabled = false;

        }

        private void resetearBotonesDiagnosticos()
        {
            btnAgregarDiagnosticos.Enabled = true;
            btnEliminarDiagnostico.Enabled = false;
            btnModificarDiagnostico.Enabled = false;
        }

        private void cargarComboDiagnosticos()
        {
            cmbDiagnosticos.DataSource = AD_Diagnostico.obtenerDatosDiagnosticos();
            cmbDiagnosticos.DisplayMember = "Descripcion";
            cmbDiagnosticos.ValueMember = "Id";
            cmbDiagnosticos.SelectedIndex = -1;
        }

        private void resetearComboDiagnosticos()
        {
            cmbDiagnosticos.SelectedIndex = -1;
        }

        private void cargarComboMedicamentos()
        {
            cmbMedicamentos.DataSource = AD_Medicamentos.obtenerDatosMedicamentos();
            cmbMedicamentos.DisplayMember = "Descripcion";
            cmbMedicamentos.ValueMember = "Id";
            cmbMedicamentos.SelectedIndex = -1;
        }

        private void resetearComboMedicamentos()
        {
            cmbMedicamentos.SelectedIndex = -1;
        }

        private void resetearBotones()
        {
            btnActualizarConsulta.Enabled = false;
            btnEliminarConsulta.Enabled = false;
        }

        private void resetearCombEmpleado()
        {
            cmbEmpleados.SelectedIndex = -1;
        }

        private void resetearComboSucursal()
        {
            cmbSucursal.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            txtIdConsulta.Text = "";
            //txtHistoriaClinica.Text = "";
            txtNumeroDoc.Text = "";
            txtFechaEntrada.Text = "";
            txtFechaSalida.Text = "";
            txtTipoDoc.Text = ""; //cmbTipoDoc.SelectedIndex = -1;
            resetearComboSucursal();
            resetearCombEmpleado();


        }
        private bool VerificarCamposLlenos()
        {
            if (cmbSucursal.SelectedIndex != -1 && txtIdConsulta.Text.Length > 0
                && txtNumeroDoc.Text.Length >0 /*&& txtHistoriaClinica.Text.Length > 0*/ 
                && !(txtFechaEntrada.Text.Equals("  /  /")) && !(txtFechaSalida.Text.Equals("  /  /"))
                && txtTipoDoc.Text.Length > 0 && cmbPerros.SelectedIndex != -1
                /*&& cmbTipoDoc.SelectedIndex != -1*/)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //private void CargarComboTipoDoc()
        //{
        //    try
        //    {
        //        //cmbTipoDoc.DataSource = AD_Consulta.ObtenerTipoDocumento();
        //        //cmbTipoDoc.DisplayMember = "Nombre";
        //        //cmbTipoDoc.ValueMember = "Id";
        //        //cmbTipoDoc.SelectedIndex = -1;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
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
                if (dgvDiagnosticosSelec.Rows.Count == 0 || dgvMedicamentosSelec.Rows.Count == 0)
                {
                    DialogResult resultadoU = MessageBox.Show("¿Omitir medicamentos y diagnosticos?", "Atencion", MessageBoxButtons.YesNo);
                    if (resultadoU == System.Windows.Forms.DialogResult.Yes)
                    {
                        guardarConsulta();
                    }

                }
                else
                {
                    guardarConsulta();
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todos los campos.");

            }
                
            
        }

        private void guardarConsulta()
        {
            Consulta consulta = ObtenerDatosConsulta();
            if (dgvDiagnosticosSelec.Rows.Count == 0 || dgvMedicamentosSelec.Rows.Count == 0)
            {
                AD_Consulta.AgregarPersonaABD(consulta);
            }
            else
            {
                List<MedicamentoPorConsulta> medicamentos = ObtenerDatosMedicamentosPorConsulta();
                List<DiagnosticoPorConsulta> diagnosticos = ObtenerDatosDiagnosticosPorConsulta();
                bool resultOp = AD_Consulta.AgregarPersonaABD(consulta, medicamentos, diagnosticos);

                if(resultOp)
                {
                    MessageBox.Show("Consulta guardada con exito.");
                    LimpiarCampos();
                    resetearComboSucursal();
                    resetearCombEmpleado();
                    resetearBotones();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Se produjo un error mientras se intentaba guardar los datos");
                }
            }



        }

        private List<DiagnosticoPorConsulta> ObtenerDatosDiagnosticosPorConsulta()
        {
            List<DiagnosticoPorConsulta> listDiag = new List<DiagnosticoPorConsulta>();
            for (int i = 0; i < dgvDiagnosticosSelec.Rows.Count; i++)
            {
                DiagnosticoPorConsulta diag = new DiagnosticoPorConsulta();
                diag.IdDiagnostico = int.Parse(dgvDiagnosticosSelec.Rows[i].Cells["CodDiagnostico"].Value.ToString());

                listDiag.Add(diag);
            }

            return listDiag;
        }

        private List<MedicamentoPorConsulta> ObtenerDatosMedicamentosPorConsulta()
        {
            List<MedicamentoPorConsulta> listMed = new List<MedicamentoPorConsulta>();
            for (int i = 0; i < dgvMedicamentosSelec.Rows.Count; i++)
            {
                MedicamentoPorConsulta med = new MedicamentoPorConsulta();
                med.IdMedicamento = int.Parse(dgvMedicamentosSelec.Rows[i].Cells["CodMedicamento"].Value.ToString());
                med.Dosis = int.Parse(txtCantidadMedicamento.Text);
                med.Periodicidad = 1; // SE PODRA EXPANDIR SI ES NECESARIO, EN NUEVAS ACTUALIZACIONES

                listMed.Add(med);
            }
            return listMed;

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
            p.NroHistoriaClinica = cmbPerros.SelectedValue.ToString();/*txtHistoriaClinica.Text.Trim();*/
            p.TipoDocumentoEmpleado = int.Parse(txtTipoDoc.Text); //p.TipoDocumentoEmpleado = (int)cmbTipoDoc.SelectedValue;
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

        private void CargarConsultas(Consulta c)
        {
            txtIdConsulta.Text = c.Id_Consulta;
            //txtHistoriaClinica.Text = c.NroHistoriaClinica;
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
            txtTipoDoc.Text = (c.TipoDocumentoEmpleado).ToString();
            cmbSucursal.SelectedValue = c.Id_Sucursal;



        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSucursal.SelectedIndex != -1 && formCargado)
            {
                try
                {
                    string a = cmbSucursal.SelectedValue.ToString();
                    ObtenerUltimaConsulta(a);
                    cargarComboEmpleados(int.Parse(cmbSucursal.SelectedValue.ToString()));
                    cargarComboPerros(int.Parse(cmbSucursal.SelectedValue.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos de la sucursal seleccionada");
                    //throw ex;
                }
            }
        }

        private void cargarComboPerros(int idSucursal)
        {
            try
            {
                cmbPerros.DataSource = AD_Perros.obtenerPerrosPorSucursal(idSucursal);
                cmbPerros.DisplayMember = "Nombre";
                cmbPerros.ValueMember = "NroHistoriaClinica";
                cmbPerros.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarComboEmpleados(int idSucursal)
        {
            try
            {
                cmbEmpleados.DataSource = AD_Empleados.obtenerDatosEmpleadosPorSucursal(idSucursal);
                cmbEmpleados.DisplayMember = "Nombre";
                cmbEmpleados.SelectedIndex = -1;
                LimpiarCamposEmpleado();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            limpiarCamposDagnosticos();
            resetearGrillaDiagnosticos();
            limpiarCamposMedicamentos();
            resetearGrillaMedicamentos();
            
        }

        private void resetearGrillaMedicamentos()
        {
            dgvMedicamentosSelec.Rows.Clear();
        }

        private void resetearGrillaDiagnosticos()
        {
            dgvDiagnosticosSelec.Rows.Clear();
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEmpleados.SelectedIndex != -1 )
            {
                cargarCamposEmpleado();
            }
            else
            {
                LimpiarCamposEmpleado();
            }
        }

        private void LimpiarCamposEmpleado()
        {
            txtNumeroDoc.Text = "";
            txtTipoDoc.Text = "";
        }

        private void cargarCamposEmpleado()
        {
            DataTable tabla = (DataTable)cmbEmpleados.DataSource;
            DataRow fila = tabla.Rows[cmbEmpleados.SelectedIndex];
            //txtTipoDoc.Text = tabla.Rows[cmbEmpleados.SelectedIndex][1];
            txtTipoDoc.Text = fila[1].ToString();
            txtNumeroDoc.Text = fila[2].ToString();
        }

        private void btnModificarDiagnostico_Click(object sender, EventArgs e)
        {
            dgvDiagnosticosSelec.Rows[indiceDiagSelec].Cells[0].Value = cmbDiagnosticos.SelectedValue.ToString();
            dgvDiagnosticosSelec.Rows[indiceDiagSelec].Cells[1].Value = cmbDiagnosticos.Text;
            resetearBotonesDiagnosticos();
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            if (cmbMedicamentos.SelectedIndex != -1 && txtCantidadMedicamento.Text != "" 
                && txtCantidadMedicamento.Text != "0" && noRepiteMedicamento())
            {
                dgvMedicamentosSelec.Rows.Add(1);
                int cantFilas = dgvMedicamentosSelec.Rows.Count;
                dgvMedicamentosSelec.Rows[cantFilas -1].Cells[0].Value = cmbMedicamentos.SelectedValue.ToString();
                dgvMedicamentosSelec.Rows[cantFilas -1].Cells[1].Value = cmbMedicamentos.Text;
                dgvMedicamentosSelec.Rows[cantFilas -1].Cells[2].Value = txtCantidadMedicamento.Text;

                resetearBotonesMedicamentos();

            }
            else
            {
                MessageBox.Show("Complete todos los campos del medicamento que quiere ingresar");
            }
        }

        private bool noRepiteMedicamento()
        {
            for (int i = 0; i < dgvMedicamentosSelec.Rows.Count; i++)
            {
                if (dgvMedicamentosSelec.Rows[i].Cells[0].Value.ToString().Equals(cmbMedicamentos.SelectedValue.ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnAgregarDiagnosticos_Click(object sender, EventArgs e)
        {
            if (cmbDiagnosticos.SelectedIndex != -1 && noRepiteDiagnostico())
            {
                dgvDiagnosticosSelec.Rows.Add(1);
                int cantFilas = dgvDiagnosticosSelec.Rows.Count;
                dgvDiagnosticosSelec.Rows[cantFilas - 1].Cells[0].Value = cmbDiagnosticos.SelectedValue.ToString();
                dgvDiagnosticosSelec.Rows[cantFilas - 1].Cells[1].Value = cmbDiagnosticos.Text;

                resetearBotonesDiagnosticos();
            }
            else
            {
                MessageBox.Show("Complete todos los campos del diagnostico que quiere ingresar");
            }
        }

        private bool noRepiteDiagnostico()
        {
            for (int i = 0; i < dgvDiagnosticosSelec.Rows.Count; i++)
            {
                if (dgvDiagnosticosSelec.Rows[i].Cells[0].Value.ToString().Equals(cmbDiagnosticos.SelectedValue.ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        private void dgvMedicamentosSelec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvMedicamentosSelec.Rows[e.RowIndex];
                cmbMedicamentos.SelectedValue = fila.Cells[0].Value.ToString();
                txtCantidadMedicamento.Text = fila.Cells[2].Value.ToString();

                this.indiceMedSelec = e.RowIndex;

                btnEliminarMedicamento.Enabled = true;
                btnModificarMedicamento.Enabled = true;
            }
        }

        private void dgvDiagnosticosSelec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvDiagnosticosSelec.Rows[e.RowIndex];
                cmbDiagnosticos.SelectedValue = fila.Cells[0].Value.ToString();

                this.indiceDiagSelec = e.RowIndex;

                btnModificarDiagnostico.Enabled = true;
                btnEliminarDiagnostico.Enabled = true;
            }
        }

        private void btnEliminarMedicamento_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMedicamentosSelec.Rows.Count; i++)
            {
                DataGridViewRow fila = dgvMedicamentosSelec.Rows[i];
                if(fila.Cells[0].Value.ToString().Equals(cmbMedicamentos.SelectedValue.ToString()))
                {
                    dgvMedicamentosSelec.Rows.Remove(fila);
                }
            }

            resetearBotonesMedicamentos();
        }

        private void btnModificarMedicamento_Click(object sender, EventArgs e)
        {
            dgvMedicamentosSelec.Rows[indiceMedSelec].Cells[0].Value = cmbMedicamentos.SelectedValue.ToString();
            dgvMedicamentosSelec.Rows[indiceMedSelec].Cells[1].Value = cmbMedicamentos.Text;
            dgvMedicamentosSelec.Rows[indiceMedSelec].Cells[2].Value = txtCantidadMedicamento.Text;
            resetearBotonesMedicamentos();
        }

        private void btnEliminarDiagnostico_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDiagnosticosSelec.Rows.Count; i++)
            {
                DataGridViewRow fila = dgvDiagnosticosSelec.Rows[i];
                if (fila.Cells[0].Value.ToString().Equals(cmbDiagnosticos.SelectedValue.ToString()))
                {
                    dgvDiagnosticosSelec.Rows.Remove(fila);
                }
            }

            resetearBotonesDiagnosticos();
        }


    }
}
