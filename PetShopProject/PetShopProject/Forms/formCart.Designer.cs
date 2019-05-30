namespace PetShopProject.Forms
{
    partial class formCart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteChitiet = new System.Windows.Forms.Button();
            this.btnAddChiTiet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 55);
            this.panel1.TabIndex = 21;
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
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.Soluong,
            this.ThanhTien});
            this.dgvCart.Location = new System.Drawing.Point(11, 114);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(451, 177);
            this.dgvCart.TabIndex = 19;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Product";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Product Name";
            this.TenSanPham.Name = "TenSanPham";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Amount";
            this.Soluong.Name = "Soluong";
            this.Soluong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Soluong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "AmountofMoney";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.btnDeleteChitiet.Location = new System.Drawing.Point(11, 70);
            this.btnDeleteChitiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteChitiet.Name = "btnDeleteChitiet";
            this.btnDeleteChitiet.Size = new System.Drawing.Size(83, 39);
            this.btnDeleteChitiet.TabIndex = 22;
            this.btnDeleteChitiet.UseVisualStyleBackColor = false;
            this.btnDeleteChitiet.Click += new System.EventHandler(this.btnDeleteChitiet_Click);
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
            this.btnAddChiTiet.Location = new System.Drawing.Point(98, 70);
            this.btnAddChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddChiTiet.Name = "btnAddChiTiet";
            this.btnAddChiTiet.Size = new System.Drawing.Size(83, 39);
            this.btnAddChiTiet.TabIndex = 23;
            this.btnAddChiTiet.UseVisualStyleBackColor = false;
            this.btnAddChiTiet.Click += new System.EventHandler(this.btnAddChiTiet_Click);
            // 
            // formCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 296);
            this.Controls.Add(this.btnAddChiTiet);
            this.Controls.Add(this.btnDeleteChitiet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCart);
            this.Name = "formCart";
            this.Text = "formCart";
            this.Load += new System.EventHandler(this.formCart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnDeleteChitiet;
        private System.Windows.Forms.Button btnAddChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}