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
    #region tngo add start
    public class EmployeeRepository : BaseDAL
    {
        public DataTable GetEmployeeList()
        {
            return ExecuteQueryNonParams("sp_GetEmployeeList");
        }
        public DataTable GetEmployeeTypeIDList()
        {
            return ExecuteQueryNonParams("sp_GetEmployeeTypeID");
        }
        public int AddEmployee(EmployeeModel employee)
        {
            var parameters = new List<SqlParameter>()
            {
                //new SqlParameter { ParameterName = "@MaNhanVien", SqlDbType = SqlDbType.Int, Value =employee.MaNhanVien },
                new SqlParameter { ParameterName = "@TenNhanVien", SqlDbType = SqlDbType.VarChar, Value =employee.TenNhanVien.Trim() },
                new SqlParameter { ParameterName = "@Tuoi", SqlDbType = SqlDbType.Int, Value =employee.Tuoi },
                new SqlParameter { ParameterName = "@SoDT", SqlDbType = SqlDbType.VarChar, Value =employee.SoDT },
                new SqlParameter { ParameterName = "@GioiTinh", SqlDbType = SqlDbType.VarChar, Value =employee.GioiTinh.Trim() },
                new SqlParameter { ParameterName = "@MaLoaiNV", SqlDbType = SqlDbType.Int, Value =employee.MaLoaiNV }
            };
            return ExecuteNonQuery("sp_AddEmployee", parameters);
        }
        public int EditEmployee(EmployeeModel employee)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter { ParameterName = "@MaNhanVien", SqlDbType = SqlDbType.Int, Value =employee.MaNhanVien},
                new SqlParameter { ParameterName = "@TenNhanVien", SqlDbType = SqlDbType.VarChar, Value =employee.TenNhanVien.Trim() },
                new SqlParameter { ParameterName = "@Tuoi", SqlDbType = SqlDbType.Int, Value =employee.Tuoi },
                new SqlParameter { ParameterName = "@SoDT", SqlDbType = SqlDbType.VarChar, Value =employee.SoDT },
                new SqlParameter { ParameterName = "@GioiTinh", SqlDbType = SqlDbType.VarChar, Value =employee.GioiTinh.Trim() },
                new SqlParameter { ParameterName = "@MaLoaiNV", SqlDbType = SqlDbType.Int, Value =employee.MaLoaiNV }
            };
            return ExecuteNonQuery("sp_EditEmployee", parameters);
        }
        public int DeleteEmployee(int employeeID)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@MaNhanVien", SqlDbType = SqlDbType.Int, Value =employeeID}
            };
            return ExecuteNonQuery("sp_DeleteEmployee", parameters);
        }

        public DataTable SearchEmployee(string employeeName)
        {

            var parameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@TenNhanVien", SqlDbType = SqlDbType.VarChar, Value =employeeName}
            };
            return ExecuteQuery("sp_SearchEmployee", parameters);
        }
        
    }
    #endregion
}

