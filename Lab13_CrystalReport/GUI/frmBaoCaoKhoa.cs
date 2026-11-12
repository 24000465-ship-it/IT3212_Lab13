using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Lab13_CrystalReport.DAL;
using Lab13_CrystalReport.Reports;

namespace Lab13_CrystalReport.GUI
{
    public partial class frmBaoCaoKhoa : Form
    {
        private ReportDocument _report;

        public frmBaoCaoKhoa()
        {
            InitializeComponent();
        }

        private void frmBaoCaoKhoa_Load(object sender, EventArgs e)
        {
            NapBaoCao();
        }

        private void NapBaoCao()
        {
            try
            {
                DataTable data = new BaoCaoDAL().GetFacultyReportData();
                GiaiPhongBaoCao();
                _report = new CrystalReportKhoa();
                _report.SetDataSource(data);
                crystalReportViewer1.ReportSource = _report;
                crystalReportViewer1.Refresh();
                lblThongTin.Text = "Số khoa: " + data.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được báo cáo.\nHãy kiểm tra kết nối CSDL và Crystal Reports runtime (64-bit).\n\nChi tiết: "
                    + ex.Message, "Lỗi báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GiaiPhongBaoCao()
        {
            if (_report != null)
            {
                crystalReportViewer1.ReportSource = null;
                _report.Close();
                _report.Dispose();
                _report = null;
            }
        }

        private void XuatPdf(string duongDan)
        {
            _report.ExportToDisk(ExportFormatType.PortableDocFormat, duongDan);
        }

        private void btnXuatPdf_Click(object sender, EventArgs e)
        {
            if (_report == null)
            {
                MessageBox.Show("Chưa có báo cáo để xuất.", "Xuất PDF");
                return;
            }
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "PDF file|*.pdf";
                dlg.FileName = "DanhSachKhoa.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XuatPdf(dlg.FileName);
                        MessageBox.Show("Đã xuất báo cáo:\n" + dlg.FileName, "Xuất PDF");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không xuất được tệp PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (_report == null) return;
            using (PrintDialog dlg = new PrintDialog())
            {
                dlg.UseEXDialog = true;
                dlg.AllowSomePages = true;
                if (dlg.ShowDialog() != DialogResult.OK) return;
                try
                {
                    _report.PrintToPrinter(dlg.PrinterSettings, dlg.PrinterSettings.DefaultPageSettings, false);
                    MessageBox.Show("Đã gửi báo cáo tới máy in " + dlg.PrinterSettings.PrinterName + ".", "In báo cáo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không in được: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            NapBaoCao();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            GiaiPhongBaoCao();
            base.OnFormClosed(e);
        }
    }
}
