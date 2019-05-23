using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopProject.Business;
using PetShopProject.DAL.Models;

namespace PetShopProject
{
    public partial class ucProducts : UserControl
    {
        private ProductBusiness productBusiness;
        public ucProducts()
        {
            productBusiness = new ProductBusiness();
            InitializeComponent();
            customDgvProduct();
        }
        private void customDgvProduct()
        {
            dgvProduct.BorderStyle = BorderStyle.None;
            dgvProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvProduct.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvProduct.DefaultCellStyle.SelectionForeColor = Color.Lavender;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dgvProduct.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgvProduct.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;


            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            dgvProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProduct.Columns["MaSanPham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["MaLoaiSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["SoLuongSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProduct.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["NhaSanXuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void ucProducts_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = productBusiness.GetProductList();
            dgvProduct.DataSource = source;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.Image = (Image)(PetShopProject.Properties.Resources.add_24_blue);

        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Image = (Image)(PetShopProject.Properties.Resources.add_24_white);

        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.Image = (Image)(PetShopProject.Properties.Resources.edit_24_blue);

        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.Image = (Image)(PetShopProject.Properties.Resources.edit_24_white);

        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.Image = (Image)(PetShopProject.Properties.Resources.delete_24_red);

        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Image = (Image)(PetShopProject.Properties.Resources.delete_24_white);

        }

      
    }
}
