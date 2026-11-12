using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai3
    {
        public static void chay()
        {
            Console.Write("Nhập vào điểm của bạn : ");
            double diem;
            if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm phải thuộc 0 -> 10 ");
            }
            else if (diem >= 9) Console.WriteLine("Xuất sắc"); 
            else if (diem >= 8) Console.WriteLine("Giỏi"); 
            else if (diem >= 6.5) Console.WriteLine("Khá"); 
            else if (diem >= 5) Console.WriteLine("Trung bình"); 
            else  Console.WriteLine("Yếu"); 

        }
    }
}
