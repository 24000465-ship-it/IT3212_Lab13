namespace Lab10_DisconnectedData
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
            this.btnKhoaSinhVien = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnBangDiem = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnHopNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = false;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(400, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LAB 10 - DỮ LIỆU NGẮT KẾT NỐI";
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKhoaSinhVien
            // 
            this.btnKhoaSinhVien.Location = new System.Drawing.Point(30, 65);
            this.btnKhoaSinhVien.Name = "btnKhoaSinhVien";
            this.btnKhoaSinhVien.Size = new System.Drawing.Size(400, 40);
            this.btnKhoaSinhVien.TabIndex = 1;
            this.btnKhoaSinhVien.Text = "Bài 1 - 4: Khoa và sinh viên (DataSet, DataView)";
            this.btnKhoaSinhVien.UseVisualStyleBackColor = true;
            this.btnKhoaSinhVien.Click += new System.EventHandler(this.btnKhoaSinhVien_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(30, 115);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(400, 40);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Bài 5, 7, 8: Cập nhật dữ liệu qua DataAdapter";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.Location = new System.Drawing.Point(30, 165);
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.Size = new System.Drawing.Size(400, 40);
            this.btnBangDiem.TabIndex = 3;
            this.btnBangDiem.Text = "Bài 6: Bảng điểm tạo thủ công";
            this.btnBangDiem.UseVisualStyleBackColor = true;
            this.btnBangDiem.Click += new System.EventHandler(this.btnBangDiem_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(30, 215);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(400, 40);
            this.btnXml.TabIndex = 4;
            this.btnXml.Text = "Bài 9: Lưu và đọc DataSet XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnHopNhat
            // 
            this.btnHopNhat.Location = new System.Drawing.Point(30, 265);
            this.btnHopNhat.Name = "btnHopNhat";
            this.btnHopNhat.Size = new System.Drawing.Size(400, 40);
            this.btnHopNhat.TabIndex = 5;
            this.btnHopNhat.Text = "Bài 10: Hợp nhất dữ liệu (Merge)";
            this.btnHopNhat.UseVisualStyleBackColor = true;
            this.btnHopNhat.Click += new System.EventHandler(this.btnHopNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(30, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(400, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 385);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHopNhat);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnBangDiem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnKhoaSinhVien);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 10 - Lê Đức Bình - 24000465";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnKhoaSinhVien;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnBangDiem;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnHopNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}
