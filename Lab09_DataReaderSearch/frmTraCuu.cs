using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab09_DataReaderSearch
{
    public partial class frmTraCuu : Form
    {
        private const int SoDongMoiTrang = 10;
        private int trangHienTai = 1;
        private int tongSoTrang = 1;
        private DataTable bangHienTai;
        private BindingSource bsSinhVien = new BindingSource();

        private string[] tenCotSapXep = { "Mã SV", "Họ tên", "Ngày sinh", "Khoa", "Điểm TB" };
        private string[] cotSapXep = { "sv.MaSV", "sv.HoTen", "sv.NgaySinh", "k.TenKhoa", "sv.DiemTB" };

        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Add("Tất cả");
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.SelectedIndex = 0;
            for (int i = 0; i < tenCotSapXep.Length; i++)
            {
                cboSapXep.Items.Add(tenCotSapXep[i]);
            }
            cboSapXep.SelectedIndex = 0;
            cboChieu.Items.Add("Tăng dần");
            cboChieu.Items.Add("Giảm dần");
            cboChieu.SelectedIndex = 0;
            dgvSinhVien.DataSource = bsSinhVien;
            try
            {
                NapKhoa();
                TaiTrang();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi");
            }
        }

        private DataTable DocBang(MySqlCommand cmd)
        {
            DataTable bang = new DataTable();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                bang.Load(reader);
            }
            return bang;
        }

        private void NapKhoa()
        {
            DataTable bang;
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa", conn))
            {
                conn.Open();
                bang = DocBang(cmd);
            }
            DataRow tatCa = bang.NewRow();
            tatCa["MaKhoa"] = "";
            tatCa["TenKhoa"] = "Tất cả";
            bang.Rows.InsertAt(tatCa, 0);
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DataSource = bang;
        }

        private decimal DocSo(TextBox o, string tenO)
        {
            decimal so;
            string s = o.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out so))
                throw new ArgumentException(tenO + " phải là số.");
            return so;
        }

        private string TaoDieuKien(MySqlCommand cmd)
        {
            string dieuKien = " WHERE 1 = 1";

            if (txtTimMa.Text.Trim() != "")
            {
                dieuKien += " AND sv.MaSV LIKE @Ma";
                cmd.Parameters.Add("@Ma", MySqlDbType.VarChar, 17).Value = "%" + txtTimMa.Text.Trim() + "%";
            }
            if (txtTimTen.Text.Trim() != "")
            {
                dieuKien += " AND sv.HoTen LIKE @Keyword";
                cmd.Parameters.Add("@Keyword", MySqlDbType.VarChar, 102).Value = "%" + txtTimTen.Text.Trim() + "%";
            }
            string maKhoa = cboKhoa.SelectedValue == null ? "" : cboKhoa.SelectedValue.ToString();
            if (maKhoa != "")
            {
                dieuKien += " AND sv.MaKhoa = @MaKhoa";
                cmd.Parameters.Add("@MaKhoa", MySqlDbType.VarChar, 10).Value = maKhoa;
            }
            if (cboGioiTinh.SelectedIndex > 0)
            {
                dieuKien += " AND sv.GioiTinh = @GioiTinh";
                cmd.Parameters.Add("@GioiTinh", MySqlDbType.Bit).Value = cboGioiTinh.SelectedIndex == 1;
            }

            bool coDiemTu = txtDiemTu.Text.Trim() != "";
            bool coDiemDen = txtDiemDen.Text.Trim() != "";
            decimal diemTu = coDiemTu ? DocSo(txtDiemTu, "Điểm từ") : 0;
            decimal diemDen = coDiemDen ? DocSo(txtDiemDen, "Điểm đến") : 10;
            if (diemTu > diemDen)
                throw new ArgumentException("Điểm từ không được lớn hơn điểm đến.");
            if (coDiemTu || coDiemDen)
            {
                dieuKien += " AND sv.DiemTB BETWEEN @Min AND @Max";
                cmd.Parameters.Add("@Min", MySqlDbType.Decimal).Value = diemTu;
                cmd.Parameters.Add("@Max", MySqlDbType.Decimal).Value = diemDen;
            }

            if (txtTuoiTu.Text.Trim() != "")
            {
                int tuoiTu = (int)DocSo(txtTuoiTu, "Tuổi từ");
                dieuKien += " AND sv.NgaySinh <= @NgaySinhMax";
                cmd.Parameters.Add("@NgaySinhMax", MySqlDbType.Date).Value = DateTime.Today.AddYears(-tuoiTu);
            }
            if (txtTuoiDen.Text.Trim() != "")
            {
                int tuoiDen = (int)DocSo(txtTuoiDen, "Tuổi đến");
                dieuKien += " AND sv.NgaySinh >= @NgaySinhMin";
                cmd.Parameters.Add("@NgaySinhMin", MySqlDbType.Date).Value = DateTime.Today.AddYears(-(tuoiDen + 1)).AddDays(1);
            }
            return dieuKien;
        }

        private void TaiTrang()
        {
            string tuBang = " FROM SinhVien sv JOIN Khoa k ON sv.MaKhoa = k.MaKhoa";
            string cot = cotSapXep[cboSapXep.SelectedIndex];
            string chieu = cboChieu.SelectedIndex == 1 ? "DESC" : "ASC";
            try
            {
                using (MySqlConnection conn = DbConnectionFactory.Create())
                {
                    conn.Open();
                    int tongSo;
                    using (MySqlCommand cmdDem = new MySqlCommand())
                    {
                        cmdDem.Connection = conn;
                        cmdDem.CommandText = "SELECT COUNT(*)" + tuBang + TaoDieuKien(cmdDem);
                        tongSo = Convert.ToInt32(cmdDem.ExecuteScalar());
                    }
                    tongSoTrang = tongSo == 0 ? 1 : (tongSo + SoDongMoiTrang - 1) / SoDongMoiTrang;
                    if (trangHienTai > tongSoTrang) trangHienTai = tongSoTrang;
                    if (trangHienTai < 1) trangHienTai = 1;

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"SELECT sv.MaSV, sv.HoTen, sv.NgaySinh,
                            TIMESTAMPDIFF(YEAR, sv.NgaySinh, CURDATE()) AS Tuoi,
                            CASE sv.GioiTinh WHEN 1 THEN 'Nam' ELSE 'Nữ' END AS GioiTinh,
                            k.TenKhoa, sv.DiemTB, sv.Email" + tuBang + TaoDieuKien(cmd)
                            + " ORDER BY " + cot + " " + chieu + ", sv.MaSV"
                            + " LIMIT @PageSize OFFSET @Offset";
                        cmd.Parameters.Add("@PageSize", MySqlDbType.Int32).Value = SoDongMoiTrang;
                        cmd.Parameters.Add("@Offset", MySqlDbType.Int32).Value = (trangHienTai - 1) * SoDongMoiTrang;
                        bangHienTai = DocBang(cmd);
                    }
                    bsSinhVien.DataSource = bangHienTai;
                    DinhDangLuoi();
                    lblTrang.Text = "Trang " + trangHienTai + "/" + tongSoTrang;
                    btnTruoc.Enabled = trangHienTai > 1;
                    btnSau.Enabled = trangHienTai < tongSoTrang;
                    lblTongSo.Text = "Tìm thấy: " + tongSo + " sinh viên";
                    if (tongSo == 0)
                    {
                        XoaChiTiet();
                        lblTrangThai.Text = "Không có sinh viên nào phù hợp.";
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Sai dữ liệu lọc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void DinhDangLuoi()
        {
            string[] cot = { "MaSV", "HoTen", "NgaySinh", "Tuoi", "GioiTinh", "TenKhoa", "DiemTB", "Email" };
            string[] tieuDe = { "Mã SV", "Họ tên", "Ngày sinh", "Tuổi", "Giới tính", "Khoa", "Điểm TB", "Email" };
            int[] doRong = { 60, 140, 85, 45, 65, 150, 65, 140 };
            for (int i = 0; i < cot.Length; i++)
            {
                dgvSinhVien.Columns[cot[i]].HeaderText = tieuDe[i];
                dgvSinhVien.Columns[cot[i]].FillWeight = doRong[i];
                dgvSinhVien.Columns[cot[i]].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvSinhVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSinhVien.Columns["DiemTB"].DefaultCellStyle.Format = "0.00";
            dgvSinhVien.Columns["DiemTB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSinhVien.Columns["Tuoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new Font(dgvSinhVien.Font, FontStyle.Bold);

            for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
            {
                DataGridViewRow dong = dgvSinhVien.Rows[i];
                decimal diem = Convert.ToDecimal(dong.Cells["DiemTB"].Value);
                if (diem < 5)
                    dong.DefaultCellStyle.BackColor = Color.MistyRose;
                else if (diem >= 8)
                    dong.DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;
            DataGridViewRow row = dgvSinhVien.CurrentRow;
            txtMaSV.Text = Convert.ToString(row.Cells["MaSV"].Value);
            txtHoTen.Text = Convert.ToString(row.Cells["HoTen"].Value);
            txtNgaySinh.Text = Convert.ToDateTime(row.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");
            txtTuoi.Text = Convert.ToString(row.Cells["Tuoi"].Value);
            txtGioiTinh.Text = Convert.ToString(row.Cells["GioiTinh"].Value);
            txtKhoa.Text = Convert.ToString(row.Cells["TenKhoa"].Value);
            txtDiemTB.Text = Convert.ToDecimal(row.Cells["DiemTB"].Value).ToString("0.00");
            txtEmail.Text = row.Cells["Email"].Value == DBNull.Value ? "(chưa có)" : Convert.ToString(row.Cells["Email"].Value);
            lblTrangThai.Text = "Đang chọn: " + txtMaSV.Text;
        }

        private void XoaChiTiet()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtTuoi.Clear();
            txtGioiTinh.Clear();
            txtKhoa.Clear();
            txtDiemTB.Clear();
            txtEmail.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            trangHienTai = 1;
            TaiTrang();
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimMa.Clear();
            txtTimTen.Clear();
            txtDiemTu.Clear();
            txtDiemDen.Clear();
            txtTuoiTu.Clear();
            txtTuoiDen.Clear();
            cboKhoa.SelectedIndex = 0;
            cboGioiTinh.SelectedIndex = 0;
            cboSapXep.SelectedIndex = 0;
            cboChieu.SelectedIndex = 0;
            trangHienTai = 1;
            TaiTrang();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1)
            {
                trangHienTai--;
                TaiTrang();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (trangHienTai < tongSoTrang)
            {
                trangHienTai++;
                TaiTrang();
            }
        }

        private string ONhoCSV(string s)
        {
            if (s.Contains(",") || s.Contains("\"") || s.Contains("\n"))
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        private int XuatCSV(string duongDan)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mã SV,Họ tên,Ngày sinh,Tuổi,Giới tính,Khoa,Điểm TB,Email");
            for (int i = 0; i < bangHienTai.Rows.Count; i++)
            {
                DataRow r = bangHienTai.Rows[i];
                string email = r["Email"] == DBNull.Value ? "" : r["Email"].ToString();
                sb.AppendLine(ONhoCSV(r["MaSV"].ToString()) + ","
                    + ONhoCSV(r["HoTen"].ToString()) + ","
                    + Convert.ToDateTime(r["NgaySinh"]).ToString("dd/MM/yyyy") + ","
                    + r["Tuoi"] + ","
                    + r["GioiTinh"] + ","
                    + ONhoCSV(r["TenKhoa"].ToString()) + ","
                    + Convert.ToDecimal(r["DiemTB"]).ToString("0.00", CultureInfo.InvariantCulture) + ","
                    + ONhoCSV(email));
            }
            File.WriteAllText(duongDan, sb.ToString(), new UTF8Encoding(true));
            return bangHienTai.Rows.Count;
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (bangHienTai == null || bangHienTai.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Xuất CSV");
                return;
            }
            SaveFileDialog hopThoai = new SaveFileDialog();
            hopThoai.Filter = "Tệp CSV (*.csv)|*.csv";
            hopThoai.FileName = "KetQuaTimKiem.csv";
            if (hopThoai.ShowDialog() != DialogResult.OK) return;
            try
            {
                int soDong = XuatCSV(hopThoai.FileName);
                MessageBox.Show("Đã xuất " + soDong + " dòng ra tệp:\n" + hopThoai.FileName, "Xuất CSV");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Không ghi được tệp: " + ex.Message, "Lỗi");
            }
        }
    }
}
