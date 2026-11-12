using System;
using System.Collections.Generic;
using Lab06_ThreeLayerMemory.DAL;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.BUS
{
    public class SinhVienBUS
    {
        private SinhVienDAL _dal = new SinhVienDAL();
        private KhoaDAL _khoaDal = new KhoaDAL();

        public List<SinhVien> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Khoa> GetDanhSachKhoa()
        {
            return _khoaDal.GetAll();
        }

        public string DuongDanFile()
        {
            return SinhVienDAL.DuongDanFile;
        }

        public void Add(SinhVien sv)
        {
            KiemTra(sv);
            if (_dal.GetByMa(sv.MaSV) != null)
                throw new InvalidOperationException("Mã sinh viên " + sv.MaSV + " đã tồn tại.");
            _dal.Add(sv);
        }

        public void Update(SinhVien sv)
        {
            KiemTra(sv);
            if (_dal.GetByMa(sv.MaSV) == null)
                throw new InvalidOperationException("Không tìm thấy sinh viên có mã " + sv.MaSV + ".");
            _dal.Update(sv);
        }

        public void Delete(string maSV)
        {
            if (_dal.GetByMa(maSV) == null)
                throw new InvalidOperationException("Không tìm thấy sinh viên có mã " + maSV + ".");
            _dal.Delete(maSV);
        }

        private void KiemTra(SinhVien sv)
        {
            if (string.IsNullOrWhiteSpace(sv.MaSV))
                throw new ArgumentException("Thiếu mã sinh viên.");
            if (string.IsNullOrWhiteSpace(sv.Khoa))
                throw new ArgumentException("Chưa chọn khoa.");
            if (sv.NgaySinh > DateTime.Today)
                throw new ArgumentException("Ngày sinh không được lớn hơn ngày hiện tại.");
        }

        public List<SinhVien> TimKiem(string tuKhoa)
        {
            List<SinhVien> ds = _dal.GetAll();
            List<SinhVien> ketQua = new List<SinhVien>();
            string k = tuKhoa.Trim().ToLower();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaSV.ToLower().Contains(k) || ds[i].HoTen.ToLower().Contains(k))
                    ketQua.Add(ds[i]);
            }
            return ketQua;
        }

        public List<SinhVien> LocTheoKhoa(string tenKhoa)
        {
            List<SinhVien> ds = _dal.GetAll();
            List<SinhVien> ketQua = new List<SinhVien>();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].Khoa == tenKhoa)
                    ketQua.Add(ds[i]);
            }
            return ketQua;
        }

        public Dictionary<string, List<SinhVien>> NhomTheoKhoa()
        {
            Dictionary<string, List<SinhVien>> nhom = new Dictionary<string, List<SinhVien>>();
            List<Khoa> dsKhoa = _khoaDal.GetAll();
            for (int i = 0; i < dsKhoa.Count; i++)
            {
                nhom.Add(dsKhoa[i].TenKhoa, new List<SinhVien>());
            }
            List<SinhVien> ds = _dal.GetAll();
            for (int i = 0; i < ds.Count; i++)
            {
                if (!nhom.ContainsKey(ds[i].Khoa))
                    nhom.Add(ds[i].Khoa, new List<SinhVien>());
                nhom[ds[i].Khoa].Add(ds[i]);
            }
            return nhom;
        }

        public int ViTriBieuTuong(SinhVien sv)
        {
            string xl = sv.XepLoai();
            if (xl == "Xuất sắc") return 0;
            if (xl == "Giỏi") return 1;
            if (xl == "Khá") return 2;
            if (xl == "Trung bình") return 3;
            return 4;
        }
    }
}
