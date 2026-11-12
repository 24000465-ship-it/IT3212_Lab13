namespace Lab10_DisconnectedData
{
    partial class frmXml
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
            this.btnNapCSDL = new System.Windows.Forms.Button();
            this.btnGhiXml = new System.Windows.Forms.Button();
            this.btnDocXml = new System.Windows.Forms.Button();
            this.lblDuongDan = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblThongTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNapCSDL
            // 
            this.btnNapCSDL.Location = new System.Drawing.Point(15, 12);
            this.btnNapCSDL.Name = "btnNapCSDL";
            this.btnNapCSDL.Size = new System.Drawing.Size(150, 34);
            this.btnNapCSDL.TabIndex = 0;
            this.btnNapCSDL.Text = "Nạp từ CSDL";
            this.btnNapCSDL.UseVisualStyleBackColor = true;
            this.btnNapCSDL.Click += new System.EventHandler(this.btnNapCSDL_Click);
            // 
            // btnGhiXml
            // 
            this.btnGhiXml.Location = new System.Drawing.Point(172, 12);
            this.btnGhiXml.Name = "btnGhiXml";
            this.btnGhiXml.Size = new System.Drawing.Size(190, 34);
            this.btnGhiXml.TabIndex = 1;
            this.btnGhiXml.Text = "Ghi XML (kèm schema)";
            this.btnGhiXml.UseVisualStyleBackColor = true;
            this.btnGhiXml.Click += new System.EventHandler(this.btnGhiXml_Click);
            // 
            // btnDocXml
            // 
            this.btnDocXml.Location = new System.Drawing.Point(369, 12);
            this.btnDocXml.Name = "btnDocXml";
            this.btnDocXml.Size = new System.Drawing.Size(210, 34);
            this.btnDocXml.TabIndex = 2;
            this.btnDocXml.Text = "Đọc XML (không kết nối)";
            this.btnDocXml.UseVisualStyleBackColor = true;
            this.btnDocXml.Click += new System.EventHandler(this.btnDocXml_Click);
            // 
            // lblDuongDan
            // 
            this.lblDuongDan.AutoSize = false;
            this.lblDuongDan.Location = new System.Drawing.Point(15, 55);
            this.lblDuongDan.Name = "lblDuongDan";
            this.lblDuongDan.Size = new System.Drawing.Size(970, 22);
            this.lblDuongDan.TabIndex = 3;
            this.lblDuongDan.Text = "";
            this.lblDuongDan.ForeColor = System.Drawing.Color.Gray;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(15, 82);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Khoa";
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.Location = new System.Drawing.Point(15, 105);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Size = new System.Drawing.Size(330, 400);
            this.dgvKhoa.TabIndex = 5;
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AllowUserToDeleteRows = false;
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.MultiSelect = false;
            this.dgvKhoa.RowHeadersWidth = 30;
            this.dgvKhoa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.AutoSize = true;
            this.lblSinhVien.Location = new System.Drawing.Point(360, 82);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.TabIndex = 6;
            this.lblSinhVien.Text = "Sinh viên";
            this.lblSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Location = new System.Drawing.Point(360, 105);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(625, 400);
            this.dgvSinhVien.TabIndex = 7;
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
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = false;
            this.lblThongTin.Location = new System.Drawing.Point(15, 512);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(970, 44);
            this.lblThongTin.TabIndex = 8;
            this.lblThongTin.Text = "Chưa có dữ liệu.";
            // 
            // frmXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.lblSinhVien);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblDuongDan);
            this.Controls.Add(this.btnDocXml);
            this.Controls.Add(this.btnGhiXml);
            this.Controls.Add(this.btnNapCSDL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmXml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 9: Lưu và đọc DataSet XML";
            this.Load += new System.EventHandler(this.frmXml_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNapCSDL;
        private System.Windows.Forms.Button btnGhiXml;
        private System.Windows.Forms.Button btnDocXml;
        private System.Windows.Forms.Label lblDuongDan;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblThongTin;
    }
}
