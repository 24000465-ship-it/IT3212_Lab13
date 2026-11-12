using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai2
    {
        public static void chay()
        {
            double r, h;
            Console.Write("Bán kính r = ");
            if ( !double.TryParse(Console.ReadLine(), out r) || r <= 0 ) { 
                return; 
            }
            Console.Write("Chiều cao h = ");
            if( !double.TryParse(Console.ReadLine(),out h) || h <= 0 ) {    
                return; 
            }
            double dienTichXq = 2 * Math.PI * r * h;
            double theTich = Math.PI * (r * r) * h;
            Console.WriteLine(" Diện tích xung quanh : {0:N2}", dienTichXq);
            Console.WriteLine(" Thể tích : {0:N2}", theTich);
        }
    }
}
