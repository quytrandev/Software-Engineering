namespace PetShopProject.User_Controls
{
    partial class ucChangePassword
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
            this.lblAddAccount = new System.Windows.Forms.Label();
            this.cbxRetype = new System.Windows.Forms.CheckBox();
            this.cbxNew = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlChangePass = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddAccount
            // 
            this.lblAddAccount.AutoSize = true;
            this.lblAddAccount.Font = new System.Drawing.Font("Arial", 30F);
            this.lblAddAccount.ForeColor = System.Drawing.Color.White;
            this.lblAddAccount.Location = new System.Drawing.Point(93, 12);
            this.lblAddAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAccount.Name = "lblAddAccount";
            this.lblAddAccount.Size = new System.Drawing.Size(429, 57);
            this.lblAddAccount.TabIndex = 52;
            this.lblAddAccount.Text = "Change password";
            // 
            // cbxRetype
            // 
            this.cbxRetype.AutoSize = true;
            this.cbxRetype.Enabled = false;
            this.cbxRetype.ForeColor = System.Drawing.Color.White;
            this.cbxRetype.Location = new System.Drawing.Point(497, 542);
            this.cbxRetype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxRetype.Name = "cbxRetype";
            this.cbxRetype.Size = new System.Drawing.Size(64, 21);
            this.cbxRetype.TabIndex = 49;
            this.cbxRetype.Text = "Show";
            this.cbxRetype.UseVisualStyleBackColor = true;
            // 
            // cbxNew
            // 
            this.cbxNew.AutoSize = true;
            this.cbxNew.Enabled = false;
            this.cbxNew.ForeColor = System.Drawing.Color.White;
            this.cbxNew.Location = new System.Drawing.Point(497, 410);
            this.cbxNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNew.Name = "cbxNew";
            this.cbxNew.Size = new System.Drawing.Size(64, 21);
            this.cbxNew.TabIndex = 48;
            this.cbxNew.Text = "Show";
            this.cbxNew.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 35);
            this.label2.TabIndex = 43;
            this.label2.Text = "Retype new password";
            // 
            // txtRetype
            // 
            this.txtRetype.Font = new System.Drawing.Font("Arial", 20F);
            this.txtRetype.Location = new System.Drawing.Point(67, 491);
            this.txtRetype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.Size = new System.Drawing.Size(497, 46);
            this.txtRetype.TabIndex = 42;
            this.txtRetype.TextChanged += new System.EventHandler(this.txtRetype_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 35);
            this.label1.TabIndex = 41;
            this.label1.Text = "New password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Arial", 20F);
            this.txtNewPass.Location = new System.Drawing.Point(67, 359);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(497, 46);
            this.txtNewPass.TabIndex = 40;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(60, 185);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(274, 35);
            this.lbl1.TabIndex = 39;
            this.lbl1.Text = "Current password";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Font = new System.Drawing.Font("Arial", 20F);
            this.txtCurrentPass.Location = new System.Drawing.Point(67, 224);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(497, 46);
            this.txtCurrentPass.TabIndex = 38;
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::PetShopProject.Properties.Resources.close1_24_white;
            this.btnCancel.Location = new System.Drawing.Point(453, 583);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 48);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = global::PetShopProject.Properties.Resources.check_24_blue;
            this.btnOK.Location = new System.Drawing.Point(336, 583);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 48);
            this.btnOK.TabIndex = 53;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlChangePass
            // 
            this.pnlChangePass.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlChangePass.Controls.Add(this.txtUsername);
            this.pnlChangePass.Controls.Add(this.label3);
            this.pnlChangePass.Controls.Add(this.lblAddAccount);
            this.pnlChangePass.Controls.Add(this.btnCancel);
            this.pnlChangePass.Controls.Add(this.txtCurrentPass);
            this.pnlChangePass.Controls.Add(this.btnOK);
            this.pnlChangePass.Controls.Add(this.lbl1);
            this.pnlChangePass.Controls.Add(this.txtNewPass);
            this.pnlChangePass.Controls.Add(this.cbxRetype);
            this.pnlChangePass.Controls.Add(this.label1);
            this.pnlChangePass.Controls.Add(this.cbxNew);
            this.pnlChangePass.Controls.Add(this.txtRetype);
            this.pnlChangePass.Controls.Add(this.label2);
            this.pnlChangePass.Location = new System.Drawing.Point(214, 29);
            this.pnlChangePass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChangePass.Name = "pnlChangePass";
            this.pnlChangePass.Size = new System.Drawing.Size(637, 660);
            this.pnlChangePass.TabIndex = 56;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 20F);
            this.txtUsername.Location = new System.Drawing.Point(67, 119);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(497, 46);
            this.txtUsername.TabIndex = 55;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 35);
            this.label3.TabIndex = 56;
            this.label3.Text = "Username";
            // 
            // ucChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlChangePass);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucChangePassword";
            this.Size = new System.Drawing.Size(1038, 717);
            this.Load += new System.EventHandler(this.ucChangePassword_Load);
            this.pnlChangePass.ResumeLayout(false);
            this.pnlChangePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddAccount;
        private System.Windows.Forms.CheckBox cbxRetype;
        private System.Windows.Forms.CheckBox cbxNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlChangePass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
    }
}
