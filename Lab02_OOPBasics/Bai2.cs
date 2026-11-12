using System;

namespace Lab02_OOPBasics
{
    internal class Bai2
    {
        public static void chay()
        {
            Console.Write("Constructor không tham số   : ");
            SinhVien sv1 = new SinhVien();
            sv1.HienThi();

            Console.Write("Constructor đầy đủ tham số : ");
            SinhVien sv2 = new SinhVien("24000466", "Lê Bình Minh", new DateTime(2006, 09, 20), 8.1);
            sv2.HienThi();
        }
    }
}
