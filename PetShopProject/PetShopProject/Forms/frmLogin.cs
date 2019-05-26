using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //align panel giữa form
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
           
        }
       
        public static string UserName;
        // ẩn/hiện password
        private void ShowPassword()
        {
            if (cbShowPassword.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        // xóa/đặt lại chú thích 'Type your username'
        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Type your username")
                txtUsername.ResetText();
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Type your username";
                txtUsername.ForeColor = System.Drawing.Color.LightGray;
                txtUsername.Font = new Font(txtUsername.Font, FontStyle.Italic);
            }

        }
        //

        // xóa/đặt lại chú thích 'Type your password'
        private void txtPassword_Click(object sender, EventArgs e)
        {
            ShowPassword();
            if (txtPassword.Text == "Type your password")
                txtPassword.ResetText();
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Type your password";
                txtPassword.ForeColor = System.Drawing.Color.LightGray;
                txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);
                txtPassword.UseSystemPasswordChar = false;
            }

        }
        //

        //đổi fontstyle, màu chữ khi nhập username/password
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Font = new Font(txtUsername.Font, FontStyle.Regular);
            txtUsername.ForeColor = System.Drawing.Color.Black;

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Regular);
            txtPassword.ForeColor = System.Drawing.Color.Black;
            txtPassword.UseSystemPasswordChar = true;
        }
        //


        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //hiện mật khẩu
            ShowPassword();
        }
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //focus xuống textbox Mật khẩu
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
                ShowPassword();
                txtPassword.ResetText();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enter để đăng nhập
            if (e.KeyChar == 13)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                try
                {
                    //if (loginBL.CheckLogin(username, password))
                    //{
                    //    UserName = username;
                    //    frmProducts frm = new frmProducts();
                    //    this.Hide();
                    //    frm.Show();
                    //}
                }
                catch
                {
                    //Form frm = new frmWP();
                    //frm.ShowDialog();
                    this.btnSignIn.BackgroundImage = null;
                    this.btnSignIn.BackColor = System.Drawing.Color.Black;
                    this.txtUsername.Focus();
                    txtUsername.ResetText();
                    txtPassword.ResetText();
                }
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //btn đăng nhập
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            try
            {
                //if (loginBL.CheckLogin(username, password))
                //{
                //    UserName = username;
                //    frmProducts frm = new frmProducts();
                //    this.Hide();
                //    frm.Show();
                //}
            }
            catch
            {
                //Form frm = new frmWP();
                //frm.ShowDialog();
                this.btnSignIn.BackgroundImage = null;
                this.btnSignIn.BackColor = System.Drawing.Color.Black;
                this.txtUsername.Focus();
                txtUsername.ResetText();
                txtPassword.ResetText();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure want to exit?", "Exit", buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {

            }

        }

        //đổi màu nền btn SignIn

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            // this.btnSignIn.BackgroundImage = ((System.Drawing.Image)
            //(Project_1.Properties.Resources.Sign_in_bg));
            this.btnSignIn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSignIn.ForeColor = Color.RoyalBlue;


        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            this.btnSignIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSignIn.ForeColor = Color.Gainsboro;
        }

        private void btnSignIn_Enter(object sender, EventArgs e)
        {
            //this.btnSignIn.BackgroundImage = ((System.Drawing.Image)
            //(Project_1.Properties.Resources.Sign_in_bg));
            this.btnSignIn.BackColor = System.Drawing.Color.RoyalBlue;

        }

        private void btnSignIn_Leave(object sender, EventArgs e)
        {
            this.btnSignIn.BackColor = System.Drawing.Color.Black;

        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.close_24_blue);

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.close_24_white);

        }
    }
}
