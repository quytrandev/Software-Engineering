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
    public class AccountRepository : BaseDAL
    {
        public bool Login (AccountModel account)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter { ParameterName = "@TenDangNhap", SqlDbType = SqlDbType.VarChar, Value = account.TenDangNhap.Trim()},
                new SqlParameter { ParameterName = "@MatKhau", SqlDbType = SqlDbType.VarChar, Value = account.MatKhau.Trim() },
            };
            DataTable result = ExecuteQuery("sp_Login", parameters);

            return result.Rows.Count > 0;
        }

        public int ChangePassword(AccountModel account)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter { ParameterName = "@TenDangNhap", SqlDbType = SqlDbType.VarChar, Value = account.TenDangNhap.Trim()},
                new SqlParameter { ParameterName = "@MatKhau", SqlDbType = SqlDbType.VarChar, Value = account.MatKhau.Trim() },
                new SqlParameter { ParameterName = "@MatKhauMoi", SqlDbType = SqlDbType.VarChar, Value = account.MatKhauMoi.Trim() }
            };
            return ExecuteNonQuery("sp_UpdatePassword1", parameters);
        }
    }
}
