using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_OOPBasics
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        private string _hoTen;
        private double _diemTB;
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
                    throw new ArgumentOutOfRangeException("DiemTB");
                _diemTB = value;
            }
        }
        public DateTime NgaySinh { get; set; }
        

        public SinhVien()
        {
            MaSV = "Chưa có";
            HoTen = "Chưa có";
            NgaySinh = DateTime.Today;
            DiemTB = 0;
        }
        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiemTB = diemTB;
        }

        public void HienThi() {
            Console.WriteLine("{0} - {1} - {2:dd/MM/yyyy} - {3:N2} ", MaSV ,HoTen, NgaySinh, DiemTB);
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
    }
}
