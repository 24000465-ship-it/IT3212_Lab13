namespace Lab05_MultiForm
{
    partial class frmSinhVien
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
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnChonKhoa = new System.Windows.Forms.Button();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.lblGoiYDiem = new System.Windows.Forms.Label();
            this.lblXemTruoc = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpSoThich = new System.Windows.Forms.GroupBox();
            this.chkDocSach = new System.Windows.Forms.CheckBox();
            this.chkTheThao = new System.Windows.Forms.CheckBox();
            this.chkLapTrinh = new System.Windows.Forms.CheckBox();
            this.btnSoThich = new System.Windows.Forms.Button();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.grpAnh = new System.Windows.Forms.GroupBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpSoThich.SuspendLayout();
            this.grpAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(30, 28);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(150, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(220, 22);
            this.txtMaSV.TabIndex = 1;
            this.txtMaSV.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 63);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(150, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 22);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 98);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(150, 95);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(220, 22);
            this.dtpNgaySinh.TabIndex = 5;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(380, 98);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.TabIndex = 6;
            this.lblTuoi.Text = "Tuổi:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 133);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.TabIndex = 7;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(150, 131);
            this.radNam.Name = "radNam";
            this.radNam.TabIndex = 8;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(240, 131);
            this.radNu.Name = "radNu";
            this.radNu.TabIndex = 9;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(30, 168);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.TabIndex = 10;
            this.lblKhoa.Text = "Khoa";
            // 
            // cboKhoa
            // 
            this.cboKhoa.Location = new System.Drawing.Point(150, 165);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(220, 24);
            this.cboKhoa.TabIndex = 11;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // btnChonKhoa
            // 
            this.btnChonKhoa.Location = new System.Drawing.Point(378, 164);
            this.btnChonKhoa.Name = "btnChonKhoa";
            this.btnChonKhoa.Size = new System.Drawing.Size(40, 26);
            this.btnChonKhoa.TabIndex = 12;
            this.btnChonKhoa.Text = "...";
            this.btnChonKhoa.UseVisualStyleBackColor = true;
            this.btnChonKhoa.Click += new System.EventHandler(this.btnChonKhoa_Click);
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(30, 203);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.TabIndex = 13;
            this.lblDiemTB.Text = "Điểm TB";
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(150, 200);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(100, 22);
            this.txtDiemTB.TabIndex = 14;
            this.txtDiemTB.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.txtDiemTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemTB_KeyPress);
            // 
            // lblGoiYDiem
            // 
            this.lblGoiYDiem.AutoSize = true;
            this.lblGoiYDiem.Location = new System.Drawing.Point(258, 203);
            this.lblGoiYDiem.Name = "lblGoiYDiem";
            this.lblGoiYDiem.TabIndex = 15;
            this.lblGoiYDiem.Text = "(0 - 10, dấu chấm thập phân)";
            this.lblGoiYDiem.ForeColor = System.Drawing.Color.Gray;
            // 
            // lblXemTruoc
            // 
            this.lblXemTruoc.AutoSize = false;
            this.lblXemTruoc.Location = new System.Drawing.Point(30, 240);
            this.lblXemTruoc.Name = "lblXemTruoc";
            this.lblXemTruoc.Size = new System.Drawing.Size(520, 22);
            this.lblXemTruoc.TabIndex = 16;
            this.lblXemTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblXemTruoc.Text = "Xem trước:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = false;
            this.lblTrangThai.Location = new System.Drawing.Point(30, 266);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(520, 22);
            this.lblTrangThai.TabIndex = 17;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(30, 300);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 34);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(140, 300);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(100, 34);
            this.btnHienThi.TabIndex = 19;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(250, 300);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(110, 34);
            this.btnChiTiet.TabIndex = 20;
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(370, 300);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 34);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(480, 300);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 34);
            this.btnLamMoi.TabIndex = 22;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpSoThich
            // 
            this.grpSoThich.Controls.Add(this.chkDocSach);
            this.grpSoThich.Controls.Add(this.chkTheThao);
            this.grpSoThich.Controls.Add(this.chkLapTrinh);
            this.grpSoThich.Controls.Add(this.btnSoThich);
            this.grpSoThich.Controls.Add(this.lblSoThich);
            this.grpSoThich.Location = new System.Drawing.Point(600, 15);
            this.grpSoThich.Name = "grpSoThich";
            this.grpSoThich.Size = new System.Drawing.Size(235, 175);
            this.grpSoThich.TabIndex = 23;
            this.grpSoThich.Text = "Sở thích";
            this.grpSoThich.TabStop = false;
            // 
            // chkDocSach
            // 
            this.chkDocSach.AutoSize = true;
            this.chkDocSach.Location = new System.Drawing.Point(18, 28);
            this.chkDocSach.Name = "chkDocSach";
            this.chkDocSach.TabIndex = 24;
            this.chkDocSach.Text = "Đọc sách";
            this.chkDocSach.UseVisualStyleBackColor = true;
            // 
            // chkTheThao
            // 
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(18, 55);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.TabIndex = 25;
            this.chkTheThao.Text = "Thể thao";
            this.chkTheThao.UseVisualStyleBackColor = true;
            // 
            // chkLapTrinh
            // 
            this.chkLapTrinh.AutoSize = true;
            this.chkLapTrinh.Location = new System.Drawing.Point(18, 82);
            this.chkLapTrinh.Name = "chkLapTrinh";
            this.chkLapTrinh.TabIndex = 26;
            this.chkLapTrinh.Text = "Lập trình";
            this.chkLapTrinh.UseVisualStyleBackColor = true;
            // 
            // btnSoThich
            // 
            this.btnSoThich.Location = new System.Drawing.Point(18, 110);
            this.btnSoThich.Name = "btnSoThich";
            this.btnSoThich.Size = new System.Drawing.Size(120, 30);
            this.btnSoThich.TabIndex = 27;
            this.btnSoThich.Text = "Xem sở thích";
            this.btnSoThich.UseVisualStyleBackColor = true;
            this.btnSoThich.Click += new System.EventHandler(this.btnSoThich_Click);
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = false;
            this.lblSoThich.Location = new System.Drawing.Point(18, 146);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(210, 22);
            this.lblSoThich.TabIndex = 28;
            this.lblSoThich.Text = "Chưa chọn";
            // 
            // grpAnh
            // 
            this.grpAnh.Controls.Add(this.picAnh);
            this.grpAnh.Controls.Add(this.btnChonAnh);
            this.grpAnh.Controls.Add(this.txtDuongDanAnh);
            this.grpAnh.Location = new System.Drawing.Point(850, 15);
            this.grpAnh.Name = "grpAnh";
            this.grpAnh.Size = new System.Drawing.Size(200, 320);
            this.grpAnh.TabIndex = 29;
            this.grpAnh.Text = "Ảnh đại diện";
            this.grpAnh.TabStop = false;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(15, 25);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(170, 200);
            this.picAnh.TabIndex = 30;
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(15, 235);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(170, 32);
            this.btnChonAnh.TabIndex = 31;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.Location = new System.Drawing.Point(15, 278);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.Size = new System.Drawing.Size(170, 22);
            this.txtDuongDanAnh.TabIndex = 32;
            this.txtDuongDanAnh.ReadOnly = true;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = false;
            this.lblDanhSach.Location = new System.Drawing.Point(30, 350);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(600, 22);
            this.lblDanhSach.TabIndex = 33;
            this.lblDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.Text = "Danh sách sinh viên đã lưu (nhấp đúp để xem chi tiết):";
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.Location = new System.Drawing.Point(30, 378);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(1020, 164);
            this.lstSinhVien.TabIndex = 34;
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.ItemHeight = 16;
            this.lstSinhVien.DoubleClick += new System.EventHandler(this.lstSinhVien_DoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 560);
            this.Controls.Add(this.lstSinhVien);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.grpAnh);
            this.Controls.Add(this.grpSoThich);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblXemTruoc);
            this.Controls.Add(this.lblGoiYDiem);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.lblDiemTB);
            this.Controls.Add(this.btnChonKhoa);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaSV);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.grpSoThich.ResumeLayout(false);
            this.grpSoThich.PerformLayout();
            this.grpAnh.ResumeLayout(false);
            this.grpAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnChonKhoa;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label lblGoiYDiem;
        private System.Windows.Forms.Label lblXemTruoc;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpSoThich;
        private System.Windows.Forms.CheckBox chkDocSach;
        private System.Windows.Forms.CheckBox chkTheThao;
        private System.Windows.Forms.CheckBox chkLapTrinh;
        private System.Windows.Forms.Button btnSoThich;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.GroupBox grpAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
