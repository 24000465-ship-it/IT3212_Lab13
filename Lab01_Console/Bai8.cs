using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai8
    {
        public static void chay() {
            Console.Write("Nhập n số nguyên : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("các số nguyên tố không vượt quá n là các số : ");
            for ( int i = 2; i <= n; i++)
            {
                if (checkPrime(i))
                {
                    Console.WriteLine(i);
                }
            }


        }
        public static bool checkPrime (int check)
        {
            bool isPrime = true;
            if ( check <= 1)
            {
                isPrime = false;
            }else if ( check == 2 )
            {
                isPrime = true;
            }
            else
            {
                for ( int i = 2; i <= Math.Sqrt(check); i++)
                {
                    if ( check % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            return isPrime;

        }
    }
}
