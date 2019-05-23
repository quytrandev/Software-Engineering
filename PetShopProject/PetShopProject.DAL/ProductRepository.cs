using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopProject;
namespace PetShopProject.DAL
{
    public class ProductRepository:BaseDAL
    {
        
        public DataTable GetProductList()
        {
            //var parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter { ParameterName = "@DeviceID", SqlDbType = MySqlDbType.VarChar, Value = device.DeviceID.Trim() },
            //    new SqlParameter { ParameterName = "@DeviceName", MySqlDbType = MySqlDbType.VarChar, Value = device.DeviceName.Trim() },
            //    new SqlParameter { ParameterName = "@DeviceTypeID", MySqlDbType = MySqlDbType.VarChar, Value = device.DeviceTypeID },
            //    new SqlParameter { ParameterName = "@UserId", MySqlDbType = MySqlDbType.VarChar, Value = device.UserId }
            //};
            return ExecuteQueryNonParams("sp_GetProductList");
        } 
    }
}
