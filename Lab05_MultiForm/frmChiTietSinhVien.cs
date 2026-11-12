using System;
using System.IO;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmChiTietSinhVien : Form
    {
        private readonly SinhVien _sinhVien;

        // Nhận đối tượng SinhVien từ form gọi qua constructor
        public frmChiTietSinhVien(SinhVien sinhVien)
        {
            InitializeComponent();
            _sinhVien = sinhVien;
        }

        private void frmChiTietSinhVien_Load(object sender, EventArgs e)
        {
            lblMa.Text = _sinhVien.MaSV;
            lblHoTen.Text = _sinhVien.HoTen;
            lblNgaySinh.Text = _sinhVien.NgaySinh.ToString("dd/MM/yyyy");
            lblTuoi.Text = _sinhVien.TinhTuoi().ToString();
            lblGioiTinh.Text = _sinhVien.GioiTinh;
            lblKhoa.Text = _sinhVien.Khoa;
            lblDiem.Text = _sinhVien.DiemTB.ToString("N2");
            lblXepLoai.Text = _sinhVien.XepLoai();
            if (!string.IsNullOrEmpty(_sinhVien.AnhDaiDien) && File.Exists(_sinhVien.AnhDaiDien))
                picAnh.ImageLocation = _sinhVien.AnhDaiDien;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
