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
   public class InvoiceRepository:BaseDAL1
    {
        public DataSet getList()
        {
            return ExecuteQueryDataSet("select * from HOADON", CommandType.Text);
        }
        public bool Add(HoaDon hoaDon, ref string err)
        {
            return MyExecuteNonQuery("sp_AddInvoice", CommandType.StoredProcedure, ref err,
                new SqlParameter("@NgayLap", hoaDon.NgayLap),
                 new SqlParameter("@MaNhanVien", hoaDon.MaNhanVien),
                  new SqlParameter("@MaKhachHang", hoaDon.MaKhachHang));
        }
        public bool Edit(HoaDon hoaDon, ref string err)
        {
            return MyExecuteNonQuery("sp_EditInvoice", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Mahoadon", hoaDon.MaHoaDon),
                new SqlParameter("@NgayLap", hoaDon.NgayLap),
                new SqlParameter("@MaNhanVien", hoaDon.MaNhanVien),
                  new SqlParameter("@MaKhachHang", hoaDon.MaKhachHang));
        }
        public bool Delete(int invoiceID, ref string err)
        {

            return MyExecuteNonQuery("sp_DeleteInvoice", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Mahoadon", invoiceID)
              );
        }
        public DataSet search(int invoiceID)
        {
            return ExecuteQueryDataSetWithPra("sp_SearchInvoice", CommandType.StoredProcedure, new SqlParameter("@MaHoaDon", invoiceID));
        }
        public DataSet getLastId()
        {
            return ExecuteQueryDataSetWithPra("sp_SelectLastIdInvoice", CommandType.StoredProcedure);
        }
    }
}
