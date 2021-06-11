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
    public partial class ABM_Usuarios : Form
    {
        public ABM_Usuarios()
        {
            InitializeComponent();
        }
        private void ABM_Usuarios_Load(object sender, EventArgs e)
            
        {
            LimpiarCampos();
            CargarGrilla();
            CargarFecha();
            CargarComboTiposUsuarios();
          
        }
        private void CargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void CargarGrilla()
        {
            try
            {
                grillaUsuarios.DataSource = AD_Usuarios.ObtenerListadoUsuarios();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener listado de usuarios");
            }

        }
        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtRepetirContraseña.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario");
            }
            else
            {
                if (txtContraseña.Text.Equals(txtRepetirContraseña.Text))
                {
                    try
                    {
                        bool resultado = AD_Usuarios.InsertarUsuario(txtNombreUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtFecha.Text,(int)cmbTiposUsuario.SelectedValue);
                        if (resultado)
                        {
                            MessageBox.Show("Usuario dado de alta con exito");
                            LimpiarCampos();
                            //txtNombreUsuario.Focus();
                            CargarGrilla();
                            txtNombreUsuario.Focus();


                        }
                        else
                        {
                            MessageBox.Show("Error al insertar nuevo usuario");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al introducir al nuevo usuario");
                        txtNombreUsuario.Focus();

                    }

                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }




        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
       
        private void CargarComboTiposUsuarios()
        {
            string cadenaDB = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaDB);
            
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TipoUsuarios";

                cmd.Parameters.Clear();
               


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbTiposUsuario.DataSource = tabla;
                cmbTiposUsuario.DisplayMember = "Nombre";
                cmbTiposUsuario.ValueMember = "Id";
                cmbTiposUsuario.SelectedIndex = -1;
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
    }
}
