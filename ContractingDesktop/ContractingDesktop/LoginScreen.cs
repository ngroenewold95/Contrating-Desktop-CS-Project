using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractingDesktop
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var splash = new Splash();
            splash.Closed += (s, args) => this.Close();
            splash.Show();
        }
    }
}
