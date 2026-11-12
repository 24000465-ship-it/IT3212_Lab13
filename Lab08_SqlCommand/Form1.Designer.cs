namespace Lab08_SqlCommand
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
            this.grpBai12 = new System.Windows.Forms.GroupBox();
            this.btnDemSV = new System.Windows.Forms.Button();
            this.lblSoSV = new System.Windows.Forms.Label();
            this.btnDocDS = new System.Windows.Forms.Button();
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.grpCacBai = new System.Windows.Forms.GroupBox();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnTheoKhoa = new System.Windows.Forms.Button();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.grpBai12.SuspendLayout();
            this.grpCacBai.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(25, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Text = "LAB 8 - MySqlCommand, MySqlParameter";
            // 
            // grpBai12
            // 
            this.grpBai12.Controls.Add(this.btnDemSV);
            this.grpBai12.Controls.Add(this.lblSoSV);
            this.grpBai12.Controls.Add(this.btnDocDS);
            this.grpBai12.Controls.Add(this.lstSinhVien);
            this.grpBai12.Location = new System.Drawing.Point(25, 50);
            this.grpBai12.Name = "grpBai12";
            this.grpBai12.Size = new System.Drawing.Size(460, 400);
            this.grpBai12.TabIndex = 1;
            this.grpBai12.Text = "Bài 1, 2: ExecuteScalar và ExecuteReader";
            this.grpBai12.TabStop = false;
            // 
            // btnDemSV
            // 
            this.btnDemSV.Location = new System.Drawing.Point(15, 30);
            this.btnDemSV.Name = "btnDemSV";
            this.btnDemSV.Size = new System.Drawing.Size(150, 36);
            this.btnDemSV.TabIndex = 2;
            this.btnDemSV.Text = "Đếm sinh viên";
            this.btnDemSV.UseVisualStyleBackColor = true;
            this.btnDemSV.Click += new System.EventHandler(this.btnDemSV_Click);
            // 
            // lblSoSV
            // 
            this.lblSoSV.AutoSize = true;
            this.lblSoSV.Location = new System.Drawing.Point(180, 40);
            this.lblSoSV.Name = "lblSoSV";
            this.lblSoSV.TabIndex = 3;
            this.lblSoSV.Text = "Số sinh viên: ...";
            // 
            // btnDocDS
            // 
            this.btnDocDS.Location = new System.Drawing.Point(15, 76);
            this.btnDocDS.Name = "btnDocDS";
            this.btnDocDS.Size = new System.Drawing.Size(150, 36);
            this.btnDocDS.TabIndex = 4;
            this.btnDocDS.Text = "Đọc danh sách";
            this.btnDocDS.UseVisualStyleBackColor = true;
            this.btnDocDS.Click += new System.EventHandler(this.btnDocDS_Click);
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.Location = new System.Drawing.Point(15, 122);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(428, 260);
            this.lstSinhVien.TabIndex = 5;
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.ItemHeight = 16;
            // 
            // grpCacBai
            // 
            this.grpCacBai.Controls.Add(this.btnQuanLy);
            this.grpCacBai.Controls.Add(this.btnTheoKhoa);
            this.grpCacBai.Controls.Add(this.lblGhiChu);
            this.grpCacBai.Location = new System.Drawing.Point(505, 50);
            this.grpCacBai.Name = "grpCacBai";
            this.grpCacBai.Size = new System.Drawing.Size(250, 400);
            this.grpCacBai.TabIndex = 6;
            this.grpCacBai.Text = "Các bài khác";
            this.grpCacBai.TabStop = false;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Location = new System.Drawing.Point(15, 30);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(220, 56);
            this.btnQuanLy.TabIndex = 7;
            this.btnQuanLy.Text = "Bài 3, 4, 6, 8, 9:\nQuản lý sinh viên";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnTheoKhoa
            // 
            this.btnTheoKhoa.Location = new System.Drawing.Point(15, 100);
            this.btnTheoKhoa.Name = "btnTheoKhoa";
            this.btnTheoKhoa.Size = new System.Drawing.Size(220, 56);
            this.btnTheoKhoa.TabIndex = 8;
            this.btnTheoKhoa.Text = "Bài 5, 7:\nSinh viên theo khoa";
            this.btnTheoKhoa.UseVisualStyleBackColor = true;
            this.btnTheoKhoa.Click += new System.EventHandler(this.btnTheoKhoa_Click);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = false;
            this.lblGhiChu.Location = new System.Drawing.Point(15, 175);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(220, 80);
            this.lblGhiChu.TabIndex = 9;
            this.lblGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChu.Text = "Bài 10: lớp SqlHelper gói gọn ExecuteScalar, ExecuteNonQuery, ExecuteReader, dùng ở các bài 6, 7, 8.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 470);
            this.Controls.Add(this.grpCacBai);
            this.Controls.Add(this.grpBai12);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 8 - SqlCommand";
            this.grpBai12.ResumeLayout(false);
            this.grpBai12.PerformLayout();
            this.grpCacBai.ResumeLayout(false);
            this.grpCacBai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpBai12;
        private System.Windows.Forms.Button btnDemSV;
        private System.Windows.Forms.Label lblSoSV;
        private System.Windows.Forms.Button btnDocDS;
        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.GroupBox grpCacBai;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnTheoKhoa;
        private System.Windows.Forms.Label lblGhiChu;
    }
}
