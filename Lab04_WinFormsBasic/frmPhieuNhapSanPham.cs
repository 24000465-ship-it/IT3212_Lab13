using System;
using System.IO;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmPhieuNhapSanPham : Form
    {
        public frmPhieuNhapSanPham()
        {
            InitializeComponent();
        }

        private void frmPhieuNhapSanPham_Load(object sender, EventArgs e)
        {
            cboLoai.Items.Clear();
            cboLoai.Items.Add("Điện thoại");
            cboLoai.Items.Add("Laptop");
            cboLoai.Items.Add("Phụ kiện");
            cboLoai.Items.Add("Văn phòng phẩm");
            cboLoai.SelectedIndex = 0;

            dtpNgayNhap.MaxDate = DateTime.Today;
            dtpNgayNhap.Value = DateTime.Today;
        }

        // Thành tiền = số lượng x đơn giá, cập nhật mỗi khi đổi số lượng hoặc đơn giá
        private void CapNhatThanhTien()
        {
            decimal donGia;
            if (decimal.TryParse(txtDonGia.Text, out donGia) && donGia > 0)
            {
                decimal thanhTien = nudSoLuong.Value * donGia;
                lblThanhTien.Text = thanhTien.ToString("N0") + " đ";
            }
            else
            {
                lblThanhTien.Text = "0 đ";
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                string thuMucAnh = Path.Combine(Application.StartupPath, "Images");
                if (Directory.Exists(thuMucAnh))
                    dlg.InitialDirectory = thuMucAnh;

                if (dlg.ShowDialog() == DialogResult.OK && File.Exists(dlg.FileName))
                {
                    picAnhSP.ImageLocation = dlg.FileName;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Lỗi");
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Lỗi");
                txtTenSP.Focus();
                return;
            }
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi");
                nudSoLuong.Focus();
                return;
            }
            decimal donGia;
            if (!decimal.TryParse(txtDonGia.Text, out donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số lớn hơn 0!", "Lỗi");
                txtDonGia.Focus();
                return;
            }
            if (string.IsNullOrEmpty(picAnhSP.ImageLocation))
            {
                MessageBox.Show("Vui lòng chọn ảnh sản phẩm!", "Lỗi");
                return;
            }

            string phieu = "Mã SP: " + txtMaSP.Text.Trim()
                + "\nTên SP: " + txtTenSP.Text.Trim()
                + "\nLoại: " + cboLoai.Text
                + "\nSố lượng: " + nudSoLuong.Value
                + "\nĐơn giá: " + donGia.ToString("N0") + " đ"
                + "\nThành tiền: " + (nudSoLuong.Value * donGia).ToString("N0") + " đ"
                + "\nNgày nhập: " + dtpNgayNhap.Value.ToString("dd/MM/yyyy")
                + "\nẢnh: " + Path.GetFileName(picAnhSP.ImageLocation);
            MessageBox.Show(phieu, "Lưu phiếu nhập thành công");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoai.SelectedIndex = 0;
            nudSoLuong.Value = 0;
            txtDonGia.Clear();
            dtpNgayNhap.Value = DateTime.Today;
            picAnhSP.ImageLocation = null;
            picAnhSP.Image = null;
            lblThanhTien.Text = "0 đ";
            txtMaSP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
