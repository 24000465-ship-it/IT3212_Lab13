using System;

namespace Lab02_OOPBasics
{
    internal class Bai7
    {
        public static void chay()
        {
            TaiKhoanNganHang tk1 = new TaiKhoanNganHang("1001", "Lê Đức Bình", 1000000);
            TaiKhoanNganHang tk2 = new TaiKhoanNganHang("1002", "Trần Thị Bình", 500000);

            Console.WriteLine("Ban đầu:");
            tk1.HienThi();
            tk2.HienThi();

            ThucHien("Nạp 200.000 đ vào TK 1001", () => tk1.NapTien(200000));
            ThucHien("Rút 300.000 đ từ TK 1001", () => tk1.RutTien(300000));
            ThucHien("Chuyển 400.000 đ từ TK 1001 sang TK 1002", () => tk1.ChuyenTien(tk2, 400000));
            ThucHien("Rút 5.000.000 đ từ TK 1002", () => tk2.RutTien(5000000));
            ThucHien("Nạp -50.000 đ vào TK 1002", () => tk2.NapTien(-50000));
            ThucHien("Chuyển 1.000.000 đ từ TK 1001 sang TK 1002", () => tk1.ChuyenTien(tk2, 1000000));

            Console.WriteLine("\nSau các giao dịch:");
            tk1.HienThi();
            tk2.HienThi();
        }

        static void ThucHien(string moTa, Action giaoDich)
        {
            Console.Write("\n" + moTa + ": ");
            try
            {
                giaoDich();
                Console.WriteLine("Thành công");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thất bại - " + ex.Message);
            }
        }
    }
}
