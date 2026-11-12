namespace Lab05_MultiForm
{
    partial class frmTimKiem
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
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.radTheoTen = new System.Windows.Forms.RadioButton();
            this.radTheoMa = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location = new System.Drawing.Point(25, 25);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.TabIndex = 0;
            this.lblTuKhoa.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(110, 22);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(250, 22);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // radTheoTen
            // 
            this.radTheoTen.AutoSize = true;
            this.radTheoTen.Location = new System.Drawing.Point(110, 58);
            this.radTheoTen.Name = "radTheoTen";
            this.radTheoTen.TabIndex = 2;
            this.radTheoTen.Text = "Tìm theo tên";
            this.radTheoTen.Checked = true;
            this.radTheoTen.TabStop = true;
            this.radTheoTen.UseVisualStyleBackColor = true;
            // 
            // radTheoMa
            // 
            this.radTheoMa.AutoSize = true;
            this.radTheoMa.Location = new System.Drawing.Point(240, 58);
            this.radTheoMa.Name = "radTheoMa";
            this.radTheoMa.TabIndex = 3;
            this.radTheoMa.Text = "Tìm theo mã";
            this.radTheoMa.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(110, 95);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 34);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(240, 95);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 34);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 150);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.radTheoMa);
            this.Controls.Add(this.radTheoTen);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.lblTuKhoa);
            this.AcceptButton = this.btnTim;
            this.CancelButton = this.btnHuy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.RadioButton radTheoTen;
        private System.Windows.Forms.RadioButton radTheoMa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHuy;
    }
}
