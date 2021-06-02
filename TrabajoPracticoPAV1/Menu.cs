using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1;
using TrabajoPracticoPAV1.Formularios;
using TrabajoPracticoPAV1.Formularios.ABM;
using TrabajoPracticoPAV1.AD;
using TrabajoPracticoPAV1.Entidades;
using TrabajoPracticoPAV1.Formularios.Procesos;

namespace TrabajoPracticoPAV1
{
    public partial class Menu : Form
    {
        public Menu(Usuario usu)
        {
            InitializeComponent();
            personalizarMenu();
            lblBienvenido.Text = "Bienvenido " + usu.NombreDeUsuario;
        }

        private void personalizarMenu()
        {
            panel_submenu_ABM.Visible = false;
            panel_submenu_Procesos.Visible = false;
            panel_submenu_InformesEstadisticas.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panel_submenu_ABM.Visible == true)
            {
                panel_submenu_ABM.Visible = false;
            }
            if(panel_submenu_Procesos.Visible == true)
            {
                panel_submenu_Procesos.Visible = false;
            }
            if(panel_submenu_InformesEstadisticas.Visible == true)
            {
                panel_submenu_InformesEstadisticas.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panel_submenu_ABM);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Empleados formEmpleados = new ABM_Empleados();
            formEmpleados.ShowDialog();
            ocultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Sucursales formSucursales = new ABM_Sucursales();
            formSucursales.ShowDialog();
            ocultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Medicamentos ventana = new ABM_Medicamentos();
            ventana.ShowDialog();
            ocultarSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Razas ventana = new ABM_Razas();
            ventana.ShowDialog();
            ocultarSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Laboratorios ventana = new ABM_Laboratorios();
            ventana.ShowDialog();
            ocultarSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Sintomas ventana = new ABM_Sintomas();
            ventana.ShowDialog();
            ocultarSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Perros ventana_perros = new ABM_Perros();
            ventana_perros.ShowDialog();
            ocultarSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Usuarios ventana_Usu = new ABM_Usuarios();
            ventana_Usu.ShowDialog();
            ocultarSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Dueños ventana = new ABM_Dueños();
            ventana.ShowDialog();
            ocultarSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Vacunas ventana = new ABM_Vacunas();
            ventana.Show();
            ocultarSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Barrios formBarrios = new ABM_Barrios();
            formBarrios.ShowDialog();
            ocultarSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //mostrar formulario

            ocultarSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            ABM_Consultas ventana = new ABM_Consultas();
            ventana.Show();
            ocultarSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //mostrar formulario

            ocultarSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //mostrar formulario

            ocultarSubMenu();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panel_submenu_Procesos);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //mostrar formulario

            ocultarSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            FacturacionConsulta ventana = new FacturacionConsulta();
            ventana.ShowDialog();
            ocultarSubMenu();
        }

        private void btnInformesEstadisticas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panel_submenu_InformesEstadisticas);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            SubMenuReportes reportes = new SubMenuReportes();
            reportes.ShowDialog();
            ocultarSubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //mostrar formulario
            SubMenuEstadisticas estadisticas = new SubMenuEstadisticas();
            estadisticas.ShowDialog();
            ocultarSubMenu();
        }

        private void abrirFormularios()
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
