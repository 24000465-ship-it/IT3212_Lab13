using System;

namespace Lab02_OOPBasics
{
    internal class Bai4
    {
        public static void chay()
        {
            SinhVien[] ds =
            {
                new SinhVien("24000465", "Lê Đức Bình", new DateTime(2006, 4, 25), 9.5),
                new SinhVien("SV002", "Trần Thị Bình", new DateTime(2005, 8, 20), 8.1),
                new SinhVien("SV003", "Lê Văn Cường", new DateTime(2004, 12, 31), 7.0),
                new SinhVien("SV004", "Phạm Thị Dung", new DateTime(2003, 1, 15), 5.5),
                new SinhVien("SV005", "Hoàng Văn Em", new DateTime(2005, 6, 1), 3.8)
            };

            Console.WriteLine("{0,-10} {1,-16} {2,-12} {3,5} {4,6}  {5}", "Mã SV", "Họ tên", "Ngày sinh", "Tuổi", "Điểm", "Xếp loại");
            foreach (SinhVien sv in ds)
            {
                Console.WriteLine("{0,-10} {1,-16} {2,-12:dd/MM/yyyy} {3,5} {4,6:N2}  {5}",
                    sv.MaSV, sv.HoTen, sv.NgaySinh, sv.TinhTuoi(), sv.DiemTB, sv.XepLoai());
            }
        }
    }
}
