using System;

namespace Lab02_OOPBasics
{
    internal class SanPham
    {
        private string _maSP;
        private string _tenSP;
        private decimal _donGia;
        private int _soLuong;

        public string MaSP
        {
            get { return _maSP; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Mã sản phẩm không được rỗng.");
                _maSP = value.Trim();
            }
        }

        public string TenSP
        {
            get { return _tenSP; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên sản phẩm không được rỗng.");
                _tenSP = value.Trim();
            }
        }

        public decimal DonGia
        {
            get { return _donGia; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Đơn giá phải lớn hơn 0.");
                _donGia = value;
            }
        }

        public int SoLuong
        {
            get { return _soLuong; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Số lượng không được âm.");
                _soLuong = value;
            }
        }

        public SanPham(string maSP, string tenSP, decimal donGia, int soLuong)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public decimal ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public void HienThi()
        {
            Console.WriteLine("{0,-6} {1,-22} {2,12:N0} {3,6} {4,14:N0}", MaSP, TenSP, DonGia, SoLuong, ThanhTien());
        }
    }
}
