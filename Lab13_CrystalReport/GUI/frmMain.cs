using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace Lab13_CrystalReport.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblMoiTruong.Text = ThongTinMoiTruong();
        }

        private string ThongTinMoiTruong()
        {
            Assembly engine = typeof(ReportDocument).Assembly;
            FileVersionInfo tep = FileVersionInfo.GetVersionInfo(engine.Location);
            return "Crystal Reports: " + engine.GetName().Version + " (tệp " + tep.FileVersion + ")\n"
                + "Viewer: " + typeof(CrystalReportViewer).Assembly.GetName().Version
                + " | Shared: " + typeof(ExportFormatType).Assembly.GetName().Version + "\n"
                + "Tiến trình: " + (Environment.Is64BitProcess ? "64-bit (x64)" : "32-bit (x86)")
                + " | .NET CLR " + Environment.Version;
        }

        private void MoBaoCao<T>() where T : Form, new()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is T)
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    return;
                }
            }
            T moi = new T();
            moi.Show();
        }

        private void mnuBaoCaoSinhVien_Click(object sender, EventArgs e)
        {
            MoBaoCao<frmBaoCaoSinhVien>();
        }

        private void mnuBaoCaoKhoa_Click(object sender, EventArgs e)
        {
            MoBaoCao<frmBaoCaoKhoa>();
        }

        private void mnuBaoCaoHocPhan_Click(object sender, EventArgs e)
        {
            MoBaoCao<frmBaoCaoHocPhan>();
        }

        private void mnuKiemTra_Click(object sender, EventArgs e)
        {
            string ketQua;
            try
            {
                using (ReportDocument thu = new ReportDocument())
                {
                    ketQua = "Đã tạo được ReportDocument, Crystal Reports runtime hoạt động bình thường.";
                }
            }
            catch (Exception ex)
            {
                ketQua = "Không khởi tạo được Crystal Reports: " + ex.Message;
            }
            MessageBox.Show(ThongTinMoiTruong() + "\n\n" + ketQua, "Kiểm tra môi trường Crystal Reports",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
