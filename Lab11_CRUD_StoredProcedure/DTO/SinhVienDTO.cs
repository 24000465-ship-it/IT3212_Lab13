using System;

namespace Lab11_CRUD_StoredProcedure.DTO
{
    public class SinhVienDTO
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public decimal DiemTB { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public string GioiTinhText
        {
            get { return GioiTinh ? "Nam" : "Nữ"; }
        }

        public string TrangThai
        {
            get { return IsActive ? "Đang học" : "Đã xóa"; }
        }
    }
}
