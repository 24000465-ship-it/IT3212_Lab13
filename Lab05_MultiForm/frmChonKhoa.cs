using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmChonKhoa : Form
    {
        private List<string> dsKhoa;
        private string khoaBanDau;

        // Khoa được chọn, form gọi đọc thuộc tính này sau khi ShowDialog() trả về OK
        public string KhoaDuocChon { get; private set; }

        // Nhận danh sách khoa và khoa đang chọn qua constructor (không dùng biến toàn cục)
        public frmChonKhoa(List<string> danhSachKhoa, string khoaHienTai)
        {
            InitializeComponent();
            dsKhoa = danhSachKhoa;
            khoaBanDau = khoaHienTai;
            KhoaDuocChon = "";
        }

        private void frmChonKhoa_Load(object sender, EventArgs e)
        {
            lstKhoa.Items.Clear();
            for (int i = 0; i < dsKhoa.Count; i++)
            {
                lstKhoa.Items.Add(dsKhoa[i]);
                if (dsKhoa[i] == khoaBanDau)
                    lstKhoa.SelectedIndex = i;
            }
            if (lstKhoa.SelectedIndex < 0 && lstKhoa.Items.Count > 0)
                lstKhoa.SelectedIndex = 0;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (lstKhoa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một khoa!", "Thông báo");
                return;
            }
            KhoaDuocChon = lstKhoa.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void lstKhoa_DoubleClick(object sender, EventArgs e)
        {
            btnChon_Click(sender, e);
        }
    }
}
