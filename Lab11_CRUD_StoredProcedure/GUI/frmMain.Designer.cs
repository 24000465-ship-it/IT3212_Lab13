namespace Lab11_CRUD_StoredProcedure.GUI
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnNhatKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = false;
            this.lblTieuDe.Location = new System.Drawing.Point(15, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(430, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LAB 11 - CRUD VÀ STORED PROCEDURE";
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Location = new System.Drawing.Point(30, 65);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(400, 40);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "Quản lý sinh viên (Bài 1 - 5, 7 - 10)";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(30, 115);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(400, 40);
            this.btnKhoa.TabIndex = 2;
            this.btnKhoa.Text = "Quản lý khoa (Bài 6)";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnNhatKy
            // 
            this.btnNhatKy.Location = new System.Drawing.Point(30, 165);
            this.btnNhatKy.Name = "btnNhatKy";
            this.btnNhatKy.Size = new System.Drawing.Size(400, 40);
            this.btnNhatKy.TabIndex = 3;
            this.btnNhatKy.Text = "Xem nhật ký lỗi (Bài 10)";
            this.btnNhatKy.UseVisualStyleBackColor = true;
            this.btnNhatKy.Click += new System.EventHandler(this.btnNhatKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(30, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(400, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 285);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhatKy);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 11 - Lê Đức Bình - 24000465";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnNhatKy;
        private System.Windows.Forms.Button btnThoat;
    }
}
