using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmSinhVien : Form
    {
        // Danh sách khoa do frmMain truyền sang qua constructor
        private List<string> dsKhoa;

        // Danh sách sinh viên đã lưu và danh sách đang hiển thị trên ListBox
        private List<SinhVien> dsSinhVien = new List<SinhVien>();
        private List<SinhVien> dsDangHienThi = new List<SinhVien>();

        public frmSinhVien() : this(null)
        {
        }

        public frmSinhVien(List<string> danhSachKhoa)
        {
            InitializeComponent();
            if (danhSachKhoa == null)
            {
                danhSachKhoa = new List<string>();
                danhSachKhoa.Add("Công nghệ thông tin");
                danhSachKhoa.Add("Công nghệ kỹ thuật ô tô");
                danhSachKhoa.Add("Kinh tế");
            }
            dsKhoa = danhSachKhoa;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            NapDanhSachKhoa();
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            radNam.Checked = true;
            dtpNgaySinh.MaxDate = DateTime.Today;
            Input_TextChanged(null, null);
        }

        private void NapDanhSachKhoa()
        {
            cboKhoa.Items.Clear();
            for (int i = 0; i < dsKhoa.Count; i++)
            {
                cboKhoa.Items.Add(dsKhoa[i]);
            }
            if (cboKhoa.Items.Count > 0)
                cboKhoa.SelectedIndex = 0;
        }

        // ===== Bài 1: kiểm tra bắt buộc bằng ErrorProvider =====
        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool valid = true;
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errorProvider1.SetError(txtMaSV, "Nhập mã sinh viên");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Nhập họ tên");
                valid = false;
            }
            double diem;
            if (!DocDiem(out diem))
            {
                errorProvider1.SetError(txtDiemTB, "Điểm phải là số từ 0 đến 10");
                valid = false;
            }
            if (cboKhoa.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboKhoa, "Chọn khoa");
                valid = false;
            }
            return valid;
        }

        // Đọc điểm theo dấu chấm thập phân (máy cài tiếng Việt dùng dấu phẩy nên phải chỉ rõ InvariantCulture)
        private bool DocDiem(out double diem)
        {
            if (!double.TryParse(txtDiemTB.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out diem))
                return false;
            return diem >= 0 && diem <= 10;
        }

        // ===== Bài 2: chỉ cho nhập chữ số và một dấu thập phân =====
        private void txtDiemTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txtDiemTB.Text.Contains(".")) return;
            e.Handled = true;
        }

        // ===== Bài 3: dùng chung một handler cho txtMaSV, txtHoTen, txtDiemTB =====
        private void Input_TextChanged(object sender, EventArgs e)
        {
            double diem;
            bool hopLe = DocDiem(out diem);
            // Ô nào đã nhập đúng thì xóa ngay dấu báo lỗi của ô đó
            if (txtMaSV.Text.Trim() != "") errorProvider1.SetError(txtMaSV, "");
            if (txtHoTen.Text.Trim() != "") errorProvider1.SetError(txtHoTen, "");
            if (hopLe) errorProvider1.SetError(txtDiemTB, "");
            lblXemTruoc.Text = "Xem trước: " + txtMaSV.Text + " - " + txtHoTen.Text + " - " + cboKhoa.Text;
            if (hopLe)
            {
                lblTrangThai.Text = "Trạng thái: Dữ liệu điểm hợp lệ (" + diem.ToString("0.00") + ")";
                lblTrangThai.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Trạng thái: Kiểm tra điểm (phải từ 0 đến 10)";
                lblTrangThai.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Input_TextChanged(sender, e);
        }

        private int TinhTuoi(DateTime ngaySinh)
        {
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            if (ngaySinh.Date > DateTime.Today.AddYears(-tuoi))
                tuoi--;
            return tuoi;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            lblTuoi.Text = "Tuổi: " + TinhTuoi(dtpNgaySinh.Value);
        }

        // Tạo đối tượng SinhVien từ dữ liệu đang nhập trên form
        private SinhVien TaoSinhVienTuForm()
        {
            double diem;
            DocDiem(out diem);
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            SinhVien sv = new SinhVien(txtMaSV.Text.Trim(), txtHoTen.Text, dtpNgaySinh.Value.Date, gioiTinh, cboKhoa.Text, diem);
            sv.AnhDaiDien = txtDuongDanAnh.Text;
            return sv;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ, xem dấu báo lỗi cạnh các ô!", "Lỗi");
                return;
            }
            string ma = txtMaSV.Text.Trim();
            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                if (dsSinhVien[i].MaSV.ToLower() == ma.ToLower())
                {
                    errorProvider1.SetError(txtMaSV, "Mã sinh viên đã tồn tại");
                    MessageBox.Show("Mã sinh viên " + ma + " đã tồn tại!", "Lỗi");
                    return;
                }
            }
            dsSinhVien.Add(TaoSinhVienTuForm());
            HienThiDanhSach(dsSinhVien);
            lblDanhSach.Text = "Danh sách sinh viên đã lưu (" + dsSinhVien.Count + " sinh viên, nhấp đúp để xem chi tiết):";
            MessageBox.Show("Đã lưu sinh viên " + ma + ".", "Thông báo");
        }

        private void HienThiDanhSach(List<SinhVien> ds)
        {
            lstSinhVien.Items.Clear();
            dsDangHienThi = ds;
            for (int i = 0; i < ds.Count; i++)
            {
                lstSinhVien.Items.Add((i + 1) + ". " + ds[i].ToString());
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string thongTin = string.Format(
                "Mã: {0}\nHọ tên: {1}\nNgày sinh: {2:dd/MM/yyyy}\nKhoa: {3}\nGiới tính: {4}",
                txtMaSV.Text,
                txtHoTen.Text,
                dtpNgaySinh.Value,
                cboKhoa.Text,
                gioiTinh
            );
            MessageBox.Show(thongTin, "Thông tin sinh viên");
        }

        // ===== Bài 4: truyền đối tượng SinhVien sang form chi tiết qua constructor =====
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            SinhVien sv;
            if (lstSinhVien.SelectedIndex >= 0)
            {
                sv = dsDangHienThi[lstSinhVien.SelectedIndex];
            }
            else
            {
                if (!ValidateInput())
                {
                    MessageBox.Show("Chọn một sinh viên trong danh sách hoặc nhập đủ dữ liệu hợp lệ!", "Lỗi");
                    return;
                }
                sv = TaoSinhVienTuForm();
            }
            frmChiTietSinhVien f = new frmChiTietSinhVien(sv);
            f.ShowDialog();
        }

        private void lstSinhVien_DoubleClick(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex >= 0)
                btnChiTiet_Click(sender, e);
        }

        // ===== Bài 7: hộp thoại tìm kiếm trả kết quả qua property + DialogResult =====
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        public void TimKiem()
        {
            frmTimKiem f = new frmTimKiem();
            if (f.ShowDialog() != DialogResult.OK)
                return;

            string tuKhoa = f.TuKhoa.ToLower();
            List<SinhVien> ketQua = new List<SinhVien>();
            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                string noiDung;
                if (f.TimTheoMa)
                    noiDung = dsSinhVien[i].MaSV.ToLower();
                else
                    noiDung = dsSinhVien[i].HoTen.ToLower();

                if (noiDung.Contains(tuKhoa))
                    ketQua.Add(dsSinhVien[i]);
            }
            HienThiDanhSach(ketQua);
            string kieu = f.TimTheoMa ? "mã" : "tên";
            lblDanhSach.Text = "Kết quả tìm theo " + kieu + " \"" + f.TuKhoa + "\": " + ketQua.Count + " sinh viên (bấm Làm mới để hiện tất cả)";
        }

        // ===== Bài 8: truyền danh sách khoa sang form chọn, nhận lại khoa được chọn =====
        private void btnChonKhoa_Click(object sender, EventArgs e)
        {
            frmChonKhoa f = new frmChonKhoa(dsKhoa, cboKhoa.Text);
            if (f.ShowDialog() == DialogResult.OK)
            {
                cboKhoa.SelectedItem = f.KhoaDuocChon;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            radNam.Checked = true;
            NapDanhSachKhoa();
            chkDocSach.Checked = false;
            chkTheThao.Checked = false;
            chkLapTrinh.Checked = false;
            lblSoThich.Text = "Chưa chọn";
            picAnh.ImageLocation = null;
            picAnh.Image = null;
            txtDuongDanAnh.Clear();
            errorProvider1.Clear();
            HienThiDanhSach(dsSinhVien);
            lblDanhSach.Text = "Danh sách sinh viên đã lưu (" + dsSinhVien.Count + " sinh viên, nhấp đúp để xem chi tiết):";
            txtMaSV.Focus();
        }

        private void btnSoThich_Click(object sender, EventArgs e)
        {
            List<string> ds = new List<string>();
            if (chkDocSach.Checked) ds.Add("Đọc sách");
            if (chkTheThao.Checked) ds.Add("Thể thao");
            if (chkLapTrinh.Checked) ds.Add("Lập trình");
            lblSoThich.Text = ds.Count == 0 ? "Chưa chọn" : string.Join(", ", ds);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                string thuMucAnh = System.IO.Path.Combine(Application.StartupPath, "Images");
                if (System.IO.Directory.Exists(thuMucAnh))
                    dlg.InitialDirectory = thuMucAnh;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (!System.IO.File.Exists(dlg.FileName))
                    {
                        MessageBox.Show("Tệp ảnh không tồn tại!", "Lỗi");
                        return;
                    }
                    picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    picAnh.ImageLocation = dlg.FileName;
                    txtDuongDanAnh.Text = dlg.FileName;
                }
            }
        }
    }
}
