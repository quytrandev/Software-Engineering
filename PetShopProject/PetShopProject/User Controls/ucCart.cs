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

namespace PetShopProject.User_Controls
{
    public partial class ucCart : UserControl
    {
        private ProductBusiness productBusiness;
        private ProductModel product;
        private DataTable dt;
        private int Total = 0;
        public ucCart()
        {
            InitializeComponent();
        }
        public ucCart(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            product = new ProductModel();
            productBusiness = new ProductBusiness();
        }
        private void ucCart_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            var source = new BindingSource();
            source.DataSource = productBusiness.GetProductList();
            // chuyển lên combobox
           /* cmbPro.DataSource = source;
            cmbPro.DisplayMember = "TenSanPham";
            cmbPro.ValueMember = "MaSanPham";
            dgvCart.DataSource = dt; */
           /* for(int i=0; i<dgvCart.RowCount;i++)
            {
                Total += Int32.Parse(dgvCart.Rows[i].Cells[2].Value.ToString());
            }
            txtTotal.Text = Total.ToString(); */
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCart.CurrentCell.RowIndex;
        }

        private void btnDeleteChitiet_Click(object sender, EventArgs e)
        {
            int r = dgvCart.CurrentCell.RowIndex;
            // lay ma
            string ma = dgvCart.Rows[r].Cells[0].Value.ToString();
            foreach (DataRow orow in dt.Select())
            {
                if (orow["MaSanPham"].ToString().Equals(ma))
                {
                    dt.Rows.Remove(orow);
                }
            }

        }


    }
}
