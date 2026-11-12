using System;

namespace Lab03_OOPAdvanced
{
    internal class XeDap : IMove
    {
        public string Ten { get; private set; }
        public double TocDo { get; private set; }

        public XeDap(string ten, double tocDo)
        {
            if (tocDo <= 0) throw new ArgumentException("Tốc độ phải lớn hơn 0.");
            Ten = ten;
            TocDo = tocDo;
        }

        public double TinhThoiGian(double quangDuong)
        {
            return quangDuong / TocDo;
        }

        public decimal TinhChiPhi(double quangDuong)
        {
            return 0;
        }
    }
}
