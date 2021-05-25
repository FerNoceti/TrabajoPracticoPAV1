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

namespace TrabajoPracticoPAV1.Formularios.Procesos
{
    public partial class FacturacionConsulta : Form
    {
        public FacturacionConsulta()
        {
            InitializeComponent();
        }

        private void FacturacionConsulta_Load(object sender, EventArgs e)
        {
            cargarComboSucursales();
            limpiarCampos();
            configurarGrillas();
            resetearBotones();
        }

        private void resetearBotones()
        {
            btnBuscarConsulta.Enabled = true;
            btnConfirmarFacturacion.Enabled = false;
            btnDeshacerFacturacion.Enabled = true;
        }

        private void cargarComboSucursales()
        {
            cmbSucursales.DataSource = AD_Varios.obtenerSucursales();
            cmbSucursales.DisplayMember = "Nombre";
            cmbSucursales.ValueMember = "Id";
            cmbSucursales.SelectedIndex = -1;
        }
        private void configurarGrillas()
        {
            foreach (DataGridViewColumn column in dgvDetalleDiagnosticos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in dgvDetalleDiagnosticos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void limpiarCampos()
        {

            // fecha
            txtFecha.Text = DateTime.Now.ToString();

            //NroConsulta
            txtNroConsulta.Text = "";

            try
            {
                //NroFactura
                txtNroFactura.Text = (AD_Facturas.obtenerUltimoNroFactura() + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el ultimo numero de factura");
            }

            cmbSucursales.SelectedIndex = -1;


            //Perro y Dueño
            txtNombrePerro.Text = "";
            txtNroHistoriaPerro.Text = "";

            txtNombreDueño.Text = "";
            txtApellidoDueño.Text = "";

            //Detalles de la Facturacion
            dgvDetalleDiagnosticos.DataSource = new DataTable();
            txtSubtotalDiagnosticos.Text = "";
            
            dgvDetalleMedicamentos.DataSource = new DataTable();
            txtSubtotalMedicamentos.Text = "";

            txtTotalAFacturar.Text = "";

        }

        private void btnDeshacerFacturacion_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cargarDatosPerro(Perro perro)
        {
            txtNombrePerro.Text = perro.NombrePerro;
            txtNroHistoriaPerro.Text = perro.HistoriaClinica.ToString();
        }

        private void cargarDatosDueño(Dueño dueño)
        {
            txtNombreDueño.Text = dueño.NombreDueño;
            txtApellidoDueño.Text = dueño.ApellidoDueño;
        }

        private void btnBuscarConsulta_Click(object sender, EventArgs e)
        {
            if (txtNroConsulta.Text.Equals("") || cmbSucursales.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese correctamente los datos antes de buscar");
            }
            else if (AD_Facturas.existeFactura(int.Parse(txtNroConsulta.Text))) 
            {
                MessageBox.Show("Ya se ha realizado la facturacion de la consulta solicitada");
            }
            else
            {
                try
                {
                    bool resultado = AD_Consulta.existeConsulta(int.Parse(txtNroConsulta.Text), int.Parse(cmbSucursales.SelectedValue.ToString()));
                    if(resultado)
                    {
                        Consulta consulta = AD_Consulta.ObtenerConsulta(txtNroConsulta.Text, cmbSucursales.SelectedValue.ToString());
                        Perro perro = AD_Perros.obtenerPerro(int.Parse(consulta.NroHistoriaClinica));
                        Dueño dueño = AD_Dueño.ObtenerDueño(perro.DueñoPerro.ToString());

                        cargarDatosPerro(perro);
                        cargarDatosDueño(dueño);

                        DataTable diagnosticos = AD_Diagnostico.obtenerDatosDiagnosticosPorConsulta(int.Parse(consulta.Id_Consulta));
                        DataTable medicamentos = AD_Medicamentos.obtenerMedicamentosPorConsulta(int.Parse(consulta.Id_Consulta));
                        
                        cargarGrillaDiagnosticos(diagnosticos);
                        cargarGrillaMedicamentos(medicamentos);
                        cargarTotalFacturacion();

                        btnConfirmarFacturacion.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No existe la consulta que intenta facturar");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar buscar el numero de consulta");
                }
            }
        }

        private void cargarTotalFacturacion()
        {
            txtTotalAFacturar.Text = (int.Parse(txtSubtotalMedicamentos.Text) + int.Parse(txtSubtotalDiagnosticos.Text)).ToString();
        }

        private void cargarGrillaMedicamentos(DataTable tabla)
        {
            dgvDetalleMedicamentos.DataSource = tabla;
            int precioUnidad = 0;
            int precioTotal = 0;
            for(int i = 0; i < dgvDetalleMedicamentos.Rows.Count; i++)
            {
                DataGridViewRow fila = dgvDetalleMedicamentos.Rows[i];
                precioUnidad = int.Parse(fila.Cells["PrecioUnidadMedicamento"].Value.ToString());
                precioTotal += precioUnidad;
            }

            txtSubtotalMedicamentos.Text = precioTotal.ToString();
        }

        private void cargarGrillaDiagnosticos(DataTable tabla)
        {
            try
            {
                dgvDetalleDiagnosticos.DataSource = tabla;
                int precioUnidad = 0;
                int precioTotal = 0;
                for (int i = 0; i < dgvDetalleDiagnosticos.Rows.Count; i++)
                {
                    DataGridViewRow fila = dgvDetalleDiagnosticos.Rows[i];
                    precioUnidad = int.Parse(fila.Cells["PrecioDiagnostico"].Value.ToString());
                    precioTotal += precioUnidad;
                }
                txtSubtotalDiagnosticos.Text = precioTotal.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnConfirmarFacturacion_Click(object sender, EventArgs e)
        {
            if(txtTotalAFacturar.Text.Equals("0"))
            {
                MessageBox.Show("No es posible facturar un monto nulo");
            }
            else
            {
                Factura factura = cargarDatosFactura();
                bool resultado = AD_Facturas.ingresarFacturaNueva(factura);
                if (resultado)
                {
                    MessageBox.Show("Datos de la Factura cargados exitosamente");
                    limpiarCampos();
                    resetearBotones();
                }
                else
                {
                    MessageBox.Show("Error inesperado al intentar guardar los datos de facturacion");
                }
            }
        }

        private Factura cargarDatosFactura()
        {
            Factura factura = new Factura();
            factura.NumeroFactura = int.Parse(txtNroFactura.Text);
            factura.IdConsulta = int.Parse(txtNroConsulta.Text);
            factura.FechaFactura = DateTime.Now;
            factura.IdTipoFactura = 2; //POR AHORA SOLO CONSIDERAMOS QUE LA VETERINARIA SOLO EMITE FACTURAS TIPO B

            return factura;
        }

        private void txtNroConsulta_TextChanged(object sender, EventArgs e)
        {
            resetearBotones();
        }
    }
}
