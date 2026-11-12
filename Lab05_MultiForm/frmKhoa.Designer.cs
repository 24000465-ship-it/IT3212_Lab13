namespace Lab05_MultiForm
{
    partial class frmKhoa
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
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstKhoa = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(20, 23);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.TabIndex = 0;
            this.lblTenKhoa.Text = "Tên khoa";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(100, 20);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(250, 22);
            this.txtTenKhoa.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(360, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstKhoa
            // 
            this.lstKhoa.Location = new System.Drawing.Point(20, 60);
            this.lstKhoa.Name = "lstKhoa";
            this.lstKhoa.Size = new System.Drawing.Size(330, 180);
            this.lstKhoa.TabIndex = 3;
            this.lstKhoa.FormattingEnabled = true;
            this.lstKhoa.ItemHeight = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(360, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = false;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 250);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(330, 22);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số khoa: 0";
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 285);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lstKhoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.lblTenKhoa);
            this.Name = "frmKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục khoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstKhoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblSoLuong;
    }
}
