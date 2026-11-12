namespace Lab13_CrystalReport.GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoHocPhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKiemTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNganCach = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnHocPhan = new System.Windows.Forms.Button();
            this.lblMoiTruong = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCao,
            this.mnuHeThong});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCaoSinhVien,
            this.mnuBaoCaoKhoa,
            this.mnuBaoCaoHocPhan});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBaoCaoSinhVien
            // 
            this.mnuBaoCaoSinhVien.Name = "mnuBaoCaoSinhVien";
            this.mnuBaoCaoSinhVien.Text = "Danh sách sinh viên";
            this.mnuBaoCaoSinhVien.Click += new System.EventHandler(this.mnuBaoCaoSinhVien_Click);
            // 
            // mnuBaoCaoKhoa
            // 
            this.mnuBaoCaoKhoa.Name = "mnuBaoCaoKhoa";
            this.mnuBaoCaoKhoa.Text = "Danh sách khoa";
            this.mnuBaoCaoKhoa.Click += new System.EventHandler(this.mnuBaoCaoKhoa_Click);
            // 
            // mnuBaoCaoHocPhan
            // 
            this.mnuBaoCaoHocPhan.Name = "mnuBaoCaoHocPhan";
            this.mnuBaoCaoHocPhan.Text = "Danh sách học phần";
            this.mnuBaoCaoHocPhan.Click += new System.EventHandler(this.mnuBaoCaoHocPhan_Click);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKiemTra,
            this.mnuNganCach,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuKiemTra
            // 
            this.mnuKiemTra.Name = "mnuKiemTra";
            this.mnuKiemTra.Text = "Kiểm tra môi trường Crystal Reports";
            this.mnuKiemTra.Click += new System.EventHandler(this.mnuKiemTra_Click);
            // 
            // mnuNganCach
            // 
            this.mnuNganCach.Name = "mnuNganCach";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = false;
            this.lblTieuDe.Location = new System.Drawing.Point(20, 45);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(440, 32);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Text = "LAB 13 - BÁO CÁO CRYSTAL REPORT";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Location = new System.Drawing.Point(40, 95);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(400, 40);
            this.btnSinhVien.TabIndex = 2;
            this.btnSinhVien.Text = "Báo cáo danh sách sinh viên (Bài 1 - 5)";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.mnuBaoCaoSinhVien_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(40, 145);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(400, 40);
            this.btnKhoa.TabIndex = 3;
            this.btnKhoa.Text = "Báo cáo danh sách khoa (Bài 6)";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.mnuBaoCaoKhoa_Click);
            // 
            // btnHocPhan
            // 
            this.btnHocPhan.Location = new System.Drawing.Point(40, 195);
            this.btnHocPhan.Name = "btnHocPhan";
            this.btnHocPhan.Size = new System.Drawing.Size(400, 40);
            this.btnHocPhan.TabIndex = 4;
            this.btnHocPhan.Text = "Báo cáo danh sách học phần (Bài 8)";
            this.btnHocPhan.UseVisualStyleBackColor = true;
            this.btnHocPhan.Click += new System.EventHandler(this.mnuBaoCaoHocPhan_Click);
            // 
            // lblMoiTruong
            // 
            this.lblMoiTruong.AutoSize = false;
            this.lblMoiTruong.Location = new System.Drawing.Point(40, 250);
            this.lblMoiTruong.Name = "lblMoiTruong";
            this.lblMoiTruong.Size = new System.Drawing.Size(400, 70);
            this.lblMoiTruong.TabIndex = 5;
            this.lblMoiTruong.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoiTruong.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 335);
            this.Controls.Add(this.lblMoiTruong);
            this.Controls.Add(this.btnHocPhan);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 13 - Lê Đức Bình - 24000465";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoHocPhan;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuKiemTra;
        private System.Windows.Forms.ToolStripSeparator mnuNganCach;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnHocPhan;
        private System.Windows.Forms.Label lblMoiTruong;
    }
}
