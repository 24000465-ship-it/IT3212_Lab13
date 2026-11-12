using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Lab10_DisconnectedData
{
    public partial class frmBangDiem : Form
    {
        private DataTable bangDiem;

        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            TaoBangDiem();
            dgvBangDiem.DataSource = bangDiem;
            GiaoDien.DatTieuDe(dgvBangDiem);
            dgvBangDiem.Columns["XepLoai"].DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            lblBieuThuc.Text = "Cột Xếp loại là cột tính, biểu thức: " + bangDiem.Columns["XepLoai"].Expression;
            CapNhatTongKet();
        }

        private void TaoBangDiem()
        {
            bangDiem = new DataTable("BangDiem");

            DataColumn cotMa = new DataColumn("MaSV", typeof(string));
            cotMa.AllowDBNull = false;
            cotMa.MaxLength = 15;
            bangDiem.Columns.Add(cotMa);

            DataColumn cotTen = new DataColumn("HoTen", typeof(string));
            cotTen.AllowDBNull = false;
            bangDiem.Columns.Add(cotTen);

            DataColumn cotDiem = new DataColumn("Diem", typeof(decimal));
            cotDiem.AllowDBNull = false;
            bangDiem.Columns.Add(cotDiem);

            DataColumn cotXepLoai = new DataColumn("XepLoai", typeof(string));
            cotXepLoai.Expression = "IIF(Diem >= 8.5, 'Giỏi', IIF(Diem >= 7, 'Khá', IIF(Diem >= 5, 'Trung bình', 'Yếu')))";
            bangDiem.Columns.Add(cotXepLoai);

            bangDiem.PrimaryKey = new DataColumn[] { cotMa };

            bangDiem.Rows.Add("SV001", "Nguyễn Văn An", 8.7m);
            bangDiem.Rows.Add("SV002", "Trần Thị Bình", 7.2m);
            bangDiem.Rows.Add("SV003", "Lê Hoàng Cường", 5.5m);
            bangDiem.Rows.Add("SV004", "Phạm Thu Dung", 4.0m);
        }

        private void CapNhatTongKet()
        {
            if (bangDiem.Rows.Count == 0)
            {
                lblTongKet.Text = "Bảng điểm đang trống.";
                return;
            }
            object diemTB = bangDiem.Compute("AVG(Diem)", "");
            lblTongKet.Text = string.Format("Tổng {0} sinh viên | Giỏi {1} | Khá {2} | Trung bình {3} | Yếu {4} | Điểm trung bình lớp {5:0.00}",
                bangDiem.Rows.Count,
                bangDiem.Select("XepLoai = 'Giỏi'").Length,
                bangDiem.Select("XepLoai = 'Khá'").Length,
                bangDiem.Select("XepLoai = 'Trung bình'").Length,
                bangDiem.Select("XepLoai = 'Yếu'").Length,
                Convert.ToDecimal(diemTB));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            decimal diem;

            if (ma == "" || hoTen == "")
            {
                MessageBox.Show("Nhập đủ mã sinh viên và họ tên.", "Thiếu dữ liệu");
                return;
            }
            if (!decimal.TryParse(txtDiem.Text.Trim().Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out diem)
                || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10.", "Sai dữ liệu");
                txtDiem.Focus();
                return;
            }

            try
            {
                DataRow row = bangDiem.NewRow();
                row["MaSV"] = ma;
                row["HoTen"] = hoTen;
                row["Diem"] = diem;
                bangDiem.Rows.Add(row);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Mã sinh viên " + ma + " đã có trong bảng điểm.", "Trùng mã");
                return;
            }

            txtMa.Clear();
            txtHoTen.Clear();
            txtDiem.Clear();
            txtMa.Focus();
            CapNhatTongKet();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBangDiem.CurrentRow == null) return;
            DataRowView dongChon = dgvBangDiem.CurrentRow.DataBoundItem as DataRowView;
            if (dongChon == null) return;
            dongChon.Row.Delete();
            CapNhatTongKet();
        }

        private void dgvBangDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CapNhatTongKet();
        }

        private void dgvBangDiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Giá trị không hợp lệ: " + e.Exception.Message, "Sai dữ liệu");
            e.ThrowException = false;
        }
    }
}
