using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Lab11_CRUD_StoredProcedure.BUS;
using Lab11_CRUD_StoredProcedure.DTO;

namespace Lab11_CRUD_StoredProcedure.GUI
{
    public partial class frmSinhVien : Form
    {
        private SinhVienBUS _bus = new SinhVienBUS();
        private KhoaBUS _khoaBus = new KhoaBUS();
        private bool dangNap = false;

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                NapKhoa();
                LoadStudents();
                LamMoi();
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Mở form sinh viên");
            }
        }

        private void NapKhoa()
        {
            List<KhoaDTO> dsKhoa = _khoaBus.DanhSach();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DataSource = dsKhoa;

            List<KhoaDTO> dsLoc = new List<KhoaDTO>();
            dsLoc.Add(new KhoaDTO { MaKhoa = "", TenKhoa = "Tất cả" });
            dsLoc.AddRange(dsKhoa);
            cboLocKhoa.DisplayMember = "TenKhoa";
            cboLocKhoa.ValueMember = "MaKhoa";
            cboLocKhoa.DataSource = dsLoc;
        }

        private void LoadStudents()
        {
            dangNap = true;
            try
            {
                List<SinhVienDTO> ds = _bus.TimKiem(txtTuKhoa.Text, Convert.ToString(cboLocKhoa.SelectedValue), chkHienDaXoa.Checked);
                dgvSinhVien.DataSource = ds;
                DinhDangLuoi();
                lblTongSo.Text = "Tổng: " + ds.Count + " sinh viên";
            }
            finally
            {
                dangNap = false;
            }
        }

        private void DinhDangLuoi()
        {
            dgvSinhVien.Columns["GioiTinh"].Visible = false;
            dgvSinhVien.Columns["MaKhoa"].Visible = false;
            dgvSinhVien.Columns["IsActive"].Visible = false;
            dgvSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["TenKhoa"].HeaderText = "Khoa";
            dgvSinhVien.Columns["DiemTB"].HeaderText = "Điểm TB";
            dgvSinhVien.Columns["GioiTinhText"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvSinhVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSinhVien.Columns["DiemTB"].DefaultCellStyle.Format = "0.00";

            dgvSinhVien.Columns["MaSV"].FillWeight = 55;
            dgvSinhVien.Columns["HoTen"].FillWeight = 120;
            dgvSinhVien.Columns["NgaySinh"].FillWeight = 75;
            dgvSinhVien.Columns["TenKhoa"].FillWeight = 120;
            dgvSinhVien.Columns["DiemTB"].FillWeight = 55;
            dgvSinhVien.Columns["Email"].FillWeight = 125;
            dgvSinhVien.Columns["GioiTinhText"].FillWeight = 55;
            dgvSinhVien.Columns["TrangThai"].FillWeight = 80;

            foreach (DataGridViewRow dong in dgvSinhVien.Rows)
            {
                SinhVienDTO sv = (SinhVienDTO)dong.DataBoundItem;
                if (!sv.IsActive)
                    dong.DefaultCellStyle.ForeColor = Color.Gray;
            }
            dgvSinhVien.ClearSelection();
        }

        private SinhVienDTO DocForm()
        {
            decimal diem;
            string chuoiDiem = txtDiemTB.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(chuoiDiem, NumberStyles.Number, CultureInfo.InvariantCulture, out diem))
                throw new FormatException("Điểm TB phải là số, ví dụ 7.5");
            if (cboKhoa.SelectedValue == null)
                throw new ArgumentException("Chưa chọn khoa.");

            SinhVienDTO dto = new SinhVienDTO
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = radNam.Checked,
                MaKhoa = cboKhoa.SelectedValue.ToString(),
                DiemTB = diem,
                Email = txtEmail.Text.Trim()
            };
            return dto;
        }

        private SinhVienDTO DongDangChon()
        {
            if (dgvSinhVien.SelectedRows.Count == 0) return null;
            return dgvSinhVien.SelectedRows[0].DataBoundItem as SinhVienDTO;
        }

        private void ChonDong(string maSV)
        {
            foreach (DataGridViewRow dong in dgvSinhVien.Rows)
            {
                if (((SinhVienDTO)dong.DataBoundItem).MaSV == maSV)
                {
                    dgvSinhVien.CurrentCell = dong.Cells["MaSV"];
                    dong.Selected = true;
                    return;
                }
            }
        }

        private void LamMoi()
        {
            dgvSinhVien.ClearSelection();
            txtMaSV.Clear();
            txtMaSV.ReadOnly = false;
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Today.AddYears(-19);
            radNam.Checked = true;
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            txtDiemTB.Clear();
            txtEmail.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnKhoiPhuc.Enabled = false;
            lblTrangThai.Text = "Nhập thông tin rồi bấm Thêm, hoặc chọn một dòng để sửa, xóa.";
            txtMaSV.Focus();
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dangNap) return;
            SinhVienDTO sv = DongDangChon();
            if (sv == null) return;

            txtMaSV.Text = sv.MaSV;
            txtMaSV.ReadOnly = true;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            radNam.Checked = sv.GioiTinh;
            radNu.Checked = !sv.GioiTinh;
            cboKhoa.SelectedValue = sv.MaKhoa;
            txtDiemTB.Text = sv.DiemTB.ToString("0.00", CultureInfo.InvariantCulture);
            txtEmail.Text = sv.Email;

            btnThem.Enabled = false;
            btnSua.Enabled = sv.IsActive;
            btnXoa.Enabled = sv.IsActive;
            btnKhoiPhuc.Enabled = !sv.IsActive;
            lblTrangThai.Text = "Đang chọn: " + sv.MaSV + " - " + sv.HoTen + " (" + sv.TrangThai + ")";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVienDTO dto = DocForm();
                _bus.Add(dto);
                LoadStudents();
                ChonDong(dto.MaSV);
                MessageBox.Show("Thêm thành công.", "Thêm sinh viên");
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Thêm sinh viên " + txtMaSV.Text.Trim());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVienDTO dto = DocForm();
                _bus.Update(dto);
                LoadStudents();
                ChonDong(dto.MaSV);
                MessageBox.Show("Cập nhật thành công.", "Sửa sinh viên");
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Sửa sinh viên " + txtMaSV.Text.Trim());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = DongDangChon();
            if (sv == null) return;
            DialogResult chon = MessageBox.Show("Xóa sinh viên " + sv.MaSV + " - " + sv.HoTen + "?\n"
                + "Sinh viên chỉ bị ẩn khỏi danh sách và có thể khôi phục lại.", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon != DialogResult.Yes) return;
            try
            {
                _bus.Delete(sv.MaSV);
                LoadStudents();
                LamMoi();
                lblTrangThai.Text = "Đã xóa sinh viên " + sv.MaSV + ".";
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Xóa sinh viên " + sv.MaSV);
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = DongDangChon();
            if (sv == null) return;
            try
            {
                _bus.KhoiPhuc(sv.MaSV);
                LoadStudents();
                ChonDong(sv.MaSV);
                lblTrangThai.Text = "Đã khôi phục sinh viên " + sv.MaSV + ".";
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Khôi phục sinh viên " + sv.MaSV);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                LoadStudents();
                LamMoi();
                lblTrangThai.Text = "Kết quả tìm kiếm: " + dgvSinhVien.Rows.Count + " sinh viên.";
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Tìm kiếm sinh viên");
            }
        }
    }
}
