using System;
using System.Collections.Generic;
using Lab11_CRUD_StoredProcedure.DAL;
using Lab11_CRUD_StoredProcedure.DTO;

namespace Lab11_CRUD_StoredProcedure.BUS
{
    public class KhoaBUS
    {
        private KhoaDAL _dal = new KhoaDAL();

        public List<KhoaDTO> DanhSach()
        {
            return _dal.DanhSach();
        }

        public void Add(KhoaDTO dto)
        {
            KiemTra(dto);
            _dal.Insert(dto);
        }

        public void Update(KhoaDTO dto)
        {
            KiemTra(dto);
            _dal.Update(dto);
        }

        public void Delete(KhoaDTO dto)
        {
            if (dto == null)
                throw new ArgumentException("Chưa chọn khoa cần xóa.");
            if (dto.SoSinhVien > 0)
                throw new LoiNghiepVuException("Không thể xóa khoa " + dto.TenKhoa + " vì đang có " + dto.SoSinhVien + " sinh viên.");
            _dal.Delete(dto.MaKhoa);
        }

        private void KiemTra(KhoaDTO dto)
        {
            dto.MaKhoa = (dto.MaKhoa ?? "").Trim().ToUpper();
            dto.TenKhoa = (dto.TenKhoa ?? "").Trim();

            if (dto.MaKhoa == "")
                throw new ArgumentException("Mã khoa không được rỗng.");
            if (dto.MaKhoa.Length > 10 || dto.MaKhoa.Contains(" "))
                throw new ArgumentException("Mã khoa tối đa 10 ký tự và không có khoảng trắng.");
            if (dto.TenKhoa == "")
                throw new ArgumentException("Tên khoa không được rỗng.");
            if (dto.TenKhoa.Length > 100)
                throw new ArgumentException("Tên khoa tối đa 100 ký tự.");
        }
    }
}
