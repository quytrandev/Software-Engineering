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
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucProducts);
            ucProducts.Location = new Point(312, 51);
        }

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
            this.btnLogOut.ForeColor=System.Drawing.Color.RoyalBlue;
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
    }
}
