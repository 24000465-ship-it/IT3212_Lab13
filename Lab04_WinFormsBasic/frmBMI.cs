using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double chieuCao, canNang;

            if (!double.TryParse(txtChieuCao.Text, out chieuCao) || chieuCao < 50 || chieuCao > 250)
            {
                MessageBox.Show("Chiều cao phải là số từ 50 đến 250 (cm)!", "Lỗi");
                txtChieuCao.Focus();
                return;
            }
            if (!double.TryParse(txtCanNang.Text, out canNang) || canNang < 10 || canNang > 300)
            {
                MessageBox.Show("Cân nặng phải là số từ 10 đến 300 (kg)!", "Lỗi");
                txtCanNang.Focus();
                return;
            }

            // BMI = cân nặng (kg) / (chiều cao (m) x chiều cao (m))
            double chieuCaoMet = chieuCao / 100;
            double bmi = canNang / (chieuCaoMet * chieuCaoMet);

            string phanLoai;
            Color mau;
            if (bmi < 18.5)
            {
                phanLoai = "Gầy";
                mau = Color.DarkOrange;
            }
            else if (bmi < 25)
            {
                phanLoai = "Bình thường";
                mau = Color.Green;
            }
            else if (bmi < 30)
            {
                phanLoai = "Thừa cân";
                mau = Color.OrangeRed;
            }
            else
            {
                phanLoai = "Béo phì";
                mau = Color.Red;
            }

            lblBMI.Text = "Chỉ số BMI: " + bmi.ToString("0.00");
            lblPhanLoai.Text = "Phân loại: " + phanLoai;
            lblPhanLoai.ForeColor = mau;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtChieuCao.Clear();
            txtCanNang.Clear();
            lblBMI.Text = "Chỉ số BMI:";
            lblPhanLoai.Text = "Phân loại:";
            lblPhanLoai.ForeColor = Color.Black;
            txtChieuCao.Focus();
        }
    }
}
