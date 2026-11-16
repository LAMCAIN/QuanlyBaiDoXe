using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyBaiDoXe.BLL;
using QuanlyBaiDoXe.Models;

namespace QuanlyBaiDoXe.GUI
{
    public partial class FrmLogin : Form
    {
        private TaiKhoanBLL bll = new TaiKhoanBLL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string message;

            TaiKhoan tk = bll.DangNhap(user, pass, out message);

            if (tk != null)
            {
                MessageBox.Show($"{message}\nXin chào: {tk.HoTen} - Quyền: {tk.Quyen}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
