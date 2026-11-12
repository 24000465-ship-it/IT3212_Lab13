namespace Lab10_DisconnectedData
{
    partial class frmBangDiem
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
            this.grpNhap = new System.Windows.Forms.GroupBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.lblBieuThuc = new System.Windows.Forms.Label();
            this.lblTongKet = new System.Windows.Forms.Label();
            this.grpNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNhap
            // 
            this.grpNhap.Controls.Add(this.lblMa);
            this.grpNhap.Controls.Add(this.txtMa);
            this.grpNhap.Controls.Add(this.lblHoTen);
            this.grpNhap.Controls.Add(this.txtHoTen);
            this.grpNhap.Controls.Add(this.lblDiem);
            this.grpNhap.Controls.Add(this.txtDiem);
            this.grpNhap.Controls.Add(this.btnThem);
            this.grpNhap.Controls.Add(this.btnXoa);
            this.grpNhap.Location = new System.Drawing.Point(15, 10);
            this.grpNhap.Name = "grpNhap";
            this.grpNhap.Size = new System.Drawing.Size(730, 70);
            this.grpNhap.TabIndex = 0;
            this.grpNhap.Text = "Thêm sinh viên vào bảng điểm";
            this.grpNhap.TabStop = false;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(12, 32);
            this.lblMa.Name = "lblMa";
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã SV";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(62, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(80, 22);
            this.txtMa.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(155, 32);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(210, 29);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(190, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(412, 32);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.TabIndex = 5;
            this.lblDiem.Text = "Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(455, 29);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(55, 22);
            this.txtDiem.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(522, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(623, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 34);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa dòng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.Location = new System.Drawing.Point(15, 90);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.Size = new System.Drawing.Size(730, 280);
            this.dgvBangDiem.TabIndex = 9;
            this.dgvBangDiem.AllowUserToAddRows = false;
            this.dgvBangDiem.AllowUserToDeleteRows = false;
            this.dgvBangDiem.ReadOnly = false;
            this.dgvBangDiem.MultiSelect = false;
            this.dgvBangDiem.RowHeadersWidth = 30;
            this.dgvBangDiem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBangDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvBangDiem_DataError);
            this.dgvBangDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDiem_CellEndEdit);
            // 
            // lblBieuThuc
            // 
            this.lblBieuThuc.AutoSize = false;
            this.lblBieuThuc.Location = new System.Drawing.Point(15, 378);
            this.lblBieuThuc.Name = "lblBieuThuc";
            this.lblBieuThuc.Size = new System.Drawing.Size(730, 40);
            this.lblBieuThuc.TabIndex = 10;
            this.lblBieuThuc.Text = "";
            this.lblBieuThuc.ForeColor = System.Drawing.Color.Gray;
            // 
            // lblTongKet
            // 
            this.lblTongKet.AutoSize = false;
            this.lblTongKet.Location = new System.Drawing.Point(15, 420);
            this.lblTongKet.Name = "lblTongKet";
            this.lblTongKet.Size = new System.Drawing.Size(730, 24);
            this.lblTongKet.TabIndex = 11;
            this.lblTongKet.Text = "";
            this.lblTongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 455);
            this.Controls.Add(this.lblTongKet);
            this.Controls.Add(this.lblBieuThuc);
            this.Controls.Add(this.dgvBangDiem);
            this.Controls.Add(this.grpNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBangDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 6: Bảng điểm tạo thủ công";
            this.Load += new System.EventHandler(this.frmBangDiem_Load);
            this.grpNhap.ResumeLayout(false);
            this.grpNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhap;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.Label lblBieuThuc;
        private System.Windows.Forms.Label lblTongKet;
    }
}
