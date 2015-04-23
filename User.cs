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
        String stuff = "";



        public User()
        {
            InitializeComponent();
            selectFilterBox.SelectedIndex = 2;
            orderByBox.SelectedIndex = 2;
            NormalMode();
            cancelButton.Visible = false;

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
            comboBox1.SelectedIndex = 43;
            textBox1.Text = "78212";
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 43;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = true;
            comboBox2.SelectedIndex = 43;
            textBox14.Text = "7538432";
            maskedTextBox2.Text = "8324562178";
            maskedTextBox3.Text = "8329824388";
            maskedTextBox1.Text = "04081988";
            textBox2.Text = "zfoster@gmail.com";
            checkBox2.Checked = true;
            label34.Text = "10309";
            label46.Text = "3819";

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
            this.BackColor = Color.SeaGreen;
        }

        private void NormalMode_Click(object sender, EventArgs e)
        {
            NormalMode();
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
            comboBox1.SelectedIndex = 43;
            textBox1.Text = "78212";
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 43;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = true;
            comboBox2.SelectedIndex = 43;
            textBox14.Text = "7538432";
            maskedTextBox2.Text = "8324562178";
            maskedTextBox3.Text = "8329824388";
            maskedTextBox1.Text = "04081988";
            textBox2.Text = "zfoster@gmail.com";
            checkBox2.Checked = true;
            label34.Text = "10309";
            label46.Text = "3819";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void AddMode()
        {
            if (btnAddMode.Text == "Save")
            {
                this.BackColor = Color.SeaGreen;
                btnAddMode.Text = "Add User";
                cancelButton.Visible = false;
                btnAddMode.ForeColor = Color.Black;
                cancelButton.ForeColor = Color.Black;
                MessageBox.Show("Saved!");
            }
            else
            {
                btnAddMode.Text = "Save";
                cancelButton.Visible = true;
                btnAddMode.ForeColor = Color.MidnightBlue;
                cancelButton.ForeColor = Color.MidnightBlue;
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
                comboBox1.SelectedIndex = 0;
                textBox1.Text = "";
                textBox6.Text = textBillSt1.Text;
                textBox7.Text = textBillSt2.Text;
                textBox8.Text = textBillCity.Text;
                comboBox3.SelectedIndex = 0;
                textBox9.Text = textBox1.Text;
                checkBox1.Checked = false;
                comboBox2.SelectedIndex = 0;
                textBox14.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox1.Text = "";
                textBox2.Text = "";
                checkBox2.Checked = false;
                label34.Text = "";
                label46.Text = "";
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
                MessageBox.Show("Saved!");

            }
            else
            {
                this.BackColor = Color.Firebrick;
                /*btnEditMode.Text = "Save";
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
                this.BackColor = Color.Firebrick;*/
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

            dataGridView2.Rows.Add("15846", "Alice", "Box", "alicethegreat@gmail.com","8325875241", "8329752145");
            dataGridView2.Rows.Add("17322", "Lil' Nathan", "Cox", "", "", "");
            dataGridView1.Rows.Add("0928", "04/18/14", "$99.99");
            dataGridView1.Rows.Add("0718", "04/18/14", "$24.99");
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnAddMode.Text = "Add User";
            btnAddMode.ForeColor = Color.Black;
            cancelButton.ForeColor = Color.Black;
            cancelButton.Visible = false;
            NormalMode();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PrimaryTabPanel.SelectTab(0);
            AddMode();
            //This is the "split" button
            txtFirst.Text = "Alice";
            txtLast.Text = "Box";
            txtStreet1.Text = "190 Kings Ct";
            txtStreet2.Text = "";
            txtCity.Text = "San Antonio";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = txtStreet1.Text;
            textBillSt2.Text = txtStreet2.Text;
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            comboGenAcctType.Text = "Personal";
            maskedTextGenAccessed.Text = "05/05/2015";
            maskedTextGenCreated.Text = "05/05/2015";
            textGeneralNotes.Text = "";
            comboBox1.SelectedIndex = 43;
            textBox1.Text = textBillZip.Text;
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 43;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = 43;
            textBox14.Text = "9875418";
            maskedTextBox2.Text = "8325875241";
            maskedTextBox3.Text = "8329752145";
            maskedTextBox1.Text = "10221983";
            textBox2.Text = "alicethegreat@gmail.com";
            checkBox2.Checked = true;
            label34.Text = "15846";
            label46.Text = "8405";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stuff = txtStreet1.Text;
            txtStreet1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtStreet1.Text = stuff;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Skype...");
        }

        private void leftButtonLeft_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "Corey";
            txtLast.Text = "Fisher";
            txtStreet1.Text = "1 Trinity Place";
            txtStreet2.Text = "#130";
            txtCity.Text = "San Antonio";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = "1 Trinity Place";
            textBillSt2.Text = "#130";
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            comboGenAcctType.Text = "Corporate";
            maskedTextGenAccessed.Text = "02/19/2015";
            maskedTextGenCreated.Text = "05/29/2010";
            textGeneralNotes.Text = "Corey is available. /Ladies/.";
            comboBox1.SelectedIndex = 43;
            textBox1.Text = "78212";
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 43;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = true;
            comboBox2.SelectedIndex = 43;
            textBox14.Text = "6342891";
            maskedTextBox2.Text = "4364322890";
            maskedTextBox3.Text = "8023889255";
            maskedTextBox1.Text = "03051993";
            textBox2.Text = "cfisher@trinity.edu";
            checkBox2.Checked = true;
            label34.Text = "13264";
            label46.Text = "1024";
        }

        private void leftButtonRight_Click(object sender, EventArgs e)
        {

            txtFirst.Text = "Corey";
            txtLast.Text = "Fisher";
            txtStreet1.Text = "1 Trinity Place";
            txtStreet2.Text = "#130";
            txtCity.Text = "San Antonio";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = "1 Trinity Place";
            textBillSt2.Text = "#130";
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            comboGenAcctType.Text = "Corporate";
            maskedTextGenAccessed.Text = "02/19/2015";
            maskedTextGenCreated.Text = "05/29/2010";
            textGeneralNotes.Text = "Corey is available. /Ladies/.";
            comboBox1.SelectedIndex = 43;
            textBox1.Text = "78212";
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 43;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = true;
            comboBox2.SelectedIndex = 43;
            textBox14.Text = "6342891";
            maskedTextBox2.Text = "4364322890";
            maskedTextBox3.Text = "8023889255";
            maskedTextBox1.Text = "03051993";
            textBox2.Text = "cfisher@trinity.edu";
            checkBox2.Checked = true;
            label34.Text = "13264";
            label46.Text = "1024";
        }

        private void rightButtonLeft_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "Bob";
            txtLast.Text = "Cox";
            txtStreet1.Text = "190 Kings Ct";
            txtStreet2.Text = "";
            txtCity.Text = "San Antonio";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = txtStreet1.Text;
            textBillSt2.Text = txtStreet2.Text;
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            comboGenAcctType.Text = "Family";
            maskedTextGenAccessed.Text = "05/04/2015";
            maskedTextGenCreated.Text = "05/02/2015";
            textGeneralNotes.Text = "Nice guy, wife and kids.";
            comboBox1.SelectedIndex = 43;
            textBox1.Text = textBillZip.Text;
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 43;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = 43;
            textBox14.Text = "5217562";
            maskedTextBox2.Text = "8324193275";
            maskedTextBox3.Text = "8321608364";
            maskedTextBox1.Text = "02171973";
            textBox2.Text = "cox.bob@hotmail.com";
            checkBox2.Checked = true;
            label34.Text = "16482";
            label46.Text = "3248";
        }

        private void rightButtonRight_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "Bob";
            txtLast.Text = "Cox";
            txtStreet1.Text = "190 Kings Ct";
            txtStreet2.Text = "";
            txtCity.Text = "San Antonio";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = txtStreet1.Text;
            textBillSt2.Text = txtStreet2.Text;
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            comboGenAcctType.Text = "Family";
            maskedTextGenAccessed.Text = "05/04/2015";
            maskedTextGenCreated.Text = "05/02/2015";
            textGeneralNotes.Text = "Nice guy, wife and kids.";
            comboBox1.SelectedIndex = 43;
            textBox1.Text = textBillZip.Text;
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 43;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = 43;
            textBox14.Text = "5217562";
            maskedTextBox2.Text = "8324193275";
            maskedTextBox3.Text = "8321608364";
            maskedTextBox1.Text = "02171973";
            textBox2.Text = "cox.bob@hotmail.com";
            checkBox2.Checked = true;
            label34.Text = "16482";
            label46.Text = "3248";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "Rock";
            txtLast.Text = "Candy";
            txtStreet1.Text = "270 Gumdrop Lane";
            txtStreet2.Text = "";
            txtCity.Text = "Lalaland";
            textBillCity.Text = txtCity.Text;
            textBillSt1.Text = txtStreet1.Text;
            textBillSt2.Text = txtStreet2.Text;
            textBillZip.Text = "94093";
            textBillState.Text = "Florida";
            comboGenAcctType.Text = "Family";
            maskedTextGenAccessed.Text = "02/04/2010";
            maskedTextGenCreated.Text = "03/07/2014";
            textGeneralNotes.Text = "Sweet and innocent and probably delicious. I haven't taken a bite to check.";
            comboBox1.SelectedIndex = 10;
            textBox1.Text = textBillZip.Text;
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 10;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = 10;
            textBox14.Text = "5879954";
            maskedTextBox2.Text = "9752497952";
            maskedTextBox3.Text = "4572015772";
            maskedTextBox1.Text = "09021945";
            textBox2.Text = "lalilulelo@yahoo.com";
            checkBox2.Checked = true;
            label34.Text = "11111";
            label46.Text = "6166";

        }

        private void rightButtonRight_Click_1(object sender, EventArgs e)
        {

            txtFirst.Text = "Bob";
            txtLast.Text = "Cox";
            txtStreet1.Text = "190 Kings Ct";
            txtStreet2.Text = "";
            txtCity.Text = "San Antonio";
            textBillCity.Text = "San Antonio";
            textBillSt1.Text = txtStreet1.Text;
            textBillSt2.Text = txtStreet2.Text;
            textBillZip.Text = "78212";
            textBillState.Text = "Texas";
            comboGenAcctType.Text = "Family";
            maskedTextGenAccessed.Text = "05/04/2015";
            maskedTextGenCreated.Text = "05/02/2015";
            textGeneralNotes.Text = "Nice guy, wife and kids.";
            comboBox1.SelectedIndex = 43;
            textBox1.Text = textBillZip.Text;
            textBox6.Text = textBillSt1.Text;
            textBox7.Text = textBillSt2.Text;
            textBox8.Text = textBillCity.Text;
            comboBox3.SelectedIndex = 43;
            textBox9.Text = textBox1.Text;
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = 43;
            textBox14.Text = "5217562";
            maskedTextBox2.Text = "8324193275";
            maskedTextBox3.Text = "8321608364";
            maskedTextBox1.Text = "02171973";
            textBox2.Text = "cox.bob@hotmail.com";
            checkBox2.Checked = true;
            label34.Text = "16482";
            label46.Text = "3248";
        }
    }
}
