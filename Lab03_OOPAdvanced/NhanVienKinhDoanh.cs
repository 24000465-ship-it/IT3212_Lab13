using System;

namespace Lab03_OOPAdvanced
{
    internal class NhanVienKinhDoanh : NhanVien
    {
        public decimal DoanhSo { get; private set; }
        public double TiLeHoaHong { get; private set; }

        public NhanVienKinhDoanh(string maNV, string hoTen, decimal luongCoBan, decimal doanhSo, double tiLeHoaHong)
            : base(maNV, hoTen, luongCoBan)
        {
            if (doanhSo < 0) throw new ArgumentException("Doanh số không được âm.");
            if (tiLeHoaHong < 0 || tiLeHoaHong > 1) throw new ArgumentException("Tỉ lệ hoa hồng phải từ 0 đến 1.");
            DoanhSo = doanhSo;
            TiLeHoaHong = tiLeHoaHong;
        }

        public override string ChucVu
        {
            get { return "Kinh doanh"; }
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan + DoanhSo * (decimal)TiLeHoaHong;
        }

        public override string CongThuc()
        {
            return string.Format("LCB + {0:N0} x {1:P0}", DoanhSo, TiLeHoaHong);
        }
    }
}
