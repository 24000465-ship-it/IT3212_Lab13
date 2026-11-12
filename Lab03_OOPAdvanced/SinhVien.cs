
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab03_OOPAdvanced
{
    internal class SinhVien : Nguoi, IValidatable, IPrintable
    {
        public string MaSV { get; set; }
        
        private double _diemTB;
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





        public SinhVien()
            :base("Chưa có", DateTime.Today)
        {
            MaSV = "Chưa có";
            DiemTB = 0;
        }
        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB)
            :base(hoTen, ngaySinh)
        {
            MaSV = maSV;
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
        public override string MoTa()
        {
            return base.MoTa() + " - " + MaSV + " - " + DiemTB.ToString("N2");
        }

        public bool IsValid(out string message)
        {
            if (string.IsNullOrWhiteSpace(MaSV) || MaSV == "Chưa có")
            {
                message = "Thiếu mã sinh viên";
                return false;
            }
            if (HoTen == "Chưa có")
            {
                message = "Thiếu họ tên";
                return false;
            }
            if (NgaySinh.Date >= DateTime.Today)
            {
                message = "Ngày sinh không hợp lệ";
                return false;
            }
            message = "";
            return true;
        }

        public string ToDisplayText()
        {
            return MaSV + " - " + HoTen + " - Điểm: " + DiemTB.ToString("N2") + " (" + XepLoai() + ")";
        }
    }
}
