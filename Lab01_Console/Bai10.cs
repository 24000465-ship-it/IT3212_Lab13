using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai10
    {
        
public static void chay()
        {
            int luaChon;

            do
            {
                Console.WriteLine("\n===== MENU VE HINH =====");
                Console.WriteLine("1. Ve tam giac vuong dac");
                Console.WriteLine("2. Ve tam giac vuong rong");
                Console.WriteLine("3. Ve hinh vuong rong");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");
                luaChon = int.Parse(Console.ReadLine());

                if (luaChon >= 1 && luaChon <= 3)
                {
                    Console.Write("Nhap kich thuoc n: ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Kich thuoc phai lon hon 0!");
                        continue;
                    }

                    switch (luaChon)
                    {
                        case 1:
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            break;

                        case 2:
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    if (j == 1 || j == i || i == n)
                                        Console.Write("*");
                                    else
                                        Console.Write(" ");
                                }
                                Console.WriteLine();
                            }
                            break;

                        case 3:
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= n; j++)
                                {
                                    if (i == 1 || i == n || j == 1 || j == n)
                                        Console.Write("*");
                                    else
                                        Console.Write(" ");
                                }
                                Console.WriteLine();
                            }
                            break;
                    }
                }
                else if (luaChon != 0)
                {
                    Console.WriteLine("Lua chon khong hop le!");
                }

            } while (luaChon != 0);

            Console.WriteLine("Da thoat chuong trinh!");
        }


    }
}
