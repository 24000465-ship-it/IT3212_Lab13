using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai1
    {
        public static void chay()
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string name;
            int yearOfBirth;
            Console.Write("Nhập Họ Tên : ");
            name = Console.ReadLine();
            Console.WriteLine("Tên của bạn là : {0}", name);
            Console.Write("Nhập Năm Sinh : ");

            if (!int.TryParse(Console.ReadLine(), out yearOfBirth))
            {
                Console.WriteLine("Năm sinh không hợp lệ ");
                return;
            }
            int age = DateTime.Now.Year - yearOfBirth;
            Console.WriteLine("Tuổi của bạn : {0}", age);

        }
    }
}
