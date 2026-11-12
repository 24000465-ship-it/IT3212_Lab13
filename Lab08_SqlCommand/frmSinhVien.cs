using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab08_SqlCommand
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Today;
            dtpNgaySinh.Value = new DateTime(2005, 1, 1);
            try
            {
                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.ValueMember = "MaKhoa";
                cboKhoa.DataSource = SqlHelper.ExecuteDataTable("SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa");
                NapDanhSach();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi");
            }
        }

        private void NapDanhSach()
        {
            dgvSinhVien.DataSource = SqlHelper.ExecuteDataTable(
                "SELECT s.MaSV AS 'Mã SV', s.HoTen AS 'Họ tên', s.NgaySinh AS 'Ngày sinh', " +
                "IF(s.GioiTinh = 1, 'Nam', 'Nữ') AS 'Giới tính', k.TenKhoa AS 'Khoa', s.DiemTB AS 'Điểm TB', s.Email " +
                "FROM SinhVien s JOIN Khoa k ON k.MaKhoa = s.MaKhoa ORDER BY s.MaSV");
            dgvSinhVien.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            lblSoLuong.Text = "Số sinh viên hiện tại: " + dgvSinhVien.Rows.Count;
        }

        private bool DocDiem(out decimal diem)
        {
            string s = txtDiemTB.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out diem))
                return false;
            return diem >= 0 && diem <= 10;
        }

        private bool KiemTraNhap()
        {
            decimal diem;
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã sinh viên.", "Thiếu dữ liệu");
                txtMaSV.Focus();
                return false;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập họ tên.", "Thiếu dữ liệu");
                txtHoTen.Focus();
                return false;
            }
            if (!DocDiem(out diem))
            {
                MessageBox.Show("Điểm TB phải là số từ 0 đến 10.", "Sai dữ liệu");
                txtDiemTB.Focus();
                return false;
            }
            return true;
        }

        private void BaoLoiMySql(MySqlException ex)
        {
            string loi;
            if (ex.Number == 1062)
                loi = "Mã sinh viên hoặc email đã tồn tại.";
            else if (ex.Number == 3819)
                loi = "Dữ liệu vi phạm ràng buộc CHECK (điểm phải từ 0 đến 10).";
            else if (ex.Number == 1452 || ex.Number == 1216)
                loi = "Mã khoa không tồn tại.";
            else
                loi = ex.Message;
            MessageBox.Show(loi + "\n(Mã lỗi MySQL: " + ex.Number + ")", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;
            decimal diem;
            DocDiem(out diem);
            string sql = @"INSERT INTO SinhVien
                (MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email)
                VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @MaKhoa, @DiemTB, @Email)";
            try
            {
                using (MySqlConnection conn = DbConnectionFactory.Create())
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSV", MySqlDbType.VarChar, 15).Value = txtMaSV.Text.Trim();
                    cmd.Parameters.Add("@HoTen", MySqlDbType.VarChar, 100).Value = txtHoTen.Text.Trim();
                    cmd.Parameters.Add("@NgaySinh", MySqlDbType.Date).Value = dtpNgaySinh.Value.Date;
                    cmd.Parameters.Add("@GioiTinh", MySqlDbType.Bit).Value = radNam.Checked;
                    cmd.Parameters.Add("@MaKhoa", MySqlDbType.VarChar, 10).Value = cboKhoa.SelectedValue;
                    cmd.Parameters.Add("@DiemTB", MySqlDbType.Decimal).Value = diem;
                    cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value =
                        string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim();
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm " + rows + " bản ghi.", "Thêm sinh viên");
                }
                NapDanhSach();
            }
            catch (MySqlException ex)
            {
                BaoLoiMySql(ex);
            }
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            decimal diem;
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã sinh viên.", "Thiếu dữ liệu");
                return;
            }
            if (!DocDiem(out diem))
            {
                MessageBox.Show("Điểm TB phải là số từ 0 đến 10.", "Sai dữ liệu");
                return;
            }
            string sql = "UPDATE SinhVien SET DiemTB = @DiemTB WHERE MaSV = @MaSV";
            try
            {
                using (MySqlConnection conn = DbConnectionFactory.Create())
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    MySqlParameter pDiem = cmd.Parameters.Add("@DiemTB", MySqlDbType.Decimal);
                    pDiem.Precision = 4;
                    pDiem.Scale = 2;
                    pDiem.Value = diem;
                    cmd.Parameters.Add("@MaSV", MySqlDbType.VarChar, 15).Value = txtMaSV.Text.Trim();
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows == 1 ? "Cập nhật thành công." : "Không tìm thấy mã " + txtMaSV.Text.Trim() + ".", "Cập nhật điểm");
                }
                NapDanhSach();
            }
            catch (MySqlException ex)
            {
                BaoLoiMySql(ex);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            if (ma == "")
            {
                MessageBox.Show("Nhập mã sinh viên cần tìm.", "Thiếu dữ liệu");
                return;
            }
            string sql = "SELECT s.MaSV, s.HoTen, s.NgaySinh, s.GioiTinh, s.MaKhoa, k.TenKhoa, s.DiemTB, s.Email " +
                         "FROM SinhVien s JOIN Khoa k ON k.MaKhoa = s.MaKhoa WHERE s.MaSV = @MaSV";
            try
            {
                using (MySqlDataReader reader = SqlHelper.ExecuteReader(sql,
                    SqlHelper.ThamSo("@MaSV", MySqlDbType.VarChar, ma)))
                {
                    if (!reader.Read())
                    {
                        lblChiTiet.Text = "Không tìm thấy sinh viên có mã " + ma + ".";
                        MessageBox.Show("Không tìm thấy sinh viên có mã " + ma + ".", "Tìm kiếm");
                        return;
                    }
                    DateTime ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                    bool nam = Convert.ToBoolean(reader["GioiTinh"]);
                    string email = reader["Email"] == DBNull.Value ? "(chưa có)" : reader["Email"].ToString();
                    lblChiTiet.Text = "Mã SV: " + reader["MaSV"] + "\n"
                        + "Họ tên: " + reader["HoTen"] + "\n"
                        + "Ngày sinh: " + ngaySinh.ToString("dd/MM/yyyy") + "\n"
                        + "Giới tính: " + (nam ? "Nam" : "Nữ") + "\n"
                        + "Khoa: " + reader["TenKhoa"] + "\n"
                        + "Điểm TB: " + Convert.ToDecimal(reader["DiemTB"]).ToString("0.00") + "\n"
                        + "Email: " + email;
                    txtHoTen.Text = reader["HoTen"].ToString();
                    dtpNgaySinh.Value = ngaySinh;
                    radNam.Checked = nam;
                    radNu.Checked = !nam;
                    cboKhoa.SelectedValue = reader["MaKhoa"].ToString();
                    txtDiemTB.Text = Convert.ToDecimal(reader["DiemTB"]).ToString("0.00");
                    txtEmail.Text = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                BaoLoiMySql(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            if (ma == "")
            {
                MessageBox.Show("Nhập mã sinh viên cần xóa.", "Thiếu dữ liệu");
                return;
            }
            DialogResult traLoi = MessageBox.Show("Xóa sinh viên có mã " + ma + "?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi != DialogResult.Yes) return;
            try
            {
                int rows = SqlHelper.ExecuteNonQuery("DELETE FROM SinhVien WHERE MaSV = @MaSV",
                    SqlHelper.ThamSo("@MaSV", MySqlDbType.VarChar, ma));
                MessageBox.Show(rows == 1 ? "Đã xóa sinh viên " + ma + "." : "Không tìm thấy mã " + ma + ".", "Xóa sinh viên");
                NapDanhSach();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451 || ex.Number == 1217)
                    MessageBox.Show("Không xóa được: sinh viên " + ma + " đang có dữ liệu đăng ký học phần (khóa ngoại FK_DangKy_SinhVien).",
                        "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    BaoLoiMySql(ex);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;
            decimal diem;
            DocDiem(out diem);
            try
            {
                using (MySqlConnection conn = DbConnectionFactory.Create())
                using (MySqlCommand cmd = new MySqlCommand("sp_SinhVien_Them", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_MaSV", MySqlDbType.VarChar, 15).Value = txtMaSV.Text.Trim();
                    cmd.Parameters.Add("p_HoTen", MySqlDbType.VarChar, 100).Value = txtHoTen.Text.Trim();
                    cmd.Parameters.Add("p_NgaySinh", MySqlDbType.Date).Value = dtpNgaySinh.Value.Date;
                    cmd.Parameters.Add("p_GioiTinh", MySqlDbType.Bit).Value = radNam.Checked;
                    cmd.Parameters.Add("p_MaKhoa", MySqlDbType.VarChar, 10).Value = cboKhoa.SelectedValue;
                    cmd.Parameters.Add("p_DiemTB", MySqlDbType.Decimal).Value = diem;
                    cmd.Parameters.Add("p_Email", MySqlDbType.VarChar, 100).Value =
                        string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim();
                    MySqlParameter pSoLuong = cmd.Parameters.Add("p_SoLuong", MySqlDbType.Int32);
                    pSoLuong.Direction = ParameterDirection.Output;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int soLuong = Convert.ToInt32(pSoLuong.Value);
                    MessageBox.Show("Đã thêm bằng thủ tục sp_SinhVien_Them.\nSố sinh viên hiện tại (OUTPUT): " + soLuong,
                        "Thêm bằng thủ tục");
                }
                NapDanhSach();
            }
            catch (MySqlException ex)
            {
                BaoLoiMySql(ex);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            txtEmail.Clear();
            dtpNgaySinh.Value = new DateTime(2005, 1, 1);
            radNam.Checked = true;
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            lblChiTiet.Text = "Nhập mã sinh viên rồi bấm \"Tìm theo mã\" để xem chi tiết.";
            txtMaSV.Focus();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaSV.Text = dgvSinhVien.Rows[e.RowIndex].Cells["Mã SV"].Value.ToString();
        }
    }
}
