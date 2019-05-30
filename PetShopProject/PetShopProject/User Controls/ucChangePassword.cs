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
    public partial class ucChangePassword : UserControl
    {
        AccountBusiness accountBusiness;
        AccountModel account;
        public ucChangePassword()
        {
            accountBusiness = new AccountBusiness();
            account = new AccountModel();
            InitializeComponent();
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            txtCurrentPass.UseSystemPasswordChar = true;
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            account.TenDangNhap = frmLogin.username;
            
            account.MatKhau = txtCurrentPass.Text.Trim();
            account.MatKhauMoi = txtNewPass.Text.Trim();
            

            if (txtCurrentPass.Text.Trim() == "" ||
                txtNewPass.Text.Trim() == "" || txtRetype.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (txtNewPass.Text != txtRetype.Text)
            {
                MessageBox.Show("Pass new không khớp nhau! Vui lòng nhập lại cho đúng!!!");
            }
            else if (txtCurrentPass.Text.Trim() == txtNewPass.Text.Trim())
            {
                MessageBox.Show("Passold phải khác Passnew!!!");
            }
            else
            {
                try
                {

                    bool result = accountBusiness.Login(account);
                    int result2 = accountBusiness.ChangePassword(account);
                    if (result == true)
                    {
                        if (result2==1)
                        {
                            MessageBox.Show("cập nhập thành công");
                           
                            txtCurrentPass.ResetText();
                            txtNewPass.ResetText();
                            txtRetype.ResetText();
                            txtCurrentPass.Focus();
                        }
                        else
                        {
                            MessageBox.Show("cập nhập thất bại!!!");
                            txtCurrentPass.ResetText();
                            txtNewPass.ResetText();
                            txtRetype.ResetText();
                            txtCurrentPass.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pass không đúng!!! Mới ban nhập lại đúng pass cũ!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlChangePass.Hide();
        }

        private void ucChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Text = frmLogin.username;
            txtUsername.Enabled = false;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void txtRetype_TextChanged(object sender, EventArgs e)
        {
            txtRetype.UseSystemPasswordChar = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
