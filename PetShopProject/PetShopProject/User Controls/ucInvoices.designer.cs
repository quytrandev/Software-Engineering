namespace PetShopProject.User_Controls
{
    partial class ucInvoices
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
            this.lblHr = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlPostData = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtEmploy = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDeleteChitiet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnUpdateChiTiet = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.btnAddChiTiet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInID2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.pnlPostData.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHr.Location = new System.Drawing.Point(-1, 41);
            this.lblHr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(839, 7);
            this.lblHr.TabIndex = 8;
            this.lblHr.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(-6, 2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 39);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Invoice";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHr);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 55);
            this.panel1.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(100, 165);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 20);
            this.txtSearch.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search :";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.NgayLap,
            this.MaNhanVien,
            this.MaKhachHang});
            this.dgvInvoice.Location = new System.Drawing.Point(0, 220);
            this.dgvInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(568, 176);
            this.dgvInvoice.TabIndex = 9;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::PetShopProject.Properties.Resources.search_24_black;
            this.btnSearch.Location = new System.Drawing.Point(296, 162);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlPostData
            // 
            this.pnlPostData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPostData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPostData.Controls.Add(this.date);
            this.pnlPostData.Controls.Add(this.label1);
            this.pnlPostData.Controls.Add(this.txtCustom);
            this.pnlPostData.Controls.Add(this.lblPrice);
            this.pnlPostData.Controls.Add(this.txtEmploy);
            this.pnlPostData.Controls.Add(this.lblProductName);
            this.pnlPostData.Controls.Add(this.txtInvoiceID);
            this.pnlPostData.Controls.Add(this.lblProductID);
            this.pnlPostData.Location = new System.Drawing.Point(3, 61);
            this.pnlPostData.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPostData.Name = "pnlPostData";
            this.pnlPostData.Size = new System.Drawing.Size(565, 92);
            this.pnlPostData.TabIndex = 11;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(346, 52);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(288, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date:";
            // 
            // txtCustom
            // 
            this.txtCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustom.ForeColor = System.Drawing.Color.Black;
            this.txtCustom.Location = new System.Drawing.Point(121, 49);
            this.txtCustom.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(163, 27);
            this.txtCustom.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPrice.Location = new System.Drawing.Point(3, 49);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 22);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Customer ID:";
            // 
            // txtEmploy
            // 
            this.txtEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploy.ForeColor = System.Drawing.Color.Black;
            this.txtEmploy.Location = new System.Drawing.Point(400, 9);
            this.txtEmploy.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmploy.Name = "txtEmploy";
            this.txtEmploy.Size = new System.Drawing.Size(163, 27);
            this.txtEmploy.TabIndex = 16;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblProductName.Location = new System.Drawing.Point(287, 14);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(116, 22);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Employee ID:";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceID.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceID.Location = new System.Drawing.Point(120, 9);
            this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(163, 27);
            this.txtInvoiceID.TabIndex = 14;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblProductID.Location = new System.Drawing.Point(2, 12);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(93, 22);
            this.lblProductID.TabIndex = 13;
            this.lblProductID.Text = "Invoice ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtPro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtamount);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnDeleteChitiet);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnUpdateChiTiet);
            this.panel2.Controls.Add(this.txtTien);
            this.panel2.Controls.Add(this.btnAddChiTiet);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtInID2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(572, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 146);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(262, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Product:";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.ForeColor = System.Drawing.Color.Black;
            this.txtamount.Location = new System.Drawing.Point(93, 49);
            this.txtamount.Margin = new System.Windows.Forms.Padding(2);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(163, 27);
            this.txtamount.TabIndex = 18;
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Tomato;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::PetShopProject.Properties.Resources.close1_24_white;
            this.btnHuy.Location = new System.Drawing.Point(355, 92);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(83, 39);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnDeleteChitiet.Location = new System.Drawing.Point(180, 92);
            this.btnDeleteChitiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteChitiet.Name = "btnDeleteChitiet";
            this.btnDeleteChitiet.Size = new System.Drawing.Size(83, 39);
            this.btnDeleteChitiet.TabIndex = 11;
            this.btnDeleteChitiet.UseVisualStyleBackColor = false;
            this.btnDeleteChitiet.Click += new System.EventHandler(this.btnDeleteChitiet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(2, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Amount:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::PetShopProject.Properties.Resources.check_24_white;
            this.btnLuu.Location = new System.Drawing.Point(266, 92);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 39);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnUpdateChiTiet
            // 
            this.btnUpdateChiTiet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateChiTiet.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateChiTiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateChiTiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnUpdateChiTiet.Image = global::PetShopProject.Properties.Resources.edit_24_white;
            this.btnUpdateChiTiet.Location = new System.Drawing.Point(93, 92);
            this.btnUpdateChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateChiTiet.Name = "btnUpdateChiTiet";
            this.btnUpdateChiTiet.Size = new System.Drawing.Size(83, 39);
            this.btnUpdateChiTiet.TabIndex = 10;
            this.btnUpdateChiTiet.UseVisualStyleBackColor = false;
            this.btnUpdateChiTiet.Click += new System.EventHandler(this.btnUpdateChiTiet_Click);
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.ForeColor = System.Drawing.Color.Black;
            this.txtTien.Location = new System.Drawing.Point(338, 49);
            this.txtTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(163, 27);
            this.txtTien.TabIndex = 16;
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
            this.btnAddChiTiet.Location = new System.Drawing.Point(6, 92);
            this.btnAddChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddChiTiet.Name = "btnAddChiTiet";
            this.btnAddChiTiet.Size = new System.Drawing.Size(83, 39);
            this.btnAddChiTiet.TabIndex = 9;
            this.btnAddChiTiet.UseVisualStyleBackColor = false;
            this.btnAddChiTiet.Click += new System.EventHandler(this.btnAddChiTiet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(260, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total:";
            // 
            // txtInID2
            // 
            this.txtInID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInID2.ForeColor = System.Drawing.Color.Black;
            this.txtInID2.Location = new System.Drawing.Point(93, 9);
            this.txtInID2.Margin = new System.Windows.Forms.Padding(2);
            this.txtInID2.Name = "txtInID2";
            this.txtInID2.Size = new System.Drawing.Size(163, 27);
            this.txtInID2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(2, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Invoice ID:";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaSanPham,
            this.SoLuong,
            this.ThanhTien});
            this.dgvList.Location = new System.Drawing.Point(572, 220);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(508, 176);
            this.dgvList.TabIndex = 17;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // txtPro
            // 
            this.txtPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro.ForeColor = System.Drawing.Color.Black;
            this.txtPro.Location = new System.Drawing.Point(338, 9);
            this.txtPro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPro.Name = "txtPro";
            this.txtPro.Size = new System.Drawing.Size(163, 27);
            this.txtPro.TabIndex = 20;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "InvoiceID";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            this.MaHoaDon.Width = 150;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "DateTime";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 150;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Employee";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNhanVien.Width = 150;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Customer";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            this.MaKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKhachHang.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Product";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            this.MaSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSanPham.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "Soluong";
            this.SoLuong.HeaderText = "Amount";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuong.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Total";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThanhTien.Width = 150;
            // 
            // ucInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlPostData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvInvoice);
            this.Name = "ucInvoices";
            this.Size = new System.Drawing.Size(1096, 436);
            this.Load += new System.EventHandler(this.ucInvoices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.pnlPostData.ResumeLayout(false);
            this.pnlPostData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlPostData;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtEmploy;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDeleteChitiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnUpdateChiTiet;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Button btnAddChiTiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInID2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}
