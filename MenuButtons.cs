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
    public partial class MenuButtons : Form
    {     
        Inventory inventoryForm = null;
        Login loginForm = null;
        User userForm = null;

        public MenuButtons()
        {
            InitializeComponent();
           
        }

        private void btnUserSubSystem_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuButtons_Load(object sender, EventArgs e)
        {

        }

        private void btnInventorySubSystem_Click(object sender, EventArgs e)
        {
            inventoryForm = new Inventory();
            inventoryForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginForm = new Login();
            loginForm.Show();
        }

        private void btnVendorSubSystem_Click(object sender, EventArgs e)
        {
            userForm = new User();
            userForm.Show();
        }
    }
}
