namespace LeaseToBuy
{
    partial class UndeletePurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UndeleteVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteVDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUndelete = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UndeleteVID,
            this.UndeleteVName,
            this.UndeleteVDate,
            this.UndeleteDate});
            this.dataGridView1.Location = new System.Drawing.Point(7, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 166);
            this.dataGridView1.TabIndex = 14;
            // 
            // UndeleteVID
            // 
            this.UndeleteVID.HeaderText = "Vendor ID";
            this.UndeleteVID.Name = "UndeleteVID";
            // 
            // UndeleteVName
            // 
            this.UndeleteVName.HeaderText = "Name";
            this.UndeleteVName.Name = "UndeleteVName";
            // 
            // UndeleteVDate
            // 
            this.UndeleteVDate.HeaderText = "Date Created";
            this.UndeleteVDate.Name = "UndeleteVDate";
            // 
            // UndeleteDate
            // 
            this.UndeleteDate.HeaderText = "Date Deleted";
            this.UndeleteDate.Name = "UndeleteDate";
            // 
            // btnUndelete
            // 
            this.btnUndelete.Location = new System.Drawing.Point(7, 215);
            this.btnUndelete.Name = "btnUndelete";
            this.btnUndelete.Size = new System.Drawing.Size(402, 34);
            this.btnUndelete.TabIndex = 11;
            this.btnUndelete.Text = "Undelete";
            this.btnUndelete.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Vendor ID",
            "Vendor Name",
            "Date Created",
            "Date Deleted"});
            this.comboBox2.Location = new System.Drawing.Point(147, 184);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "Sort by...";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Recent(< 90 Days)",
            "Old(> 90 Days)"});
            this.comboBox1.Location = new System.Drawing.Point(7, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Filter by...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Search";
            // 
            // UndeletePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUndelete);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "UndeletePurchase";
            this.Text = "UndeletePurchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUndelete;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteVDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteDate;
        private System.Windows.Forms.TextBox textBox1;
    }
}