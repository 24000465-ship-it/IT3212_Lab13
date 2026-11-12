using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab08_SqlCommand
{
    public partial class frmTheoKhoa : Form
    {
        public frmTheoKhoa()
        {
            InitializeComponent();
        }

        private void frmTheoKhoa_Load(object sender, EventArgs e)
        {
            lvSinhVien.Columns.Add("Mã SV", 100);
            lvSinhVien.Columns.Add("Họ tên", 260);
            lvSinhVien.Columns.Add("Ngày sinh", 140);
            lvSinhVien.Columns.Add("Điểm TB", 100, HorizontalAlignment.Right);
            try
            {
                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.ValueMember = "MaKhoa";
                cboKhoa.DataSource = SqlHelper.ExecuteDataTable("SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedValue == null) return;
            string maKhoa = cboKhoa.SelectedValue.ToString();
            try
            {
                using (MySqlConnection conn = DbConnectionFactory.Create())
                using (MySqlCommand cmd = new MySqlCommand("sp_SinhVien_TheoKhoa", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_MaKhoa", MySqlDbType.VarChar, 10).Value = maKhoa;
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        lvSinhVien.Items.Clear();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["MaSV"].ToString());
                            item.SubItems.Add(reader["HoTen"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"));
                            item.SubItems.Add(Convert.ToDecimal(reader["DiemTB"]).ToString("0.00"));
                            lvSinhVien.Items.Add(item);
                        }
                    }
                }
                lblKetQua.Text = "Khoa " + cboKhoa.Text + ": " + lvSinhVien.Items.Count + " sinh viên (gọi thủ tục sp_SinhVien_TheoKhoa).";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void btnDiemMax_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedValue == null) return;
            try
            {
                object ketQua = SqlHelper.ExecuteScalar("SELECT MAX(DiemTB) FROM SinhVien WHERE MaKhoa = @MaKhoa",
                    SqlHelper.ThamSo("@MaKhoa", MySqlDbType.VarChar, cboKhoa.SelectedValue.ToString()));
                if (ketQua == null || ketQua == DBNull.Value)
                    lblDiemMax.Text = "Khoa " + cboKhoa.Text + " chưa có sinh viên nên chưa có điểm cao nhất.";
                else
                    lblDiemMax.Text = "Điểm cao nhất của khoa " + cboKhoa.Text + ": " + Convert.ToDecimal(ketQua).ToString("0.00");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }
    }
}
