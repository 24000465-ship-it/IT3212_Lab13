using System;
using System.Collections.Generic;

namespace Lab02_OOPBasics
{
    internal class Bai6
    {
        public static void chay()
        {
            List<SanPham> ds = new List<SanPham>();
            ds.Add(new SanPham("SP01", "Bút bi Thiên Long", 5000, 20));
            ds.Add(new SanPham("SP02", "Vở 200 trang", 15000, 10));
            ds.Add(new SanPham("SP03", "Chuột không dây", 250000, 2));

            Console.WriteLine("{0,-6} {1,-22} {2,12} {3,6} {4,14}", "Mã", "Tên sản phẩm", "Đơn giá", "SL", "Thành tiền");
            decimal tong = 0;
            foreach (SanPham sp in ds)
            {
                sp.HienThi();
                tong += sp.ThanhTien();
            }
            Console.WriteLine("Tổng tiền: {0:N0} đ", tong);

            Console.WriteLine("\nKiểm tra dữ liệu không hợp lệ:");
            try
            {
                new SanPham("SP04", "Bàn phím", -100000, 1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("- " + ex.Message);
            }
            try
            {
                new SanPham("SP05", "Tai nghe", 300000, -3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("- " + ex.Message);
            }
            try
            {
                new SanPham("SP06", "", 10000, 1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("- " + ex.Message);
            }
        }
    }
}
