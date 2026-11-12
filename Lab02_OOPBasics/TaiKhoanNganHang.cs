using System;

namespace Lab02_OOPBasics
{
    internal class TaiKhoanNganHang
    {
        public string SoTaiKhoan { get; private set; }
        public string ChuTaiKhoan { get; private set; }
        public decimal SoDu { get; private set; }

        public TaiKhoanNganHang(string soTaiKhoan, string chuTaiKhoan, decimal soDuBanDau)
        {
            if (string.IsNullOrWhiteSpace(soTaiKhoan))
                throw new ArgumentException("Số tài khoản không được rỗng.");
            if (string.IsNullOrWhiteSpace(chuTaiKhoan))
                throw new ArgumentException("Tên chủ tài khoản không được rỗng.");
            if (soDuBanDau < 0)
                throw new ArgumentException("Số dư ban đầu không được âm.");
            SoTaiKhoan = soTaiKhoan;
            ChuTaiKhoan = chuTaiKhoan;
            SoDu = soDuBanDau;
        }

        public void NapTien(decimal soTien)
        {
            if (soTien <= 0)
                throw new ArgumentException("Số tiền nạp phải lớn hơn 0.");
            SoDu += soTien;
        }

        public void RutTien(decimal soTien)
        {
            if (soTien <= 0)
                throw new ArgumentException("Số tiền rút phải lớn hơn 0.");
            if (soTien > SoDu)
                throw new InvalidOperationException("Số dư không đủ để rút " + soTien.ToString("N0") + " đ.");
            SoDu -= soTien;
        }

        public void ChuyenTien(TaiKhoanNganHang taiKhoanNhan, decimal soTien)
        {
            if (taiKhoanNhan == null)
                throw new ArgumentException("Tài khoản nhận không tồn tại.");
            if (taiKhoanNhan == this)
                throw new InvalidOperationException("Không thể chuyển tiền cho chính mình.");
            RutTien(soTien);
            taiKhoanNhan.NapTien(soTien);
        }

        public void HienThi()
        {
            Console.WriteLine("{0} - {1} - Số dư: {2:N0} đ", SoTaiKhoan, ChuTaiKhoan, SoDu);
        }
    }
}
