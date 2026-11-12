using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_OOPAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int choice;
            do
            {
                Console.WriteLine("\n========== LAB 3 - KẾ THỪA, ĐA HÌNH, LỚP TRỪU TƯỢNG VÀ INTERFACE ==========");
                Console.WriteLine("1 - Bài 1: Kế thừa Nguoi - SinhVien");
                Console.WriteLine("2 - Bài 2: Ghi đè phương thức MoTa()");
                Console.WriteLine("3 - Bài 3: Lớp trừu tượng NguoiHoc - học phí");
                Console.WriteLine("4 - Bài 4: Interface IValidatable và IPrintable");
                Console.WriteLine("5 - Bài 5: Danh sách đa hình - tổng học phí");
                Console.WriteLine("6 - Bài 6: Hệ thống nhân viên");
                Console.WriteLine("7 - Bài 7: Quản lý phương tiện (IMove)");
                Console.WriteLine("8 - Bài 8: Quản lý tài liệu thư viện");
                Console.WriteLine("9 - Bài 9: Hệ thống thanh toán (IPayment)");
                Console.WriteLine("10 - Bài 10: Nâng cấp quản lý sinh viên");
                Console.WriteLine("0 - Thoát");
                Console.Write("Nhập lựa chọn ở đây : ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Vui lòng nhập số từ 0 đến 10!");
                    choice = -1;
                    continue;
                }
                Console.WriteLine();
                switch (choice)
                {
                    case 1: Bai1.chay(); break;
                    case 2: Bai2.chay(); break;
                    case 3: Bai3.chay(); break;
                    case 4: Bai4.chay(); break;
                    case 5: Bai5.chay(); break;
                    case 6: Bai6.chay(); break;
                    case 7: Bai7.chay(); break;
                    case 8: Bai8.chay(); break;
                    case 9: Bai9.chay(); break;
                    case 10: Bai10.chay(); break;
                    case 0: Console.WriteLine("Kết thúc chương trình."); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            } while (choice != 0);
        }
    }
}
