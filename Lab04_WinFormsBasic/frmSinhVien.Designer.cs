
namespace Lab04_WinFormsBasic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblTuoi = new System.Windows.Forms.Label();
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
            this.grpSoThich.SuspendLayout();
            this.grpAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Khoa";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(252, 62);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(198, 22);
            this.txtMaSV.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(252, 111);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(198, 22);
            this.txtHoTen.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(250, 159);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 11;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(250, 216);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 12;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(363, 216);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 13;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(250, 288);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(200, 24);
            this.cboKhoa.TabIndex = 14;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(250, 343);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(94, 37);
            this.btnHienThi.TabIndex = 15;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(493, 164);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(37, 16);
            this.lblTuoi.TabIndex = 16;
            this.lblTuoi.Text = "Tuổi:";
            // 
            // grpSoThich
            // 
            this.grpSoThich.Controls.Add(this.chkDocSach);
            this.grpSoThich.Controls.Add(this.chkTheThao);
            this.grpSoThich.Controls.Add(this.chkLapTrinh);
            this.grpSoThich.Controls.Add(this.btnSoThich);
            this.grpSoThich.Controls.Add(this.lblSoThich);
            this.grpSoThich.Location = new System.Drawing.Point(560, 30);
            this.grpSoThich.Name = "grpSoThich";
            this.grpSoThich.Size = new System.Drawing.Size(270, 200);
            this.grpSoThich.TabIndex = 17;
            this.grpSoThich.TabStop = false;
            this.grpSoThich.Text = "Sở thích";
            // 
            // chkDocSach
            // 
            this.chkDocSach.AutoSize = true;
            this.chkDocSach.Location = new System.Drawing.Point(20, 30);
            this.chkDocSach.Name = "chkDocSach";
            this.chkDocSach.TabIndex = 0;
            this.chkDocSach.Text = "Đọc sách";
            this.chkDocSach.UseVisualStyleBackColor = true;
            // 
            // chkTheThao
            // 
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(20, 58);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.TabIndex = 1;
            this.chkTheThao.Text = "Thể thao";
            this.chkTheThao.UseVisualStyleBackColor = true;
            // 
            // chkLapTrinh
            // 
            this.chkLapTrinh.AutoSize = true;
            this.chkLapTrinh.Location = new System.Drawing.Point(20, 86);
            this.chkLapTrinh.Name = "chkLapTrinh";
            this.chkLapTrinh.TabIndex = 2;
            this.chkLapTrinh.Text = "Lập trình";
            this.chkLapTrinh.UseVisualStyleBackColor = true;
            // 
            // btnSoThich
            // 
            this.btnSoThich.Location = new System.Drawing.Point(20, 120);
            this.btnSoThich.Name = "btnSoThich";
            this.btnSoThich.Size = new System.Drawing.Size(120, 32);
            this.btnSoThich.TabIndex = 3;
            this.btnSoThich.Text = "Xem sở thích";
            this.btnSoThich.UseVisualStyleBackColor = true;
            this.btnSoThich.Click += new System.EventHandler(this.btnSoThich_Click);
            // 
            // lblSoThich
            // 
            this.lblSoThich.Location = new System.Drawing.Point(20, 160);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(240, 32);
            this.lblSoThich.TabIndex = 4;
            this.lblSoThich.Text = "Chưa chọn";
            // 
            // grpAnh
            // 
            this.grpAnh.Controls.Add(this.picAnh);
            this.grpAnh.Controls.Add(this.btnChonAnh);
            this.grpAnh.Controls.Add(this.txtDuongDanAnh);
            this.grpAnh.Location = new System.Drawing.Point(560, 240);
            this.grpAnh.Name = "grpAnh";
            this.grpAnh.Size = new System.Drawing.Size(270, 205);
            this.grpAnh.TabIndex = 18;
            this.grpAnh.TabStop = false;
            this.grpAnh.Text = "Ảnh đại diện";
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(15, 25);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(120, 130);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(150, 25);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(105, 32);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.Location = new System.Drawing.Point(15, 165);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.ReadOnly = true;
            this.txtDuongDanAnh.Size = new System.Drawing.Size(240, 22);
            this.txtDuongDanAnh.TabIndex = 2;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 470);
            this.Controls.Add(this.grpAnh);
            this.Controls.Add(this.grpSoThich);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVien";
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.grpSoThich.ResumeLayout(false);
            this.grpSoThich.PerformLayout();
            this.grpAnh.ResumeLayout(false);
            this.grpAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblTuoi;
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
    }
}


