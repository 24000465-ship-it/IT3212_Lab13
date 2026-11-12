using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmDangNhap : Form
    {
        private string[] dsTenDangNhap = { "admin", "sinhvien" };
        private string[] dsMatKhau = { "123456", "eaut2026" };

        private int soLanSai = 0;
        private int soGiayConLai = 0;
        private const int THOI_GIAN_KHOA = 30;

        
        public string TenDangNhap { get; private set; }

        public frmDangNhap()
        {
            InitializeComponent();
            TenDangNhap = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (ten == "" || matKhau == "")
            {
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Text = "Vui lòng nhập đủ tên đăng nhập và mật khẩu!";
                return;
            }

            bool dung = false;
            for (int i = 0; i < dsTenDangNhap.Length; i++)
            {
                if (dsTenDangNhap[i] == ten && dsMatKhau[i] == matKhau)
                {
                    dung = true;
                    break;
                }
            }

            if (dung)
            {
                TenDangNhap = ten;
                this.DialogResult = DialogResult.OK;   
                return;
            }

            soLanSai++;
            lblThongBao.ForeColor = Color.Red;
            lblThongBao.Text = "Sai tên đăng nhập hoặc mật khẩu (lần " + soLanSai + "/3).";
            txtMatKhau.Clear();
            txtMatKhau.Focus();

            if (soLanSai >= 3)
            {
                
                btnDangNhap.Enabled = false;
                soGiayConLai = THOI_GIAN_KHOA;
                lblThongBao.Text = "Sai 3 lần! Khóa đăng nhập, còn " + soGiayConLai + " giây.";
                tmrKhoa.Start();
            }
        }

        private void tmrKhoa_Tick(object sender, EventArgs e)
        {
            soGiayConLai--;
            if (soGiayConLai > 0)
            {
                lblThongBao.Text = "Sai 3 lần! Khóa đăng nhập, còn " + soGiayConLai + " giây.";
            }
            else
            {
                tmrKhoa.Stop();
                soLanSai = 0;
                btnDangNhap.Enabled = true;
                lblThongBao.ForeColor = Color.Black;
                lblThongBao.Text = "Đã mở khóa, mời đăng nhập lại.";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
