using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Lab11_CRUD_StoredProcedure.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.ShowDialog();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa f = new frmKhoa();
            f.ShowDialog();
        }

        private void btnNhatKy_Click(object sender, EventArgs e)
        {
            if (!File.Exists(XuLyLoi.DuongDanNhatKy))
            {
                MessageBox.Show("Hôm nay chưa có lỗi nào được ghi lại.", "Nhật ký lỗi");
                return;
            }
            Process.Start("notepad.exe", "\"" + XuLyLoi.DuongDanNhatKy + "\"");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
