using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_OOPAdvanced
{
    internal class Bai9
    {
        static List<GiaoDich> lichSu = new List<GiaoDich>();

        public static void chay()
        {
            lichSu.Clear();
            IPayment chuyenKhoan = new ChuyenKhoan("Vietcombank", "1012345678", 2000000);
            IPayment chuyenKhoanSai = new ChuyenKhoan("BIDV", "12AB", 5000000);
            IPayment viMoMo = new ViDienTu("MoMo", "0912345678", 300000, 200000);

            ThanhToan(new ThanhToanTienMat(500000), 350000);
            ThanhToan(new ThanhToanTienMat(200000), 250000);
            ThanhToan(chuyenKhoan, 1500000);
            ThanhToan(chuyenKhoan, 800000);
            ThanhToan(chuyenKhoanSai, 100000);
            ThanhToan(viMoMo, 150000);
            ThanhToan(viMoMo, 250000);
            ThanhToan(viMoMo, -20000);

            Console.WriteLine("\n================================ LỊCH SỬ GIAO DỊCH ================================");
            foreach (GiaoDich gd in lichSu)
                Console.WriteLine(gd);
            Console.WriteLine("Thành công: {0}/{1} giao dịch, tổng tiền đã thu: {2:N0} đ",
                lichSu.Count(x => x.ThanhCong), lichSu.Count, lichSu.Where(x => x.ThanhCong).Sum(x => x.SoTien));
        }

        static void ThanhToan(IPayment phuongThuc, decimal soTien)
        {
            string thongBao;
            bool hopLe = phuongThuc.KiemTra(soTien, out thongBao);
            if (hopLe) phuongThuc.ThucHien(soTien);
            lichSu.Add(new GiaoDich(lichSu.Count + 1, phuongThuc.TenPhuongThuc, soTien, hopLe, thongBao));
            Console.WriteLine("{0,-14} {1,12:N0} đ -> {2}: {3}", phuongThuc.TenPhuongThuc, soTien, hopLe ? "OK" : "TỪ CHỐI", thongBao);
        }
    }
}
