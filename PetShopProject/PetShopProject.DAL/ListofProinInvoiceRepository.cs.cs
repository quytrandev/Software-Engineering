using PetShopProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL
{
    public class ListofProinInvoiceRepository: BaseDAL1
    {
        public DataSet getListInvoice(int Id)
        {
            return ExecuteQueryDataSetWithPra("sp_SelectListofProInvoice", CommandType.StoredProcedure, new SqlParameter("@Mahoadon", Id));
        }
        public bool Add(ChiTietHoaDon hoaDon, ref string err)
        {
            return MyExecuteNonQuery("sp_AddListofProInvoice", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Mahoadon", hoaDon.MaHoaDon),
                 new SqlParameter("@Masanpham", hoaDon.MaSanPham),
                  new SqlParameter("@Soluong", hoaDon.Soluong),
                  new SqlParameter("@Thanhtien", hoaDon.tien));
        }
        public bool Edit(ChiTietHoaDon hoaDon, ref string err)
        {
            return MyExecuteNonQuery("sp_EditListofProInvoice", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Mahoadon", hoaDon.MaHoaDon),
                 new SqlParameter("@Masanpham", hoaDon.MaSanPham),
                  new SqlParameter("@Soluong", hoaDon.Soluong),
                  new SqlParameter("@Thanhtien", hoaDon.tien));
        }
        public bool Delete(int InvoiceId,int ProId, ref string err)
        {

            return MyExecuteNonQuery("sp_DeleteListOfPro", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Mahoadon", InvoiceId),
                new SqlParameter("@MaSanPham",ProId)
              );
        }
        /*public DataSet search(int invoiceID)
        {
            return ExecuteQueryDataSetWithPra("sp_SearchInvoice", CommandType.StoredProcedure, new SqlParameter("@MaHoaDon", invoiceID));
        }*/
    }
}
