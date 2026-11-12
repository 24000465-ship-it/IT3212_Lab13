namespace Lab06_ThreeLayerMemory.DTO
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DanhMuc { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }

        public decimal ThanhTien
        {
            get { return DonGia * SoLuong; }
        }

        public SanPham(string maSP, string tenSP, string danhMuc, decimal donGia, int soLuong)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DanhMuc = danhMuc;
            DonGia = donGia;
            SoLuong = soLuong;
        }
    }
}
