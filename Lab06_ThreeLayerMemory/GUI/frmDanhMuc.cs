using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.BUS;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmDanhMuc : Form
    {
        private SanPhamBUS _bus = new SanPhamBUS();

        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadTree();
        }

        private void LoadTree()
        {
            tvDanhMuc.Nodes.Clear();
            Dictionary<string, List<SanPham>> nhom = _bus.NhomTheoDanhMuc();
            List<string> dsDanhMuc = new List<string>(nhom.Keys);
            for (int i = 0; i < dsDanhMuc.Count; i++)
            {
                TreeNode dmNode = new TreeNode(dsDanhMuc[i]);
                List<SanPham> dsSP = nhom[dsDanhMuc[i]];
                for (int j = 0; j < dsSP.Count; j++)
                {
                    TreeNode spNode = new TreeNode(dsSP[j].TenSP);
                    spNode.Tag = dsSP[j];
                    dmNode.Nodes.Add(spNode);
                }
                tvDanhMuc.Nodes.Add(dmNode);
            }
            tvDanhMuc.ExpandAll();
        }

        private bool LaDanhMuc(TreeNode node)
        {
            return node != null && node.Level == 0;
        }

        private void tvDanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                tvDanhMuc.SelectedNode = e.Node;
        }

        private void cmsDanhMuc_Opening(object sender, CancelEventArgs e)
        {
            TreeNode node = tvDanhMuc.SelectedNode;
            mnuThemDanhMuc.Enabled = true;
            mnuThemSanPham.Enabled = node != null;
            mnuDoiTen.Enabled = node != null;
            mnuXoa.Enabled = node != null;
        }

        private void mnuThemDanhMuc_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode("Danh mục mới");
            tvDanhMuc.Nodes.Add(node);
            tvDanhMuc.SelectedNode = node;
            node.BeginEdit();
        }

        private void mnuThemSanPham_Click(object sender, EventArgs e)
        {
            TreeNode dmNode = tvDanhMuc.SelectedNode;
            if (dmNode == null) return;
            if (!LaDanhMuc(dmNode)) dmNode = dmNode.Parent;
            try
            {
                SanPham sp = new SanPham(_bus.TaoMaMoi(), "Sản phẩm mới", dmNode.Text, 100000, 0);
                _bus.Add(sp);
                TreeNode spNode = new TreeNode(sp.TenSP);
                spNode.Tag = sp;
                dmNode.Nodes.Add(spNode);
                dmNode.Expand();
                tvDanhMuc.SelectedNode = spNode;
                spNode.BeginEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void mnuDoiTen_Click(object sender, EventArgs e)
        {
            if (tvDanhMuc.SelectedNode != null)
                tvDanhMuc.SelectedNode.BeginEdit();
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            XoaNode(tvDanhMuc.SelectedNode);
        }

        private void XoaNode(TreeNode node)
        {
            if (node == null) return;
            string loi = LaDanhMuc(node)
                ? "Xóa danh mục \"" + node.Text + "\" và " + node.Nodes.Count + " sản phẩm bên trong?"
                : "Xóa sản phẩm \"" + node.Text + "\"?";
            if (MessageBox.Show(loi, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            if (LaDanhMuc(node))
                _bus.XoaDanhMuc(node.Text);
            else
                _bus.Delete(((SanPham)node.Tag).MaSP);
            node.Remove();
            lblThongTin.Text = "Đã xóa.";
        }

        private void tvDanhMuc_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null) return;
            if (e.Label.Trim() == "")
            {
                e.CancelEdit = true;
                MessageBox.Show("Tên không được rỗng.", "Lỗi");
                return;
            }
            try
            {
                if (LaDanhMuc(e.Node))
                    _bus.DoiTenDanhMuc(e.Node.Text, e.Label);
                else
                    _bus.DoiTen((SanPham)e.Node.Tag, e.Label);
                lblThongTin.Text = "Đã đổi tên thành: " + e.Label.Trim();
            }
            catch (Exception ex)
            {
                e.CancelEdit = true;
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void tvDanhMuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && tvDanhMuc.SelectedNode != null)
                tvDanhMuc.SelectedNode.BeginEdit();
            if (e.KeyCode == Keys.Delete)
                XoaNode(tvDanhMuc.SelectedNode);
        }

        private void tvDanhMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (LaDanhMuc(e.Node))
            {
                lblThongTin.Text = "Danh mục: " + e.Node.Text + "\n\nSố sản phẩm: " + e.Node.Nodes.Count;
                return;
            }
            SanPham sp = (SanPham)e.Node.Tag;
            lblThongTin.Text = "Sản phẩm: " + sp.TenSP + "\n\nMã: " + sp.MaSP + "\nDanh mục: " + sp.DanhMuc
                + "\nĐơn giá: " + sp.DonGia.ToString("N0") + " đ\nSố lượng: " + sp.SoLuong
                + "\nGiá trị tồn: " + sp.ThanhTien.ToString("N0") + " đ";
        }
    }
}
