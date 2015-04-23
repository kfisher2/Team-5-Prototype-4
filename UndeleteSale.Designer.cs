namespace LeaseToBuy
{
    partial class UndeleteSale
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
            this.UndeleteSUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteSSalesperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteSOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.UndeleteSUser,
            this.UndeleteSSalesperson,
            this.UndeleteSOrderDate,
            this.UndeleteSDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 166);
            this.dataGridView1.TabIndex = 14;
            // 
            // UndeleteSUser
            // 
            this.UndeleteSUser.HeaderText = "Username";
            this.UndeleteSUser.Name = "UndeleteSUser";
            // 
            // UndeleteSSalesperson
            // 
            this.UndeleteSSalesperson.HeaderText = "Salesperson";
            this.UndeleteSSalesperson.Name = "UndeleteSSalesperson";
            // 
            // UndeleteSOrderDate
            // 
            this.UndeleteSOrderDate.HeaderText = "Order Date";
            this.UndeleteSOrderDate.Name = "UndeleteSOrderDate";
            // 
            // UndeleteSDate
            // 
            this.UndeleteSDate.HeaderText = "Date Deleted";
            this.UndeleteSDate.Name = "UndeleteSDate";
            // 
            // btnUndelete
            // 
            this.btnUndelete.Location = new System.Drawing.Point(12, 215);
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
            "Username",
            "Salesperson",
            "Order Date",
            "Deleted Date"});
            this.comboBox2.Location = new System.Drawing.Point(152, 184);
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
            this.comboBox1.Location = new System.Drawing.Point(12, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Filter by...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Search";
            // 
            // UndeleteSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(421, 257);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUndelete);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "UndeleteSale";
            this.Text = "UndeleteSale";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUndelete;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteSUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteSSalesperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteSOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteSDate;
        private System.Windows.Forms.TextBox textBox1;
    }
}