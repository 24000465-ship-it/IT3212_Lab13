using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai5
    {
        public static void chay()
        {
            try
            {
                Console.WriteLine("Nhập a : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập b : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(" {0} / {1}  = {2:F2} " , a , b , (double)a / b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu phải là số nguyen");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Không thể chia cho 0 ");
            }
            finally
            {
                Console.WriteLine("Kết thúc phép chia ");
            }
        }
    }
}
