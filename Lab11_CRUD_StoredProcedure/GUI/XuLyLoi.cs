using System;
using System.Data.Common;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Lab11_CRUD_StoredProcedure.DTO;

namespace Lab11_CRUD_StoredProcedure.GUI
{
    public static class XuLyLoi
    {
        public static string DuongDanNhatKy
        {
            get
            {
                return Path.Combine(Application.StartupPath, "Logs", "loi_" + DateTime.Today.ToString("yyyyMMdd") + ".log");
            }
        }

        public static void HienThi(Exception ex, string thaoTac)
        {
            if (ex is LoiNghiepVuException)
            {
                GhiNhatKy("NGHIEP VU", thaoTac, ex);
                MessageBox.Show(ex.Message, "Không thực hiện được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ex is ArgumentException || ex is FormatException)
            {
                MessageBox.Show(ex.Message, "Dữ liệu nhập chưa đúng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ex is DbException)
            {
                GhiNhatKy("CSDL", thaoTac, ex);
                MessageBox.Show("Không làm việc được với cơ sở dữ liệu. Hãy kiểm tra kết nối rồi thử lại.\n"
                    + "Chi tiết lỗi đã được ghi vào nhật ký.", "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GhiNhatKy("KHAC", thaoTac, ex);
                MessageBox.Show("Đã xảy ra lỗi ngoài dự kiến. Chi tiết lỗi đã được ghi vào nhật ký.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void GhiNhatKy(string loai, string thaoTac, Exception ex)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(DuongDanNhatKy));
                string noiDung = string.Format("[{0:dd/MM/yyyy HH:mm:ss}] [{1}] {2}\r\n{3}\r\n\r\n",
                    DateTime.Now, loai, thaoTac, ex);
                File.AppendAllText(DuongDanNhatKy, noiDung, Encoding.UTF8);
            }
            catch (IOException)
            {
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
    }
}
