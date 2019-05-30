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
    public partial class ucCategory : UserControl
    {
        private CategoryBusiness categoryBusiness;
        private LoaiSanPham loaiSanPham;
        private bool isAdd;
        public DataTable dtCategory;
        public ucCategory()
        {
            InitializeComponent();
           categoryBusiness = new CategoryBusiness();
            loaiSanPham = new LoaiSanPham();
        }
        private void loadData()
        {
            dtCategory = new DataTable();
            dtCategory.Clear();
            dtCategory = categoryBusiness.getCategoryList().Tables[0];
            dagvCategory.DataSource = dtCategory;
            //
            txtFind.Enabled = true;
            txtProductName.Enabled = false;
           dagvCategory_CellClick(null, null);
        }
        private void ucCategory_Load(object sender, EventArgs e)
        {
            loadData();
            
        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtFind.ResetText();
            txtFind.Enabled = false;
            txtProductName.Enabled = true;
            txtProductName.ResetText();
            //

        }
        private void dagvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dagvCategory.CurrentCell.RowIndex;
            txtProductName.Text = dagvCategory.Rows[r].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            txtFind.ResetText();
            txtProductName.Enabled = true;
            txtProductName.ResetText();
            txtFind.Enabled = false;

        }
        private void btnAddData_Click(object sender, EventArgs e)
        {
            loaiSanPham.TenLoaiSP = txtProductName.Text;
            string err = "";
            if (isAdd == true)
            {
                bool result = categoryBusiness.AddCategory(loaiSanPham, ref err);
                if (result)
                {
                    MessageBox.Show("Added successfully!", "Add a new category");
                }
                else
                {
                    MessageBox.Show("Failed to add a new category! Error" + err, "Add a new category");

                }
            }
            else
            {
                bool result = categoryBusiness.EditCategory(loaiSanPham,ref err);
                if (result)
                {
                    MessageBox.Show("Edited successfully!", "Edit a category");
                }
                else
                {
                    MessageBox.Show("Failed to edit a category!Error:"+err, "Edit a category");

                }
            }
            loadData();

        }
        #region MouseEnter/MouseLeave
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
        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string err = "";
            DialogResult isDeleted = MessageBox.Show("Are you sure want to delete this category?", "Delete a category", MessageBoxButtons.YesNo);
            if (isDeleted == DialogResult.Yes)
            {
                int r = dagvCategory.CurrentCell.RowIndex;
                int categoryID = Int32.Parse(dagvCategory.Rows[r].Cells[0].Value.ToString());
                bool result = categoryBusiness.DeleteCategory(categoryID,ref err);
                if (result)
                {
                    MessageBox.Show("Deleted successfully!", "Delete a category");
                }
                else
                {
                    MessageBox.Show("Failed to delete a category!Error:"+err, "Delete a category");

                }
                loadData();
            }

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if(txtFind.Text.Trim()!=null)
            {
                dtCategory = new DataTable();
                dtCategory.Clear();
                dtCategory = categoryBusiness.searchCategory(txtFind.Text.Trim()).Tables[0];
                dagvCategory.DataSource = dtCategory;
                txtFind.Enabled = true;
                txtProductName.Enabled = false;
                dagvCategory_CellClick(null, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                txtProductName.ResetText();
                loadData();
            }
        }
    }
}
