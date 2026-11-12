namespace Lab04_WinFormsBasic
{
    partial class frmBMI
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
            this.lblChieuCao = new System.Windows.Forms.Label();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.lblCanNang = new System.Windows.Forms.Label();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblBangPhanLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChieuCao
            // 
            this.lblChieuCao.AutoSize = true;
            this.lblChieuCao.Location = new System.Drawing.Point(30, 32);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.TabIndex = 0;
            this.lblChieuCao.Text = "Chiều cao (cm)";
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(160, 29);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(220, 22);
            this.txtChieuCao.TabIndex = 1;
            // 
            // lblCanNang
            // 
            this.lblCanNang.AutoSize = true;
            this.lblCanNang.Location = new System.Drawing.Point(30, 72);
            this.lblCanNang.Name = "lblCanNang";
            this.lblCanNang.TabIndex = 2;
            this.lblCanNang.Text = "Cân nặng (kg)";
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(160, 69);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(220, 22);
            this.txtCanNang.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(160, 110);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(105, 36);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính BMI";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(275, 110);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 36);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = false;
            this.lblBMI.Location = new System.Drawing.Point(30, 165);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(350, 24);
            this.lblBMI.TabIndex = 6;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBMI.Text = "Chỉ số BMI:";
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = false;
            this.lblPhanLoai.Location = new System.Drawing.Point(30, 197);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(350, 24);
            this.lblPhanLoai.TabIndex = 7;
            this.lblPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhanLoai.Text = "Phân loại:";
            // 
            // lblBangPhanLoai
            // 
            this.lblBangPhanLoai.AutoSize = false;
            this.lblBangPhanLoai.Location = new System.Drawing.Point(30, 235);
            this.lblBangPhanLoai.Name = "lblBangPhanLoai";
            this.lblBangPhanLoai.Size = new System.Drawing.Size(360, 70);
            this.lblBangPhanLoai.TabIndex = 8;
            this.lblBangPhanLoai.Text = "Gầy: BMI < 18,5\r\nBình thường: 18,5 - 24,9\r\nThừa cân: 25 - 29,9\r\nBéo phì: BMI >= 30";
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.lblBangPhanLoai);
            this.Controls.Add(this.lblPhanLoai);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.lblCanNang);
            this.Controls.Add(this.txtChieuCao);
            this.Controls.Add(this.lblChieuCao);
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 8 - Tính chỉ số BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChieuCao;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.Label lblCanNang;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblBangPhanLoai;
    }
}
