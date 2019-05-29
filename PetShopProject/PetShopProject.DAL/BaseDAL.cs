using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL
{
    public class BaseDAL
    {
        private readonly string _connectionString;
        public BaseDAL()
        {
            _connectionString =
            "Data Source=(local);Initial Catalog=PetStore;Integrated Security=True;";
        }
        protected DataTable ExecuteQuery(string storeName, List<SqlParameter> parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                if (parameters.Count > 0)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd))
                {
                    sqlAdapter.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
        protected int ExecuteNonQuery(string storeName, List<SqlParameter> parameters, ref List<SqlParameter> outParameters)
        {
            int result = -1;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;

                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                    if (param.Direction == ParameterDirection.Output)
                    {
                        outParameters.Add(new SqlParameter { ParameterName = param.ParameterName, SqlDbType = param.SqlDbType });
                    }
                }

                result = cmd.ExecuteNonQuery();
                conn.Close();
                foreach (var outParam in outParameters)
                {
                    outParam.Value = cmd.Parameters[outParam.ParameterName].Value.ToString();
                }
            }
            return result;
        }

        protected int ExecuteNonQuery(string storeName, List<SqlParameter> parameters)
        {
            int result = -1;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                cmd.Parameters.AddRange(parameters.ToArray());
                result = cmd.ExecuteNonQuery();
                conn.Close();

            }
            return result;
        }
        protected DataTable ExecuteQueryNonParams(string storeName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd))
                {
                    sqlAdapter.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
    }
}
