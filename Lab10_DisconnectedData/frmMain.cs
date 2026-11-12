using System;
using System.Windows.Forms;

namespace Lab10_DisconnectedData
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKhoaSinhVien_Click(object sender, EventArgs e)
        {
            frmKhoaSinhVien f = new frmKhoaSinhVien();
            f.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhat f = new frmCapNhat();
            f.ShowDialog();
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            frmBangDiem f = new frmBangDiem();
            f.ShowDialog();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            frmXml f = new frmXml();
            f.ShowDialog();
        }

        private void btnHopNhat_Click(object sender, EventArgs e)
        {
            frmHopNhat f = new frmHopNhat();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
