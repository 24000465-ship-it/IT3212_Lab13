using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai6
    {
        public static void chay()
        {
            double a, b, c;
            Console.Write("Nhập số a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhập số c : ");
            c = double.Parse(Console.ReadLine());
            double delta = ( b * b ) - ( 4 * a * c );
            if (a == 0)
            {
                phuongTrinhBacNhat(b, c);
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm ( trong tập số thực)");

                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine(" x1 = x2  = {0:F2}", x);

                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = {0:F2}", x1);
                    Console.WriteLine("x2 = {0:F2}", x2);
                }
            }

        }
        public static void phuongTrinhBacNhat( double a , double b)
        {
            if (a != 0)
            {

                Console.WriteLine("Phương trình có nghiệm duy nhất : x = {0:F2} ", -b / a);
            }
            else if (b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }
}
