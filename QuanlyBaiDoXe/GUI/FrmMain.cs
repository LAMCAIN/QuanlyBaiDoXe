using QuanlyBaiDoXe.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyBaiDoXe.GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            cboLoaiXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiXe.Items.Clear();
            cboLoaiXe.Items.Add("Ô Tô");
            cboLoaiXe.Items.Add("Xe Máy");
            cboLoaiXe.SelectedIndex = 0;

            txtThoiGianVao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            KhoiTaoSoDoBaiDoXe();
        }

        private Button currentSelectedBtn = null;

        private void HienThiThongTinLenGiaoDien(Button btn)
        {
            string maViTri = btn.Text.Split('\n')[0];
            string trangThai = btn.Tag.ToString();

            lblViTriChon.Text = $"Vị trí: {maViTri}";

            if (trangThai == "Trống")
            {
                lblTrangThaiChon.Text = "Trạng thái: Ô trống";
                lblBienSoChon.Text = "Biển số: ---";
                lblLoaiXeChon.Text = "Loại xe: ---";
            }    
            else
            {
                string[] info = trangThai.Split('|');
                lblTrangThaiChon.Text = "Trạng thái: Đang gửi";
                lblBienSoChon.Text = $"Biển số: {info[0]}";
                lblLoaiXeChon.Text = $"Loại xe: {info[1]}";
            }    
        }
        
        //Mở rộng với di chuột xem thông tin xe (không cần ấn) (nếu làm tiếp)
        private void XoaThongTinTrenGiaoDien()
        {
            lblViTriChon.Text = "Vị trí: ---";
            lblTrangThaiChon.Text = "Trạng thái: ---";
            lblBienSoChon.Text = "Biển số: ---";
            lblLoaiXeChon.Text = "Loại xe: ---";
        }
    
        private void BoKhoaCoDinh()
        {
            if (currentSelectedBtn != null)
            {
                currentSelectedBtn.FlatStyle = FlatStyle.Standard;
                currentSelectedBtn = null;
            }    
        }

        private void BtnSlot_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            
            if (currentSelectedBtn == clickedBtn)
            {
                BoKhoaCoDinh();
                HienThiThongTinLenGiaoDien(clickedBtn);
            }
            else
            {
                BoKhoaCoDinh();

                currentSelectedBtn = clickedBtn;
                currentSelectedBtn.FlatAppearance.BorderColor = Color.Blue;
                currentSelectedBtn.FlatAppearance.BorderSize = 3;
                currentSelectedBtn.FlatStyle = FlatStyle.Flat;

                HienThiThongTinLenGiaoDien(currentSelectedBtn);
            }    
        }


        //Khởi tạo sơ đồ bãi xe (bên phải màn hình)
        private void KhoiTaoSoDoBaiDoXe()
        {
            tlpSoDoBaiXe.Controls.Clear();
            tlpSoDoBaiXe.ColumnCount = 6;
            tlpSoDoBaiXe.RowCount = 10;

            tlpSoDoBaiXe.ColumnStyles.Clear();
            for (int i = 0; i < 6; i++)
            {
                tlpSoDoBaiXe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 6f));
            }

            tlpSoDoBaiXe.RowStyles.Clear();
            for (int i = 0; i < 10; i++)
            {
                tlpSoDoBaiXe.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 10f));
            }

            string[] columns = { "A", "B", "C", "D", "E", "F" };

            //Lấy dữ liệu trạng thái các ô từ CSDL
            DataTable dtSlots = DataBaseHelper.ExecuteQuery("sp_GetAllSlots");

            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    string maViTri = $"{row}-{columns[col]}";
                    Button btnSlot = new Button();
                    btnSlot.Dock = DockStyle.Fill;
                    btnSlot.Margin = new Padding(2);
                    btnSlot.Text = maViTri;
                    btnSlot.BackColor = Color.LightGreen;
                    btnSlot.Tag = "Trống";

                    if (dtSlots != null && dtSlots.Rows.Count > 0)
                    {
                        DataRow[] rows = dtSlots.Select($"SLotId = '{maViTri}'");
                        if (rows.Length > 0)
                        {
                            string trangThai = rows[0]["Status"].ToString();
                            if (trangThai == "Đang gửi")
                            {
                                string bienSo = rows[0]["LicensePlate"].ToString();
                                string loaiXe = rows[0]["VehicleType"].ToString();
                            }
                        }
                    }    

                    btnSlot.Click += BtnSlot_Click;

                    tlpSoDoBaiXe.Controls.Add(btnSlot, col, row);
                }
            }
        }
  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Nút Tạo Vé
        private void btnTaoVe_Click(object sender, EventArgs e)
        {
            string bienSo = txtBienSo.Text.Trim();
            string loaiXe = cboLoaiXe.Text.Trim();

            if (string.IsNullOrEmpty (bienSo))
            {
                MessageBox.Show("Vui lòng nhập biển số xe trước khi tạo vé!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBienSo.Focus();
                return;
            }

            string pattern = @"^\d{2}[A-Z]-\d{3}\.\d{2}$";
            if (!Regex.IsMatch (bienSo, pattern))
            {
                MessageBox.Show("Biển số xe không đúng định dạng!\nVui lòng nhập lại", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBienSo.Focus ();
                txtBienSo.SelectAll();
                return;
            }    

            if (string.IsNullOrEmpty (loaiXe))
            {
                MessageBox.Show("Vui lòng chọn loại xe!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiXe.Focus();
                return;
            }    

            //Tìm ô trống đầu tiên (có màu xanh) trên sơ đồ
            Button slotTrong = null;
            foreach (Control ctrl in tlpSoDoBaiXe.Controls)
            {
                if (ctrl is Button btn && btn.BackColor == Color.LightGreen)
                {
                    slotTrong = btn;
                    break;
                }    
            }
            
            if (slotTrong == null)
            {
                MessageBox.Show("Bãi xe kín chỗ, không thể nhận thêm xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Cập nhật trạng thái ô đỗ thành có xe
            string maVitri = slotTrong.Text.Split('\n')[0];
            slotTrong.BackColor = Color.LightCoral;
            slotTrong.Tag = $"{bienSo}|{loaiXe}";
            slotTrong.Text = $"{maVitri}\n({bienSo}\n({loaiXe})";

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@SlotId", maVitri),
                    new SqlParameter("@LicensePlate", bienSo),
                    new SqlParameter("@VehicleType", loaiXe),
                    new SqlParameter("CheckInTime", DateTime.ParseExact(txtThoiGianVao.Text.Trim(), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture))
                };

                DataBaseHelper.ExecuteNonQuery("sp_UpdateLotCheckIn", parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu vào CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Tạo vé thành công!\n- Vị trí đỗ: {maVitri}\n- Biển số: {bienSo}\n- Loại xe: {loaiXe}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset ô nhập dữ liệu
            txtBienSo.Clear();
            txtThoiGianVao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        //Nút mở cổng
        private void btnMoCongVao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã phát lệnh mở thanh chắn cửa vào!", "Cổng vào", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMoCongRa_Click(object sender, EventArgs e)
        {
            txtTienPhaiTra.Clear();

            MessageBox.Show("Đã phát lệnh mở thanh chắn cửa ra!", "Cổng ra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlpSoDoBaiXe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBienSoChon_Click(object sender, EventArgs e)
        {

        }

        private void lblLoaiXeChon_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaVe_Click(object sender, EventArgs e)
        {
            string bienSoXacNhan = txtBienSoRa.Text.Trim();

            if (string.IsNullOrEmpty(bienSoXacNhan))
            {
                MessageBox.Show("Vui lòng nhập biển số xe cần check-out!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBienSoRa.Focus();
                return;
            }

            Button targetSlot = null;
            string maViTriTimDuoc = "";
            string loaiXe = "";
            string thoiGianVaoStr = "";

            foreach (Control ctrl in tlpSoDoBaiXe.Controls)
            {
                if (ctrl is Button btn)
                {
                    string tagValue = btn.Tag?.ToString() ?? "";

                    if (tagValue != "Trống" && !string.IsNullOrEmpty(tagValue))
                    {
                        string[] info = tagValue.Split('|');
                        if (info.Length >= 2)
                        {
                            string bienSoTrongHeThong = info[0].Trim();

                            if (bienSoTrongHeThong.Equals(bienSoXacNhan, StringComparison.OrdinalIgnoreCase))
                            {
                                targetSlot = btn;
                                maViTriTimDuoc = btn.Text.Split('\n')[0];
                                loaiXe = info[1].Trim();
                                thoiGianVaoStr = (info.Length >= 3) ? info[2].Trim() : DateTime.Now.AddHours(-1).ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            }
                        }
                    }    
                }    
            }

            if (targetSlot == null)
            {
                MessageBox.Show($"Không tìm thấy xe mang biển số [{bienSoXacNhan}] đang gửi trong bãi!", "Lỗi tra cứu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBienSoRa.Focus();
                txtBienSoRa.SelectAll();
                return;
            }


            DateTime thoiGianVao;
            bool parseThanhCong = DateTime.TryParseExact(
                thoiGianVaoStr,
                "dd/MM/yyyy HH:mm:ss",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out  thoiGianVao
            );

            if (!parseThanhCong)
            {
                DateTime.TryParse(thoiGianVaoStr, out thoiGianVao);
            }    

            DateTime thoiGianRa = DateTime.Now;

            int tienPhaiTra = TinhTienGuiXe(loaiXe, thoiGianVao, thoiGianRa);
            txtTienPhaiTra.Text = tienPhaiTra.ToString("#,##0") + " VNĐ";

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@SlotId", maViTriTimDuoc),
                    new SqlParameter("@LicensePlate", bienSoXacNhan),
                    new SqlParameter("@VehicleType", loaiXe),
                    new SqlParameter("@CheckInTime", thoiGianVao),
                    new SqlParameter("@CheckOutTime", thoiGianRa),
                    new SqlParameter("@Fee", (decimal)tienPhaiTra)
                };

                DataBaseHelper.ExecuteNonQuery("sp_ProcessCheckOut", parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật CSDL khi xe ra: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            targetSlot.BackColor = Color.LightGreen;
            targetSlot.Tag = "Trống";
            targetSlot.Text = maViTriTimDuoc;

            MessageBox.Show($"Check-out thành công!\n- Xe biển số: {bienSoXacNhan}\n- Rời khỏi vị trí: [{maViTriTimDuoc}]\nÔ đỗ đã được trả lại.", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBienSoRa.Clear();

            if (currentSelectedBtn == targetSlot)
            {
                HienThiThongTinLenGiaoDien(targetSlot);
            }
        }

        //5h - 18h (1);  18h - 22h (2);  22h - 5h (3)
        private int TinhTienGuiXe(string loaiXe, DateTime thoiGianVao, DateTime thoiGianRa)
        {
            if (thoiGianRa <= thoiGianVao) return 0;

            TimeSpan tongThoiGian = thoiGianRa - thoiGianVao;
            int tongTien = 0;

            int soNgayGui = (int)tongThoiGian.TotalDays;
            DateTime thoiDiemXetLe = thoiGianVao;

            if (soNgayGui > 0)
            {
                tongTien += soNgayGui * 15000;
                thoiDiemXetLe = thoiGianVao.AddDays(soNgayGui);
            }

            int gioRa = thoiGianRa.Hour;
            int gioVaoLe = thoiDiemXetLe.Hour;

            bool diQuaKhoang3 = false;
            DateTime temp = thoiDiemXetLe;
            while (temp <= thoiGianRa)
            {
                int h = temp.Hour;
                if (h >= 22 || h < 5)
                {
                    diQuaKhoang3 = true;
                    break;
                }
                temp = temp.AddHours(1);
            }

            if (diQuaKhoang3 || (gioRa >= 22 || gioRa < 5))
            {
                tongTien += 15000;
            }
            else if ((gioVaoLe >= 5 && gioVaoLe < 22) && (gioRa >= 18 && gioRa <22))
            {
                tongTien += 15000;
            }
            else
            {
                int giaNgay = (loaiXe == "Xe Máy") ? 2000 : 3000;
                tongTien += giaNgay;
            }

            return tongTien;
        }

        private void txtTienPhaiTra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
