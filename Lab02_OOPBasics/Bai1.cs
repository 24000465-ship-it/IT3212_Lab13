using System;

namespace Lab02_OOPBasics
{
    internal class Bai1
    {
        public static void chay()
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = "24000465";
            sv.HoTen = "Lê Đức Bình";
            sv.NgaySinh = new DateTime(2006, 04, 25);
            sv.DiemTB = 9.5;
            sv.HienThi();
        }
    }
}
