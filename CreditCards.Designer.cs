namespace LeaseToBuy
{
    partial class CreditCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCards));
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leftButtonLeft = new System.Windows.Forms.Button();
            this.rightButtonLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(147, 6);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(184, 26);
            this.textBox18.TabIndex = 22;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(147, 35);
            this.maskedTextBox4.Mask = "****-****-****-####";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(131, 26);
            this.maskedTextBox4.TabIndex = 13;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(82, 35);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 19);
            this.label32.TabIndex = 14;
            this.label32.Text = "Card #";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(74, 68);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(67, 19);
            this.label33.TabIndex = 15;
            this.label33.Text = "Expires";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox5.Location = new System.Drawing.Point(147, 65);
            this.maskedTextBox5.Mask = "#/##";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(40, 26);
            this.maskedTextBox5.TabIndex = 16;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(107, 101);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(34, 19);
            this.label37.TabIndex = 17;
            this.label37.Text = "Pin";
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(147, 94);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 26);
            this.textBox16.TabIndex = 18;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(1, 9);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(140, 19);
            this.label39.TabIndex = 21;
            this.label39.Text = "Holder Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Company";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Discover",
            "Visa",
            "MasterCard",
            "American Express"});
            this.comboBox1.Location = new System.Drawing.Point(147, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 27);
            this.comboBox1.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(130, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 30;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(256, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 28;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // leftButtonLeft
            // 
            this.leftButtonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leftButtonLeft.Image = ((System.Drawing.Image)(resources.GetObject("leftButtonLeft.Image")));
            this.leftButtonLeft.Location = new System.Drawing.Point(5, 106);
            this.leftButtonLeft.Name = "leftButtonLeft";
            this.leftButtonLeft.Size = new System.Drawing.Size(49, 46);
            this.leftButtonLeft.TabIndex = 31;
            this.leftButtonLeft.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.leftButtonLeft.UseVisualStyleBackColor = true;
            // 
            // rightButtonLeft
            // 
            this.rightButtonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rightButtonLeft.Image = ((System.Drawing.Image)(resources.GetObject("rightButtonLeft.Image")));
            this.rightButtonLeft.Location = new System.Drawing.Point(282, 106);
            this.rightButtonLeft.Name = "rightButtonLeft";
            this.rightButtonLeft.Size = new System.Drawing.Size(49, 46);
            this.rightButtonLeft.TabIndex = 32;
            this.rightButtonLeft.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rightButtonLeft.UseVisualStyleBackColor = true;
            this.rightButtonLeft.Click += new System.EventHandler(this.rightButtonLeft_Click);
            // 
            // CreditCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(335, 180);
            this.ControlBox = false;
            this.Controls.Add(this.leftButtonLeft);
            this.Controls.Add(this.rightButtonLeft);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.maskedTextBox4);
            this.Name = "CreditCards";
            this.Text = "Credit Card Info by Corey Fisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button leftButtonLeft;
        private System.Windows.Forms.Button rightButtonLeft;

    }
}