using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmKhoa : Form
    {
        
        private List<string> dsKhoa;

        public frmKhoa(List<string> danhSachKhoa)
        {
            InitializeComponent();
            dsKhoa = danhSachKhoa;
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            lstKhoa.Items.Clear();
            for (int i = 0; i < dsKhoa.Count; i++)
            {
                lstKhoa.Items.Add((i + 1) + ". " + dsKhoa[i]);
            }
            lblSoLuong.Text = "Số khoa: " + dsKhoa.Count;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenKhoa.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Vui lòng nhập tên khoa!", "Lỗi");
                txtTenKhoa.Focus();
                return;
            }
            for (int i = 0; i < dsKhoa.Count; i++)
            {
                if (dsKhoa[i].ToLower() == ten.ToLower())
                {
                    MessageBox.Show("Khoa \"" + ten + "\" đã có trong danh sách!", "Lỗi");
                    return;
                }
            }
            dsKhoa.Add(ten);
            txtTenKhoa.Clear();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int viTri = lstKhoa.SelectedIndex;
            if (viTri < 0)
            {
                MessageBox.Show("Chọn khoa cần xóa!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Xóa khoa \"" + dsKhoa[viTri] + "\"?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsKhoa.RemoveAt(viTri);
                HienThi();
            }
        }
    }
}
