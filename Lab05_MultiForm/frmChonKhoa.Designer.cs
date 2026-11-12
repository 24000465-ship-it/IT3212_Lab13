namespace Lab05_MultiForm
{
    partial class frmChonKhoa
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
            this.lstKhoa = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Location = new System.Drawing.Point(20, 15);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.TabIndex = 0;
            this.lblHuongDan.Text = "Chọn một khoa (nhấp đúp để chọn nhanh):";
            // 
            // lstKhoa
            // 
            this.lstKhoa.Location = new System.Drawing.Point(20, 42);
            this.lstKhoa.Name = "lstKhoa";
            this.lstKhoa.Size = new System.Drawing.Size(330, 164);
            this.lstKhoa.TabIndex = 1;
            this.lstKhoa.FormattingEnabled = true;
            this.lstKhoa.ItemHeight = 16;
            this.lstKhoa.DoubleClick += new System.EventHandler(this.lstKhoa_DoubleClick);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(110, 218);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(115, 34);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(235, 218);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 34);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmChonKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 270);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lstKhoa);
            this.Controls.Add(this.lblHuongDan);
            this.AcceptButton = this.btnChon;
            this.CancelButton = this.btnHuy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChonKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn khoa";
            this.Load += new System.EventHandler(this.frmChonKhoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.ListBox lstKhoa;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
    }
}
