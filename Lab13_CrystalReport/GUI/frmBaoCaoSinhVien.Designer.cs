namespace Lab13_CrystalReport.GUI
{
    partial class frmBaoCaoSinhVien
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
            this.tsBaoCao = new System.Windows.Forms.ToolStrip();
            this.btnTaiLai = new System.Windows.Forms.ToolStripButton();
            this.btnXuatPdf = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.tsNganCach = new System.Windows.Forms.ToolStripSeparator();
            this.lblThongTin = new System.Windows.Forms.ToolStripLabel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tsBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBaoCao
            // 
            this.tsBaoCao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTaiLai,
            this.btnXuatPdf,
            this.btnIn,
            this.tsNganCach,
            this.lblThongTin});
            this.tsBaoCao.Name = "tsBaoCao";
            this.tsBaoCao.TabIndex = 0;
            this.tsBaoCao.Text = "tsBaoCao";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnXuatPdf
            // 
            this.btnXuatPdf.Name = "btnXuatPdf";
            this.btnXuatPdf.Text = "Xuất PDF";
            this.btnXuatPdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXuatPdf.Click += new System.EventHandler(this.btnXuatPdf_Click);
            // 
            // btnIn
            // 
            this.btnIn.Name = "btnIn";
            this.btnIn.Text = "In...";
            this.btnIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // tsNganCach
            // 
            this.tsNganCach.Name = "tsNganCach";
            // 
            // lblThongTin
            // 
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Text = "";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 27);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1000, 640);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmBaoCaoSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 667);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.tsBaoCao);
            this.Name = "frmBaoCaoSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmBaoCaoSinhVien_Load);
            this.tsBaoCao.ResumeLayout(false);
            this.tsBaoCao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBaoCao;
        private System.Windows.Forms.ToolStripButton btnTaiLai;
        private System.Windows.Forms.ToolStripButton btnXuatPdf;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripSeparator tsNganCach;
        private System.Windows.Forms.ToolStripLabel lblThongTin;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
