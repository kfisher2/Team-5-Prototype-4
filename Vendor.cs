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
    public partial class Vendor : Form
    {
        bool Testing = false;
        Email emailForm = null;

        public Vendor()
        {
            InitializeComponent();
            selectFilterBox.SelectedIndex = 2;
            orderByBox.SelectedIndex = 2;
            NormalMode();
            cancelButton.Visible = false;

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
            textShipStreet1.Text = "123 Midnight Dr";
            textShipStreet2.Text = "Suite 102";
            textShipState.Text = "Texas";
            textShipCity.Text = "San Antonio";
            textShipZip.Text = "78212";
            txtFirst.Text = "HaloWare Inc";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = "1 Semicolon Place";
            textBillSt2.Text = "#655";
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            maskedTextGenAccessed.Text = "02/19/2015";
            textContactNotes.Text = "Jordan has been our contact for HaloWare since 2013. Very friendly, good over the phone but slow to respond to e-mail. Previous Contact: Joe Hammerschmidt, retired 2013";
            txtContactFirst.Text = "Jordan";
            txtContactLast.Text = "Myers";
            txtContactPosition.Text = "NAM Sales Director";
            txtContactEmail.Text = "jmyers352@haloware.com";
            txtContactPhone1.Text = "281-555-8278";
            txtContactPhone2.Text = "281-555-7000";
            txtContactFax.Text = "281-555-7770";
            textVendorURL.Text = "haloware.wordpress.com";
            this.BackColor = Color.SeaGreen;
        }

        private void NormalMode_Click(object sender, EventArgs e)
        {
            NormalMode();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void clearText()
        {
            textShipStreet1.Text = "";
            textShipStreet2.Text = "";
            textShipState.Text = "";
            textShipCity.Text = "";
            textShipZip.Text = "";
            txtFirst.Text = "";
            textBillCity.Text = "";
            textBillSt1.Text = "";
            textBillSt2.Text = "";
            textBillZip.Text = "";
            textBillState.Text = "";
            maskedTextGenAccessed.Text = "";
            textContactNotes.Text = "";
            txtContactFirst.Text = "";
            txtContactLast.Text = "";
            txtContactPosition.Text = "";
            txtContactEmail.Text = "";
            txtContactPhone1.Text = "";
            txtContactPhone2.Text = "";
            txtContactFax.Text = "";
            textVendorURL.Text = "";

        }

        void AddMode()
        {
            if (btnAddMode.Text == "Save")
            {
                this.BackColor = Color.SeaGreen;
                btnAddMode.Text = "Add Vendor";
                btnAddMode.ForeColor = Color.Black;
                cancelButton.Visible = false;
                panel1.Enabled = true;
            }
            else
            {
                btnAddMode.Text = "Save";
                cancelButton.Visible = true;
                panel1.Enabled = false;
                btnAddMode.ForeColor = Color.MidnightBlue;
                cancelButton.ForeColor = Color.MidnightBlue;
                clearText();
                this.BackColor = Color.SteelBlue;
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

            }
            else
            {
                this.BackColor = Color.Firebrick;
                btnEditMode.Text = "Save";
                textShipStreet1.Text = "123 Midnight Dr";
                textShipStreet2.Text = "Suite 102";
                textShipState.Text = "Texas";
                textShipCity.Text = "San Antonio";
                textShipZip.Text = "78212";
                txtFirst.Text = "HaloWare Inc";
                textBillCity.Text = "San Antonio";
                textBillSt1.Text = "1 Semicolon Place";
                textBillSt2.Text = "#655";
                textBillZip.Text = "78212";
                textBillState.Text = "Texas";
                maskedTextGenAccessed.Text = "02/19/2015";
                textContactNotes.Text = "Jordan has been our contact for HaloWare since 2013. Very friendly, good over the phone but slow to respond to e-mail. Previous Contact: Joe Hammerschmidt, retired 2013";
                txtContactFirst.Text = "Jordan";
                txtContactLast.Text = "Myers";
                txtContactPosition.Text = "NAM Sales Director";
                txtContactEmail.Text = "jmyers352@haloware.com";
                txtContactPhone1.Text = "281-555-8278";
                txtContactPhone2.Text = "281-555-7000";
                txtContactFax.Text = "281-555-7770";
                textVendorURL.Text = "haloware.wordpress.com";
                this.BackColor = Color.Firebrick;
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
  
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            emailForm = new Email();
            emailForm.MdiParent = this.MdiParent;
            emailForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textShipCity.Text = textBillCity.Text;
                textShipStreet1.Text = textBillSt1.Text;
                textShipStreet2.Text = textBillSt2.Text;
                textShipState.Text = textBillState.Text;
                textShipZip.Text = textBillZip.Text;
            }
            else
            {
                textShipCity.Text = "";
                textShipStreet1.Text = "";
                textShipStreet2.Text = "";
                textShipState.Text = "";
                textShipZip.Text = "";
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            btnAddMode.Text = "Add Vendor";
            btnAddMode.ForeColor = Color.Black;
            cancelButton.Visible = false;
            panel1.Enabled = true;
            NormalMode();
        }
    }
}
