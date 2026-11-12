namespace Lab03_OOPAdvanced
{
    internal interface IMove
    {
        string Ten { get; }
        double TocDo { get; }
        double TinhThoiGian(double quangDuong);
        decimal TinhChiPhi(double quangDuong);
    }
}
