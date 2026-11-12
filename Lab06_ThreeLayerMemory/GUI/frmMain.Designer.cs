namespace Lab06_ThreeLayerMemory.GUI
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
            this.lblMoTa = new System.Windows.Forms.Label();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.btnCayKhoa = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(25, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Text = "QUẢN LÝ SINH VIÊN - LAB 6";
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(28, 52);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Mô hình 3 lớp GUI - BUS - DAL, dữ liệu lưu trong bộ nhớ";
            this.btnSinhVien.Location = new System.Drawing.Point(30, 85);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(480, 40);
            this.btnSinhVien.TabIndex = 2;
            this.btnSinhVien.Text = "Bài 1, 2, 5: Quản lý sinh viên (DataGridView + BindingList)";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            this.btnListView.Location = new System.Drawing.Point(30, 135);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(480, 40);
            this.btnListView.TabIndex = 3;
            this.btnListView.Text = "Bài 3, 8: Danh sách sinh viên (ListView + ImageList)";
            this.btnListView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            this.btnCayKhoa.Location = new System.Drawing.Point(30, 185);
            this.btnCayKhoa.Name = "btnCayKhoa";
            this.btnCayKhoa.Size = new System.Drawing.Size(480, 40);
            this.btnCayKhoa.TabIndex = 4;
            this.btnCayKhoa.Text = "Bài 4: Cây Khoa - Sinh viên (TreeView)";
            this.btnCayKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCayKhoa.UseVisualStyleBackColor = true;
            this.btnCayKhoa.Click += new System.EventHandler(this.btnCayKhoa_Click);
            this.btnSanPham.Location = new System.Drawing.Point(30, 235);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(480, 40);
            this.btnSanPham.TabIndex = 5;
            this.btnSanPham.Text = "Bài 6: Quản lý sản phẩm (DataGridView)";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            this.btnDanhMuc.Location = new System.Drawing.Point(30, 285);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(480, 40);
            this.btnDanhMuc.TabIndex = 6;
            this.btnDanhMuc.Text = "Bài 7: Danh mục sản phẩm (TreeView + ContextMenuStrip)";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            this.lblFile.AutoSize = false;
            this.lblFile.Location = new System.Drawing.Point(30, 340);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(480, 40);
            this.lblFile.TabIndex = 7;
            this.lblFile.Text = "Bài 9 - Tệp dữ liệu:";
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(30, 388);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.TabIndex = 8;
            this.lblTacGia.ForeColor = System.Drawing.Color.Gray;
            this.lblTacGia.Text = "Sinh viên thực hiện: Lê Đức Bình - 24000465";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 420);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.btnCayKhoa);
            this.Controls.Add(this.btnListView);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên - Lab 6";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.Button btnCayKhoa;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblTacGia;
    }
}
