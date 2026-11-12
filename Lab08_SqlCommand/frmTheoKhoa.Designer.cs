namespace Lab08_SqlCommand
{
    partial class frmTheoKhoa
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
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnDiemMax = new System.Windows.Forms.Button();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblDiemMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(25, 25);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Khoa";
            // 
            // cboKhoa
            // 
            this.cboKhoa.Location = new System.Drawing.Point(80, 22);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(260, 24);
            this.cboKhoa.TabIndex = 1;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(355, 18);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(200, 34);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem sinh viên (Bài 5)";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnDiemMax
            // 
            this.btnDiemMax.Location = new System.Drawing.Point(565, 18);
            this.btnDiemMax.Name = "btnDiemMax";
            this.btnDiemMax.Size = new System.Drawing.Size(200, 34);
            this.btnDiemMax.TabIndex = 3;
            this.btnDiemMax.Text = "Điểm cao nhất (Bài 7)";
            this.btnDiemMax.UseVisualStyleBackColor = true;
            this.btnDiemMax.Click += new System.EventHandler(this.btnDiemMax_Click);
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Location = new System.Drawing.Point(25, 65);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(740, 280);
            this.lvSinhVien.TabIndex = 4;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = false;
            this.lblKetQua.Location = new System.Drawing.Point(25, 355);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(740, 26);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "Chọn khoa rồi bấm \"Xem sinh viên\".";
            // 
            // lblDiemMax
            // 
            this.lblDiemMax.AutoSize = false;
            this.lblDiemMax.Location = new System.Drawing.Point(25, 385);
            this.lblDiemMax.Name = "lblDiemMax";
            this.lblDiemMax.Size = new System.Drawing.Size(740, 26);
            this.lblDiemMax.TabIndex = 6;
            this.lblDiemMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiemMax.Text = "Điểm cao nhất: ...";
            // 
            // frmTheoKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 425);
            this.Controls.Add(this.lblDiemMax);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.btnDiemMax);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTheoKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 5, 7 - Sinh viên theo khoa";
            this.Load += new System.EventHandler(this.frmTheoKhoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnDiemMax;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblDiemMax;
    }
}
