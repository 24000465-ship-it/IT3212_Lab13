using System;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmMayTinh : Form
    {
        public frmMayTinh()
        {
            InitializeComponent();
        }

        // Đọc 2 số từ 2 ô nhập. Trả về false nếu nhập sai.
        private bool LayHaiSo(out double so1, out double so2)
        {
            so2 = 0;
            if (!double.TryParse(txtSo1.Text, out so1))
            {
                MessageBox.Show("Số thứ nhất không hợp lệ!", "Lỗi");
                txtSo1.Focus();
                return false;
            }
            if (!double.TryParse(txtSo2.Text, out so2))
            {
                MessageBox.Show("Số thứ hai không hợp lệ!", "Lỗi");
                txtSo2.Focus();
                return false;
            }
            return true;
        }

        private void TinhToan(string phepToan)
        {
            double so1, so2;
            if (!LayHaiSo(out so1, out so2))
                return;

            double ketQua = 0;
            if (phepToan == "+")
            {
                ketQua = so1 + so2;
            }
            else if (phepToan == "-")
            {
                ketQua = so1 - so2;
            }
            else if (phepToan == "×")
            {
                ketQua = so1 * so2;
            }
            else if (phepToan == "÷")
            {
                if (so2 == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi");
                    txtSo2.Focus();
                    return;
                }
                ketQua = so1 / so2;
            }

            txtKetQua.Text = ketQua.ToString("0.####");
            lblPhepTinh.Text = so1 + " " + phepToan + " " + so2 + " = " + txtKetQua.Text;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            TinhToan("+");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            TinhToan("-");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            TinhToan("×");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            TinhToan("÷");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
            lblPhepTinh.Text = "";
            txtSo1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
