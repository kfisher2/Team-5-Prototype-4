using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaseToBuy
{
    public partial class Login : Form
    {
        MainWindow menuForm = null;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.MdiParent.MainMenuStrip.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textUsername.Text = "THicks";
            textPass.Text = "*****";
        }
    }
}
