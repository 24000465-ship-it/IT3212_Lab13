using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmMain : Form
    {
        
        private List<string> dsKhoa = new List<string>();
        private string tenNguoiDung;

        public frmMain() : this("khách")
        {
        }

        public frmMain(string nguoiDung)
        {
            InitializeComponent();
            tenNguoiDung = nguoiDung;
            dsKhoa.Add("Công nghệ thông tin");
            dsKhoa.Add("Công nghệ kỹ thuật ô tô");
            dsKhoa.Add("Kinh tế");
            dsKhoa.Add("Ngôn ngữ Anh");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblNguoiDung.Text = "Người dùng: " + tenNguoiDung;
            CapNhatThanhTrangThai();
            tmrDongHo.Start();
        }

        
        private void OpenChildForm(Form child)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == child.GetType())
                {
                    f.Activate();
                    child.Dispose();
                    return;
                }
            }
            child.MdiParent = this;
            child.Show();
            CapNhatThanhTrangThai();
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSinhVien(dsKhoa));
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhoa(dsKhoa));
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new frmSinhVien(dsKhoa));
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i] is frmSinhVien)
                {
                    ((frmSinhVien)this.MdiChildren[i]).TimKiem();
                    break;
                }
            }
        }

        private void mnuChonKhoa_Click(object sender, EventArgs e)
        {
            frmChonKhoa f = new frmChonKhoa(dsKhoa, "");
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Bạn đã chọn khoa: " + f.KhoaDuocChon, "Chọn khoa");
            }
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu f = new frmGioiThieu();
            f.ShowDialog();   
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();     
        }

        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traLoi = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.No)
            {
                e.Cancel = true;   
            }
        }

       
        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            CapNhatThanhTrangThai();
        }

        private void CapNhatThanhTrangThai()
        {
            lblDongHo.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
            lblSoForm.Text = "Đang mở: " + this.MdiChildren.Length + " form";
        }
    }
}
