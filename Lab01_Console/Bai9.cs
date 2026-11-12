using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai9
    {
        public static void chay()
        {
            Console.Write("Nhập số nguyên từ 0 đến 99: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 99)
            {
                Console.WriteLine("Số nhập vào không hợp lệ!");
                return;
            }

            if (n < 10)
            {
                switch (n)
                {
                    case 0: Console.WriteLine("không"); break;
                    case 1: Console.WriteLine("một"); break;
                    case 2: Console.WriteLine("hai"); break;
                    case 3: Console.WriteLine("ba"); break;
                    case 4: Console.WriteLine("bốn"); break;
                    case 5: Console.WriteLine("năm"); break;
                    case 6: Console.WriteLine("sáu"); break;
                    case 7: Console.WriteLine("bảy"); break;
                    case 8: Console.WriteLine("tám"); break;
                    case 9: Console.WriteLine("chín"); break;
                }
                return;
            }

            int chuc = n / 10;
            int donVi = n % 10;
            string ketQua = "";

            switch (chuc)
            {
                case 1: ketQua = "mười"; break;
                case 2: ketQua = "hai mươi"; break;
                case 3: ketQua = "ba mươi"; break;
                case 4: ketQua = "bốn mươi"; break;
                case 5: ketQua = "năm mươi"; break;
                case 6: ketQua = "sáu mươi"; break;
                case 7: ketQua = "bảy mươi"; break;
                case 8: ketQua = "tám mươi"; break;
                case 9: ketQua = "chín mươi"; break;
            }

            if (donVi != 0)
            {
                if (chuc == 1)
                {
                    switch (donVi)
                    {
                        case 1: ketQua += " một"; break;
                        case 2: ketQua += " hai"; break;
                        case 3: ketQua += " ba"; break;
                        case 4: ketQua += " bốn"; break;
                        case 5: ketQua += " lăm"; break;
                        case 6: ketQua += " sáu"; break;
                        case 7: ketQua += " bảy"; break;
                        case 8: ketQua += " tám"; break;
                        case 9: ketQua += " chín"; break;
                    }
                }
                else
                {
                    switch (donVi)
                    {
                        case 1: ketQua += " mốt"; break;
                        case 2: ketQua += " hai"; break;
                        case 3: ketQua += " ba"; break;
                        case 4: ketQua += " tư"; break;
                        case 5: ketQua += " lăm"; break;
                        case 6: ketQua += " sáu"; break;
                        case 7: ketQua += " bảy"; break;
                        case 8: ketQua += " tám"; break;
                        case 9: ketQua += " chín"; break;
                    }
                }
            }

            Console.WriteLine(ketQua);
        }
    }
}
