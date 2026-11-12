namespace Lab04_WinFormsBasic
{
    partial class frmDangKyHocPhan
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
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.lblTongTinChi = new System.Windows.Forms.Label();
            this.lblCanhBao = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Location = new System.Drawing.Point(20, 15);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.TabIndex = 0;
            this.lblHuongDan.Text = "Chọn các học phần muốn đăng ký (tối đa 20 tín chỉ):";
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.Location = new System.Drawing.Point(20, 42);
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(430, 190);
            this.clbMonHoc.TabIndex = 1;
            this.clbMonHoc.CheckOnClick = true;
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbMonHoc_ItemCheck);
            // 
            // lblTongTinChi
            // 
            this.lblTongTinChi.AutoSize = false;
            this.lblTongTinChi.Location = new System.Drawing.Point(20, 245);
            this.lblTongTinChi.Name = "lblTongTinChi";
            this.lblTongTinChi.Size = new System.Drawing.Size(430, 24);
            this.lblTongTinChi.TabIndex = 2;
            this.lblTongTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTinChi.Text = "Tổng số tín chỉ: 0";
            // 
            // lblCanhBao
            // 
            this.lblCanhBao.AutoSize = false;
            this.lblCanhBao.Location = new System.Drawing.Point(20, 272);
            this.lblCanhBao.Name = "lblCanhBao";
            this.lblCanhBao.Size = new System.Drawing.Size(430, 24);
            this.lblCanhBao.TabIndex = 3;
            this.lblCanhBao.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao.Text = "";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(20, 305);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(130, 36);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.Location = new System.Drawing.Point(160, 305);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(150, 36);
            this.btnBoChon.TabIndex = 5;
            this.btnBoChon.Text = "Bỏ chọn tất cả";
            this.btnBoChon.UseVisualStyleBackColor = true;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(320, 305);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 360);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoChon);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblCanhBao);
            this.Controls.Add(this.lblTongTinChi);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.lblHuongDan);
            this.Name = "frmDangKyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 9 - Đăng ký học phần";
            this.Load += new System.EventHandler(this.frmDangKyHocPhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Label lblTongTinChi;
        private System.Windows.Forms.Label lblCanhBao;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.Button btnThoat;
    }
}
