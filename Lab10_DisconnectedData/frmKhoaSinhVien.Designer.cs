namespace Lab10_DisconnectedData
{
    partial class frmKhoaSinhVien
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
            this.btnFillTable = new System.Windows.Forms.Button();
            this.btnNapDataSet = new System.Windows.Forms.Button();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.lblCon = new System.Windows.Forms.Label();
            this.lstSinhVienCon = new System.Windows.Forms.ListBox();
            this.lblSoCon = new System.Windows.Forms.Label();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.lblLocKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblDiemMin = new System.Windows.Forms.Label();
            this.numMinDiem = new System.Windows.Forms.NumericUpDown();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.grpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillTable
            // 
            this.btnFillTable.Location = new System.Drawing.Point(15, 12);
            this.btnFillTable.Name = "btnFillTable";
            this.btnFillTable.Size = new System.Drawing.Size(190, 34);
            this.btnFillTable.TabIndex = 0;
            this.btnFillTable.Text = "Bài 1: Fill DataTable";
            this.btnFillTable.UseVisualStyleBackColor = true;
            this.btnFillTable.Click += new System.EventHandler(this.btnFillTable_Click);
            // 
            // btnNapDataSet
            // 
            this.btnNapDataSet.Location = new System.Drawing.Point(215, 12);
            this.btnNapDataSet.Name = "btnNapDataSet";
            this.btnNapDataSet.Size = new System.Drawing.Size(190, 34);
            this.btnNapDataSet.TabIndex = 1;
            this.btnNapDataSet.Text = "Bài 2: Nạp DataSet";
            this.btnNapDataSet.UseVisualStyleBackColor = true;
            this.btnNapDataSet.Click += new System.EventHandler(this.btnNapDataSet_Click);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = false;
            this.lblThongTin.Location = new System.Drawing.Point(420, 14);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(665, 30);
            this.lblThongTin.TabIndex = 2;
            this.lblThongTin.Text = "Chưa nạp dữ liệu.";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(15, 62);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa";
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.Location = new System.Drawing.Point(15, 85);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Size = new System.Drawing.Size(420, 190);
            this.dgvKhoa.TabIndex = 4;
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AllowUserToDeleteRows = false;
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.MultiSelect = false;
            this.dgvKhoa.RowHeadersWidth = 30;
            this.dgvKhoa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.SelectionChanged += new System.EventHandler(this.dgvKhoa_SelectionChanged);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(15, 288);
            this.lblCon.Name = "lblCon";
            this.lblCon.TabIndex = 5;
            this.lblCon.Text = "Sinh viên của khoa đang chọn (GetChildRows)";
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // lstSinhVienCon
            // 
            this.lstSinhVienCon.Location = new System.Drawing.Point(15, 311);
            this.lstSinhVienCon.Name = "lstSinhVienCon";
            this.lstSinhVienCon.Size = new System.Drawing.Size(420, 244);
            this.lstSinhVienCon.TabIndex = 6;
            this.lstSinhVienCon.FormattingEnabled = true;
            this.lstSinhVienCon.ItemHeight = 16;
            // 
            // lblSoCon
            // 
            this.lblSoCon.AutoSize = false;
            this.lblSoCon.Location = new System.Drawing.Point(15, 562);
            this.lblSoCon.Name = "lblSoCon";
            this.lblSoCon.Size = new System.Drawing.Size(420, 24);
            this.lblSoCon.TabIndex = 7;
            this.lblSoCon.Text = "";
            // 
            // grpLoc
            // 
            this.grpLoc.Controls.Add(this.lblLocKhoa);
            this.grpLoc.Controls.Add(this.cboKhoa);
            this.grpLoc.Controls.Add(this.lblDiemMin);
            this.grpLoc.Controls.Add(this.numMinDiem);
            this.grpLoc.Controls.Add(this.btnLoc);
            this.grpLoc.Controls.Add(this.btnBoLoc);
            this.grpLoc.Location = new System.Drawing.Point(450, 55);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Size = new System.Drawing.Size(635, 62);
            this.grpLoc.TabIndex = 8;
            this.grpLoc.Text = "Bài 4: Lọc và sắp xếp bằng DataView";
            this.grpLoc.TabStop = false;
            // 
            // lblLocKhoa
            // 
            this.lblLocKhoa.AutoSize = true;
            this.lblLocKhoa.Location = new System.Drawing.Point(12, 27);
            this.lblLocKhoa.Name = "lblLocKhoa";
            this.lblLocKhoa.TabIndex = 9;
            this.lblLocKhoa.Text = "Khoa";
            // 
            // cboKhoa
            // 
            this.cboKhoa.Location = new System.Drawing.Point(55, 23);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(210, 24);
            this.cboKhoa.TabIndex = 10;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            // 
            // lblDiemMin
            // 
            this.lblDiemMin.AutoSize = true;
            this.lblDiemMin.Location = new System.Drawing.Point(280, 27);
            this.lblDiemMin.Name = "lblDiemMin";
            this.lblDiemMin.TabIndex = 11;
            this.lblDiemMin.Text = "Điểm từ";
            // 
            // numMinDiem
            // 
            this.numMinDiem.Location = new System.Drawing.Point(340, 24);
            this.numMinDiem.Name = "numMinDiem";
            this.numMinDiem.Size = new System.Drawing.Size(65, 22);
            this.numMinDiem.TabIndex = 12;
            this.numMinDiem.DecimalPlaces = 1;
            this.numMinDiem.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.numMinDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(420, 19);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(100, 32);
            this.btnLoc.TabIndex = 13;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Location = new System.Drawing.Point(525, 19);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(100, 32);
            this.btnBoLoc.TabIndex = 14;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.AutoSize = true;
            this.lblSinhVien.Location = new System.Drawing.Point(450, 125);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.TabIndex = 15;
            this.lblSinhVien.Text = "Sinh viên";
            this.lblSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Location = new System.Drawing.Point(450, 148);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(635, 407);
            this.dgvSinhVien.TabIndex = 16;
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.RowHeadersWidth = 30;
            this.dgvSinhVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = false;
            this.lblKetQua.Location = new System.Drawing.Point(450, 562);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(635, 24);
            this.lblKetQua.TabIndex = 17;
            this.lblKetQua.Text = "";
            // 
            // frmKhoaSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 595);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.lblSinhVien);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.lblSoCon);
            this.Controls.Add(this.lstSinhVienCon);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnNapDataSet);
            this.Controls.Add(this.btnFillTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmKhoaSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1 - 4: Khoa và sinh viên";
            this.Load += new System.EventHandler(this.frmKhoaSinhVien_Load);
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFillTable;
        private System.Windows.Forms.Button btnNapDataSet;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.ListBox lstSinhVienCon;
        private System.Windows.Forms.Label lblSoCon;
        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.Label lblLocKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblDiemMin;
        private System.Windows.Forms.NumericUpDown numMinDiem;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblKetQua;
    }
}
