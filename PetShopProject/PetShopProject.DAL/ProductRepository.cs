using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopProject;
using PetShopProject.DAL.Models;
namespace PetShopProject.DAL
{
    public class ProductRepository:BaseDAL
    {
        
        public DataTable GetProductList()
        {
           
            return ExecuteQueryNonParams("sp_GetProductList");
        } 
        public DataTable GetProductTypeIDList()
        {
            return ExecuteQueryNonParams("sp_GetProductTypeID");
        }
        public int AddProduct(ProductModel product)
        {
            var parameters = new List<SqlParameter>()
            {
                //new SqlParameter { ParameterName = "@MaSanPham", SqlDbType = SqlDbType.VarChar, Value =product.MaSanPham.Trim() },
                new SqlParameter { ParameterName = "@TenSanPham", SqlDbType = SqlDbType.VarChar, Value =product.TenSanPham.Trim() },
                new SqlParameter { ParameterName = "@SoLuongSP", SqlDbType = SqlDbType.Int, Value =product.SoLuongSP },
                new SqlParameter { ParameterName = "@GiaBan", SqlDbType = SqlDbType.Int, Value =product.GiaBan },
                new SqlParameter { ParameterName = "@MaLoaiSP", SqlDbType = SqlDbType.VarChar, Value =product.MaLoaiSP },
                new SqlParameter { ParameterName = "@NhaSanXuat", SqlDbType = SqlDbType.VarChar, Value =product.NhaSanXuat.Trim() } 
            };
            return ExecuteNonQuery("sp_AddProduct", parameters);
        }
        public int EditProduct(ProductModel product)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter { ParameterName = "@MaSanPham", SqlDbType = SqlDbType.VarChar, Value =product.MaSanPham},
                new SqlParameter { ParameterName = "@TenSanPham", SqlDbType = SqlDbType.VarChar, Value =product.TenSanPham.Trim() },
                new SqlParameter { ParameterName = "@SoLuongSP", SqlDbType = SqlDbType.Int, Value =product.SoLuongSP },
                new SqlParameter { ParameterName = "@GiaBan", SqlDbType = SqlDbType.Int, Value =product.GiaBan },
                new SqlParameter { ParameterName = "@MaLoaiSP", SqlDbType = SqlDbType.VarChar, Value =product.MaLoaiSP },
                new SqlParameter { ParameterName = "@NhaSanXuat", SqlDbType = SqlDbType.VarChar, Value =product.NhaSanXuat.Trim() }
            };
            return ExecuteNonQuery("sp_EditProduct", parameters);
        }
        public int DeleteProduct(string productID)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@MaSanPham", SqlDbType = SqlDbType.VarChar, Value =productID.Trim() }
            };
            return ExecuteNonQuery("sp_DeleteProduct", parameters);
        }
        public DataTable SearchProduct(string productName)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@TenSanPham", SqlDbType = SqlDbType.NChar, Value =productName }
            };
            return ExecuteQuery("sp_SearchProduct",parameters);
        }
        #region 
        // Huyen Tim kiem San Pham theo ten
        public DataTable searchProduct(string productName)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter {ParameterName="@TenSP",SqlDbType= SqlDbType.VarChar,Value=productName}
            };
            return ExecuteQuery("sp_searchProduct", parameters);
        }
        public DataTable searchProduct(int productId)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter {ParameterName="@MaPro",SqlDbType= SqlDbType.Int,Value=productId}
            };
            return ExecuteQuery("sp_searchPro", parameters);
        }

        #endregion
    }
}
