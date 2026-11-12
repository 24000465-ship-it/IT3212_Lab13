using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_OOPAdvanced
{
    internal class Bai1
    {
        public static void chay()
        {
            SinhVien sv1 = new SinhVien("SV001" , "Le Duc Binh", new DateTime(2006,04,25) , 9.5);
            
            sv1.HienThi();

        }
    }
}
