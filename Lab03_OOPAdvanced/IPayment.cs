namespace Lab03_OOPAdvanced
{
    internal interface IPayment
    {
        string TenPhuongThuc { get; }
        bool KiemTra(decimal soTien, out string thongBao);
        void ThucHien(decimal soTien);
    }
}
