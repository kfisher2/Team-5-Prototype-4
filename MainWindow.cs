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
    public partial class MainWindow : Form
    {
        Inventory inventoryForm = null;
        Login loginForm = null;
        User userForm = null;
        Vendor vendorForm = null;
        PurchaseOrders purchaseForm = null;
        SalesOrders salesForm = null;

        public MainWindow()
        {
            InitializeComponent();

            loginForm = new Login();
            loginForm.MdiParent = this;
            MainMenuStrip = menuStrip1;
            MainMenuStrip.Hide();
            loginForm.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void inventorySubsystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryForm = new Inventory();
            inventoryForm.MdiParent = this;
            inventoryForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userForm = new User();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendorForm = new Vendor();
            vendorForm.MdiParent = this;
            vendorForm.Show();
        }

        private void menuStripInventory_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void purchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseForm = new PurchaseOrders();
            purchaseForm.MdiParent = this;
            purchaseForm.Show();
        }

        private void salesOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesForm = new SalesOrders();
            salesForm.MdiParent = this;
            salesForm.Show();
        }

        private void userBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm = new Login();
            loginForm.MdiParent = this;
            loginForm.Show();
            MainMenuStrip.Hide();
        }
    }
}
