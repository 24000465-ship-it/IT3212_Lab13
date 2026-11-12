using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Lab11_CRUD_StoredProcedure.DAL;
using Lab11_CRUD_StoredProcedure.DTO;

namespace Lab11_CRUD_StoredProcedure.BUS
{
    public class SinhVienBUS
    {
        private SinhVienDAL _dal = new SinhVienDAL();

        public List<SinhVienDTO> TimKiem(string tuKhoa, string maKhoa, bool hienDaXoa)
        {
            return _dal.TimKiem((tuKhoa ?? "").Trim(), maKhoa ?? "", hienDaXoa);
        }

        public void Add(SinhVienDTO dto)
        {
            KiemTra(dto);
            _dal.Insert(dto);
        }

        public void Update(SinhVienDTO dto)
        {
            KiemTra(dto);
            _dal.Update(dto);
        }

        public void Delete(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new ArgumentException("Chưa chọn sinh viên cần xóa.");
            _dal.Delete(maSV);
        }

        public void KhoiPhuc(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new ArgumentException("Chưa chọn sinh viên cần khôi phục.");
            _dal.KhoiPhuc(maSV);
        }

        private void KiemTra(SinhVienDTO dto)
        {
            dto.MaSV = (dto.MaSV ?? "").Trim().ToUpper();
            dto.HoTen = (dto.HoTen ?? "").Trim();
            dto.Email = (dto.Email ?? "").Trim();

            if (dto.MaSV == "")
                throw new ArgumentException("Mã sinh viên không được rỗng.");
            if (dto.MaSV.Length > 15 || dto.MaSV.Contains(" "))
                throw new ArgumentException("Mã sinh viên tối đa 15 ký tự và không có khoảng trắng.");
            if (dto.HoTen == "")
                throw new ArgumentException("Họ tên không được rỗng.");
            if (dto.HoTen.Length > 100)
                throw new ArgumentException("Họ tên tối đa 100 ký tự.");
            if (dto.NgaySinh > DateTime.Today.AddYears(-15))
                throw new ArgumentException("Tuổi sinh viên chưa hợp lệ (phải từ 15 tuổi trở lên).");
            if (dto.NgaySinh < DateTime.Today.AddYears(-60))
                throw new ArgumentException("Ngày sinh không hợp lệ (quá 60 tuổi).");
            if (dto.DiemTB < 0 || dto.DiemTB > 10)
                throw new ArgumentException("Điểm phải thuộc [0,10].");
            if (string.IsNullOrWhiteSpace(dto.MaKhoa))
                throw new ArgumentException("Chưa chọn khoa.");

            if (dto.Email != "")
            {
                if (dto.Email.Length > 100 || !Regex.IsMatch(dto.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new ArgumentException("Email không đúng định dạng, ví dụ: ten@gmail.com");
                if (_dal.EmailDaTonTai(dto.Email, dto.MaSV))
                    throw new LoiNghiepVuException("Email " + dto.Email + " đã được sinh viên khác sử dụng.");
            }
        }
    }
}
