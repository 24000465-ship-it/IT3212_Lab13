using System;

namespace Lab03_OOPAdvanced
{
    internal class GiangVien : NhanVien
    {
        public double HeSo { get; private set; }
        public int SoTietDay { get; private set; }
        public decimal DonGiaTiet { get; private set; }

        public GiangVien(string maNV, string hoTen, decimal luongCoBan, double heSo, int soTietDay, decimal donGiaTiet)
            : base(maNV, hoTen, luongCoBan)
        {
            if (heSo <= 0) throw new ArgumentException("Hệ số phải lớn hơn 0.");
            if (soTietDay < 0) throw new ArgumentException("Số tiết dạy không được âm.");
            if (donGiaTiet <= 0) throw new ArgumentException("Đơn giá tiết phải lớn hơn 0.");
            HeSo = heSo;
            SoTietDay = soTietDay;
            DonGiaTiet = donGiaTiet;
        }

        public override string ChucVu
        {
            get { return "Giảng viên"; }
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan * (decimal)HeSo + SoTietDay * DonGiaTiet;
        }

        public override string CongThuc()
        {
            return string.Format("LCB x {0} + {1} tiết x {2:N0}", HeSo, SoTietDay, DonGiaTiet);
        }
    }
}
