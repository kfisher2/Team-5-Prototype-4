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
    public partial class User : Form
    {
        bool Testing = false;
        Undelete undeleteForm = null;
        EmployeeInfo employ = null;
        CreditCards credit = null;

        public User()
        {
            InitializeComponent();
            selectFilterBox.SelectedIndex = 2;
            orderByBox.SelectedIndex = 2;
            NormalMode();

            if (checkBox1.Checked)
                button8.Visible = true;
            else
                button8.Visible = false;

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
            txtFirst.Text = "Zane";
            txtLast.Text = "Foster";
            txtStreet1.Text = "1 Trinity Place";
            txtStreet2.Text = "#655";
            txtCity.Text = "San Antonio";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = "1 Trinity Place";
            textBillSt2.Text = "#655";
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            comboGenAcctType.Text = "Corporate";
            maskedTextGenAccessed.Text = "02/19/2015";
            maskedTextGenCreated.Text = "05/29/2010";
            textGeneralNotes.Text = "Zane is a valued customer.";
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
            txtFirst.Text = "";
            txtLast.Text = "";
            txtStreet1.Text = "";
            txtStreet2.Text = "";
            txtCity.Text = "";
            textBillCity.Text = "";
            textBillSt1.Text = "";
            textBillSt2.Text = "";
            textBillZip.Text = "";
            textBillState.Text = "";
            maskedTextGenAccessed.Text = "";
            maskedTextGenCreated.Text = "";
            comboGenAcctType.Text = "";
            textGeneralNotes.Text = "";
            this.BackColor = Color.SteelBlue;
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
            txtFirst.Text = "Zane";
            txtLast.Text = "Foster";
            txtStreet1.Text = "1 Trinity Place";
            txtStreet2.Text = "#655";
            txtCity.Text = "San Antonio";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = "1 Trinity Place";
            textBillSt2.Text = "#655";
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            comboGenAcctType.Text = "Corporate";
            maskedTextGenAccessed.Text = "02/19/2015";
            maskedTextGenCreated.Text = "05/29/2010";
            textGeneralNotes.Text = "Zane is a valued customer.";
            this.BackColor = Color.Firebrick;
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void General_Click(object sender, EventArgs e)
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMode();
        }

        private void undeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undeleteForm = new Undelete();
            undeleteForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormalMode();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormalMode();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            employ = new EmployeeInfo();
            employ.MdiParent = this.MdiParent;
            employ.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            credit = new CreditCards();
            credit.MdiParent = this.MdiParent;
            credit.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            credit = new CreditCards();
            credit.MdiParent = this.MdiParent;
            credit.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            employ = new EmployeeInfo();
            employ.MdiParent = this.MdiParent;
            employ.Show();
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                button8.Visible = true;
            else
                button8.Visible = false;

        }


    }
}
