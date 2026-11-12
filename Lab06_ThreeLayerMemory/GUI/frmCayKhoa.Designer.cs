namespace Lab06_ThreeLayerMemory.GUI
{
    partial class frmCayKhoa
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
            this.lblCay = new System.Windows.Forms.Label();
            this.tvKhoa = new System.Windows.Forms.TreeView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.lblTieuDeMa = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTieuDeHoTen = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTieuDeNgaySinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTieuDeTuoi = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblTieuDeGioiTinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTieuDeKhoa = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblTieuDeDiem = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblTieuDeXepLoai = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.grpChiTiet.SuspendLayout();
            this.SuspendLayout();
            this.lblCay.AutoSize = true;
            this.lblCay.Location = new System.Drawing.Point(20, 15);
            this.lblCay.Name = "lblCay";
            this.lblCay.TabIndex = 0;
            this.lblCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCay.Text = "Khoa - Sinh viên";
            this.tvKhoa.Location = new System.Drawing.Point(20, 40);
            this.tvKhoa.Name = "tvKhoa";
            this.tvKhoa.Size = new System.Drawing.Size(330, 400);
            this.tvKhoa.TabIndex = 1;
            this.tvKhoa.HideSelection = false;
            this.tvKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);
            this.grpChiTiet.Controls.Add(this.lblTieuDeMa);
            this.grpChiTiet.Controls.Add(this.lblMa);
            this.grpChiTiet.Controls.Add(this.lblTieuDeHoTen);
            this.grpChiTiet.Controls.Add(this.lblHoTen);
            this.grpChiTiet.Controls.Add(this.lblTieuDeNgaySinh);
            this.grpChiTiet.Controls.Add(this.lblNgaySinh);
            this.grpChiTiet.Controls.Add(this.lblTieuDeTuoi);
            this.grpChiTiet.Controls.Add(this.lblTuoi);
            this.grpChiTiet.Controls.Add(this.lblTieuDeGioiTinh);
            this.grpChiTiet.Controls.Add(this.lblGioiTinh);
            this.grpChiTiet.Controls.Add(this.lblTieuDeKhoa);
            this.grpChiTiet.Controls.Add(this.lblKhoa);
            this.grpChiTiet.Controls.Add(this.lblTieuDeDiem);
            this.grpChiTiet.Controls.Add(this.lblDiem);
            this.grpChiTiet.Controls.Add(this.lblTieuDeXepLoai);
            this.grpChiTiet.Controls.Add(this.lblXepLoai);
            this.grpChiTiet.Controls.Add(this.lblGhiChu);
            this.grpChiTiet.Location = new System.Drawing.Point(370, 35);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(430, 405);
            this.grpChiTiet.TabIndex = 2;
            this.grpChiTiet.Text = "Thông tin chi tiết";
            this.grpChiTiet.TabStop = false;
            this.lblTieuDeMa.AutoSize = true;
            this.lblTieuDeMa.Location = new System.Drawing.Point(20, 35);
            this.lblTieuDeMa.Name = "lblTieuDeMa";
            this.lblTieuDeMa.TabIndex = 3;
            this.lblTieuDeMa.Text = "Mã SV:";
            this.lblMa.AutoSize = false;
            this.lblMa.Location = new System.Drawing.Point(130, 35);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(280, 22);
            this.lblMa.TabIndex = 4;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMa.Text = "...";
            this.lblTieuDeHoTen.AutoSize = true;
            this.lblTieuDeHoTen.Location = new System.Drawing.Point(20, 70);
            this.lblTieuDeHoTen.Name = "lblTieuDeHoTen";
            this.lblTieuDeHoTen.TabIndex = 5;
            this.lblTieuDeHoTen.Text = "Họ tên:";
            this.lblHoTen.AutoSize = false;
            this.lblHoTen.Location = new System.Drawing.Point(130, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(280, 22);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.Text = "...";
            this.lblTieuDeNgaySinh.AutoSize = true;
            this.lblTieuDeNgaySinh.Location = new System.Drawing.Point(20, 105);
            this.lblTieuDeNgaySinh.Name = "lblTieuDeNgaySinh";
            this.lblTieuDeNgaySinh.TabIndex = 7;
            this.lblTieuDeNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.AutoSize = false;
            this.lblNgaySinh.Location = new System.Drawing.Point(130, 105);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(280, 22);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinh.Text = "...";
            this.lblTieuDeTuoi.AutoSize = true;
            this.lblTieuDeTuoi.Location = new System.Drawing.Point(20, 140);
            this.lblTieuDeTuoi.Name = "lblTieuDeTuoi";
            this.lblTieuDeTuoi.TabIndex = 9;
            this.lblTieuDeTuoi.Text = "Tuổi:";
            this.lblTuoi.AutoSize = false;
            this.lblTuoi.Location = new System.Drawing.Point(130, 140);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(280, 22);
            this.lblTuoi.TabIndex = 10;
            this.lblTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTuoi.Text = "...";
            this.lblTieuDeGioiTinh.AutoSize = true;
            this.lblTieuDeGioiTinh.Location = new System.Drawing.Point(20, 175);
            this.lblTieuDeGioiTinh.Name = "lblTieuDeGioiTinh";
            this.lblTieuDeGioiTinh.TabIndex = 11;
            this.lblTieuDeGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.AutoSize = false;
            this.lblGioiTinh.Location = new System.Drawing.Point(130, 175);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(280, 22);
            this.lblGioiTinh.TabIndex = 12;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.Text = "...";
            this.lblTieuDeKhoa.AutoSize = true;
            this.lblTieuDeKhoa.Location = new System.Drawing.Point(20, 210);
            this.lblTieuDeKhoa.Name = "lblTieuDeKhoa";
            this.lblTieuDeKhoa.TabIndex = 13;
            this.lblTieuDeKhoa.Text = "Khoa:";
            this.lblKhoa.AutoSize = false;
            this.lblKhoa.Location = new System.Drawing.Point(130, 210);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(280, 22);
            this.lblKhoa.TabIndex = 14;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblKhoa.Text = "...";
            this.lblTieuDeDiem.AutoSize = true;
            this.lblTieuDeDiem.Location = new System.Drawing.Point(20, 245);
            this.lblTieuDeDiem.Name = "lblTieuDeDiem";
            this.lblTieuDeDiem.TabIndex = 15;
            this.lblTieuDeDiem.Text = "Điểm TB:";
            this.lblDiem.AutoSize = false;
            this.lblDiem.Location = new System.Drawing.Point(130, 245);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(280, 22);
            this.lblDiem.TabIndex = 16;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiem.Text = "...";
            this.lblTieuDeXepLoai.AutoSize = true;
            this.lblTieuDeXepLoai.Location = new System.Drawing.Point(20, 280);
            this.lblTieuDeXepLoai.Name = "lblTieuDeXepLoai";
            this.lblTieuDeXepLoai.TabIndex = 17;
            this.lblTieuDeXepLoai.Text = "Xếp loại:";
            this.lblXepLoai.AutoSize = false;
            this.lblXepLoai.Location = new System.Drawing.Point(130, 280);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(280, 22);
            this.lblXepLoai.TabIndex = 18;
            this.lblXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblXepLoai.Text = "...";
            this.lblGhiChu.AutoSize = false;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 330);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(390, 50);
            this.lblGhiChu.TabIndex = 19;
            this.lblGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChu.Text = "Chọn một sinh viên trên cây để xem chi tiết.";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 460);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.tvKhoa);
            this.Controls.Add(this.lblCay);
            this.Name = "frmCayKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 4 - Cây Khoa - Sinh viên (TreeView)";
            this.Load += new System.EventHandler(this.frmCayKhoa_Load);
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCay;
        private System.Windows.Forms.TreeView tvKhoa;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.Label lblTieuDeMa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTieuDeHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblTieuDeNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTieuDeTuoi;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblTieuDeGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTieuDeKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblTieuDeDiem;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblTieuDeXepLoai;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.Label lblGhiChu;
    }
}
