using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanlyBaiDoXe.Connection
{
    public class DataBaseHelper
    {
        // Chuỗi kết nối tới SQL Server Express
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=QuanLyBaiDoXe;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm thực thi Stored Procedure để lấy dữ liệu
        public static DataTable ExecuteQuery(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    // Bắt buộc phải dùng SqlDataAdapter ở đây
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static int ExecuteNonQuery(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange (parameters);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }    
            }
        }
    }
}
