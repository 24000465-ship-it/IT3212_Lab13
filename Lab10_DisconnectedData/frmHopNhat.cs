using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab10_DisconnectedData
{
    public partial class frmHopNhat : Form
    {
        private DataTable nguon1;
        private DataTable nguon2;

        public frmHopNhat()
        {
            InitializeComponent();
        }

        private void btnTaoNguon_Click(object sender, EventArgs e)
        {
            try
            {
                nguon1 = new DataTable("SinhVien");
                using (MySqlConnection conn = DbConnectionFactory.Create())
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT MaSV, HoTen, MaKhoa, DiemTB FROM SinhVien WHERE MaKhoa = 'CNTT' ORDER BY MaSV LIMIT 6", conn))
                {
                    adapter.Fill(nguon1);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                return;
            }

            nguon2 = nguon1.Clone();
            nguon2.Rows.Add(nguon1.Rows[0]["MaSV"], nguon1.Rows[0]["HoTen"], "CNTT", 9.10m);
            nguon2.Rows.Add(nguon1.Rows[1]["MaSV"], nguon1.Rows[1]["HoTen"], "CNTT", 8.00m);
            nguon2.Rows.Add("SV101", "Trần Minh Khôi", "CNTT", 7.60m);
            nguon2.Rows.Add("SV102", "Lê Thu Hà", "CNTT", 8.40m);
            nguon2.AcceptChanges();

            dgvNguon1.DataSource = nguon1;
            dgvNguon2.DataSource = nguon2;
            GiaoDien.DatTieuDe(dgvNguon1);
            GiaoDien.DatTieuDe(dgvNguon2);
            dgvKetQua.DataSource = null;
            lblTongKet.Text = "Nguồn 1 có " + nguon1.Rows.Count + " dòng, nguồn 2 có " + nguon2.Rows.Count
                + " dòng. Có thể sửa thử điểm ở nguồn 1 trước khi hợp nhất để xem tác dụng của preserveChanges.";
        }

        private void btnHopNhat_Click(object sender, EventArgs e)
        {
            if (nguon1 == null)
            {
                MessageBox.Show("Hãy bấm \"Tạo hai nguồn dữ liệu\" trước.", "Hợp nhất");
                return;
            }
            dgvNguon1.EndEdit();
            dgvNguon2.EndEdit();

            DataTable ketQua = nguon1.Copy();
            DataTable bangHai = nguon2.Copy();
            if (chkKhoaChinh.Checked)
            {
                ketQua.PrimaryKey = new DataColumn[] { ketQua.Columns["MaSV"] };
                bangHai.PrimaryKey = new DataColumn[] { bangHai.Columns["MaSV"] };
            }

            List<string> maTrung = new List<string>();
            foreach (DataRow row in bangHai.Rows)
            {
                string ma = row["MaSV"].ToString();
                if (ketQua.Select("MaSV = '" + ma.Replace("'", "''") + "'").Length > 0)
                    maTrung.Add(ma);
            }

            try
            {
                ketQua.Merge(bangHai, chkGiuThayDoi.Checked);
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Không hợp nhất được: " + ex.Message, "Lỗi");
                return;
            }

            ketQua.DefaultView.Sort = "MaSV";
            dgvKetQua.DataSource = ketQua.DefaultView;
            GiaoDien.DatTieuDe(dgvKetQua);
            ToMauKetQua(maTrung);

            string cachXuLy;
            if (!chkKhoaChinh.Checked)
                cachXuLy = "Không có khóa chính nên Merge chỉ nối thêm dòng: các mã trùng bị lặp lại.";
            else if (chkGiuThayDoi.Checked)
                cachXuLy = "Có khóa chính, preserveChanges = true: dòng trùng khóa đã sửa ở nguồn 1 được giữ giá trị đang sửa.";
            else
                cachXuLy = "Có khóa chính: dòng trùng khóa được ghi đè bằng dữ liệu nguồn 2, mã mới được thêm vào.";

            lblTongKet.Text = "Nguồn 1: " + nguon1.Rows.Count + " dòng, nguồn 2: " + nguon2.Rows.Count + " dòng, trùng khóa: "
                + (maTrung.Count == 0 ? "không có" : string.Join(", ", maTrung)) + " -> kết quả " + ketQua.Rows.Count + " dòng.\n" + cachXuLy;
        }

        private void ToMauKetQua(List<string> maTrung)
        {
            foreach (DataGridViewRow dong in dgvKetQua.Rows)
            {
                string ma = Convert.ToString(dong.Cells["MaSV"].Value);
                if (maTrung.Contains(ma))
                    dong.DefaultCellStyle.BackColor = Color.MistyRose;
                else if (nguon2.Select("MaSV = '" + ma.Replace("'", "''") + "'").Length > 0)
                    dong.DefaultCellStyle.BackColor = Color.Honeydew;
            }
            dgvKetQua.ClearSelection();
        }
    }
}
