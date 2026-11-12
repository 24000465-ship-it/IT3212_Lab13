using System;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hiện form đăng nhập trước; đăng nhập đúng mới mở form chính
            frmDangNhap dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain(dangNhap.TenDangNhap));
            }
        }
    }
}
