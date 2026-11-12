namespace Lab10_DisconnectedData
{
    partial class frmCapNhat
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
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXemThayDoi = new System.Windows.Forms.Button();
            this.btnChapNhan = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblThayDoi = new System.Windows.Forms.Label();
            this.dgvThayDoi = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThayDoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(15, 12);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(150, 34);
            this.btnTaiLai.TabIndex = 0;
            this.btnTaiLai.Text = "Tải lại từ CSDL";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(172, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(170, 34);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu về CSDL (Update)";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXemThayDoi
            // 
            this.btnXemThayDoi.Location = new System.Drawing.Point(349, 12);
            this.btnXemThayDoi.Name = "btnXemThayDoi";
            this.btnXemThayDoi.Size = new System.Drawing.Size(210, 34);
            this.btnXemThayDoi.TabIndex = 2;
            this.btnXemThayDoi.Text = "Xem thay đổi (GetChanges)";
            this.btnXemThayDoi.UseVisualStyleBackColor = true;
            this.btnXemThayDoi.Click += new System.EventHandler(this.btnXemThayDoi_Click);
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.Location = new System.Drawing.Point(566, 12);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(255, 34);
            this.btnChapNhan.TabIndex = 3;
            this.btnChapNhan.Text = "Chấp nhận cục bộ (AcceptChanges)";
            this.btnChapNhan.UseVisualStyleBackColor = true;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(828, 12);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(257, 34);
            this.btnHoanTac.TabIndex = 4;
            this.btnHoanTac.Text = "Hoàn tác (RejectChanges)";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Location = new System.Drawing.Point(15, 55);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.TabIndex = 5;
            this.lblHuongDan.Text = "Sửa trực tiếp trên lưới. Thêm dòng ở dòng trống cuối lưới. Xóa: bấm vào đầu dòng rồi nhấn phím Delete.";
            this.lblHuongDan.ForeColor = System.Drawing.Color.Gray;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Location = new System.Drawing.Point(15, 80);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(1070, 300);
            this.dgvSinhVien.TabIndex = 6;
            this.dgvSinhVien.AllowUserToAddRows = true;
            this.dgvSinhVien.AllowUserToDeleteRows = true;
            this.dgvSinhVien.ReadOnly = false;
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.RowHeadersWidth = 30;
            this.dgvSinhVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSinhVien_DataError);
            // 
            // lblThayDoi
            // 
            this.lblThayDoi.AutoSize = true;
            this.lblThayDoi.Location = new System.Drawing.Point(15, 392);
            this.lblThayDoi.Name = "lblThayDoi";
            this.lblThayDoi.TabIndex = 7;
            this.lblThayDoi.Text = "Các dòng đã thay đổi, chưa gửi về CSDL";
            this.lblThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // dgvThayDoi
            // 
            this.dgvThayDoi.Location = new System.Drawing.Point(15, 415);
            this.dgvThayDoi.Name = "dgvThayDoi";
            this.dgvThayDoi.Size = new System.Drawing.Size(1070, 170);
            this.dgvThayDoi.TabIndex = 8;
            this.dgvThayDoi.AllowUserToAddRows = false;
            this.dgvThayDoi.AllowUserToDeleteRows = false;
            this.dgvThayDoi.ReadOnly = true;
            this.dgvThayDoi.MultiSelect = false;
            this.dgvThayDoi.RowHeadersWidth = 30;
            this.dgvThayDoi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThayDoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThayDoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThayDoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Spring = true;
            this.lblTrangThai.Text = "Sẵn sàng";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 622);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvThayDoi);
            this.Controls.Add(this.lblThayDoi);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.btnXemThayDoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaiLai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCapNhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 5, 7, 8: Cập nhật dữ liệu qua DataAdapter";
            this.Load += new System.EventHandler(this.frmCapNhat_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThayDoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXemThayDoi;
        private System.Windows.Forms.Button btnChapNhan;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblThayDoi;
        private System.Windows.Forms.DataGridView dgvThayDoi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
    }
}
