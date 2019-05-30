using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL
{
   public class BaseDAL1
    {
        #region // tạo chuối kết  nối
        string connectionString = "Data Source=HuyenNguyen\\SQLEXPRESS;Initial Catalog=PetStore;Integrated Security=True;";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        #endregion
        public BaseDAL1()
        {
            conn = new SqlConnection(connectionString);
            cmd = conn.CreateCommand();
        }
        #region //DataSet
        // lech select
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        // lech action: insert,delete,update
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        // lenh select su dung voi nhieu bien parameter
        public DataSet ExecuteQueryDataSetWithPra(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            foreach (SqlParameter p in param) //thêm các parameter
                cmd.Parameters.Add(p);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int ExecuteNonQuery_output(string strSQL, CommandType ct,ref string err)
        {
            int result= new int();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            try
            {
                result = (int)cmd.Parameters["@ouput"].Value;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return result;
        }
        #endregion
    }
}
