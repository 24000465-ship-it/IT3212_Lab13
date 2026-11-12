using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.BUS;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmListView : Form
    {
        private SinhVienBUS _bus = new SinhVienBUS();

        public frmListView()
        {
            InitializeComponent();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            TaoBieuTuong();

            lvSinhVien.View = View.Details;
            lvSinhVien.Columns.Add("Mã SV", 100);
            lvSinhVien.Columns.Add("Họ tên", 190);
            lvSinhVien.Columns.Add("Khoa", 190);
            lvSinhVien.Columns.Add("Điểm TB", 80, HorizontalAlignment.Right);
            lvSinhVien.Columns.Add("Xếp loại", 110);

            cboCheDo.Items.Add("Chi tiết");
            cboCheDo.Items.Add("Biểu tượng lớn");
            cboCheDo.SelectedIndex = 0;

            cboKhoa.Items.Add("Tất cả");
            List<Khoa> dsKhoa = _bus.GetDanhSachKhoa();
            for (int i = 0; i < dsKhoa.Count; i++)
            {
                cboKhoa.Items.Add(dsKhoa[i].TenKhoa);
            }
            cboKhoa.SelectedIndex = 0;
        }

        private void LoadListView(List<SinhVien> data)
        {
            lvSinhVien.Items.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                SinhVien sv = data[i];
                ListViewItem item = new ListViewItem(sv.MaSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.Khoa);
                item.SubItems.Add(sv.DiemTB.ToString("N2"));
                item.SubItems.Add(sv.XepLoai());
                item.ImageIndex = _bus.ViTriBieuTuong(sv);
                item.Tag = sv;
                lvSinhVien.Items.Add(item);
            }
            lblChiTiet.Text = "Đang hiển thị " + data.Count + " sinh viên. Chọn một sinh viên để xem chi tiết.";
        }

        private void TaoBieuTuong()
        {
            string[] chu = { "XS", "G", "K", "TB", "Y" };
            Color[] mau = { Color.DarkGoldenrod, Color.ForestGreen, Color.RoyalBlue, Color.DarkOrange, Color.Firebrick };
            for (int i = 0; i < chu.Length; i++)
            {
                imgNho.Images.Add(VeHinhTron(20, mau[i], chu[i]));
                imgLon.Images.Add(VeHinhTron(48, mau[i], chu[i]));
            }
        }

        private Bitmap VeHinhTron(int kichThuoc, Color mau, string chu)
        {
            Bitmap bmp = new Bitmap(kichThuoc, kichThuoc);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (SolidBrush b = new SolidBrush(mau))
                {
                    g.FillEllipse(b, 1, 1, kichThuoc - 3, kichThuoc - 3);
                }
                float co = kichThuoc / (chu.Length > 1 ? 3.2f : 2.4f);
                using (Font f = new Font("Arial", co, FontStyle.Bold, GraphicsUnit.Pixel))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(chu, f, Brushes.White, new RectangleF(0, 0, kichThuoc - 1, kichThuoc - 1), sf);
                }
            }
            return bmp;
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedIndex == 0)
                LoadListView(_bus.GetAll());
            else
                LoadListView(_bus.LocTheoKhoa(cboKhoa.Text));
        }

        private void cboCheDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCheDo.SelectedIndex == 0)
                lvSinhVien.View = View.Details;
            else
                lvSinhVien.View = View.LargeIcon;
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            SinhVien sv = (SinhVien)lvSinhVien.SelectedItems[0].Tag;
            lblChiTiet.Text = "Mã SV: " + sv.MaSV + "     Họ tên: " + sv.HoTen + "     Giới tính: " + sv.GioiTinh
                + "\nNgày sinh: " + sv.NgaySinh.ToString("dd/MM/yyyy") + " (" + sv.TinhTuoi() + " tuổi)     Khoa: " + sv.Khoa
                + "\nĐiểm TB: " + sv.DiemTB.ToString("N2") + "     Xếp loại: " + sv.XepLoai();
        }
    }
}
