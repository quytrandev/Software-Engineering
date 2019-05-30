using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopProject.DAL.Models;


namespace PetShopProject.DAL
{
   public class CategoryRepository : BaseDAL1
    {

        public DataSet getCategoryList()
        {
            return ExecuteQueryDataSet("select * from LOAISANPHAM", CommandType.Text);
        }
        public bool AddCategory(LoaiSanPham loaiSanPham, ref string err)
        {
            return MyExecuteNonQuery("sp_AddCategory",CommandType.StoredProcedure,ref err, 
                new SqlParameter("@TenLoaiSanPham",loaiSanPham.TenLoaiSP));
        }
        public bool EditCategory(LoaiSanPham loaiSanPham, ref string err)
        {
            return MyExecuteNonQuery("sp_EditCategory", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiSP", loaiSanPham.MaLoaiSP),
                new SqlParameter("@TenLoaiSP", loaiSanPham.TenLoaiSP));
        }
        public bool DeleteCategory(int categoryID,ref string err)
        {
            
            return MyExecuteNonQuery("sp_DeleteCategory", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiSP",categoryID)
              );
        }
        public DataSet searchCategory(string categoryname)
        {
            return ExecuteQueryDataSetWithPra("sp_SearchCategory", CommandType.StoredProcedure, new SqlParameter("@TenLoaiSP", categoryname));
        }
}
}
