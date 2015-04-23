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
    public partial class PurchaseOrders : Form
    {
        bool Testing = false;
        Vendor vendorForm = null;
        Undelete undeleteForm = null;

        public PurchaseOrders()
        {
            InitializeComponent();
            selectFilterBox.SelectedIndex = 2;
            orderByBox.SelectedIndex = 2;
            NormalMode();
            groupBoxTracking.Hide();
            recievedBox.Hide();
            recievedLabel.Hide();
            timeLabel.Hide();
            timeCalcLabel.Hide();
            cancelButton.Visible = false;
            btnFindVendor.Visible = false;
            vendorID.Text = "10389";
            vendorName.Text = "Haloware Inc.";
            vendorContactName.Text = "Jordan Myers";
            vendorContactPhone.Text = "281-555-8278";
            vendorURL.Text = "haloware.wordpress.com";
            shipName.Text = "John Smith";
            shipCity.Text = "Austin";
            shipSt1.Text = "947 Rainbow Road Dr.";
            shipSt2.Text = "Docking Station C";
            shipState.Text = "Texas";
            shipZip.Text = "78704";

            if (!Testing)
            {
                //btnAddMode.Visible = false;
                //btnEditMode.Visible = false;
                //btnNormalMode.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        void NormalMode()
        {
            this.BackColor = Color.SeaGreen;
            checkBoxSent.Visible = true;
            checkBoxRecieved.Visible = true;
            checkBoxSent.Enabled = false;
            checkBoxRecieved.Enabled = false;

        }

        void NormalText()
        {
            vendorID.Text = "10389";
            vendorName.Text = "Haloware Inc.";
            vendorContactName.Text = "Jordan Myers";
            vendorContactPhone.Text = "281-555-8278";
            vendorURL.Text = "haloware.wordpress.com";
            shipName.Text = "John Smith";
            shipCity.Text = "Austin";
            shipSt1.Text = "947 Rainbow Road Dr.";
            shipSt2.Text = "Docking Station C";
            shipState.Text = "Texas";
            shipZip.Text = "78704";
        }

        private void NormalMode_Click(object sender, EventArgs e)
        {
            NormalMode();
            NormalText();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void AddMode()
        {
            if (btnAddMode.Text == "Save")
            {
                btnAddMode.Text = "Add Order";
                btnAddMode.ForeColor = Color.Black;
                cancelButton.Visible = false;
                panel1.Enabled = true;
                NormalMode();
            }
            else
            {
                this.BackColor = Color.SteelBlue;
                vendorID.Text = "";
                vendorName.Text = "";
                vendorContactName.Text = "";
                vendorContactPhone.Text = "";
                vendorURL.Text = "";
                shipName.Text = "";
                shipCity.Text = "";
                shipSt1.Text = "";
                shipSt2.Text = "";
                shipState.Text = "";
                shipZip.Text = "";
                btnOpenVendor.Visible = false;
                vendorLogo.Visible = false;
                lbVendorContactName.Visible = false;
                lbVendorContactPhone.Visible = false;
                lbVendorName.Visible = false;
                lbVendorURL.Visible = false;
                vendorContactPhone.Visible = false;
                btnFindVendor.Visible = true;
                btnAddMode.Text = "Save";
                btnAddMode.ForeColor = Color.MidnightBlue;
                cancelButton.ForeColor = Color.MidnightBlue; ;
                cancelButton.Visible = true;
                panel1.Enabled = false;
                checkBoxSent.Visible = false;
                checkBoxRecieved.Visible = false;
                groupBoxTracking.Visible = false;
                btnAddMode.Enabled = true;
                btnEditMode.Enabled = true;
                btnNormalMode.Enabled = true;
                checkBoxSent.Enabled = true;
                checkBoxRecieved.Enabled = true;
            }

        }

        private void btnAddMode_Click(object sender, EventArgs e)
        {

            AddMode();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            //this.BackColor = Color.PeachPuff;
        }

        private void txtStreet1_TextChanged(object sender, EventArgs e)
        {
            //this.BackColor = Color.PeachPuff;
        }

        void EditMode()
        {
            if (btnEditMode.Text == "Save")
            {
                btnEditMode.Text = "Edit Mode";
                this.BackColor = Color.SeaGreen;
                checkBoxSent.Enabled = false;
                checkBoxRecieved.Enabled = false;

            }
            else
            {
                this.BackColor = Color.Firebrick;
                btnEditMode.Text = "Save";
                checkBoxSent.Enabled = true;
                checkBoxRecieved.Enabled = true;
                vendorID.Text = "10389";
                vendorName.Text = "Haloware Inc.";
                vendorContactName.Text = "Jordan Myers";
                vendorContactPhone.Text = "281-555-8278";
                vendorURL.Text = "haloware.wordpress.com";
                shipName.Text = "John Smith";
                shipCity.Text = "Austin";
                shipSt1.Text = "947 Rainbow Road Dr.";
                shipSt2.Text = "Docking Station C";
                shipState.Text = "Texas";
                shipZip.Text = "78704";
            }

        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            EditMode();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMode();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtStreet2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void GeneralInformation_Click(object sender, EventArgs e)
        {

        }

        private void textBillSt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("0821", "AiGuru SV1", "Laptop", "$679.85", "100", "-", "$679.85", "$679.85", "4/22/15","Electronics","Laptop");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxSent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSent.Checked)
            {
                groupBoxTracking.Show();

            }
            else
            {
                groupBoxTracking.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxRecieved_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRecieved.Checked) {
                recievedBox.Show();
                recievedLabel.Show();
                timeLabel.Show();
                timeCalcLabel.Show();
            }
            else
            {
                recievedBox.Hide();
                recievedLabel.Hide();
                timeLabel.Hide();
                timeCalcLabel.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            vendorForm = new Vendor();
            vendorForm.MdiParent = this.MdiParent;
            vendorForm.Show();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Navigate("haloware.wordpress.com");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnAddMode.Text = "Add Order";
            btnAddMode.ForeColor = Color.Black;
            cancelButton.ForeColor = Color.Black;
            cancelButton.Visible = false;
            btnOpenVendor.Visible = true;
            vendorLogo.Visible = true;
            lbVendorContactName.Visible = true;
            lbVendorContactPhone.Visible = true;
            lbVendorName.Visible = true;
            lbVendorURL.Visible = true;
            vendorContactPhone.Visible = true;
            btnFindVendor.Visible = false;
            NormalMode();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnAddMode.Text = "Add Order";
            btnAddMode.ForeColor = Color.Black;
            cancelButton.ForeColor = Color.Black;
            cancelButton.Visible = false;
            NormalMode();
            this.BackColor = Color.SeaGreen;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditMode.Text = "Edit Mode";
            this.BackColor = Color.SeaGreen;
            checkBoxSent.Enabled = false;
            checkBoxRecieved.Enabled = false;
            btnAddMode.Text = "Add Order";
            btnAddMode.ForeColor = Color.Black;
            cancelButton.Visible = false;
            panel1.Enabled = true;
            NormalMode();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormalMode();
            NormalText();
            MessageBox.Show("Delete Successful");

        }

        private void undeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undeleteForm = new Undelete();
            undeleteForm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMode();
        }

        private void General_Click(object sender, EventArgs e)
        {

        }
    }
}
