using System.Linq;

namespace Lab03_OOPAdvanced
{
    internal class ChuyenKhoan : IPayment
    {
        public string NganHang { get; private set; }
        public string SoTaiKhoan { get; private set; }
        public decimal SoDu { get; private set; }

        public ChuyenKhoan(string nganHang, string soTaiKhoan, decimal soDu)
        {
            NganHang = nganHang;
            SoTaiKhoan = soTaiKhoan;
            SoDu = soDu;
        }

        public string TenPhuongThuc
        {
            get { return "Chuyển khoản"; }
        }

        public bool KiemTra(decimal soTien, out string thongBao)
        {
            if (soTien <= 0)
            {
                thongBao = "Số tiền phải lớn hơn 0";
                return false;
            }
            if (string.IsNullOrEmpty(SoTaiKhoan) || SoTaiKhoan.Length < 8 || SoTaiKhoan.Length > 14 || !SoTaiKhoan.All(char.IsDigit))
            {
                thongBao = "Số tài khoản không hợp lệ (8-14 chữ số)";
                return false;
            }
            if (soTien > SoDu)
            {
                thongBao = "Số dư tài khoản không đủ";
                return false;
            }
            thongBao = NganHang + " - TK " + SoTaiKhoan;
            return true;
        }

        public void ThucHien(decimal soTien)
        {
            SoDu -= soTien;
        }
    }
}
