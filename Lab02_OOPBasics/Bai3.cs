using System;

namespace Lab02_OOPBasics
{
    internal class Bai3
    {
        public static void chay()
        {
            try
            {
                SinhVien sv3 = new SinhVien();
                Console.WriteLine("Gán DiemTB = 11");
                sv3.DiemTB = 11;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Lỗi điểm: " + ex.ParamName + " phải nằm trong đoạn [0, 10].");
            }

            try
            {
                SinhVien sv4 = new SinhVien();
                Console.WriteLine("Gán HoTen = \"   \"");
                sv4.HoTen = "   ";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi họ tên: " + ex.Message);
            }

            SinhVien sv5 = new SinhVien();
            sv5.HoTen = "   Nguyễn Văn An   ";
            sv5.DiemTB = 7.5;
            Console.WriteLine("Gán hợp lệ, họ tên đã được cắt khoảng trắng: [" + sv5.HoTen + "]");
        }
    }
}
