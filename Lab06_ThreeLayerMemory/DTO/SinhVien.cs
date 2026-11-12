using System;

namespace Lab06_ThreeLayerMemory.DTO
{
    public class SinhVien
    {
        private string _hoTen;
        private double _diemTB;

        public string MaSV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Khoa { get; set; }
        public string AnhDaiDien { get; set; }

        public string HoTen
        {
            get { return _hoTen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Họ tên không được rỗng.");
                _hoTen = value.Trim();
            }
        }

        public double DiemTB
        {
            get { return _diemTB; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Điểm TB phải từ 0 đến 10.");
                _diemTB = value;
            }
        }

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string khoa, double diemTB)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh.Date;
            GioiTinh = gioiTinh;
            Khoa = khoa;
            DiemTB = diemTB;
            AnhDaiDien = "";
        }

        public int TinhTuoi()
        {
            int tuoi = DateTime.Today.Year - NgaySinh.Year;
            if (NgaySinh.Date > DateTime.Today.AddYears(-tuoi)) tuoi--;
            return tuoi;
        }

        public string XepLoai()
        {
            if (DiemTB >= 9) return "Xuất sắc";
            if (DiemTB >= 8) return "Giỏi";
            if (DiemTB >= 6.5) return "Khá";
            if (DiemTB >= 5) return "Trung bình";
            return "Yếu";
        }

        public override string ToString()
        {
            return MaSV + " - " + HoTen + " - " + NgaySinh.ToString("dd/MM/yyyy") + " - " + GioiTinh
                + " - " + Khoa + " - Điểm: " + DiemTB.ToString("0.00") + " (" + XepLoai() + ")";
        }
    }
}
