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
        private ProductModel product;
        private bool isAdd;
        public ucProducts()
        {
            productBusiness = new ProductBusiness();
            product = new ProductModel();
            InitializeComponent();
            customDgvProduct();
            pnlPostData.Hide();
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
        private void loadData()
        {
            var source = new BindingSource();
            source.DataSource = productBusiness.GetProductList();
            dgvProduct.DataSource = source;
            //
            cbProductTypeID.SelectedItem = "";
            cbProductTypeID.DataSource = productBusiness.GetProductTypeIDList();
            cbProductTypeID.DisplayMember = "MaLoaiSP";
            cbProductTypeID.ValueMember = "MaLoaiSP";

        }
        private void ucProducts_Load(object sender, EventArgs e)
        {
            loadData();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            pnlPostData.Show();
            txtProductID.Enabled = true;
            txtProductID.ResetText();
            txtProductName.ResetText();
            txtPrice.ResetText();
            txtQuantity.ResetText();
            cbProductTypeID.SelectedItem = "";
            txtFrom.ResetText();
            //

        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvProduct.CurrentCell.RowIndex;
            txtProductID.Text =
            dgvProduct.Rows[r].Cells[0].Value.ToString();
            txtProductName.Text =
            dgvProduct.Rows[r].Cells[1].Value.ToString();
            txtPrice.Text =
            dgvProduct.Rows[r].Cells[2].Value.ToString();
            txtQuantity.Text =
            dgvProduct.Rows[r].Cells[3].Value.ToString();
            cbProductTypeID.Text =
            dgvProduct.Rows[r].Cells[4].Value.ToString();
            txtFrom.Text =
            dgvProduct.Rows[r].Cells[5].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            pnlPostData.Show();
            txtProductID.Enabled = false;
            dgvProduct_CellClick(null, null);

        }
        private void btnAddData_Click(object sender, EventArgs e)
        {
            product.MaSanPham = txtProductID.Text.Trim();
            product.TenSanPham = txtProductName.Text.Trim();
            product.GiaBan = int.Parse(txtPrice.Text);
            product.SoLuongSP = int.Parse(txtQuantity.Text);
            product.MaLoaiSP = cbProductTypeID.SelectedValue.ToString();
            product.NhaSanXuat = txtFrom.Text.Trim();
            if (isAdd == true)
            {              
                int result = productBusiness.AddProduct(product);
                if (result == 1)
                {
                    MessageBox.Show("Added successfully!", "Add a new product");
                    pnlPostData.Hide();
                    

                }
                else
                {
                    MessageBox.Show("Failed to add a new product!", "Add a new product");

                }
            }
            else
            {
                int result = productBusiness.EditProduct(product);
                if (result == 1)
                {
                    MessageBox.Show("Edited successfully!", "Edit a product");
                    pnlPostData.Hide();


                }
                else
                {
                    MessageBox.Show("Failed to edit a product!", "Edit a product");

                }
            }
            loadData();
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlPostData.Hide();

        }
        #region MouseEnter/MouseLeave
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = (Image)(PetShopProject.Properties.Resources.close_24_white);

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = (Image)(PetShopProject.Properties.Resources.close_24_blue);

        }

        private void btnAddData_MouseEnter(object sender, EventArgs e)
        {
            btnAddData.Image = (Image)(PetShopProject.Properties.Resources.check_24_blue);

        }

        private void btnAddData_MouseLeave(object sender, EventArgs e)
        {
            btnAddData.Image = (Image)(PetShopProject.Properties.Resources.check_24_white);

        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.Image = (Image)(PetShopProject.Properties.Resources.close_24_red);

        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = (Image)(PetShopProject.Properties.Resources.close1_24_white);

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



        #endregion

        #region Input validation
        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvProduct_CellClick(null, null);
            string productID = txtProductID.Text;
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult isDeleted = MessageBox.Show("Are you sure want to delete this product?", "Delete a product", buttons);
            if (isDeleted == DialogResult.Yes)
            {
                int result = productBusiness.DeleteProduct(productID);
                if (result == 1)
                {
                    MessageBox.Show("Deleted successfully!", "Delete a product");
                    pnlPostData.Hide();


                }
                else
                {
                    MessageBox.Show("Failed to delete a product!", "Delete a product");

                }
                loadData();
            }
            else
            {
               
            }

        }
    }
}
