namespace Lab06_ThreeLayerMemory.GUI
{
    partial class frmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.tvDanhMuc = new System.Windows.Forms.TreeView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.cmsDanhMuc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuThemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiTen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.grpThongTin.SuspendLayout();
            this.cmsDanhMuc.SuspendLayout();
            this.SuspendLayout();
            this.lblHuongDan.AutoSize = false;
            this.lblHuongDan.Location = new System.Drawing.Point(20, 15);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(720, 36);
            this.lblHuongDan.TabIndex = 0;
            this.lblHuongDan.Text = "Nhấp chuột phải vào cây để thêm, đổi tên hoặc xóa (phím F2 = đổi tên, Delete = xóa).";
            this.tvDanhMuc.Location = new System.Drawing.Point(20, 55);
            this.tvDanhMuc.Name = "tvDanhMuc";
            this.tvDanhMuc.Size = new System.Drawing.Size(380, 405);
            this.tvDanhMuc.TabIndex = 1;
            this.tvDanhMuc.HideSelection = false;
            this.tvDanhMuc.LabelEdit = true;
            this.tvDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDanhMuc.ContextMenuStrip = this.cmsDanhMuc;
            this.tvDanhMuc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDanhMuc_AfterSelect);
            this.tvDanhMuc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDanhMuc_NodeMouseClick);
            this.tvDanhMuc.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvDanhMuc_AfterLabelEdit);
            this.tvDanhMuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvDanhMuc_KeyDown);
            this.grpThongTin.Controls.Add(this.lblThongTin);
            this.grpThongTin.Location = new System.Drawing.Point(420, 50);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(320, 410);
            this.grpThongTin.TabIndex = 2;
            this.grpThongTin.Text = "Thông tin";
            this.grpThongTin.TabStop = false;
            this.lblThongTin.AutoSize = false;
            this.lblThongTin.Location = new System.Drawing.Point(15, 30);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(290, 365);
            this.lblThongTin.TabIndex = 3;
            this.lblThongTin.Text = "Chọn một node trên cây.";
            this.cmsDanhMuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemDanhMuc,
            this.mnuThemSanPham,
            this.mnuDoiTen,
            this.mnuXoa});
            this.cmsDanhMuc.Name = "cmsDanhMuc";
            this.cmsDanhMuc.Size = new System.Drawing.Size(181, 100);
            this.cmsDanhMuc.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDanhMuc_Opening);
            this.mnuThemDanhMuc.Name = "mnuThemDanhMuc";
            this.mnuThemDanhMuc.Text = "Thêm danh mục";
            this.mnuThemDanhMuc.Click += new System.EventHandler(this.mnuThemDanhMuc_Click);
            this.mnuThemSanPham.Name = "mnuThemSanPham";
            this.mnuThemSanPham.Text = "Thêm sản phẩm";
            this.mnuThemSanPham.Click += new System.EventHandler(this.mnuThemSanPham_Click);
            this.mnuDoiTen.Name = "mnuDoiTen";
            this.mnuDoiTen.Text = "Đổi tên";
            this.mnuDoiTen.Click += new System.EventHandler(this.mnuDoiTen_Click);
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Text = "Xóa";
            this.mnuXoa.Click += new System.EventHandler(this.mnuXoa_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.tvDanhMuc);
            this.Controls.Add(this.lblHuongDan);
            this.Name = "frmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 7 - Danh mục sản phẩm (TreeView)";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.cmsDanhMuc.ResumeLayout(false);
            this.cmsDanhMuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.TreeView tvDanhMuc;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.ContextMenuStrip cmsDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuThemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuThemSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiTen;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
    }
}
