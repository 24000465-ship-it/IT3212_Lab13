using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.BUS;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmSanPham : Form
    {
        private SanPhamBUS _bus = new SanPhamBUS();
        private BindingList<SanPham> _ds = new BindingList<SanPham>();

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ThemCot("MaSP", "Mã SP", 70, "");
            ThemCot("TenSP", "Tên sản phẩm", 210, "");
            ThemCot("DanhMuc", "Danh mục", 120, "");
            ThemCot("DonGia", "Đơn giá", 120, "N0");
            ThemCot("SoLuong", "Số lượng", 80, "");
            ThemCot("ThanhTien", "Giá trị tồn", 140, "N0");
            dgvSanPham.DataSource = _ds;

            cboSapXep.Items.Add("Tên A - Z");
            cboSapXep.Items.Add("Đơn giá tăng dần");
            cboSapXep.Items.Add("Đơn giá giảm dần");
            cboSapXep.Items.Add("Giá trị tồn giảm dần");

            NapDanhMuc();
            NapDuLieu(_bus.GetAll());
        }

        private void ThemCot(string thuocTinh, string tieuDe, int rong, string dinhDang)
        {
            DataGridViewTextBoxColumn cot = new DataGridViewTextBoxColumn();
            cot.DataPropertyName = thuocTinh;
            cot.HeaderText = tieuDe;
            cot.FillWeight = rong;
            if (dinhDang != "")
            {
                cot.DefaultCellStyle.Format = dinhDang;
                cot.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dgvSanPham.Columns.Add(cot);
        }

        private void NapDanhMuc()
        {
            cboDanhMuc.Items.Clear();
            List<string> dm = _bus.GetDanhSachDanhMuc();
            for (int i = 0; i < dm.Count; i++)
            {
                cboDanhMuc.Items.Add(dm[i]);
            }
        }

        private void NapDuLieu(List<SanPham> ds)
        {
            if (cboSapXep.SelectedIndex >= 0)
                ds = _bus.SapXep(ds, cboSapXep.SelectedIndex);
            _ds.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                _ds.Add(ds[i]);
            }
            lblTongGiaTri.Text = "Số sản phẩm: " + ds.Count + "     Tổng giá trị hàng tồn: "
                + _bus.TongGiaTriTon(ds).ToString("N0") + " đ";
        }

        private void NapLai()
        {
            if (txtTimKiem.Text.Trim() == "")
                NapDuLieu(_bus.GetAll());
            else
                NapDuLieu(_bus.TimKiem(txtTimKiem.Text));
        }

        private SanPham DocTuForm()
        {
            decimal donGia;
            int soLuong;
            string chuoiGia = txtDonGia.Text.Trim().Replace(".", "").Replace(",", "").Replace(" ", "");
            if (!decimal.TryParse(chuoiGia, out donGia))
                throw new ArgumentException("Đơn giá phải là số.");
            if (!int.TryParse(txtSoLuong.Text.Trim(), out soLuong))
                throw new ArgumentException("Số lượng phải là số nguyên.");
            return new SanPham(txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), cboDanhMuc.Text.Trim(), donGia, soLuong);
        }

        private SanPham SanPhamDangChon()
        {
            if (dgvSanPham.CurrentRow == null) return null;
            return dgvSanPham.CurrentRow.DataBoundItem as SanPham;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = DocTuForm();
                _bus.Add(sp);
                NapDanhMuc();
                NapLai();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPham cu = SanPhamDangChon();
            if (cu == null)
            {
                MessageBox.Show("Chọn sản phẩm cần sửa.", "Thông báo");
                return;
            }
            if (txtMaSP.Text.Trim() != cu.MaSP)
            {
                MessageBox.Show("Không được đổi mã sản phẩm khi sửa.", "Lỗi");
                txtMaSP.Text = cu.MaSP;
                return;
            }
            try
            {
                _bus.Update(DocTuForm());
                NapDanhMuc();
                NapLai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = SanPhamDangChon();
            if (sp == null)
            {
                MessageBox.Show("Chọn sản phẩm cần xóa.", "Thông báo");
                return;
            }
            if (MessageBox.Show("Xóa sản phẩm " + sp.TenSP + "?", "Xác nhận", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _bus.Delete(sp.MaSP);
                NapLai();
                LamMoi();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboDanhMuc.Text = "";
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtMaSP.Focus();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPham sp = SanPhamDangChon();
            if (sp == null) return;
            txtMaSP.Text = sp.MaSP;
            txtTenSP.Text = sp.TenSP;
            cboDanhMuc.Text = sp.DanhMuc;
            txtDonGia.Text = sp.DonGia.ToString("0");
            txtSoLuong.Text = sp.SoLuong.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Nhập từ khóa cần tìm.", "Thông báo");
                return;
            }
            NapLai();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            NapLai();
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapLai();
        }
    }
}
