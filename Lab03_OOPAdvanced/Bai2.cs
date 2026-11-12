using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_OOPAdvanced
{
    internal class Bai2
    {
        public static void chay()
        {
            SinhVien sv1 = new SinhVien();
            sv1.MaSV = "SV001";
            sv1.HoTen = "Lê Đức Bình";
            sv1.NgaySinh = new DateTime(2006, 04, 25);
            sv1.DiemTB = 9.5;
            Console.WriteLine(sv1.MoTa());
        }
    }
}
