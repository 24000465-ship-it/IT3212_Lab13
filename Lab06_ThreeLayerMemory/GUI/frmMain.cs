using System;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.BUS;

namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmMain : Form
    {
        private SinhVienBUS _bus = new SinhVienBUS();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblFile.Text = "Bài 9 - Dữ liệu sinh viên lưu ở tệp: " + System.IO.Path.GetFileName(_bus.DuongDanFile())
                + "\n(cùng thư mục với file .exe; tự lưu khi thêm/sửa/xóa, tự đọc lại khi mở)";
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.ShowDialog();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            frmListView f = new frmListView();
            f.ShowDialog();
        }

        private void btnCayKhoa_Click(object sender, EventArgs e)
        {
            frmCayKhoa f = new frmCayKhoa();
            f.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.ShowDialog();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc f = new frmDanhMuc();
            f.ShowDialog();
        }
    }
}
