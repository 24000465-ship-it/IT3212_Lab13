namespace Lab03_OOPAdvanced
{
    internal class ThanhToanTienMat : IPayment
    {
        public decimal TienKhachDua { get; private set; }
        public decimal TienThua { get; private set; }

        public ThanhToanTienMat(decimal tienKhachDua)
        {
            TienKhachDua = tienKhachDua;
        }

        public string TenPhuongThuc
        {
            get { return "Tiền mặt"; }
        }

        public bool KiemTra(decimal soTien, out string thongBao)
        {
            if (soTien <= 0)
            {
                thongBao = "Số tiền phải lớn hơn 0";
                return false;
            }
            if (TienKhachDua < soTien)
            {
                thongBao = "Khách đưa thiếu " + (soTien - TienKhachDua).ToString("N0") + " đ";
                return false;
            }
            thongBao = "Trả lại khách " + (TienKhachDua - soTien).ToString("N0") + " đ";
            return true;
        }

        public void ThucHien(decimal soTien)
        {
            TienThua = TienKhachDua - soTien;
        }
    }
}
