﻿namespace LeaseToBuy
{
    partial class Undelete
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UndeleteLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UndeleteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Recent(< 90 Days)",
            "Old(> 90 Days)"});
            this.comboBox1.Location = new System.Drawing.Point(13, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Filter by...";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Last Name",
            "First name",
            "User ID",
            "Email",
            "Date Deleted"});
            this.comboBox2.Location = new System.Drawing.Point(152, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Sort by...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(402, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Undelete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UndeleteLName,
            this.UndeleteFName,
            this.UndeleteUID,
            this.UndeleteEmail,
            this.UndeleteDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 166);
            this.dataGridView1.TabIndex = 4;
            // 
            // UndeleteLName
            // 
            this.UndeleteLName.HeaderText = "LastName";
            this.UndeleteLName.Name = "UndeleteLName";
            // 
            // UndeleteFName
            // 
            this.UndeleteFName.HeaderText = "First Name";
            this.UndeleteFName.Name = "UndeleteFName";
            // 
            // UndeleteUID
            // 
            this.UndeleteUID.HeaderText = "User ID";
            this.UndeleteUID.Name = "UndeleteUID";
            // 
            // UndeleteEmail
            // 
            this.UndeleteEmail.HeaderText = "E-mail";
            this.UndeleteEmail.Name = "UndeleteEmail";
            // 
            // UndeleteDate
            // 
            this.UndeleteDate.HeaderText = "Date Deleted";
            this.UndeleteDate.Name = "UndeleteDate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Search";
            // 
            // Undelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(426, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Undelete";
            this.Text = "Undelete";
            this.Load += new System.EventHandler(this.Undelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UndeleteDate;
        private System.Windows.Forms.TextBox textBox1;
    }
}