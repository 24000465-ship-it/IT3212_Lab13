using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab01_Console
{
    internal class Bai4
    {
        public static void chay()
        {
            int choice;
            int n;
            do
            {
                Console.WriteLine("1 - tính tổng 1 -> n");
                Console.WriteLine("2 - Bảng cửu chương");
                Console.WriteLine("0 - thoát chương trình");
                Console.Write("Nhập lựa chọn của bạn : ");
                int.TryParse(Console.ReadLine(), out choice);
              
                switch (choice)
                {

                    case 1:
                        Console.Write("Nhập một số n : ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tổng từ 1 -> {0} là {1} " , n , tong(n) );
                        break;
                    case 2:
                        n = int.Parse(Console.ReadLine());
                        bangCuuChuong(n);
                        break;
                    

                }
            } while ( choice != 0);

            Console.WriteLine("Da thoat chuong trinh!");

        }
        public static int tong ( int n )
        {
            int sum = 0;
            for ( int i = 0; i <= n; i++ )
            {
                sum += i;
            }
            return sum;
        }
        public static void bangCuuChuong ( int n)
        {
            for ( int i = 0; i <= 10; i++)
            {
                Console.WriteLine(" {0} * {1} = {2} ", n, i, n * i);

           }
        }


    }
}
