using System;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBai1_5_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.ShowDialog();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            frmMayTinh f = new frmMayTinh();
            f.ShowDialog();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
        }

        private void btnBai8_Click(object sender, EventArgs e)
        {
            frmBMI f = new frmBMI();
            f.ShowDialog();
        }

        private void btnBai9_Click(object sender, EventArgs e)
        {
            frmDangKyHocPhan f = new frmDangKyHocPhan();
            f.ShowDialog();
        }

        private void btnBai10_Click(object sender, EventArgs e)
        {
            frmPhieuNhapSanPham f = new frmPhieuNhapSanPham();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
