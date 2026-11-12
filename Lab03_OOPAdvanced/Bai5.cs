using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    internal class Bai5
    {
        public static void chay()
        {
            List<NguoiHoc> ds = new List<NguoiHoc>();
            ds.Add(new SinhVienChinhQuy { HoTen = "An", SoTinChi = 18 });
            ds.Add(new SinhVienLienThong { HoTen = "Bình", SoTinChi = 15 });
            ds.Add(new SinhVienChinhQuy { HoTen = "Cường", SoTinChi = 20 });
            ds.Add(new SinhVienLienThong { HoTen = "Dung", SoTinChi = 12 });

            decimal tong = 0;
            foreach (NguoiHoc item in ds)
            {
                decimal hocPhi = item.TinhHocPhi();
                tong += hocPhi;
                Console.WriteLine("{0,-6} ({1,-10}): {2,12:N0}", item.HoTen, item.LoaiSinhVien, hocPhi);
            }
            Console.WriteLine("Tổng học phí: {0:N0}", tong);
            Console.WriteLine("\nCùng gọi item.TinhHocPhi() qua tham chiếu NguoiHoc, nhưng mỗi đối tượng chạy công thức của lớp mình (đa hình).");
        }
    }
}
