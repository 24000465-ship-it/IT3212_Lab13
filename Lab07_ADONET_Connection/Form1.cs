using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab07_ADONET_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder tt = DbConnectionFactory.ThongTin();
                lblThongTin.Text = "Chuỗi kết nối đọc từ App.config (tên: QLSinhVien)\n"
                    + "Máy chủ: " + tt.Server + ":" + tt.Port + "     Database: " + tt.Database + "\n"
                    + "Tài khoản: " + tt.UserID;
            }
            catch (Exception ex)
            {
                lblThongTin.Text = ex.Message;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DbConnectionFactory.Create())
                {
                    conn.Open();
                    lblKetQua.ForeColor = Color.DarkGreen;
                    lblKetQua.Text = "Kết nối thành công: " + conn.Database + " (MySQL " + conn.ServerVersion + ")";
                    MessageBox.Show("Kết nối thành công: " + conn.Database, "Kiểm tra kết nối");
                }
            }
            catch (MySqlException ex)
            {
                lblKetQua.ForeColor = Color.Red;
                lblKetQua.Text = "Kết nối thất bại.";
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Kiểm tra kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                lblKetQua.ForeColor = Color.Red;
                lblKetQua.Text = "Kết nối thất bại.";
                MessageBox.Show("Lỗi: " + ex.Message, "Kiểm tra kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            frmTrangThai f = new frmTrangThai();
            f.ShowDialog();
        }
    }
}
