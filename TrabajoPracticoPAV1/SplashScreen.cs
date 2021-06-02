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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            prbSplashScreen.Increment(5);
   
            if (prbSplashScreen.Value == 100)
            {
                timer1.Enabled = false;
                LoginVeterinaria login = new LoginVeterinaria(this);
                login.Show();
                this.Hide();

            }
        }
    }
}
