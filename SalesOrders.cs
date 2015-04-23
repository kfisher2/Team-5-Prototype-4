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
    public partial class SalesOrders : Form
    {
        bool Testing = false;
        User userForm = null;
        Receipt receiptForm = null;
        UndeleteSale undeleteForm = null;

        public SalesOrders()
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
            this.BackColor = Color.SeaGreen;
            txtuserName.Text = "Caulan Peake";
            txtuserID.Text = "12354";
            txtBillingStreet1.Text = "1 Trinity Place";
            txtBillingCity.Text = "San Antonio";
            comboBoxBillingState.SelectedIndex = 42;
            txtBillingZip.Text = "78212";
            txtShippingStreet1.Text = "1 Trinity Place";
            txtShippingCity.Text = "San Antonio";
            comboBoxShippingState.SelectedIndex = 42;
            txtShippingZip.Text = "78212";

            txtOrderNum.Text = "10309";
            txtDateOrdered.Text = "4/2/2015";
            txtSalesperson.Text = "Hicksies, T";
            comboBoxStatus.SelectedIndex = 1;
            txtSubtotal.Text = "0.00";
            txtDiscount.Text = "0.00";
            txtTax.Text = "0.00";
            txtCharges.Text = "1.00";
            txtTotal.Text = "1.00";

            lblName.Text = "Caulan Peake";
            comboBoxItemsCategory.SelectedIndex = 0;

            lblNameCard.Text = "Caulan Peake";
            maskedTxtCardNum.Text = "000000000000000000";
            maskedTxtEprDate.Text = "12/16";
            txtPin.Text = "0000";
            txtCardType.Text = "Visa";
            txtCardHolderName.Text = "Caulan Peake";

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
                btnAddMode.Text = "Add Order";
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
                this.BackColor = Color.SteelBlue;
                txtuserName.Text = "";
                txtuserID.Text = "";
                txtBillingStreet1.Text = "";
                txtBillingCity.Text = "";
                comboBoxBillingState.SelectedIndex = 0;
                txtBillingZip.Text = "";
                txtShippingStreet1.Text = "";
                txtShippingCity.Text = "";
                comboBoxShippingState.SelectedIndex = 0;
                txtShippingZip.Text = "";

                txtOrderNum.Text = "";
                txtDateOrdered.Text = "";
                txtSalesperson.Text = "";
                comboBoxStatus.SelectedIndex = 0;
                txtSubtotal.Text = "";
                txtDiscount.Text = "";
                txtTax.Text = "";
                txtCharges.Text = "";
                txtTotal.Text = "";

                lblName.Text = "";
                comboBoxItemsCategory.SelectedIndex = 0;

                lblNameCard.Text = "";
                maskedTxtCardNum.Text = "";
                maskedTxtEprDate.Text = "";
                txtPin.Text = "";
                txtCardType.Text = "";
                txtCardHolderName.Text = "";
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
                this.BackColor = Color.Firebrick;
                txtuserName.Text = "Caulan Peake";
                txtuserID.Text = "12354";
                txtBillingStreet1.Text = "1 Trinity Place";
                txtBillingCity.Text = "San Antonio";
                comboBoxBillingState.SelectedIndex = 42;
                txtBillingZip.Text = "78212";
                txtShippingStreet1.Text = "1 Trinity Place";
                txtShippingCity.Text = "San Antonio";
                comboBoxShippingState.SelectedIndex = 42;
                txtShippingZip.Text = "78212";

                txtOrderNum.Text = "10309";
                txtDateOrdered.Text = "4/2/2015";
                txtSalesperson.Text = "Hicksies, T";
                comboBoxStatus.SelectedIndex = 1;
                txtSubtotal.Text = "0.00";
                txtDiscount.Text = "0.00";
                txtTax.Text = "0.00";
                txtCharges.Text = "1.00";
                txtTotal.Text = "1.00";

                lblName.Text = "Caulan Peake";
                comboBoxItemsCategory.SelectedIndex = 0;

                lblNameCard.Text = "Caulan Peake";
                maskedTxtCardNum.Text = "000000000000000000";
                maskedTxtEprDate.Text = "12/16";
                txtPin.Text = "0000";
                txtCardType.Text = "Visa";
                txtCardHolderName.Text = "Caulan Peake";
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

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void btnJumpToUser_Click(object sender, EventArgs e)
        {
            userForm = new User();
            userForm.MdiParent = this.MdiParent;
            userForm.Show();
        }

        private void CustomerInfo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtContactName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtShippingStreet1.Text = txtBillingStreet1.Text;
                txtShippingStreet2.Text = txtBillingStreet2.Text;
                txtShippingCity.Text = txtBillingCity.Text;
                txtShippingZip.Text = txtBillingZip.Text;
                comboBoxShippingState.Text = comboBoxBillingState.Text;
            }
            else
            {
                txtShippingStreet1.Text = "";
                txtShippingStreet2.Text = "";
                txtShippingCity.Text = "";
                txtShippingZip.Text = "";
                comboBoxShippingState.Text = "";
            }
        }

        private void txtuserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void undeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undeleteForm = new UndeleteSale();
            undeleteForm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMode();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditMode.Text = "Edit Mode";
            this.BackColor = Color.SeaGreen;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditMode.Text = "Edit Mode";
            btnAddMode.Text = "Add Vendor";
            btnAddMode.ForeColor = Color.Black;
            cancelButton.Visible = false;
            panel1.Enabled = true;

            NormalMode();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormalMode();

            MessageBox.Show("Delete Successful");
        }

        private void upButtonLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            receiptForm = new Receipt();
            receiptForm.Show();
        }
    }
}
