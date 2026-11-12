using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab11_CRUD_StoredProcedure.BUS;
using Lab11_CRUD_StoredProcedure.DTO;

namespace Lab11_CRUD_StoredProcedure.GUI
{
    public partial class frmKhoa : Form
    {
        private KhoaBUS _bus = new KhoaBUS();
        private bool dangNap = false;

        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                LoadKhoa();
                LamMoi();
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Mở form khoa");
            }
        }

        private void LoadKhoa()
        {
            dangNap = true;
            try
            {
                List<KhoaDTO> ds = _bus.DanhSach();
                dgvKhoa.DataSource = ds;
                dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã khoa";
                dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên khoa";
                dgvKhoa.Columns["SoSinhVien"].HeaderText = "Số SV";
                dgvKhoa.Columns["MaKhoa"].FillWeight = 60;
                dgvKhoa.Columns["TenKhoa"].FillWeight = 160;
                dgvKhoa.Columns["SoSinhVien"].FillWeight = 50;
                dgvKhoa.ClearSelection();
                lblTongSo.Text = "Tổng: " + ds.Count + " khoa";
            }
            finally
            {
                dangNap = false;
            }
        }

        private KhoaDTO DongDangChon()
        {
            if (dgvKhoa.SelectedRows.Count == 0) return null;
            return dgvKhoa.SelectedRows[0].DataBoundItem as KhoaDTO;
        }

        private KhoaDTO DocForm()
        {
            return new KhoaDTO { MaKhoa = txtMaKhoa.Text.Trim(), TenKhoa = txtTenKhoa.Text.Trim() };
        }

        private void LamMoi()
        {
            dgvKhoa.ClearSelection();
            txtMaKhoa.Clear();
            txtMaKhoa.ReadOnly = false;
            txtTenKhoa.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lblTrangThai.Text = "Nhập mã, tên khoa rồi bấm Thêm, hoặc chọn một dòng để sửa, xóa.";
            txtMaKhoa.Focus();
        }

        private void ChonDong(string maKhoa)
        {
            foreach (DataGridViewRow dong in dgvKhoa.Rows)
            {
                if (((KhoaDTO)dong.DataBoundItem).MaKhoa == maKhoa)
                {
                    dgvKhoa.CurrentCell = dong.Cells["MaKhoa"];
                    dong.Selected = true;
                    return;
                }
            }
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dangNap) return;
            KhoaDTO khoa = DongDangChon();
            if (khoa == null) return;
            txtMaKhoa.Text = khoa.MaKhoa;
            txtMaKhoa.ReadOnly = true;
            txtTenKhoa.Text = khoa.TenKhoa;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            lblTrangThai.Text = "Đang chọn: " + khoa.TenKhoa + " (" + khoa.SoSinhVien + " sinh viên)";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaDTO dto = DocForm();
                _bus.Add(dto);
                LoadKhoa();
                ChonDong(dto.MaKhoa);
                MessageBox.Show("Thêm khoa thành công.", "Thêm khoa");
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Thêm khoa " + txtMaKhoa.Text.Trim());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaDTO dto = DocForm();
                _bus.Update(dto);
                LoadKhoa();
                ChonDong(dto.MaKhoa);
                MessageBox.Show("Cập nhật khoa thành công.", "Sửa khoa");
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Sửa khoa " + txtMaKhoa.Text.Trim());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhoaDTO khoa = DongDangChon();
            if (khoa == null) return;
            DialogResult chon = MessageBox.Show("Xóa khoa " + khoa.MaKhoa + " - " + khoa.TenKhoa + "?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon != DialogResult.Yes) return;
            try
            {
                _bus.Delete(khoa);
                LoadKhoa();
                LamMoi();
                lblTrangThai.Text = "Đã xóa khoa " + khoa.MaKhoa + ".";
            }
            catch (Exception ex)
            {
                XuLyLoi.HienThi(ex, "Xóa khoa " + khoa.MaKhoa);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
