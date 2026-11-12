namespace Lab07_ADONET_Connection
{
    partial class Form1
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
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnTrangThai = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(25, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Text = "KẾT NỐI CSDL QLSinhVien (MySQL)";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = false;
            this.lblThongTin.Location = new System.Drawing.Point(28, 55);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(470, 66);
            this.lblThongTin.TabIndex = 1;
            this.lblThongTin.Text = "Thông tin kết nối";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(30, 130);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(210, 45);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra kết nối";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnTrangThai
            // 
            this.btnTrangThai.Location = new System.Drawing.Point(255, 130);
            this.btnTrangThai.Name = "btnTrangThai";
            this.btnTrangThai.Size = new System.Drawing.Size(210, 45);
            this.btnTrangThai.TabIndex = 3;
            this.btnTrangThai.Text = "Trạng thái kết nối";
            this.btnTrangThai.UseVisualStyleBackColor = true;
            this.btnTrangThai.Click += new System.EventHandler(this.btnTrangThai_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = false;
            this.lblKetQua.Location = new System.Drawing.Point(28, 190);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(470, 44);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.Text = "Chưa kiểm tra.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 250);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnTrangThai);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 7 - Kết nối MySQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnTrangThai;
        private System.Windows.Forms.Label lblKetQua;
    }
}
