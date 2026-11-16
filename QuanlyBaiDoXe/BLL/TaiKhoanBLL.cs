using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyBaiDoXe.DAL;
using QuanlyBaiDoXe.Models;

namespace QuanlyBaiDoXe.BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL dal = new TaiKhoanDAL();

        public TaiKhoan DangNhap(string user, string pass, out string message)
        {
            if (string.IsNullOrWhiteSpace(user))
            {
                message = "Nhập tên đăng nhập";
                return null;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                message = "Nhập mật khẩu";
                return null;
            }

            TaiKhoan tk = dal.KiemTraDangNhap(user, pass);
            if (tk == null)
            {
                message = "Tài khoản hoặc mật khẩu không chính xác!";
                return null;
            }

            message = "Đăng nhập thành công!";
            return tk;
        }
    }
}
