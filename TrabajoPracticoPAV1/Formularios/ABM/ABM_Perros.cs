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

namespace TrabajoPracticoPAV1
{
    public partial class ABM_Perros : Form
    {
        public ABM_Perros()
        {
            InitializeComponent();
        }

        private void btnGuardarPerro_Click(object sender, EventArgs e)
        {
            Perro p = new Perro();
            p.NombrePerro = txtNombrePerro.Text.Trim();
            p.RazaPerro = (int)cmbRaza.SelectedValue;
            p.PesoPerro = int.Parse(txtPesoPerro.Text);
            if(rdMacho.Checked)
            {
                p.SexoPerro = 1;
            }
            else if(rdHembra.Checked)
            {
                p.SexoPerro = 2;
            }
            p.AlturaPerro = int.Parse(txtAlturaPerro.Text);
            p.FechaNacimientoPerro = DateTime.Parse(txtFechaNac.Text);
            p.HistoriaClinica = int.Parse(txtNroHistoriaClinica.Text);
            p.DueñoPerro = (int)cmbDueño.SelectedValue;
            p.Sucursal = (int)cmbSucursal.SelectedValue;
           
            //AgregarPerro(p);
            bool resultado = AD_Perros.AgregarPerroABD(p);
            if(resultado)
            {
                MessageBox.Show("Perro agrgado con exito");
                LimpiarCampos();
                CargarComboDueños();
                CargarComboRazas();
                CargarComboSucursales();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar perro");
            }
        }
        
        
        private void CargarGrilla()
        {
            try
            {
                gdrPerros.DataSource = AD_Perros.ObtenerListadoPerrosReducido();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener listado de perros");
            }

        }

        //private void AgregarPerro(Perro per)
        //{
        //    DataGridViewRow fila = new DataGridViewRow();

        //    DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
        //    celdaNombre.Value = per.NombrePerro;
        //    fila.Cells.Add(celdaNombre);

        //    DataGridViewTextBoxCell celdaPeso = new DataGridViewTextBoxCell();
        //    celdaPeso.Value = per.PesoPerro;
        //    fila.Cells.Add(celdaPeso);

        //    DataGridViewTextBoxCell celdaAltura = new DataGridViewTextBoxCell();
        //    celdaAltura.Value = per.AlturaPerro;
        //    fila.Cells.Add(celdaAltura);

        //    gdrPerros.Rows.Add(fila);
        //    LimpiarCampos();
        //    txtNombrePerro.Focus();
        //    MessageBox.Show("Perro agreagado con exito");
        //}
        private void ABM_Perros_Load(object sender, EventArgs e)
        {
            CargarComboRazas();
            CargarComboDueños();
            CargarComboSucursales();
            CargarGrilla();
        }

        private void CargarComboRazas()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Razas";

                cmd.Parameters.Clear();



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbRaza.DataSource = tabla;
                cmbRaza.DisplayMember = "Nombre";
                cmbRaza.ValueMember = "Id";
                cmbRaza.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }




        }
        private void CargarComboDueños()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Dueños";

                cmd.Parameters.Clear();



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbDueño.DataSource = tabla;
                cmbDueño.DisplayMember = "Nombre";
                cmbDueño.ValueMember = "Id";
                cmbDueño.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }




        }
        private void CargarComboSucursales()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Sucursales";

                cmd.Parameters.Clear();



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbSucursal.DataSource = tabla;
                cmbSucursal.DisplayMember = "Nombre";
                cmbSucursal.ValueMember = "Id";
                cmbSucursal.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }




        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
        private void LimpiarCampos()
        {
            txtNombrePerro.Text = "";
            txtPesoPerro.Text = "";
            rdMacho.Checked = true;
            txtAlturaPerro.Text = "";
            txtFechaNac.Text = "";
            txtNroHistoriaClinica.Text = "";
       }
    }
}
