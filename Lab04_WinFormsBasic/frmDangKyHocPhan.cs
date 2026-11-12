using System;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmDangKyHocPhan : Form
    {
        // Tên môn và số tín chỉ tương ứng (cùng vị trí trong 2 mảng)
        private string[] tenMon = {
            "Lập trình .NET",
            "Cơ sở dữ liệu",
            "Mạng máy tính",
            "Cấu trúc dữ liệu và giải thuật",
            "Toán rời rạc",
            "Tiếng Anh chuyên ngành",
            "Phân tích thiết kế hệ thống"
        };
        private int[] soTinChi = { 3, 3, 3, 4, 3, 2, 3 };

        private const int TIN_CHI_TOI_DA = 20;

        public frmDangKyHocPhan()
        {
            InitializeComponent();
        }

        private void frmDangKyHocPhan_Load(object sender, EventArgs e)
        {
            clbMonHoc.Items.Clear();
            for (int i = 0; i < tenMon.Length; i++)
            {
                clbMonHoc.Items.Add(tenMon[i] + " (" + soTinChi[i] + " tín chỉ)");
            }
        }

        // Sự kiện ItemCheck chạy TRƯỚC khi ô được tích/bỏ tích,
        // nên với ô đang bấm phải dùng e.NewValue để biết trạng thái mới.
        private void clbMonHoc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                bool duocChon = clbMonHoc.GetItemChecked(i);
                if (i == e.Index)
                    duocChon = (e.NewValue == CheckState.Checked);

                if (duocChon)
                    tong += soTinChi[i];
            }
            HienThiTongTinChi(tong);
        }

        private void HienThiTongTinChi(int tong)
        {
            lblTongTinChi.Text = "Tổng số tín chỉ: " + tong;
            if (tong > TIN_CHI_TOI_DA)
                lblCanhBao.Text = "Vượt quá " + TIN_CHI_TOI_DA + " tín chỉ cho phép!";
            else
                lblCanhBao.Text = "";
        }

        private int TinhTongTinChi()
        {
            int tong = 0;
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                if (clbMonHoc.GetItemChecked(i))
                    tong += soTinChi[i];
            }
            return tong;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int tong = TinhTongTinChi();
            if (tong == 0)
            {
                MessageBox.Show("Bạn chưa chọn học phần nào!", "Thông báo");
                return;
            }
            if (tong > TIN_CHI_TOI_DA)
            {
                MessageBox.Show("Tổng " + tong + " tín chỉ, vượt quá " + TIN_CHI_TOI_DA + " tín chỉ cho phép!", "Lỗi");
                return;
            }

            string danhSach = "";
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                if (clbMonHoc.GetItemChecked(i))
                    danhSach += "- " + tenMon[i] + " (" + soTinChi[i] + " TC)\n";
            }
            MessageBox.Show("Đăng ký thành công các học phần:\n" + danhSach + "\nTổng số tín chỉ: " + tong, "Đăng ký học phần");
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }
            HienThiTongTinChi(0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
