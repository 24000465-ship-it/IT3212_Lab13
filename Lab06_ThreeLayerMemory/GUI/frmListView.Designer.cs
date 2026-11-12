namespace Lab06_ThreeLayerMemory.GUI
{
    partial class frmListView
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
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblCheDo = new System.Windows.Forms.Label();
            this.cboCheDo = new System.Windows.Forms.ComboBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.lblChuThich = new System.Windows.Forms.Label();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.imgNho = new System.Windows.Forms.ImageList(this.components);
            this.imgLon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(20, 20);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Lọc theo khoa";
            this.cboKhoa.Location = new System.Drawing.Point(120, 17);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(220, 24);
            this.cboKhoa.TabIndex = 1;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            this.lblCheDo.AutoSize = true;
            this.lblCheDo.Location = new System.Drawing.Point(370, 20);
            this.lblCheDo.Name = "lblCheDo";
            this.lblCheDo.TabIndex = 2;
            this.lblCheDo.Text = "Kiểu hiển thị";
            this.cboCheDo.Location = new System.Drawing.Point(470, 17);
            this.cboCheDo.Name = "cboCheDo";
            this.cboCheDo.Size = new System.Drawing.Size(170, 24);
            this.cboCheDo.TabIndex = 3;
            this.cboCheDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheDo.FormattingEnabled = true;
            this.cboCheDo.SelectedIndexChanged += new System.EventHandler(this.cboCheDo_SelectedIndexChanged);
            this.lvSinhVien.Location = new System.Drawing.Point(20, 55);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(780, 330);
            this.lvSinhVien.TabIndex = 4;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.MultiSelect = false;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSinhVien.SmallImageList = this.imgNho;
            this.lvSinhVien.LargeImageList = this.imgLon;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            this.lblChuThich.AutoSize = false;
            this.lblChuThich.Location = new System.Drawing.Point(20, 395);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(780, 22);
            this.lblChuThich.TabIndex = 5;
            this.lblChuThich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChuThich.Text = "Biểu tượng: XS = Xuất sắc, G = Giỏi, K = Khá, TB = Trung bình, Y = Yếu";
            this.lblChiTiet.AutoSize = false;
            this.lblChiTiet.Location = new System.Drawing.Point(20, 422);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(780, 70);
            this.lblChiTiet.TabIndex = 6;
            this.lblChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChiTiet.Text = "Chọn một sinh viên để xem chi tiết.";
            this.imgNho.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgNho.ImageSize = new System.Drawing.Size(20, 20);
            this.imgNho.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgLon.ImageSize = new System.Drawing.Size(48, 48);
            this.imgLon.TransparentColor = System.Drawing.Color.Transparent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.lblChuThich);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.cboCheDo);
            this.Controls.Add(this.lblCheDo);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Name = "frmListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 3, 8 - Danh sách sinh viên (ListView)";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblCheDo;
        private System.Windows.Forms.ComboBox cboCheDo;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.Label lblChuThich;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.ImageList imgNho;
        private System.Windows.Forms.ImageList imgLon;
    }
}
