using System;

namespace Lab03_OOPAdvanced
{
    internal class GiaoDich
    {
        public int SoThuTu { get; private set; }
        public DateTime ThoiGian { get; private set; }
        public string PhuongThuc { get; private set; }
        public decimal SoTien { get; private set; }
        public bool ThanhCong { get; private set; }
        public string GhiChu { get; private set; }

        public GiaoDich(int soThuTu, string phuongThuc, decimal soTien, bool thanhCong, string ghiChu)
        {
            SoThuTu = soThuTu;
            ThoiGian = DateTime.Now;
            PhuongThuc = phuongThuc;
            SoTien = soTien;
            ThanhCong = thanhCong;
            GhiChu = ghiChu;
        }

        public override string ToString()
        {
            return string.Format("#{0,-2} {1:HH:mm:ss} {2,-14} {3,12:N0} {4,-10} {5}",
                SoThuTu, ThoiGian, PhuongThuc, SoTien, ThanhCong ? "Thành công" : "Thất bại", GhiChu);
        }
    }
}
