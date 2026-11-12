using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
        
       
        

            do
            {
                Console.WriteLine("Nhap Lua Chon Chay Bai Tap : ");
                Console.WriteLine("1 - Bài 1 ");
                Console.WriteLine("2 - Bài 2");
                Console.WriteLine("3 - Bài 3 ");
                Console.WriteLine("4 - Bài 4 ");
                Console.WriteLine("5 - Bài 5 ");
                Console.WriteLine("6 - Bài 6 ");
                Console.WriteLine("7 - Bài 7 ");
                Console.WriteLine("8 - Bài 8 ");
                Console.WriteLine("9 - Bài 9 ");
                Console.WriteLine("10 - Bài 10 ");
                Console.Write("Nhập lựa chọn ở đây : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {   
                    case 1:
                        Bai1.chay();
                        break;
                    case 2:
                        Bai2.chay();
                        break;
                    case 3:
                        Bai3.chay();
                        break;
                    case 4:
                        Bai4.chay();
                        break;
                    case 5:
                        Bai5.chay();
                        break;
                    case 6:
                        Bai6.chay();
                        break;
                    case 7:
                        Bai7.chay();
                        break;
                    case 8:
                        Bai8.chay();
                        break;
                    case 9:
                        Bai9.chay();
                        break;
                    case 10:
                        Bai10.chay();
                        break;
                }
            }while (true);

           

        }

    }
}
