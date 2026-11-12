using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai7
    {
        public static void chay()
        {
            Console.Write("Nhập n số nguyên : ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for ( int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Nhập số nguyên thứ " + ( i + 1 ) + " : ");
                numbers[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Tổng = " + sum(numbers));
            Console.WriteLine("Trung bình cộng : " + TBsum(sum(numbers), n));
            Console.WriteLine("Số lớn nhất : " + max(numbers));
            Console.WriteLine("Số nhỏ nhất : " + min(numbers));
            Console.WriteLine("Số lượng số chẵn : " + soLuongSoChan(numbers));

        }
        public static int sum (int[] numbers)
        {
            int sum = 0;
            for ( int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
        public static double TBsum ( int sum , int n)
        {
            double TBsum = (double)sum / n;
            return TBsum;
        }
        public static int max (int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        public static int min(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        public static int soLuongSoChan ( int[] numbers)
        {
            int soLuongSoChan = 0;
            for( int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    soLuongSoChan += 1;
                }
            }
            return soLuongSoChan;
        }
    }
}
