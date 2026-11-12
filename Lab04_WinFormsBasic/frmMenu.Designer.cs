namespace Lab04_WinFormsBasic
{
    partial class frmMenu
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
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.btnBai1_5 = new System.Windows.Forms.Button();
            this.btnBai6 = new System.Windows.Forms.Button();
            this.btnBai7 = new System.Windows.Forms.Button();
            this.btnBai8 = new System.Windows.Forms.Button();
            this.btnBai9 = new System.Windows.Forms.Button();
            this.btnBai10 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(40, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Text = "LAB 4 - WINFORMS CƠ BẢN";
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.AutoSize = true;
            this.lblSinhVien.Location = new System.Drawing.Point(42, 52);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.TabIndex = 1;
            this.lblSinhVien.Text = "Sinh viên: Lê Đức Bình - 24000465";
            // 
            // btnBai1_5
            // 
            this.btnBai1_5.Location = new System.Drawing.Point(40, 85);
            this.btnBai1_5.Name = "btnBai1_5";
            this.btnBai1_5.Size = new System.Drawing.Size(340, 38);
            this.btnBai1_5.TabIndex = 2;
            this.btnBai1_5.Text = "Bài 1 - 5: Thông tin sinh viên";
            this.btnBai1_5.UseVisualStyleBackColor = true;
            this.btnBai1_5.Click += new System.EventHandler(this.btnBai1_5_Click);
            // 
            // btnBai6
            // 
            this.btnBai6.Location = new System.Drawing.Point(40, 131);
            this.btnBai6.Name = "btnBai6";
            this.btnBai6.Size = new System.Drawing.Size(340, 38);
            this.btnBai6.TabIndex = 3;
            this.btnBai6.Text = "Bài 6: Máy tính bốn phép toán";
            this.btnBai6.UseVisualStyleBackColor = true;
            this.btnBai6.Click += new System.EventHandler(this.btnBai6_Click);
            // 
            // btnBai7
            // 
            this.btnBai7.Location = new System.Drawing.Point(40, 177);
            this.btnBai7.Name = "btnBai7";
            this.btnBai7.Size = new System.Drawing.Size(340, 38);
            this.btnBai7.TabIndex = 4;
            this.btnBai7.Text = "Bài 7: Form đăng nhập";
            this.btnBai7.UseVisualStyleBackColor = true;
            this.btnBai7.Click += new System.EventHandler(this.btnBai7_Click);
            // 
            // btnBai8
            // 
            this.btnBai8.Location = new System.Drawing.Point(40, 223);
            this.btnBai8.Name = "btnBai8";
            this.btnBai8.Size = new System.Drawing.Size(340, 38);
            this.btnBai8.TabIndex = 5;
            this.btnBai8.Text = "Bài 8: Tính chỉ số BMI";
            this.btnBai8.UseVisualStyleBackColor = true;
            this.btnBai8.Click += new System.EventHandler(this.btnBai8_Click);
            // 
            // btnBai9
            // 
            this.btnBai9.Location = new System.Drawing.Point(40, 269);
            this.btnBai9.Name = "btnBai9";
            this.btnBai9.Size = new System.Drawing.Size(340, 38);
            this.btnBai9.TabIndex = 6;
            this.btnBai9.Text = "Bài 9: Đăng ký học phần";
            this.btnBai9.UseVisualStyleBackColor = true;
            this.btnBai9.Click += new System.EventHandler(this.btnBai9_Click);
            // 
            // btnBai10
            // 
            this.btnBai10.Location = new System.Drawing.Point(40, 315);
            this.btnBai10.Name = "btnBai10";
            this.btnBai10.Size = new System.Drawing.Size(340, 38);
            this.btnBai10.TabIndex = 7;
            this.btnBai10.Text = "Bài 10: Phiếu nhập sản phẩm";
            this.btnBai10.UseVisualStyleBackColor = true;
            this.btnBai10.Click += new System.EventHandler(this.btnBai10_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(40, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(340, 38);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 422);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBai10);
            this.Controls.Add(this.btnBai9);
            this.Controls.Add(this.btnBai8);
            this.Controls.Add(this.btnBai7);
            this.Controls.Add(this.btnBai6);
            this.Controls.Add(this.btnBai1_5);
            this.Controls.Add(this.lblSinhVien);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 4 - Menu chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.Button btnBai1_5;
        private System.Windows.Forms.Button btnBai6;
        private System.Windows.Forms.Button btnBai7;
        private System.Windows.Forms.Button btnBai8;
        private System.Windows.Forms.Button btnBai9;
        private System.Windows.Forms.Button btnBai10;
        private System.Windows.Forms.Button btnThoat;
    }
}
