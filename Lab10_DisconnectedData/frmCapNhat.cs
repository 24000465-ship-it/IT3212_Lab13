using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab10_DisconnectedData
{
    public partial class frmCapNhat : Form
    {
        private MySqlDataAdapter adapter;
        private DataTable bang;

        public frmCapNhat()
        {
            InitializeComponent();
        }

        private void frmCapNhat_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                MySqlConnection conn = DbConnectionFactory.Create();
                adapter = new MySqlDataAdapter("SELECT * FROM SinhVien ORDER BY MaSV", conn);
                new MySqlCommandBuilder(adapter);

                bang = new DataTable("SinhVien");
                adapter.Fill(bang);
                bang.Columns["GioiTinh"].DefaultValue = (ulong)1;
                bang.Columns["DiemTB"].DefaultValue = 0m;

                dgvSinhVien.DataSource = bang;
                GiaoDien.DatTieuDe(dgvSinhVien);
                HienThayDoi();
                lblTrangThai.Text = "Đã nạp " + bang.Rows.Count + " sinh viên từ CSDL.";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void KetThucSua()
        {
            dgvSinhVien.EndEdit();
            BindingContext[bang].EndCurrentEdit();
        }

        private string GiaTri(DataRow row, string cot, DataRowVersion phienBan)
        {
            object v = row[cot, phienBan];
            if (v == DBNull.Value) return "(trống)";
            if (v is DateTime) return ((DateTime)v).ToString("dd/MM/yyyy");
            return v.ToString();
        }

        private void HienThayDoi()
        {
            DataTable ketQua = new DataTable();
            ketQua.Columns.Add("TrangThai");
            ketQua.Columns.Add("MaSV");
            ketQua.Columns.Add("HoTen");
            ketQua.Columns.Add("ChiTiet");

            int soThem = 0, soSua = 0, soXoa = 0;
            DataTable thayDoi = bang.GetChanges();
            if (thayDoi != null)
            {
                foreach (DataRow row in thayDoi.Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        soThem++;
                        ketQua.Rows.Add("Added", GiaTri(row, "MaSV", DataRowVersion.Current),
                            GiaTri(row, "HoTen", DataRowVersion.Current), "Dòng mới, sẽ chạy INSERT");
                    }
                    else if (row.RowState == DataRowState.Deleted)
                    {
                        soXoa++;
                        ketQua.Rows.Add("Deleted", GiaTri(row, "MaSV", DataRowVersion.Original),
                            GiaTri(row, "HoTen", DataRowVersion.Original), "Dòng bị xóa, sẽ chạy DELETE");
                    }
                    else if (row.RowState == DataRowState.Modified)
                    {
                        soSua++;
                        string chiTiet = "";
                        foreach (DataColumn cot in thayDoi.Columns)
                        {
                            string cu = GiaTri(row, cot.ColumnName, DataRowVersion.Original);
                            string moi = GiaTri(row, cot.ColumnName, DataRowVersion.Current);
                            if (cu != moi)
                                chiTiet += cot.ColumnName + ": " + cu + " -> " + moi + "; ";
                        }
                        ketQua.Rows.Add("Modified", GiaTri(row, "MaSV", DataRowVersion.Current),
                            GiaTri(row, "HoTen", DataRowVersion.Current), chiTiet);
                    }
                }
            }

            dgvThayDoi.DataSource = ketQua;
            GiaoDien.DatTieuDe(dgvThayDoi);
            dgvThayDoi.Columns["TrangThai"].FillWeight = 40;
            dgvThayDoi.Columns["MaSV"].FillWeight = 40;
            dgvThayDoi.Columns["HoTen"].FillWeight = 80;
            dgvThayDoi.Columns["ChiTiet"].FillWeight = 260;
            lblThayDoi.Text = string.Format("Các dòng đã thay đổi, chưa gửi về CSDL:   Added {0}   Modified {1}   Deleted {2}",
                soThem, soSua, soXoa);
        }

        private void btnXemThayDoi_Click(object sender, EventArgs e)
        {
            KetThucSua();
            HienThayDoi();
            lblTrangThai.Text = "GetChanges() trả về các dòng có RowState khác Unchanged.";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KetThucSua();
            if (bang.GetChanges() == null)
            {
                MessageBox.Show("Không có thay đổi nào để gửi về CSDL.", "Lưu");
                return;
            }
            try
            {
                int soDong = adapter.Update(bang);
                HienThayDoi();
                lblTrangThai.Text = "Update xong: " + soDong + " dòng đã ghi vào CSDL.";
                MessageBox.Show("Đã cập nhật " + soDong + " thay đổi.", "Lưu");
            }
            catch (MySqlException ex)
            {
                HienThayDoi();
                MessageBox.Show("Không lưu được: " + ex.Message, "Lỗi");
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Dữ liệu đã bị người khác thay đổi: " + ex.Message, "Lỗi");
            }
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            KetThucSua();
            bang.AcceptChanges();
            HienThayDoi();
            lblTrangThai.Text = "AcceptChanges: mọi dòng thành Unchanged. Bấm Lưu lúc này sẽ không gửi gì về CSDL.";
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            dgvSinhVien.CancelEdit();
            BindingContext[bang].CancelCurrentEdit();
            bang.RejectChanges();
            HienThayDoi();
            lblTrangThai.Text = "RejectChanges: đã trả các dòng về giá trị lúc nạp hoặc lúc AcceptChanges gần nhất.";
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void dgvSinhVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Giá trị không hợp lệ: " + e.Exception.Message, "Sai dữ liệu");
            e.ThrowException = false;
        }
    }
}
