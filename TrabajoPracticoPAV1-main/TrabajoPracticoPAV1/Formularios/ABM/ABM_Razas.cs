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
    public partial class ABM_Razas : Form
    {
        public ABM_Razas()
        {
            InitializeComponent();
        }

        private void ABM_Razas_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            CargarGrilla();
        }
        private void LimpiarCampos()
        {
            txtNombreRaza.Text = "";
            txtPesoMaxHembra.Text = "";
            txtPesoMinHembra.Text = "";
            txtAlturaHembra.Text = "";
            txtAlturaMacho.Text = "";
            txtPesoMinMacho.Text = "";
            txtPesoMaxMacho.Text = "";
            txtNotaCuidados.Text = "";

            txtIdRaz.Text = "-1";
            txtIdRaz.Visible = false;

            btnActualizarRaz.Enabled = false;
            btnBorrarRaz.Enabled = false;

        }
        private void CargarGrilla()
        {

            try
            {
                gdrRazas.DataSource = AD_Razas.ObtenerListadoRazas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener medicamentos");
            }

        }

        private void btnGuardarRaza_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable tablaResultado = AD_Razas.ObtenerRazaPorNombre(txtNombreRaza.Text);
                if (tablaResultado.Rows.Count > 0)
                {
                    MessageBox.Show("Nombre de raza ya existe");
                }
                else
                {
                    Razas r = ObtenerDatosRazas();
                    bool resultado = AD_Razas.AgregarRazaBD(r);
                    if (resultado)
                    {
                        MessageBox.Show("Raza agregada con éxito");
                        LimpiarCampos();
                        CargarGrilla();
                        txtNombreRaza.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Error al insertar raza");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener nombre de raza");
            }
        }
        private Razas ObtenerDatosRazas()
        {
            Razas r = new Razas();

            r.Id_Razas = int.Parse(txtIdRaz.Text);

            if (txtNombreRaza.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
            }
            else
            {
                r.NombreRaza = txtNombreRaza.Text.Trim(); //guarda sin espacios al final o principio
            }

            r.NotaCuidadosRazas = txtNotaCuidados.Text.Trim();

            if (txtPesoMinHembra.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el peso minimo de la hembra");
            }
            else
            {
                r.PesoMinimoHembras = (float.Parse(txtPesoMinHembra.Text));
            }

            if (txtPesoMaxHembra.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el peso maximo de la hembra");
            }
            else
            {
                r.PesoMaximoHembras = (float.Parse(txtPesoMaxHembra.Text));
            }

            if (txtPesoMinMacho.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el peso minimo del macho");
            }
            else
            {
                r.PesoMinimoMachos = (float.Parse(txtPesoMinMacho.Text));
            }

            if (txtPesoMaxMacho.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el peso maximo del macho");
            }
            else
            {
                r.PesoMaximoMachos = (float.Parse(txtPesoMaxMacho.Text));
            }

            if (txtAlturaHembra.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la altura media de la hembra");
            }
            else
            {
                r.AltumaMediaHembras = (int.Parse(txtAlturaHembra.Text));
            }

            if (txtAlturaMacho.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la altura media del macho");
            }
            else
            {
                r.AlturaMediaMachos = (int.Parse(txtAlturaMacho.Text));
            }

            return r;
        }

        private void btnBorrarRaz_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Razas.ObtenerRazaPorId(int.Parse(txtIdRaz.Text.Trim()));
                if (tablaResultado.Rows.Count > 0)
                {
                    Razas r = ObtenerDatosRazas();
                    r.Id_Razas = int.Parse(txtIdRaz.Text);
                    bool resultado = AD_Razas.EliminarRaza(r);
                    if (resultado)
                    {
                        MessageBox.Show("Raza eliminada con éxito");
                        LimpiarCampos();
                        CargarGrilla();
                      
                        txtNombreRaza.Focus();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar raza");
            }
        }

        private void txtPesoMinHembra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            SoloFloat(txtPesoMinHembra.Text, e);
        }

        private void txtPesoMaxHembra_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFloat(txtPesoMaxHembra.Text, e);
        }

        private void txtPesoMinMacho_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFloat(txtPesoMinMacho.Text, e);
        }

        private void txtPesoMaxMacho_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFloat(txtPesoMaxMacho.Text, e);
        }

        private void SoloFloat(string a, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && a.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void btnLimpiarDatosRaz_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnActualizarRaz_Click(object sender, EventArgs e)
        {
            Razas r = ObtenerDatosRazas();
            bool resultado = AD_Razas.ActualizarRaza(r);
            if (resultado)
            {
                MessageBox.Show("Raza actualizada correctamente");
                LimpiarCampos();
                CargarGrilla();

            }
            else
            {
                MessageBox.Show("Error al actualizar raza");
            }
        }

        private void gdrRazas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarRaz.Enabled = true;

            try
            {
                DataGridViewRow filaSeleccionada = gdrRazas.Rows[indice];
                string id = filaSeleccionada.Cells["Id"].Value.ToString();
                txtIdRaz.Text = id;
                Razas r = AD_Razas.ObtenerRaza(int.Parse(id));
                //LimpiarCampos();
                CargarCampos(r);
                txtIdRaz.Visible = true;
                btnBorrarRaz.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Toque sobre una raza");
            }
        }

        private void CargarCampos(Razas r)
        {
            txtIdRaz.Text = r.Id_Razas.ToString();
            txtNombreRaza.Text = r.NombreRaza;
            txtPesoMinHembra.Text = r.PesoMinimoHembras.ToString();
            txtPesoMinMacho.Text = r.PesoMinimoMachos.ToString();
            txtPesoMaxHembra.Text = r.PesoMaximoHembras.ToString();
            txtPesoMaxMacho.Text = r.PesoMaximoMachos.ToString();
            txtAlturaHembra.Text = r.AltumaMediaHembras.ToString();
            txtAlturaMacho.Text = r.AlturaMediaMachos.ToString();
            txtNotaCuidados.Text = r.NotaCuidadosRazas;

        }

        
    }
}
