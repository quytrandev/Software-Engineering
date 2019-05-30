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
using PetShopProject.Forms;

namespace PetShopProject.User_Controls
{
    public partial class usCashier : UserControl
    {
        private ProductBusiness productBusiness;
        private ProductModel product;
        private DataTable dt = null;
        // tao Table cho gio hang
        public usCashier()
        {
            InitializeComponent();
            productBusiness = new ProductBusiness();
            product = new ProductModel();
            dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("MaSanPham");
            dt.Columns.Add("TenSanPham");
            dt.Columns.Add("Soluong");
            dt.Columns.Add("ThanhTien");
        }
        private void load()
        {
            var source = new BindingSource();
            source.DataSource = productBusiness.GetProductList();
            dgvProduct.DataSource = source;
            //
            dgvProduct_CellClick(null, null);
            txtProductName.Enabled = false;
            txtPrice.Enabled = false;
            txtProid.Enabled = false;
            
        }

        private void usCashier_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim()!=null)
            {
                var source = new BindingSource();
                source.DataSource = productBusiness.searchPro(txtSearch.Text.Trim());
                dgvProduct.DataSource = source;
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvProduct.CurrentCell.RowIndex;
            txtProductName.Text = dgvProduct.Rows[r].Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[r].Cells[2].Value.ToString();
            txtProid.Text = dgvProduct.Rows[r].Cells[0].Value.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text.Trim()!=null)
            {
                try
                {
                    int Amout = Int32.Parse(txtAmount.Text.Trim());
                    if (Amout >= 0)
                    {
                        int Tien = Amout * Int32.Parse(txtPrice.Text.Trim());
                        dt.Rows.Add(txtProid.Text.Trim(),txtProductName.Text.Trim(), Amout.ToString(), Tien.ToString());
                        MessageBox.Show("Add product to cart successful !!!");
                        txtAmount.ResetText();
                    }
                    else
                    MessageBox.Show("Amount greater than 0!!!");
                }
                catch 
                {
                    MessageBox.Show("Text AMount is number!!!");
                }
            }
            else
            {
                MessageBox.Show("Text Amount not null!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCart cart = new formCart(dt);
            cart.ShowDialog();
        }
    }
}
