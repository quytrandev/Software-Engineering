using PetShopProject.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//#4169E1

namespace PetShopProject
{
    public partial class frmMain : Form
    {
        ucProducts ucProducts = new ucProducts();
        ucEmployees ucEmployees = new ucEmployees();
        ucChangePassword ucChangePassword = new ucChangePassword();
        public frmMain()
        {
            InitializeComponent();
            ucProducts.Visible = false;
            ucEmployees.Visible = false;
            ucChangePassword.Visible = false;
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Add(ucProducts);
            ucProducts.Dock = DockStyle.Fill;
            
            if (ucProducts.Visible == true)
            {
                ucProducts.Visible = false;
                ucEmployees.Visible = false;
                ucChangePassword.Visible = false;
            }
            else
            {
                ucProducts.Visible = true;
                ucEmployees.Visible = false;
                ucChangePassword.Visible = false;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure want to sign out?", "Logout", buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form frm = new frmLogin();
                frm.ShowDialog();
            }
            else
            {

            }
           
        }
        #region MouseEnter/MouseLeave
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.close_24_blue);

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = (System.Drawing.Image)(PetShopProject.Properties.Resources.close_24_white);

        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            this.btnLogOut.ForeColor = System.Drawing.Color.RoyalBlue;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogOut.ForeColor = System.Drawing.Color.White;

        }

        private void btnProducts_MouseEnter(object sender, EventArgs e)
        {
            this.btnProducts.ForeColor = System.Drawing.Color.RoyalBlue;

        }

        private void btnProducts_MouseLeave(object sender, EventArgs e)
        {
            this.btnProducts.ForeColor = System.Drawing.Color.White;

        }

        #endregion

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Add(ucEmployees);
            ucEmployees.Dock = DockStyle.Fill;
            if (ucEmployees.Visible == true)
            {
                ucEmployees.Visible = false;
                ucProducts.Visible = false;
                ucChangePassword.Visible = false;
            }
            else
            {
                ucEmployees.Visible = true;
                ucProducts.Visible = false;
                ucChangePassword.Visible = false;
            }
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Add(ucChangePassword);
            ucChangePassword.Dock = DockStyle.Fill;

            if (ucChangePassword.Visible == true)
            {
                ucChangePassword.Visible = false;
                ucProducts.Visible = false;
                ucEmployees.Visible = false;
            }
            else
            {
                ucChangePassword.Visible = true;
                ucProducts.Visible = false;
                ucEmployees.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
