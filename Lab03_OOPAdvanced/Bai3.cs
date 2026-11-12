using System;

namespace Lab03_OOPAdvanced
{
    internal class Bai3
    {
        public static void chay()
        {
            SinhVienChinhQuy sv1 = new SinhVienChinhQuy { MaSV = "SV001", HoTen = "Lê Đức Bình", SoTinChi = 18 };
            SinhVienLienThong sv2 = new SinhVienLienThong { MaSV = "SV002", HoTen = "Trần Thị Bình", SoTinChi = 15 };

            Console.WriteLine("Sinh viên chính quy : {0} - {1} tín chỉ x 450.000 = {2:N0} đ", sv1.HoTen, sv1.SoTinChi, sv1.TinhHocPhi());
            Console.WriteLine("Sinh viên liên thông: {0} - {1} tín chỉ x 520.000 = {2:N0} đ", sv2.HoTen, sv2.SoTinChi, sv2.TinhHocPhi());

            Console.WriteLine("\nLớp NguoiHoc là abstract nên không thể viết: new NguoiHoc()");
            Console.WriteLine("Mỗi lớp con bắt buộc phải override TinhHocPhi() theo công thức riêng.");

            try
            {
                Console.Write("\nGán SoTinChi = -5: ");
                sv1.SoTinChi = -5;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi - " + ex.Message);
            }
        }
    }
}
