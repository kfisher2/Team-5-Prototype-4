namespace LeaseToBuy
{
    partial class MenuButtons
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
            this.btnUserSubSystem = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnInventorySubSystem = new System.Windows.Forms.Button();
            this.btnVendorSubSystem = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUndelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserSubSystem
            // 
            this.btnUserSubSystem.BackColor = System.Drawing.Color.Honeydew;
            this.btnUserSubSystem.Location = new System.Drawing.Point(252, 12);
            this.btnUserSubSystem.Name = "btnUserSubSystem";
            this.btnUserSubSystem.Size = new System.Drawing.Size(225, 50);
            this.btnUserSubSystem.TabIndex = 0;
            this.btnUserSubSystem.Text = "Vendor Sub-System";
            this.btnUserSubSystem.UseVisualStyleBackColor = false;
            this.btnUserSubSystem.Click += new System.EventHandler(this.btnUserSubSystem_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(252, 78);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(225, 50);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Logout";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnInventorySubSystem
            // 
            this.btnInventorySubSystem.BackColor = System.Drawing.Color.Honeydew;
            this.btnInventorySubSystem.Location = new System.Drawing.Point(493, 12);
            this.btnInventorySubSystem.Name = "btnInventorySubSystem";
            this.btnInventorySubSystem.Size = new System.Drawing.Size(225, 50);
            this.btnInventorySubSystem.TabIndex = 2;
            this.btnInventorySubSystem.Text = "Inventory Sub-System";
            this.btnInventorySubSystem.UseVisualStyleBackColor = false;
            this.btnInventorySubSystem.Click += new System.EventHandler(this.btnInventorySubSystem_Click);
            // 
            // btnVendorSubSystem
            // 
            this.btnVendorSubSystem.BackColor = System.Drawing.Color.Honeydew;
            this.btnVendorSubSystem.Location = new System.Drawing.Point(12, 12);
            this.btnVendorSubSystem.Name = "btnVendorSubSystem";
            this.btnVendorSubSystem.Size = new System.Drawing.Size(225, 50);
            this.btnVendorSubSystem.TabIndex = 3;
            this.btnVendorSubSystem.Text = "User Sub-System";
            this.btnVendorSubSystem.UseVisualStyleBackColor = false;
            this.btnVendorSubSystem.Click += new System.EventHandler(this.btnVendorSubSystem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(12, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUndelete
            // 
            this.btnUndelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUndelete.Location = new System.Drawing.Point(252, 141);
            this.btnUndelete.Name = "btnUndelete";
            this.btnUndelete.Size = new System.Drawing.Size(225, 50);
            this.btnUndelete.TabIndex = 5;
            this.btnUndelete.Text = "Un-Delete";
            this.btnUndelete.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(493, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(225, 50);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // MenuButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(740, 213);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUndelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVendorSubSystem);
            this.Controls.Add(this.btnInventorySubSystem);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnUserSubSystem);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MenuButtons";
            this.Text = "Menu Buttons";
            this.Load += new System.EventHandler(this.MenuButtons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserSubSystem;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnInventorySubSystem;
        private System.Windows.Forms.Button btnVendorSubSystem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndelete;
        private System.Windows.Forms.Button btnSearch;
    }
}

