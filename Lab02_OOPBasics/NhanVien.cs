using System;

namespace Lab02_OOPBasics
{
    internal class NhanVien
    {
        private string _hoTen;
        private decimal _luongCoBan;
        private double _heSo;
        private decimal _phuCap;

        public string MaNV { get; set; }

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

        public decimal LuongCoBan
        {
            get { return _luongCoBan; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Lương cơ bản phải lớn hơn 0.");
                _luongCoBan = value;
            }
        }

        public double HeSo
        {
            get { return _heSo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Hệ số phải lớn hơn 0.");
                _heSo = value;
            }
        }

        public decimal PhuCap
        {
            get { return _phuCap; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Phụ cấp không được âm.");
                _phuCap = value;
            }
        }

        public NhanVien(string maNV, string hoTen, decimal luongCoBan, double heSo, decimal phuCap)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
            HeSo = heSo;
            PhuCap = phuCap;
        }

        public decimal TinhLuong()
        {
            return LuongCoBan * (decimal)HeSo + PhuCap;
        }

        public void HienThi()
        {
            Console.WriteLine("{0,-6} {1,-18} {2,12:N0} {3,6:N2} {4,12:N0} {5,14:N0}", MaNV, HoTen, LuongCoBan, HeSo, PhuCap, TinhLuong());
        }
    }
}
