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
    public partial class ucCreateAccount : UserControl
    {
        private AccountBusiness accountBusiness;
        private AccountModel account;
        private bool isAdd;

        public ucCreateAccount()
        {
            accountBusiness = new AccountBusiness();
            account = new AccountModel();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCreateAcc.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            isAdd = true;
            account.TenDangNhap = txtUsername.Text.Trim();
            account.MatKhau = txtPassword.Text.Trim();
            account.MaLoaiNV = int.Parse(cbAuth.SelectedValue.ToString());
            if (isAdd == true)
            {
                int result = accountBusiness.CreateAccount(account);
                if (result == 1)
                {
                    MessageBox.Show("Added successfully!", "Add a new account");
                    
                }
                else
                {
                    MessageBox.Show("Failed to add a new account!", "Add a new account");
                }
            }
        }

        private void lblAddAccount_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pnlCreateAcc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucCreateAccount_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            
            cbAuth.SelectedItem = "";
            cbAuth.DataSource = accountBusiness.GetEmployeeTypeIDList1();
            cbAuth.DisplayMember = "TenLoaiNV";
            cbAuth.ValueMember = "MaLoaiNV";

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
