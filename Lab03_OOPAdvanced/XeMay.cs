using System;

namespace Lab03_OOPAdvanced
{
    internal class XeMay : IMove
    {
        public string Ten { get; private set; }
        public double TocDo { get; private set; }
        public double MucTieuHao { get; private set; }
        public decimal GiaXang { get; private set; }

        public XeMay(string ten, double tocDo, double mucTieuHao, decimal giaXang)
        {
            if (tocDo <= 0) throw new ArgumentException("Tốc độ phải lớn hơn 0.");
            if (mucTieuHao <= 0) throw new ArgumentException("Mức tiêu hao phải lớn hơn 0.");
            Ten = ten;
            TocDo = tocDo;
            MucTieuHao = mucTieuHao;
            GiaXang = giaXang;
        }

        public double TinhThoiGian(double quangDuong)
        {
            return quangDuong / TocDo;
        }

        public decimal TinhChiPhi(double quangDuong)
        {
            return (decimal)(quangDuong / 100 * MucTieuHao) * GiaXang;
        }
    }
}
