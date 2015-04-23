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
    public partial class SearchVendor : Form
    {
        public SearchVendor()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Haloware Inc", "10389");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectVendor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
