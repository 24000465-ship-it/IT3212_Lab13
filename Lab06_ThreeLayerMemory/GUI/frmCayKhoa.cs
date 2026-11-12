using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.BUS;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmCayKhoa : Form
    {
        private SinhVienBUS _bus = new SinhVienBUS();

        public frmCayKhoa()
        {
            InitializeComponent();
        }

        private void frmCayKhoa_Load(object sender, EventArgs e)
        {
            LoadTree(_bus.NhomTheoKhoa());
        }

        private void LoadTree(Dictionary<string, List<SinhVien>> data)
        {
            tvKhoa.Nodes.Clear();
            List<string> dsKhoa = new List<string>(data.Keys);
            for (int i = 0; i < dsKhoa.Count; i++)
            {
                List<SinhVien> dsSV = data[dsKhoa[i]];
                TreeNode khoaNode = new TreeNode(dsKhoa[i] + " (" + dsSV.Count + ")");
                khoaNode.Tag = dsKhoa[i];
                for (int j = 0; j < dsSV.Count; j++)
                {
                    TreeNode svNode = new TreeNode(dsSV[j].MaSV + " - " + dsSV[j].HoTen);
                    svNode.Tag = dsSV[j];
                    khoaNode.Nodes.Add(svNode);
                }
                tvKhoa.Nodes.Add(khoaNode);
            }
            tvKhoa.ExpandAll();
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SinhVien sv = e.Node.Tag as SinhVien;
            if (sv == null)
            {
                XoaChiTiet();
                lblGhiChu.Text = "Khoa " + e.Node.Tag + " có " + e.Node.Nodes.Count + " sinh viên. Chọn một sinh viên để xem chi tiết.";
                return;
            }
            lblMa.Text = sv.MaSV;
            lblHoTen.Text = sv.HoTen;
            lblNgaySinh.Text = sv.NgaySinh.ToString("dd/MM/yyyy");
            lblTuoi.Text = sv.TinhTuoi().ToString();
            lblGioiTinh.Text = sv.GioiTinh;
            lblKhoa.Text = sv.Khoa;
            lblDiem.Text = sv.DiemTB.ToString("N2");
            lblXepLoai.Text = sv.XepLoai();
            lblGhiChu.Text = "";
        }

        private void XoaChiTiet()
        {
            lblMa.Text = "...";
            lblHoTen.Text = "...";
            lblNgaySinh.Text = "...";
            lblTuoi.Text = "...";
            lblGioiTinh.Text = "...";
            lblKhoa.Text = "...";
            lblDiem.Text = "...";
            lblXepLoai.Text = "...";
        }
    }
}
