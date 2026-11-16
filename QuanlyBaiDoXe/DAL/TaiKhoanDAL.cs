using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanlyBaiDoXe.Connection;
using QuanlyBaiDoXe.Models;

namespace QuanlyBaiDoXe.DAL
{
    public class TaiKhoanDAL
    {
        public TaiKhoan KiemTraDangNhap(string user, string pass)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@User", user),
                new SqlParameter("@Pass", pass)
            };

            DataTable dt = DataBaseHelper.ExecuteQuery("sp_KiemTraDangNhap", p);

            if (dt != null && dt.Rows.Count > 0 )
            {
                DataRow row = dt.Rows[0];
                TaiKhoan tk = new TaiKhoan();
                {
                    tk.TenDangNhap = row["TenDangNhap"].ToString();
                    tk.HoTen = row["HoTen"].ToString();
                    tk.Quyen = row["Quyen"].ToString();
                    return tk;
                }
            }
            return null;

        }
    }
}
