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
    public partial class Inventory : Form
    {
        bool Testing = false;

        public Inventory()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void NormalMode()
        {  
            txtItemName.Text = "iPhoney 68s";
            comboCategory.Text = "Electronics";
            textSKU.Text = "123456780";
            textModelNo.Text = "987-65-4320";
            textVendorID.Text = "2";
            textWidth.Text = ".3\"";
            textLength.Text = "2\"";
            textHeight.Text = "4\"";
            textWeight.Text = "Over 9000!";
            comboPriority.Text = "As Needed";
            textUnitsInStock.Text = "5";
            textUnitsOnOrder.Text = "10";
            textminUnits.Text = "5";
            textqtyPerUnit.Text = "1";
            textUnitPrice.Text = "$400.01";
            textBoxDescription.Text = "Made of cheap plastic, costs as much as a ticket to Disney Land";
            textBoxNotes.Text = "";
            orderByBox.Text = "Name";
            selectFilterBox.Text = "All";
            this.BackColor = Color.SeaGreen;
        }

        private void NormalMode_Click(object sender, EventArgs e)
        {
            NormalMode();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void AddMode()
        {
            if (btnAddMode.Text == "Save")
            {
                btnAddMode.Text = "Add Vendor";
                btnAddMode.ForeColor = Color.Black;
                cancelButton.Visible = false;
                panel1.Enabled = true;
                this.BackColor = Color.SeaGreen;
            }
            else
            {
                btnAddMode.Text = "Save";
                cancelButton.Visible = true;
                panel1.Enabled = false;
                btnAddMode.ForeColor = Color.MidnightBlue;
                cancelButton.ForeColor = Color.MidnightBlue;
                txtItemName.Text = "";
                comboCategory.Text = "Furniture";
                textSKU.Text = "";
                textModelNo.Text = "";
                textVendorID.Text = "";
                textWidth.Text = "";
                textLength.Text = "";
                textHeight.Text = "";
                textWeight.Text = "";
                comboPriority.Text = "High";
                textUnitsInStock.Text = "";
                textUnitsOnOrder.Text = "";
                textminUnits.Text = "";
                textqtyPerUnit.Text = "";
                textUnitPrice.Text = "";
                textBoxDescription.Text = "";
                textBoxNotes.Text = "";
                orderByBox.Text = "Name";
                selectFilterBox.Text = "All";
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
                btnEditMode.Text = "Save";
                txtItemName.Text = "iPhoney 68s";
                comboCategory.Text = "Electronics";
                textSKU.Text = "123456780";
                textModelNo.Text = "987-65-4320";
                textVendorID.Text = "2";
                textWidth.Text = ".3\"";
                textLength.Text = "2\"";
                textHeight.Text = "4\"";
                textWeight.Text = "Over 9000!";
                comboPriority.Text = "As Needed";
                textUnitsInStock.Text = "5";
                textUnitsOnOrder.Text = "10";
                textminUnits.Text = "5";
                textqtyPerUnit.Text = "1";
                textUnitPrice.Text = "$400.01";
                textBoxDescription.Text = "Made of cheap plastic, costs as much as a ticket to Disney Land";
                textBoxNotes.Text = "";
                orderByBox.Text = "Name";
                selectFilterBox.Text = "All";
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void General_Click(object sender, EventArgs e)
        {

        }

        private void dataGridItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            btnAddMode.Text = "Add Item";
            btnAddMode.ForeColor = Color.Black;
            cancelButton.Visible = false;
            panel1.Enabled = true;
            NormalMode();
        }
    }
}
