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
    public partial class ucInvoices : UserControl
    {
        private InvoiceBusiness invoiceBusiness;
        private HoaDon hoaDon;
        private ListofProBusiness listofProBusiness;
        private ChiTietHoaDon chiTietHoaDon;
        private ProductBusiness productBusiness;
        private ProductModel product;
        public DataTable dtInvoice;
        public DataTable dtListPro;
        private bool them = true;

        public ucInvoices()
        {
            InitializeComponent();
            invoiceBusiness = new InvoiceBusiness();
            hoaDon = new HoaDon();
            listofProBusiness = new ListofProBusiness();
            chiTietHoaDon = new ChiTietHoaDon();
            productBusiness = new ProductBusiness();
            product = new ProductModel();
        }
        // load
        private void load()
        {
            // truyen lên datagridview
            dtInvoice = new DataTable();
            dtInvoice.Clear();
            dtInvoice = invoiceBusiness.getList().Tables[0];
            dgvInvoice.DataSource = dtInvoice;
            //
            dgvInvoice_CellClick(null, null);
            txtTien.Enabled = false;
            txtInID2.Enabled = false;
            txtInvoiceID.Enabled = false;
            txtCustom.Enabled = false;
            txtEmploy.Enabled = false;
            txtamount.ResetText();
            txtPro.ResetText();
        }
        // ham dung dẻ load chi tiet
        private void loadchitiet()
        {
            dtListPro = new DataTable();
            dtListPro.Clear();
            dtListPro = listofProBusiness.getList(Int32.Parse(txtInvoiceID.Text.Trim())).Tables[0];
            dgvList.DataSource = dtListPro;
            dgvList_CellClick(null, null);
            txtamount.ResetText();
            txtPro.ResetText();
        }
        private void ucInvoices_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvInvoice.CurrentCell.RowIndex;
            txtInvoiceID.Text = dgvInvoice.Rows[r].Cells[0].Value.ToString();
            txtCustom.Text = dgvInvoice.Rows[r].Cells[3].Value.ToString();
            txtEmploy.Text = dgvInvoice.Rows[r].Cells[2].Value.ToString();
            date.Text = dgvInvoice.Rows[r].Cells[1].Value.ToString();
            //  chuyen qua pannel
            dtListPro = new DataTable();
            dtListPro.Clear();
            dtListPro= listofProBusiness.getList(Int32.Parse(txtInvoiceID.Text.Trim())).Tables[0];
            dgvList.DataSource = dtListPro;
            dgvList_CellClick(null, null);

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int r = dgvList.CurrentCell.RowIndex;
            txtInID2.Text = dgvList.Rows[r].Cells[0].Value.ToString();
            txtamount.Text = dgvList.Rows[r].Cells[2].Value.ToString();
            txtPro.Text = dgvList.Rows[r].Cells[1].Value.ToString();
            txtTien.Text = dgvList.Rows[r].Cells[3].Value.ToString();
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddChiTiet_Click(object sender, EventArgs e)
        {
            them = true;
            txtPro.Enabled = true;
            txtPro.ResetText();
            txtamount.ResetText();
            txtTien.ResetText();
        }

        private void btnUpdateChiTiet_Click(object sender, EventArgs e)
        {
            them = false;
            txtPro.Enabled = false;
            txtamount.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // tim san pham 
            if (txtPro.Text.Trim() != null)
            {
                try
                {
                    int proId = Int32.Parse(txtPro.Text.Trim());
                    // tim kiem san pham 
                    DataTable dtpro = new DataTable();
                    dtpro.Clear();
                    dtpro = productBusiness.searchPro(proId);
                    if (dtpro != null)
                    {
                        product.MaSanPham = Int32.Parse(dtpro.Rows[0][0].ToString());
                        product.GiaBan = Int32.Parse(dtpro.Rows[0][3].ToString());
                        if (txtamount.Text.Trim() != null)
                        {
                            try
                            {
                                int Amout = Int32.Parse(txtamount.Text.Trim());
                                if (Amout >= 0)
                                {
                                    int Tien = Amout * product.GiaBan;
                                    txtTien.Text = Tien.ToString();
                                    chiTietHoaDon.MaHoaDon = Int32.Parse(txtInvoiceID.Text.Trim());
                                    chiTietHoaDon.MaSanPham = product.MaSanPham;
                                    chiTietHoaDon.Soluong = Amout;
                                    chiTietHoaDon.tien = Tien;
                                    string err = "";
                                    if ( them == true)
                                    {
                                        bool result = listofProBusiness.Add(chiTietHoaDon, ref err);
                                        if (result)
                                        {
                                            MessageBox.Show("Added successfully!", "Add a new prodcut");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to add a new category! Error" + err, "Add a new category");

                                        }
                                        loadchitiet();
                                    }
                                    else
                                    {
                                        bool result = listofProBusiness.Edit(chiTietHoaDon, ref err);
                                        if (result)
                                        {
                                            MessageBox.Show("Edited successfully!", "Edit a product");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to edit a category!Error:" + err, "Edit a category");

                                        }
                                    }
                                    loadchitiet();
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
                    else
                        MessageBox.Show("Không tim thây mã!!!");
                }
                catch
                {
                    MessageBox.Show("Text Product is number!!!");
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                dgvList_CellClick(null, null);
            }
        }

        private void btnDeleteChitiet_Click(object sender, EventArgs e)
        {
            string err = "";
            DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int r = dgvList.CurrentCell.RowIndex;
                int invoiceID = Int32.Parse(dgvList.Rows[r].Cells[0].Value.ToString());
                int proId = Int32.Parse(dgvList.Rows[r].Cells[1].Value.ToString());
                bool result = listofProBusiness.Delete(invoiceID,proId, ref err);
                if (result)
                {
                    MessageBox.Show("Deleted successfully!", "Delete a category");
                }
                else
                {
                    MessageBox.Show("Failed to delete a category!Error:" + err, "Delete a category");

                }
                loadchitiet();
            }
        }
    }
}
