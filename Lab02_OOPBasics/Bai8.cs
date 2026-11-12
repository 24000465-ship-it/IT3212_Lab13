using System;
using System.Collections.Generic;

namespace Lab02_OOPBasics
{
    internal class Bai8
    {
        public static void chay()
        {
            List<NhanVien> ds = new List<NhanVien>();
            ds.Add(new NhanVien("NV01", "Nguyễn Văn An", 2340000, 2.34, 500000));
            ds.Add(new NhanVien("NV02", "Trần Thị Bình", 2340000, 3.00, 800000));
            ds.Add(new NhanVien("NV03", "Lê Văn Cường", 2340000, 4.40, 1200000));
            ds.Add(new NhanVien("NV04", "Phạm Thị Dung", 2340000, 2.67, 0));

            Console.WriteLine("===================================== BẢNG LƯƠNG =====================================");
            Console.WriteLine("{0,-6} {1,-18} {2,12} {3,6} {4,12} {5,14}", "Mã", "Họ tên", "Lương CB", "Hệ số", "Phụ cấp", "Thực lĩnh");
            decimal tongLuong = 0;
            foreach (NhanVien nv in ds)
            {
                nv.HienThi();
                tongLuong += nv.TinhLuong();
            }
            Console.WriteLine("Tổng quỹ lương: {0:N0} đ", tongLuong);
            Console.WriteLine("Công thức: Thực lĩnh = Lương cơ bản x Hệ số + Phụ cấp");

            try
            {
                new NhanVien("NV05", "Hoàng Văn Em", 2340000, -1, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("\nThêm NV05 có hệ số -1: " + ex.Message);
            }
        }
    }
}
