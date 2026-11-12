using System.Windows.Forms;

namespace Lab10_DisconnectedData
{
    public static class GiaoDien
    {
        public static void DatTieuDe(DataGridView dgv)
        {
            foreach (DataGridViewColumn cot in dgv.Columns)
            {
                switch (cot.DataPropertyName)
                {
                    case "MaSV": cot.HeaderText = "Mã SV"; break;
                    case "HoTen": cot.HeaderText = "Họ tên"; break;
                    case "NgaySinh":
                        cot.HeaderText = "Ngày sinh";
                        cot.DefaultCellStyle.Format = "dd/MM/yyyy";
                        break;
                    case "GioiTinh": cot.HeaderText = "Giới tính (1: Nam)"; break;
                    case "MaKhoa": cot.HeaderText = "Mã khoa"; break;
                    case "TenKhoa": cot.HeaderText = "Tên khoa"; break;
                    case "DiemTB":
                        cot.HeaderText = "Điểm TB";
                        cot.DefaultCellStyle.Format = "0.00";
                        break;
                    case "Diem":
                        cot.HeaderText = "Điểm";
                        cot.DefaultCellStyle.Format = "0.00";
                        break;
                    case "XepLoai": cot.HeaderText = "Xếp loại"; break;
                    case "TrangThai": cot.HeaderText = "Trạng thái"; break;
                    case "ChiTiet": cot.HeaderText = "Chi tiết thay đổi"; break;
                }
            }
        }
    }
}
