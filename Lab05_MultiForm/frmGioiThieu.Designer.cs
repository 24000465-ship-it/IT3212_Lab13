namespace Lab05_MultiForm
{
    partial class frmGioiThieu
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
            this.lblTenUngDung = new System.Windows.Forms.Label();
            this.lblPhienBan = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTruong = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenUngDung
            // 
            this.lblTenUngDung.AutoSize = true;
            this.lblTenUngDung.Location = new System.Drawing.Point(25, 20);
            this.lblTenUngDung.Name = "lblTenUngDung";
            this.lblTenUngDung.TabIndex = 0;
            this.lblTenUngDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTenUngDung.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // lblPhienBan
            // 
            this.lblPhienBan.AutoSize = true;
            this.lblPhienBan.Location = new System.Drawing.Point(28, 55);
            this.lblPhienBan.Name = "lblPhienBan";
            this.lblPhienBan.TabIndex = 1;
            this.lblPhienBan.Text = "Phiên bản 1.0 - Lab 5 học phần Lập trình .NET (IT3212)";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = false;
            this.lblMoTa.Location = new System.Drawing.Point(28, 85);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(420, 66);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Ứng dụng đa form: nhập, kiểm tra dữ liệu, xem chi tiết, tìm kiếm sinh viên và quản lý danh mục khoa.";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(28, 160);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.TabIndex = 3;
            this.lblTacGia.Text = "Sinh viên thực hiện: Lê Đức Bình - 24000465";
            // 
            // lblTruong
            // 
            this.lblTruong.AutoSize = true;
            this.lblTruong.Location = new System.Drawing.Point(28, 185);
            this.lblTruong.Name = "lblTruong";
            this.lblTruong.TabIndex = 4;
            this.lblTruong.Text = "Khoa CNTT - Trường Đại học Công nghệ Đông Á";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(330, 220);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 34);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 275);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblTruong);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblPhienBan);
            this.Controls.Add(this.lblTenUngDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGioiThieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới thiệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenUngDung;
        private System.Windows.Forms.Label lblPhienBan;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTruong;
        private System.Windows.Forms.Button btnDong;
    }
}
