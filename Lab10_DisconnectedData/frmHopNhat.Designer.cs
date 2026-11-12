namespace Lab10_DisconnectedData
{
    partial class frmHopNhat
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
            this.btnTaoNguon = new System.Windows.Forms.Button();
            this.chkKhoaChinh = new System.Windows.Forms.CheckBox();
            this.chkGiuThayDoi = new System.Windows.Forms.CheckBox();
            this.btnHopNhat = new System.Windows.Forms.Button();
            this.lblNguon1 = new System.Windows.Forms.Label();
            this.dgvNguon1 = new System.Windows.Forms.DataGridView();
            this.lblNguon2 = new System.Windows.Forms.Label();
            this.dgvNguon2 = new System.Windows.Forms.DataGridView();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.lblTongKet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoNguon
            // 
            this.btnTaoNguon.Location = new System.Drawing.Point(15, 12);
            this.btnTaoNguon.Name = "btnTaoNguon";
            this.btnTaoNguon.Size = new System.Drawing.Size(190, 34);
            this.btnTaoNguon.TabIndex = 0;
            this.btnTaoNguon.Text = "Tạo hai nguồn dữ liệu";
            this.btnTaoNguon.UseVisualStyleBackColor = true;
            this.btnTaoNguon.Click += new System.EventHandler(this.btnTaoNguon_Click);
            // 
            // chkKhoaChinh
            // 
            this.chkKhoaChinh.AutoSize = true;
            this.chkKhoaChinh.Location = new System.Drawing.Point(225, 19);
            this.chkKhoaChinh.Name = "chkKhoaChinh";
            this.chkKhoaChinh.TabIndex = 1;
            this.chkKhoaChinh.Text = "Đặt khóa chính MaSV";
            this.chkKhoaChinh.Checked = true;
            this.chkKhoaChinh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKhoaChinh.UseVisualStyleBackColor = true;
            // 
            // chkGiuThayDoi
            // 
            this.chkGiuThayDoi.AutoSize = true;
            this.chkGiuThayDoi.Location = new System.Drawing.Point(395, 19);
            this.chkGiuThayDoi.Name = "chkGiuThayDoi";
            this.chkGiuThayDoi.TabIndex = 2;
            this.chkGiuThayDoi.Text = "Giữ thay đổi cục bộ (preserveChanges)";
            this.chkGiuThayDoi.UseVisualStyleBackColor = true;
            // 
            // btnHopNhat
            // 
            this.btnHopNhat.Location = new System.Drawing.Point(680, 12);
            this.btnHopNhat.Name = "btnHopNhat";
            this.btnHopNhat.Size = new System.Drawing.Size(190, 34);
            this.btnHopNhat.TabIndex = 3;
            this.btnHopNhat.Text = "Hợp nhất (Merge)";
            this.btnHopNhat.UseVisualStyleBackColor = true;
            this.btnHopNhat.Click += new System.EventHandler(this.btnHopNhat_Click);
            // 
            // lblNguon1
            // 
            this.lblNguon1.AutoSize = true;
            this.lblNguon1.Location = new System.Drawing.Point(15, 58);
            this.lblNguon1.Name = "lblNguon1";
            this.lblNguon1.TabIndex = 4;
            this.lblNguon1.Text = "Nguồn 1: CSDL (khoa CNTT)";
            this.lblNguon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // dgvNguon1
            // 
            this.dgvNguon1.Location = new System.Drawing.Point(15, 81);
            this.dgvNguon1.Name = "dgvNguon1";
            this.dgvNguon1.Size = new System.Drawing.Size(530, 210);
            this.dgvNguon1.TabIndex = 5;
            this.dgvNguon1.AllowUserToAddRows = false;
            this.dgvNguon1.AllowUserToDeleteRows = false;
            this.dgvNguon1.ReadOnly = false;
            this.dgvNguon1.MultiSelect = false;
            this.dgvNguon1.RowHeadersWidth = 30;
            this.dgvNguon1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNguon1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguon1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNguon1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // 
            // lblNguon2
            // 
            this.lblNguon2.AutoSize = true;
            this.lblNguon2.Location = new System.Drawing.Point(555, 58);
            this.lblNguon2.Name = "lblNguon2";
            this.lblNguon2.TabIndex = 6;
            this.lblNguon2.Text = "Nguồn 2: danh sách bổ sung (phòng đào tạo gửi)";
            this.lblNguon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // dgvNguon2
            // 
            this.dgvNguon2.Location = new System.Drawing.Point(555, 81);
            this.dgvNguon2.Name = "dgvNguon2";
            this.dgvNguon2.Size = new System.Drawing.Size(530, 210);
            this.dgvNguon2.TabIndex = 7;
            this.dgvNguon2.AllowUserToAddRows = false;
            this.dgvNguon2.AllowUserToDeleteRows = false;
            this.dgvNguon2.ReadOnly = false;
            this.dgvNguon2.MultiSelect = false;
            this.dgvNguon2.RowHeadersWidth = 30;
            this.dgvNguon2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNguon2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguon2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNguon2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(15, 303);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.TabIndex = 8;
            this.lblKetQua.Text = "Kết quả sau khi hợp nhất";
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Location = new System.Drawing.Point(15, 326);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(1070, 215);
            this.dgvKetQua.TabIndex = 9;
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.RowHeadersWidth = 30;
            this.dgvKetQua.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // 
            // lblTongKet
            // 
            this.lblTongKet.AutoSize = false;
            this.lblTongKet.Location = new System.Drawing.Point(15, 548);
            this.lblTongKet.Name = "lblTongKet";
            this.lblTongKet.Size = new System.Drawing.Size(1070, 44);
            this.lblTongKet.TabIndex = 10;
            this.lblTongKet.Text = "";
            // 
            // frmHopNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.lblTongKet);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.dgvNguon2);
            this.Controls.Add(this.lblNguon2);
            this.Controls.Add(this.dgvNguon1);
            this.Controls.Add(this.lblNguon1);
            this.Controls.Add(this.btnHopNhat);
            this.Controls.Add(this.chkGiuThayDoi);
            this.Controls.Add(this.chkKhoaChinh);
            this.Controls.Add(this.btnTaoNguon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHopNhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 10: Hợp nhất dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoNguon;
        private System.Windows.Forms.CheckBox chkKhoaChinh;
        private System.Windows.Forms.CheckBox chkGiuThayDoi;
        private System.Windows.Forms.Button btnHopNhat;
        private System.Windows.Forms.Label lblNguon1;
        private System.Windows.Forms.DataGridView dgvNguon1;
        private System.Windows.Forms.Label lblNguon2;
        private System.Windows.Forms.DataGridView dgvNguon2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lblTongKet;
    }
}
