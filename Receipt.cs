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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            lblName.Text = "Caulan Peake";
            lblOrderID.Text = "10309";
            lblDate.Text = "4/2/2015";
            txtSubtotal.Text = "0.00";
            txtDiscount.Text = "0.00";
            txtTax.Text = "0.00";
            txtCharges.Text = "1.00";
            txtTotal.Text = "1.00";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOrderID_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
