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
    public partial class ucEmployees : UserControl
    {
        private EmployeeBusiness EmployeeBusiness;
        private EmployeeModel Employee;
        private bool isAdd;
        public ucEmployees()
        {
            EmployeeBusiness = new EmployeeBusiness();
            Employee = new EmployeeModel();
            InitializeComponent();
            customDgvEmployee();
            pnlPostData.Hide();
        }
        private void customDgvEmployee()
        {
            dgvEmployee.BorderStyle = BorderStyle.None;
            dgvEmployee.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvEmployee.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvEmployee.DefaultCellStyle.SelectionForeColor = Color.Lavender;
            dgvEmployee.BackgroundColor = Color.White;
            dgvEmployee.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dgvEmployee.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgvEmployee.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;


            dgvEmployee.EnableHeadersVisualStyles = false;
            dgvEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            dgvEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvEmployee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployee.Columns["MaNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployee.Columns["MaLoaiNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployee.Columns["Tuoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployee.Columns["SoDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployee.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void loadData()
        {
            var source = new BindingSource();
            source.DataSource = EmployeeBusiness.GetEmployeeList();
            dgvEmployee.DataSource = source;
            //
            cbEmployeeTypeID.SelectedItem = "";
            cbEmployeeTypeID.DataSource = EmployeeBusiness.GetEmployeeTypeIDList();
            cbEmployeeTypeID.DisplayMember = "MaLoaiNV";
            cbEmployeeTypeID.ValueMember = "MaLoaiNV";

        }
        private void ucEmployees_Load(object sender, EventArgs e)
        {
            loadData();
        }



        #region Input validation


        #endregion

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvEmployee.CurrentCell.RowIndex;
            txtEmployeeID.Text =
            dgvEmployee.Rows[r].Cells[0].Value.ToString();
            txtEmployeeName.Text =
            dgvEmployee.Rows[r].Cells[1].Value.ToString();
            txtAge.Text =
            dgvEmployee.Rows[r].Cells[2].Value.ToString();
            txtPhoneNumber.Text =
            dgvEmployee.Rows[r].Cells[3].Value.ToString();
            cbGender.Text =
            dgvEmployee.Rows[r].Cells[4].Value.ToString();
            cbEmployeeTypeID.Text =
            dgvEmployee.Rows[r].Cells[5].Value.ToString();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            pnlPostData.Show();
            txtEmployeeID.Enabled = false;
            txtEmployeeID.ResetText();
            txtEmployeeName.ResetText();
            txtAge.ResetText();
            txtPhoneNumber.ResetText();
            cbGender.SelectedItem = "";
            cbEmployeeTypeID.SelectedItem = "";
            lblEmployeeID.Hide();
            txtEmployeeID.Hide();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            pnlPostData.Show();
            txtEmployeeID.Enabled = false;
            lblEmployeeID.Show();
            txtEmployeeID.Show();
            dgvEmployee_CellClick(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvEmployee_CellClick(null, null);
            int employeeID = Convert.ToInt32(txtEmployeeID.Text);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult isDeleted = MessageBox.Show("Are you sure want to delete this Employee?", "Delete a Employee", buttons);
            if (isDeleted == DialogResult.Yes)
            {
                int result = EmployeeBusiness.DeleteEmployee(employeeID);
                if (result == 1)
                {
                    MessageBox.Show("Deleted successfully!", "Delete a Employee");
                    pnlPostData.Hide();


                }
                else
                {
                    MessageBox.Show("Failed to delete a Employee!", "Delete a Employee");

                }
                loadData();
            }
            else
            {

            }
        }
        
        private void btnAddData_Click(object sender, EventArgs e)
        {
            Employee.MaNhanVien = int.Parse(txtEmployeeID.Text);
            Employee.TenNhanVien = txtEmployeeName.Text.Trim();
            Employee.Tuoi = int.Parse(txtAge.Text);
            Employee.SoDT = txtPhoneNumber.Text;
            Employee.GioiTinh = cbGender.Text;
            Employee.MaLoaiNV =int.Parse(cbEmployeeTypeID.SelectedValue.ToString());
            if (isAdd == true)
            {
                int result = EmployeeBusiness.AddEmployee(Employee);
                if (result == 1)
                {
                    MessageBox.Show("Added successfully!", "Add a new Employee");
                    pnlPostData.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to add a new Employee!", "Add a new Employee");
                }
            }
            else
            {
                int result = EmployeeBusiness.EditEmployee(Employee);
                if (result == 1)
                {
                    MessageBox.Show("Edited successfully!", "Edit a Employee");
                    pnlPostData.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to edit a Employee!", "Edit a Employee");

                }
            }
            loadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlPostData.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlPostData.Hide();
        }

        #region MouseEnter/MouseLeave
        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.Image = (Image)(PetShopProject.Properties.Resources.close_24_red);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = (Image)(PetShopProject.Properties.Resources.close1_24_white);
        }

        private void btnAddData_MouseEnter(object sender, EventArgs e)
        {
            btnAddData.Image = (Image)(PetShopProject.Properties.Resources.check_24_blue);
        }

        private void btnAddData_MouseLeave(object sender, EventArgs e)
        {
            btnAddData.Image = (Image)(PetShopProject.Properties.Resources.check_24_white);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = (Image)(PetShopProject.Properties.Resources.close_24_white);

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = (Image)(PetShopProject.Properties.Resources.close_24_blue);
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
        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = EmployeeBusiness.SearchEmployee(txtSearchEmployee.Text.Trim());
            dgvEmployee.DataSource = source;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
