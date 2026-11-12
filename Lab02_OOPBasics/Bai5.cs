using System;
using System.Collections.Generic;

namespace Lab02_OOPBasics
{
    internal class Bai5
    {
        public static void chay()
        {
            List<SinhVien> ds = new List<SinhVien>();
            ds.Add(new SinhVien("SV01", "Nguyễn An", new DateTime(2005, 5, 12), 8.2));
            ds.Add(new SinhVien("SV02", "Trần Bình", new DateTime(2005, 9, 3), 6.8));
            ds.Add(new SinhVien("SV03", "Lê Cường", new DateTime(2004, 11, 20), 9.1));
            ds.Add(new SinhVien("SV04", "Phạm Dung", new DateTime(2005, 2, 28), 5.4));
            ds.Add(new SinhVien("SV05", "Hoàng Em", new DateTime(2006, 7, 7), 4.5));

            Console.WriteLine("Danh sách sinh viên:");
            foreach (SinhVien sv in ds) sv.HienThi();

            Console.Write("Mã cần tìm: ");
            string ma = Console.ReadLine();
            SinhVien ketQua = ds.Find(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(ketQua == null ? "Không tìm thấy" : ketQua.HoTen);
        }
    }
}
