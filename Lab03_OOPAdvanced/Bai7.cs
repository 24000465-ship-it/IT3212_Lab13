using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    internal class Bai7
    {
        public static void chay()
        {
            List<IMove> dsPhuongTien = new List<IMove>();
            dsPhuongTien.Add(new XeMay("Xe máy Wave", 40, 1.8, 24000));
            dsPhuongTien.Add(new OTo("Ô tô Vios", 60, 6.5, 24000, 35000));
            dsPhuongTien.Add(new XeDap("Xe đạp", 15));

            double quangDuong;
            while (true)
            {
                Console.Write("Nhập quãng đường (km): ");
                if (double.TryParse(Console.ReadLine(), out quangDuong) && quangDuong > 0) break;
                Console.WriteLine("Quãng đường phải là số dương!");
            }

            Console.WriteLine("\n{0,-14} {1,10} {2,14} {3,14}", "Phương tiện", "Tốc độ", "Thời gian", "Chi phí");
            foreach (IMove pt in dsPhuongTien)
            {
                int phut = (int)Math.Round(pt.TinhThoiGian(quangDuong) * 60);
                string thoiGian = string.Format("{0}h{1:00}p", phut / 60, phut % 60);
                Console.WriteLine("{0,-14} {1,7} km/h {2,14} {3,12:N0} đ", pt.Ten, pt.TocDo, thoiGian, pt.TinhChiPhi(quangDuong));
            }
        }
    }
}
