namespace Lab07_ADONET_Connection
{
    partial class frmTrangThai
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblTenDataSource = new System.Windows.Forms.Label();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.lblTenDatabase = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblTenServerVersion = new System.Windows.Forms.Label();
            this.lblServerVersion = new System.Windows.Forms.Label();
            this.lblTenState = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblTenTimeout = new System.Windows.Forms.Label();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblTenThoiGianMo = new System.Windows.Forms.Label();
            this.lblThoiGianMo = new System.Windows.Forms.Label();
            this.lblTenLucKetNoi = new System.Windows.Forms.Label();
            this.lblLucKetNoi = new System.Windows.Forms.Label();
            this.btnMoKetNoi = new System.Windows.Forms.Button();
            this.btnDongKetNoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(25, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Text = "TRẠNG THÁI KẾT NỐI";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblTenDataSource);
            this.grpThongTin.Controls.Add(this.lblDataSource);
            this.grpThongTin.Controls.Add(this.lblTenDatabase);
            this.grpThongTin.Controls.Add(this.lblDatabase);
            this.grpThongTin.Controls.Add(this.lblTenServerVersion);
            this.grpThongTin.Controls.Add(this.lblServerVersion);
            this.grpThongTin.Controls.Add(this.lblTenState);
            this.grpThongTin.Controls.Add(this.lblState);
            this.grpThongTin.Controls.Add(this.lblTenTimeout);
            this.grpThongTin.Controls.Add(this.lblTimeout);
            this.grpThongTin.Controls.Add(this.lblTenTaiKhoan);
            this.grpThongTin.Controls.Add(this.lblTaiKhoan);
            this.grpThongTin.Controls.Add(this.lblTenThoiGianMo);
            this.grpThongTin.Controls.Add(this.lblThoiGianMo);
            this.grpThongTin.Controls.Add(this.lblTenLucKetNoi);
            this.grpThongTin.Controls.Add(this.lblLucKetNoi);
            this.grpThongTin.Location = new System.Drawing.Point(25, 50);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(480, 286);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.Text = "Thông tin kết nối";
            this.grpThongTin.TabStop = false;
            // 
            // lblTenDataSource
            // 
            this.lblTenDataSource.AutoSize = true;
            this.lblTenDataSource.Location = new System.Drawing.Point(18, 30);
            this.lblTenDataSource.Name = "lblTenDataSource";
            this.lblTenDataSource.TabIndex = 2;
            this.lblTenDataSource.Text = "Data Source:";
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = false;
            this.lblDataSource.Location = new System.Drawing.Point(175, 30);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(290, 22);
            this.lblDataSource.TabIndex = 3;
            this.lblDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataSource.Text = "...";
            // 
            // lblTenDatabase
            // 
            this.lblTenDatabase.AutoSize = true;
            this.lblTenDatabase.Location = new System.Drawing.Point(18, 61);
            this.lblTenDatabase.Name = "lblTenDatabase";
            this.lblTenDatabase.TabIndex = 4;
            this.lblTenDatabase.Text = "Database:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = false;
            this.lblDatabase.Location = new System.Drawing.Point(175, 61);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(290, 22);
            this.lblDatabase.TabIndex = 5;
            this.lblDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDatabase.Text = "...";
            // 
            // lblTenServerVersion
            // 
            this.lblTenServerVersion.AutoSize = true;
            this.lblTenServerVersion.Location = new System.Drawing.Point(18, 92);
            this.lblTenServerVersion.Name = "lblTenServerVersion";
            this.lblTenServerVersion.TabIndex = 6;
            this.lblTenServerVersion.Text = "Server Version:";
            // 
            // lblServerVersion
            // 
            this.lblServerVersion.AutoSize = false;
            this.lblServerVersion.Location = new System.Drawing.Point(175, 92);
            this.lblServerVersion.Name = "lblServerVersion";
            this.lblServerVersion.Size = new System.Drawing.Size(290, 22);
            this.lblServerVersion.TabIndex = 7;
            this.lblServerVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblServerVersion.Text = "...";
            // 
            // lblTenState
            // 
            this.lblTenState.AutoSize = true;
            this.lblTenState.Location = new System.Drawing.Point(18, 123);
            this.lblTenState.Name = "lblTenState";
            this.lblTenState.TabIndex = 8;
            this.lblTenState.Text = "State:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = false;
            this.lblState.Location = new System.Drawing.Point(175, 123);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(290, 22);
            this.lblState.TabIndex = 9;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblState.Text = "...";
            // 
            // lblTenTimeout
            // 
            this.lblTenTimeout.AutoSize = true;
            this.lblTenTimeout.Location = new System.Drawing.Point(18, 154);
            this.lblTenTimeout.Name = "lblTenTimeout";
            this.lblTenTimeout.TabIndex = 10;
            this.lblTenTimeout.Text = "Connection Timeout:";
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = false;
            this.lblTimeout.Location = new System.Drawing.Point(175, 154);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(290, 22);
            this.lblTimeout.TabIndex = 11;
            this.lblTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimeout.Text = "...";
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(18, 185);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.TabIndex = 12;
            this.lblTenTaiKhoan.Text = "Tài khoản:";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = false;
            this.lblTaiKhoan.Location = new System.Drawing.Point(175, 185);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(290, 22);
            this.lblTaiKhoan.TabIndex = 13;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTaiKhoan.Text = "...";
            // 
            // lblTenThoiGianMo
            // 
            this.lblTenThoiGianMo.AutoSize = true;
            this.lblTenThoiGianMo.Location = new System.Drawing.Point(18, 216);
            this.lblTenThoiGianMo.Name = "lblTenThoiGianMo";
            this.lblTenThoiGianMo.TabIndex = 14;
            this.lblTenThoiGianMo.Text = "Thời gian mở kết nối:";
            // 
            // lblThoiGianMo
            // 
            this.lblThoiGianMo.AutoSize = false;
            this.lblThoiGianMo.Location = new System.Drawing.Point(175, 216);
            this.lblThoiGianMo.Name = "lblThoiGianMo";
            this.lblThoiGianMo.Size = new System.Drawing.Size(290, 22);
            this.lblThoiGianMo.TabIndex = 15;
            this.lblThoiGianMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblThoiGianMo.Text = "...";
            // 
            // lblTenLucKetNoi
            // 
            this.lblTenLucKetNoi.AutoSize = true;
            this.lblTenLucKetNoi.Location = new System.Drawing.Point(18, 247);
            this.lblTenLucKetNoi.Name = "lblTenLucKetNoi";
            this.lblTenLucKetNoi.TabIndex = 16;
            this.lblTenLucKetNoi.Text = "Kết nối lúc:";
            // 
            // lblLucKetNoi
            // 
            this.lblLucKetNoi.AutoSize = false;
            this.lblLucKetNoi.Location = new System.Drawing.Point(175, 247);
            this.lblLucKetNoi.Name = "lblLucKetNoi";
            this.lblLucKetNoi.Size = new System.Drawing.Size(290, 22);
            this.lblLucKetNoi.TabIndex = 17;
            this.lblLucKetNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblLucKetNoi.Text = "...";
            // 
            // btnMoKetNoi
            // 
            this.btnMoKetNoi.Location = new System.Drawing.Point(25, 349);
            this.btnMoKetNoi.Name = "btnMoKetNoi";
            this.btnMoKetNoi.Size = new System.Drawing.Size(150, 40);
            this.btnMoKetNoi.TabIndex = 18;
            this.btnMoKetNoi.Text = "Mở kết nối";
            this.btnMoKetNoi.UseVisualStyleBackColor = true;
            this.btnMoKetNoi.Click += new System.EventHandler(this.btnMoKetNoi_Click);
            // 
            // btnDongKetNoi
            // 
            this.btnDongKetNoi.Location = new System.Drawing.Point(185, 349);
            this.btnDongKetNoi.Name = "btnDongKetNoi";
            this.btnDongKetNoi.Size = new System.Drawing.Size(150, 40);
            this.btnDongKetNoi.TabIndex = 19;
            this.btnDongKetNoi.Text = "Đóng kết nối";
            this.btnDongKetNoi.UseVisualStyleBackColor = true;
            this.btnDongKetNoi.Click += new System.EventHandler(this.btnDongKetNoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(355, 349);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 40);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 406);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongKetNoi);
            this.Controls.Add(this.btnMoKetNoi);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrangThai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 9 - Trạng thái kết nối";
            this.Load += new System.EventHandler(this.frmTrangThai_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangThai_FormClosing);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenDataSource;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Label lblTenDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblTenServerVersion;
        private System.Windows.Forms.Label lblServerVersion;
        private System.Windows.Forms.Label lblTenState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTenTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblTenThoiGianMo;
        private System.Windows.Forms.Label lblThoiGianMo;
        private System.Windows.Forms.Label lblTenLucKetNoi;
        private System.Windows.Forms.Label lblLucKetNoi;
        private System.Windows.Forms.Button btnMoKetNoi;
        private System.Windows.Forms.Button btnDongKetNoi;
        private System.Windows.Forms.Button btnThoat;
    }
}
