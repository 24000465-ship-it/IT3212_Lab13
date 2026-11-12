using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_OOPAdvanced
{
    internal class Bai8
    {
        public static void chay()
        {
            List<TaiLieu> ds = new List<TaiLieu>();
            ds.Add(new Sach("S01", "Lập trình C# căn bản", "Nguyễn Văn An", 2022, "Giáo dục", 320));
            ds.Add(new Sach("S02", "Cấu trúc dữ liệu", "Trần Thị Bình", 2020, "Khoa học", 280));
            ds.Add(new TapChi("T01", "Tạp chí Tin học", "Hội Tin học VN", 2025, 12, 6));
            ds.Add(new LuanVan("L01", "Ứng dụng C# quản lý thư viện", "Lê Văn Cường", 2024, "ĐH Công nghệ Đông Á", "TS. Phạm Dung"));
            ds.Add(new TapChi("T02", "Tạp chí Khoa học máy tính", "Viện CNTT", 2024, 3, 9));

            Console.WriteLine("Toàn bộ tài liệu:");
            foreach (TaiLieu tl in ds)
                Console.WriteLine("  " + tl.ToDisplayText());

            Console.WriteLine("\nTheo kiểu tài liệu:");
            Console.WriteLine("  Sách     : " + ds.OfType<Sach>().Count());
            Console.WriteLine("  Tạp chí  : " + ds.OfType<TapChi>().Count());
            Console.WriteLine("  Luận văn : " + ds.OfType<LuanVan>().Count());

            Console.Write("\nNhập từ khóa tìm theo tiêu đề hoặc tác giả: ");
            string tuKhoa = Console.ReadLine().Trim().ToLower();
            List<TaiLieu> ketQua = ds.Where(x => x.TieuDe.ToLower().Contains(tuKhoa)
                                              || x.TacGia.ToLower().Contains(tuKhoa)).ToList();
            if (ketQua.Count == 0)
            {
                Console.WriteLine("Không tìm thấy tài liệu.");
            }
            else
            {
                Console.WriteLine("Tìm thấy {0} tài liệu:", ketQua.Count);
                foreach (TaiLieu tl in ketQua)
                    Console.WriteLine("  " + tl.ToDisplayText());
            }
        }
    }
}
