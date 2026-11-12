using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_OOPAdvanced
{
    internal class Bai6
    {
        public static void chay()
        {
            List<NhanVien> ds = new List<NhanVien>();
            ds.Add(new NhanVienVanPhong("NV01", "Nguyễn Văn An", 2340000, 2.34, 500000));
            ds.Add(new NhanVienKinhDoanh("NV02", "Trần Thị Bình", 5000000, 80000000, 0.05));
            ds.Add(new GiangVien("GV01", "Lê Văn Cường", 2340000, 3.0, 40, 100000));
            ds.Add(new NhanVienVanPhong("NV03", "Phạm Thị Dung", 2340000, 3.33, 800000));
            ds.Add(new GiangVien("GV02", "Hoàng Văn Em", 2340000, 4.4, 24, 120000));

            Console.WriteLine("============================== BẢNG LƯƠNG ==============================");
            Console.WriteLine("{0,-5} {1,-16} {2,-12} {3,14}  {4}", "Mã", "Họ tên", "Chức vụ", "Lương", "Công thức");
            foreach (NhanVien nv in ds)
                nv.HienThi();
            Console.WriteLine("Tổng quỹ lương: {0:N0} đ", ds.Sum(x => x.TinhLuong()));

            Console.WriteLine("\nTổng lương theo chức vụ:");
            foreach (var nhom in ds.GroupBy(x => x.ChucVu))
                Console.WriteLine("  - {0,-11}: {1} người, {2,14:N0} đ", nhom.Key, nhom.Count(), nhom.Sum(x => x.TinhLuong()));

            try
            {
                Console.Write("\nThêm nhân viên kinh doanh có tỉ lệ hoa hồng 1,5: ");
                new NhanVienKinhDoanh("NV04", "Ngô Thị Hoa", 5000000, 10000000, 1.5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi - " + ex.Message);
            }
        }
    }
}
