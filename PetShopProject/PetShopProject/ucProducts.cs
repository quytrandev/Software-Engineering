using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopProject
{
    public partial class ucProducts : UserControl
    {
        public ucProducts()
        {
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
        }

        private void ucProducts_Load(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 0; i < 4; i++)
            {
                n = dgvProduct.Rows.Add();
                dgvProduct.Rows[n].Cells[0].Value = "1";
                dgvProduct.Rows[n].Cells[1].Value = "Pepsi";

            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            this.btnAdd.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.add_24_blue);

        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            this.btnAdd.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.add_24_white);

        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btnEdit.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.edit_24_blue);

        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btnEdit.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.edit_24_white);

        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            this.btnDelete.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.delete_24_red);

        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            this.btnDelete.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.delete_24_white);

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
