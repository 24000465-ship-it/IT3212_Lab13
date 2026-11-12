using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmDangNhap : Form
    {
        // Danh sách tài khoản mẫu
        private string[] dsTenDangNhap = { "admin", "sinhvien" };
        private string[] dsMatKhau = { "123456", "eaut2026" };

        // Tên đăng nhập được ghi nhớ (giữ lại trong lúc chương trình còn chạy)
        private static string tenDaGhiNho = "";

        private int soLanSai = 0;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (tenDaGhiNho != "")
            {
                txtTenDangNhap.Text = tenDaGhiNho;
                chkGhiNho.Checked = true;
                txtMatKhau.Focus();
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            // Tích vào thì hiện mật khẩu, bỏ tích thì ẩn thành dấu chấm
            if (chkHienMatKhau.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
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
                if (chkGhiNho.Checked)
                    tenDaGhiNho = ten;
                else
                    tenDaGhiNho = "";

                soLanSai = 0;
                lblThongBao.ForeColor = Color.Green;
                lblThongBao.Text = "Đăng nhập thành công! Xin chào " + ten + ".";
                MessageBox.Show("Đăng nhập thành công!\nXin chào " + ten, "Thông báo");
            }
            else
            {
                soLanSai++;
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Text = "Sai tên đăng nhập hoặc mật khẩu (lần " + soLanSai + "/3).";
                if (soLanSai >= 3)
                {
                    btnDangNhap.Enabled = false;
                    lblThongBao.Text = "Sai quá 3 lần, đã khóa nút đăng nhập!";
                }
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
