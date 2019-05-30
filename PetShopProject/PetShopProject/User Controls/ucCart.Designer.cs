namespace PetShopProject.User_Controls
{
    partial class ucCart
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnDeleteChitiet = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddChiTiet = new System.Windows.Forms.Button();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.Amount,
            this.Money});
            this.dgvCart.Location = new System.Drawing.Point(2, 149);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(451, 177);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // btnDeleteChitiet
            // 
            this.btnDeleteChitiet.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteChitiet.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnDeleteChitiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteChitiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteChitiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteChitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteChitiet.ForeColor = System.Drawing.Color.White;
            this.btnDeleteChitiet.Image = global::PetShopProject.Properties.Resources.delete_24_white;
            this.btnDeleteChitiet.Location = new System.Drawing.Point(11, 105);
            this.btnDeleteChitiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteChitiet.Name = "btnDeleteChitiet";
            this.btnDeleteChitiet.Size = new System.Drawing.Size(83, 39);
            this.btnDeleteChitiet.TabIndex = 11;
            this.btnDeleteChitiet.UseVisualStyleBackColor = false;
            this.btnDeleteChitiet.Click += new System.EventHandler(this.btnDeleteChitiet_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(67, 62);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 27);
            this.txtTotal.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(7, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 55);
            this.panel1.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 39);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Cart";
            // 
            // btnAddChiTiet
            // 
            this.btnAddChiTiet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddChiTiet.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAddChiTiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddChiTiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnAddChiTiet.Image = global::PetShopProject.Properties.Resources.add_24_white;
            this.btnAddChiTiet.Location = new System.Drawing.Point(121, 105);
            this.btnAddChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddChiTiet.Name = "btnAddChiTiet";
            this.btnAddChiTiet.Size = new System.Drawing.Size(83, 39);
            this.btnAddChiTiet.TabIndex = 9;
            this.btnAddChiTiet.UseVisualStyleBackColor = false;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "ProductID";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanpham";
            this.TenSanPham.HeaderText = "ProductName";
            this.TenSanPham.Name = "TenSanPham";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Soluong";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Money
            // 
            this.Money.DataPropertyName = "ThanhTien";
            this.Money.HeaderText = "AmountofMoney";
            this.Money.Name = "Money";
            this.Money.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Money.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ucCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteChitiet);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnAddChiTiet);
            this.Name = "ucCart";
            this.Size = new System.Drawing.Size(459, 359);
            this.Load += new System.EventHandler(this.ucCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnDeleteChitiet;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddChiTiet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
    }
}
