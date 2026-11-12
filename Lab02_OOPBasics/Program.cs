using System;
using System.Text;

namespace Lab02_OOPBasics
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
                Console.WriteLine("\n========== LAB 2 - LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG ==========");
                Console.WriteLine("1 - Bài 1: Khai báo lớp SinhVien");
                Console.WriteLine("2 - Bài 2: Constructor và nạp chồng constructor");
                Console.WriteLine("3 - Bài 3: Đóng gói và kiểm tra dữ liệu");
                Console.WriteLine("4 - Bài 4: TinhTuoi() và XepLoai()");
                Console.WriteLine("5 - Bài 5: Quản lý danh sách SinhVien");
                Console.WriteLine("6 - Bài 6: Lớp SanPham");
                Console.WriteLine("7 - Bài 7: Lớp TaiKhoanNganHang");
                Console.WriteLine("8 - Bài 8: Lớp NhanVien");
                Console.WriteLine("9 - Bài 9: Lớp HinhChuNhat");
                Console.WriteLine("10 - Bài 10: Ứng dụng quản lý sinh viên");
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
