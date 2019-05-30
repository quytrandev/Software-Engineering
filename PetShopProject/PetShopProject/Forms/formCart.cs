using PetShopProject.Business;
using PetShopProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopProject.Forms
{
    public partial class formCart : Form
    {
        private ProductBusiness productBusiness;
        private ProductModel product;
        private DataTable dt;
        private InvoiceBusiness invoiceBusiness;
        private HoaDon hoaDon;
        private ListofProBusiness listofProBusiness;
        private ChiTietHoaDon chiTietHoaDon;
        private int Total = new int();
        
        public formCart(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            product = new ProductModel();
            productBusiness = new ProductBusiness();
            invoiceBusiness = new InvoiceBusiness();
            hoaDon = new HoaDon();
            listofProBusiness = new ListofProBusiness();
            chiTietHoaDon = new ChiTietHoaDon();
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

        private void formCart_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            // chuyển lên combobox
            dgvCart.DataSource = dt;

        }

        private void btnShowTotal_Click(object sender, EventArgs e)
        {
            Total = 0;
            for (int i = 0; i < dgvCart.RowCount; i++)
            {
                Total += Int32.Parse(dgvCart.Rows[i].Cells[3].Value.ToString());
            }

        }

        private void btnAddChiTiet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to create Invoice", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string err = "";
                // them hoa don 
                hoaDon.NgayLap = DateTime.Now;
                hoaDon.MaNhanVien = 1;
                hoaDon.MaKhachHang = 1;
                bool result = invoiceBusiness.Add(hoaDon, ref err);
                if (result)
                {
                    MessageBox.Show("Added successfully!", "Add a new invoice");
                    string mahoadon = invoiceBusiness.getLastId().Tables[0].Rows[0][0].ToString();
                    MessageBox.Show(mahoadon);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        // tim kiem san pham 
                       int proId = Int32.Parse(dt.Rows[i][0].ToString());
                        // tim kiem san pham 
                        DataTable dtpro = new DataTable();
                        dtpro.Clear();
                        dtpro = productBusiness.searchPro(proId);
                        if (dtpro != null)
                        {
                            product.MaSanPham = Int32.Parse(dtpro.Rows[0][0].ToString());
                            product.GiaBan = Int32.Parse(dtpro.Rows[0][3].ToString());
                            int Amount = Int32.Parse(dt.Rows[i][2].ToString());
                            int Total = Amount * product.GiaBan;
                            // tìm mã hóa đơn 
                            chiTietHoaDon.MaSanPham = product.MaSanPham;
                            chiTietHoaDon.Soluong = Amount;
                            chiTietHoaDon.tien = Total;
                            chiTietHoaDon.MaHoaDon = Int32.Parse(mahoadon);
                            bool result1 = listofProBusiness.Add(chiTietHoaDon, ref err);
                            if (!result1)
                            {
                                MessageBox.Show("Failed to add a new product int invoice" + err);
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not Find!!!");
                            break;
                        }
                    }
                    if (result)
                    {
                        MessageBox.Show("Add successfully");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add a new invoice! Error" + err, "Add a new invoice");



                }
            }
        }
    }
}
