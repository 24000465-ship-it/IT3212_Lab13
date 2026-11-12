using System.Linq;

namespace Lab03_OOPAdvanced
{
    internal class ViDienTu : IPayment
    {
        public string TenVi { get; private set; }
        public string SoDienThoai { get; private set; }
        public decimal SoDu { get; private set; }
        public decimal HanMucMoiLan { get; private set; }

        public ViDienTu(string tenVi, string soDienThoai, decimal soDu, decimal hanMucMoiLan)
        {
            TenVi = tenVi;
            SoDienThoai = soDienThoai;
            SoDu = soDu;
            HanMucMoiLan = hanMucMoiLan;
        }

        public string TenPhuongThuc
        {
            get { return "Ví " + TenVi; }
        }

        public bool KiemTra(decimal soTien, out string thongBao)
        {
            if (soTien <= 0)
            {
                thongBao = "Số tiền phải lớn hơn 0";
                return false;
            }
            if (string.IsNullOrEmpty(SoDienThoai) || SoDienThoai.Length != 10 || SoDienThoai[0] != '0' || !SoDienThoai.All(char.IsDigit))
            {
                thongBao = "Số điện thoại ví không hợp lệ";
                return false;
            }
            if (soTien > HanMucMoiLan)
            {
                thongBao = "Vượt hạn mức " + HanMucMoiLan.ToString("N0") + " đ/lần";
                return false;
            }
            if (soTien > SoDu)
            {
                thongBao = "Số dư ví không đủ";
                return false;
            }
            thongBao = "SĐT " + SoDienThoai;
            return true;
        }

        public void ThucHien(decimal soTien)
        {
            SoDu -= soTien;
        }
    }
}
