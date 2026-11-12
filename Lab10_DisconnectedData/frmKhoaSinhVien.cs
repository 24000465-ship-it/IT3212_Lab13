using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab10_DisconnectedData
{
    public partial class frmKhoaSinhVien : Form
    {
        private DataSet ds;
        private DataView view;

        public frmKhoaSinhVien()
        {
            InitializeComponent();
        }

        private void frmKhoaSinhVien_Load(object sender, EventArgs e)
        {
            grpLoc.Enabled = false;
        }

        private DataTable LayBangSinhVien()
        {
            DataTable bang = new DataTable("SinhVien");
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM SinhVien ORDER BY MaSV", conn))
            {
                adapter.Fill(bang);
            }
            return bang;
        }

        private void btnFillTable_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable bang = LayBangSinhVien();
                dgvSinhVien.DataSource = bang;
                GiaoDien.DatTieuDe(dgvSinhVien);
                lblThongTin.Text = "Bài 1: Fill bảng \"" + bang.TableName + "\" được " + bang.Rows.Count
                    + " dòng, " + bang.Columns.Count + " cột. Adapter tự mở rồi tự đóng kết nối.";
                lblKetQua.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void NapDataSet()
        {
            ds = new DataSet("QLSinhVien");
            using (MySqlConnection conn = DbConnectionFactory.Create())
            {
                new MySqlDataAdapter("SELECT * FROM Khoa ORDER BY MaKhoa", conn).Fill(ds, "Khoa");
                new MySqlDataAdapter("SELECT * FROM SinhVien ORDER BY MaSV", conn).Fill(ds, "SinhVien");
            }

            DataRelation quanHe = new DataRelation("FK_Khoa_SinhVien",
                ds.Tables["Khoa"].Columns["MaKhoa"],
                ds.Tables["SinhVien"].Columns["MaKhoa"]);
            ds.Relations.Add(quanHe);

            view = new DataView(ds.Tables["SinhVien"]);
            view.Sort = "MaSV";
        }

        private void NapComboKhoa()
        {
            DataTable bang = ds.Tables["Khoa"].Copy();
            DataRow tatCa = bang.NewRow();
            tatCa["MaKhoa"] = "";
            tatCa["TenKhoa"] = "Tất cả";
            bang.Rows.InsertAt(tatCa, 0);
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DataSource = bang;
        }

        private void btnNapDataSet_Click(object sender, EventArgs e)
        {
            try
            {
                NapDataSet();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Không tạo được quan hệ: " + ex.Message, "Lỗi");
                return;
            }

            NapComboKhoa();
            dgvKhoa.DataSource = ds.Tables["Khoa"];
            dgvSinhVien.DataSource = view;
            GiaoDien.DatTieuDe(dgvKhoa);
            GiaoDien.DatTieuDe(dgvSinhVien);
            grpLoc.Enabled = true;

            lblThongTin.Text = "Bài 2: DataSet \"" + ds.DataSetName + "\" có " + ds.Tables.Count + " bảng: Khoa ("
                + ds.Tables["Khoa"].Rows.Count + " dòng), SinhVien (" + ds.Tables["SinhVien"].Rows.Count
                + " dòng). Quan hệ: " + ds.Relations[0].RelationName;
            lblKetQua.Text = "Đang hiển thị " + view.Count + " sinh viên";
            HienSinhVienCon();
        }

        private void HienSinhVienCon()
        {
            lstSinhVienCon.Items.Clear();
            lblSoCon.Text = "";
            if (ds == null || dgvKhoa.SelectedRows.Count == 0) return;

            DataRowView dongChon = dgvKhoa.SelectedRows[0].DataBoundItem as DataRowView;
            if (dongChon == null) return;

            DataRow khoa = dongChon.Row;
            DataRow[] sinhVien = khoa.GetChildRows("FK_Khoa_SinhVien");
            foreach (DataRow row in sinhVien)
            {
                lstSinhVienCon.Items.Add(row["MaSV"] + " - " + row["HoTen"] + " - Điểm "
                    + Convert.ToDecimal(row["DiemTB"]).ToString("0.00"));
            }
            lblSoCon.Text = khoa["TenKhoa"] + ": " + sinhVien.Length + " sinh viên";
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            HienSinhVienCon();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maKhoa = cboKhoa.SelectedValue.ToString().Replace("'", "''");
            string diem = numMinDiem.Value.ToString(CultureInfo.InvariantCulture);

            string dieuKien = "DiemTB >= " + diem;
            if (maKhoa != "")
                dieuKien = string.Format("MaKhoa = '{0}' AND DiemTB >= {1}", maKhoa, diem);

            view.RowFilter = dieuKien;
            view.Sort = "DiemTB DESC, HoTen ASC";
            dgvSinhVien.DataSource = view;
            lblKetQua.Text = "RowFilter: " + dieuKien + "   |   Tìm thấy " + view.Count + " sinh viên (không truy vấn lại CSDL)";
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            cboKhoa.SelectedIndex = 0;
            numMinDiem.Value = 0;
            view.RowFilter = "";
            view.Sort = "MaSV";
            lblKetQua.Text = "Đang hiển thị " + view.Count + " sinh viên";
        }
    }
}
