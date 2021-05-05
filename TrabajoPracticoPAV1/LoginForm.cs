using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoPAV1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AD.AD_Usuarios.validarUsuario(txtNombreUsuario.Text, txtPassword.Text))
                {
                    Principal prin = new Principal(this);
                    prin.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al validar el usuario ingresado");
                throw;
            }

        }
    }
}
