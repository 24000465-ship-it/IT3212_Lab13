using System;

namespace Lab03_OOPAdvanced
{
    internal class NhanVienVanPhong : NhanVien
    {
        public double HeSo { get; private set; }
        public decimal PhuCap { get; private set; }

        public NhanVienVanPhong(string maNV, string hoTen, decimal luongCoBan, double heSo, decimal phuCap)
            : base(maNV, hoTen, luongCoBan)
        {
            if (heSo <= 0) throw new ArgumentException("Hệ số phải lớn hơn 0.");
            if (phuCap < 0) throw new ArgumentException("Phụ cấp không được âm.");
            HeSo = heSo;
            PhuCap = phuCap;
        }

        public override string ChucVu
        {
            get { return "Văn phòng"; }
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan * (decimal)HeSo + PhuCap;
        }

        public override string CongThuc()
        {
            return string.Format("LCB x {0} + {1:N0}", HeSo, PhuCap);
        }
    }
}
