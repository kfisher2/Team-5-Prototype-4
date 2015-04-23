namespace LeaseToBuy
{
    partial class UndeleteInventory
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
            this.UndeleteIName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteICat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteIModelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteIVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteIDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.UndeleteIName,
            this.UndeleteICat,
            this.UndeleteIModelNo,
            this.UndeleteIVendor,
            this.UndeleteIDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 166);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UndeleteIName
            // 
            this.UndeleteIName.HeaderText = "Item Name";
            this.UndeleteIName.Name = "UndeleteIName";
            // 
            // UndeleteICat
            // 
            this.UndeleteICat.HeaderText = "Category";
            this.UndeleteICat.Name = "UndeleteICat";
            // 
            // UndeleteIModelNo
            // 
            this.UndeleteIModelNo.HeaderText = "Model No";
            this.UndeleteIModelNo.Name = "UndeleteIModelNo";
            // 
            // UndeleteIVendor
            // 
            this.UndeleteIVendor.HeaderText = "Vendor";
            this.UndeleteIVendor.Name = "UndeleteIVendor";
            // 
            // UndeleteIDate
            // 
            this.UndeleteIDate.HeaderText = "Date Deleted";
            this.UndeleteIDate.Name = "UndeleteIDate";
            // 
            // btnUndelete
            // 
            this.btnUndelete.Location = new System.Drawing.Point(12, 215);
            this.btnUndelete.Name = "btnUndelete";
            this.btnUndelete.Size = new System.Drawing.Size(402, 34);
            this.btnUndelete.TabIndex = 2;
            this.btnUndelete.Text = "Undelete";
            this.btnUndelete.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Item Name",
            "Category",
            "Modle No",
            "Vendor",
            "Date"});
            this.comboBox2.Location = new System.Drawing.Point(152, 184);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 21);
            this.comboBox2.TabIndex = 6;
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
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Filter by...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Search";
            // 
            // UndeleteInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(428, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUndelete);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "UndeleteInventory";
            this.Text = "UndeleteInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUndelete;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteIName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteICat;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteIModelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteIVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteIDate;
        private System.Windows.Forms.TextBox textBox1;
    }
}