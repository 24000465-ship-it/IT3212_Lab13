using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.BUS;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmSinhVien : Form
    {
        private SinhVienBUS _bus = new SinhVienBUS();

        private BindingList<SinhVien> _ds = new BindingList<SinhVien>();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.SelectedIndex = 0;

            List<Khoa> dsKhoa = _bus.GetDanhSachKhoa();
            for (int i = 0; i < dsKhoa.Count; i++)
            {
                cboKhoa.Items.Add(dsKhoa[i].TenKhoa);
            }
            cboKhoa.SelectedIndex = 0;
            dtpNgaySinh.MaxDate = DateTime.Today;

            TaoCot();
            dgvSinhVien.DataSource = _ds;
            NapDuLieu(_bus.GetAll());
        }

        private void TaoCot()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.Columns.Clear();
            ThemCot("MaSV", "Mã SV", 90, "");
            ThemCot("HoTen", "Họ tên", 180, "");
            ThemCot("NgaySinh", "Ngày sinh", 100, "dd/MM/yyyy");
            ThemCot("GioiTinh", "Giới tính", 80, "");
            ThemCot("Khoa", "Khoa", 180, "");
            ThemCot("DiemTB", "Điểm TB", 80, "0.00");
        }

        private void ThemCot(string thuocTinh, string tieuDe, int rong, string dinhDang)
        {
            DataGridViewTextBoxColumn cot = new DataGridViewTextBoxColumn();
            cot.DataPropertyName = thuocTinh;
            cot.HeaderText = tieuDe;
            cot.FillWeight = rong;
            if (dinhDang != "") cot.DefaultCellStyle.Format = dinhDang;
            dgvSinhVien.Columns.Add(cot);
        }

        private void NapDuLieu(List<SinhVien> ds)
        {
            _ds.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                _ds.Add(ds[i]);
            }
            lblTongSo.Text = "Tổng số: " + _ds.Count + " sinh viên";
        }

        private SinhVien DocTuForm()
        {
            string chuoiDiem = txtDiemTB.Text.Trim().Replace(',', '.');
            double diem;
            if (!double.TryParse(chuoiDiem, NumberStyles.Number, CultureInfo.InvariantCulture, out diem))
                throw new ArgumentException("Điểm TB phải là số.");
            return new SinhVien(txtMaSV.Text.Trim(), txtHoTen.Text, dtpNgaySinh.Value,
                cboGioiTinh.Text, cboKhoa.Text, diem);
        }

        private SinhVien SinhVienDangChon()
        {
            if (dgvSinhVien.CurrentRow == null) return null;
            return dgvSinhVien.CurrentRow.DataBoundItem as SinhVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = DocTuForm();
                _bus.Add(sv);
                _ds.Add(sv);
                lblTongSo.Text = "Tổng số: " + _ds.Count + " sinh viên";
                MessageBox.Show("Đã thêm sinh viên " + sv.HoTen + ".", "Thông báo");
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien cu = SinhVienDangChon();
            if (cu == null)
            {
                MessageBox.Show("Chọn sinh viên cần sửa.", "Thông báo");
                return;
            }
            if (txtMaSV.Text.Trim() != cu.MaSV)
            {
                MessageBox.Show("Không được đổi mã sinh viên khi sửa.", "Lỗi");
                txtMaSV.Text = cu.MaSV;
                return;
            }
            try
            {
                SinhVien moi = DocTuForm();
                _bus.Update(moi);
                int viTri = _ds.IndexOf(cu);
                _ds[viTri] = moi;
                MessageBox.Show("Đã cập nhật sinh viên " + moi.MaSV + ".", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = SinhVienDangChon();
            if (sv == null)
            {
                MessageBox.Show("Chọn sinh viên cần xóa.", "Thông báo");
                return;
            }
            DialogResult traLoi = MessageBox.Show("Xóa sinh viên " + sv.MaSV + " - " + sv.HoTen + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
            {
                _bus.Delete(sv.MaSV);
                _ds.Remove(sv);
                lblTongSo.Text = "Tổng số: " + _ds.Count + " sinh viên";
                LamMoi();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            dtpNgaySinh.Value = new DateTime(2006, 1, 1);
            cboGioiTinh.SelectedIndex = 0;
            cboKhoa.SelectedIndex = 0;
            txtMaSV.Focus();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhVien sv = SinhVienDangChon();
            if (sv == null) return;
            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            cboGioiTinh.Text = sv.GioiTinh;
            cboKhoa.Text = sv.Khoa;
            txtDiemTB.Text = sv.DiemTB.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã hoặc họ tên cần tìm.", "Thông báo");
                return;
            }
            NapDuLieu(_bus.TimKiem(txtTimKiem.Text));
            lblTongSo.Text = "Tìm thấy: " + _ds.Count + " sinh viên";
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            NapDuLieu(_bus.GetAll());
        }
    }
}
