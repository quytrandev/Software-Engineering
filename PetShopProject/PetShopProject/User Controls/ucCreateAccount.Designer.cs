namespace PetShopProject.User_Controls
{
    partial class ucCreateAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCreateAcc = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAddAccount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbAuth = new System.Windows.Forms.ComboBox();
            this.lblAuthorization = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlCreateAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCreateAcc
            // 
            this.pnlCreateAcc.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlCreateAcc.Controls.Add(this.btnOK);
            this.pnlCreateAcc.Controls.Add(this.lblAddAccount);
            this.pnlCreateAcc.Controls.Add(this.btnCancel);
            this.pnlCreateAcc.Controls.Add(this.cbAuth);
            this.pnlCreateAcc.Controls.Add(this.lblAuthorization);
            this.pnlCreateAcc.Controls.Add(this.lblUsername);
            this.pnlCreateAcc.Controls.Add(this.lblPassword);
            this.pnlCreateAcc.Controls.Add(this.txtPassword);
            this.pnlCreateAcc.Controls.Add(this.txtUsername);
            this.pnlCreateAcc.Location = new System.Drawing.Point(173, 49);
            this.pnlCreateAcc.Name = "pnlCreateAcc";
            this.pnlCreateAcc.Size = new System.Drawing.Size(423, 458);
            this.pnlCreateAcc.TabIndex = 11;
            this.pnlCreateAcc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCreateAcc_Paint);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnOK.FlatAppearance.BorderSize = 3;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnOK.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.Image = global::PetShopProject.Properties.Resources.check_24_blue;
            this.btnOK.Location = new System.Drawing.Point(163, 387);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 42);
            this.btnOK.TabIndex = 10;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAddAccount
            // 
            this.lblAddAccount.AutoSize = true;
            this.lblAddAccount.Font = new System.Drawing.Font("Arial", 30F);
            this.lblAddAccount.ForeColor = System.Drawing.Color.White;
            this.lblAddAccount.Location = new System.Drawing.Point(40, 15);
            this.lblAddAccount.Name = "lblAddAccount";
            this.lblAddAccount.Size = new System.Drawing.Size(355, 45);
            this.lblAddAccount.TabIndex = 10;
            this.lblAddAccount.Text = "Add a new account";
            this.lblAddAccount.Click += new System.EventHandler(this.lblAddAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnCancel.Image = global::PetShopProject.Properties.Resources.close_24_red;
            this.btnCancel.Location = new System.Drawing.Point(271, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 42);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbAuth
            // 
            this.cbAuth.BackColor = System.Drawing.Color.White;
            this.cbAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuth.Font = new System.Drawing.Font("Arial", 20F);
            this.cbAuth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbAuth.FormattingEnabled = true;
            this.cbAuth.Location = new System.Drawing.Point(29, 297);
            this.cbAuth.Name = "cbAuth";
            this.cbAuth.Size = new System.Drawing.Size(344, 40);
            this.cbAuth.TabIndex = 18;
            // 
            // lblAuthorization
            // 
            this.lblAuthorization.AutoSize = true;
            this.lblAuthorization.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblAuthorization.ForeColor = System.Drawing.Color.White;
            this.lblAuthorization.Location = new System.Drawing.Point(25, 255);
            this.lblAuthorization.Name = "lblAuthorization";
            this.lblAuthorization.Size = new System.Drawing.Size(187, 29);
            this.lblAuthorization.TabIndex = 16;
            this.lblAuthorization.Text = "Employee Type";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(24, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(127, 29);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(25, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(126, 29);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 20F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(29, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(344, 31);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 20F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(30, 120);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(343, 31);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // ucCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlCreateAcc);
            this.Name = "ucCreateAccount";
            this.Size = new System.Drawing.Size(769, 581);
            this.Load += new System.EventHandler(this.ucCreateAccount_Load);
            this.pnlCreateAcc.ResumeLayout(false);
            this.pnlCreateAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreateAcc;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbAuth;
        private System.Windows.Forms.Label lblAuthorization;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblAddAccount;
    }
}
