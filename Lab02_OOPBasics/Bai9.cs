using System;

namespace Lab02_OOPBasics
{
    internal class Bai9
    {
        public static void chay()
        {
            Console.Write("Constructor mặc định: ");
            new HinhChuNhat().HienThi();

            Console.Write("Constructor 5 x 3   : ");
            new HinhChuNhat(5, 3).HienThi();

            try
            {
                Console.Write("Constructor 4 x -2  : ");
                new HinhChuNhat(4, -2).HienThi();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi - " + ex.Message);
            }

            Console.WriteLine("\nNhập hình chữ nhật:");
            try
            {
                Console.Write("Chiều dài = ");
                double dai = double.Parse(Console.ReadLine());
                Console.Write("Chiều rộng = ");
                double rong = double.Parse(Console.ReadLine());
                HinhChuNhat hcn = new HinhChuNhat(dai, rong);
                hcn.HienThi();
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi - Dữ liệu phải là số.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi - " + ex.Message);
            }
        }
    }
}
