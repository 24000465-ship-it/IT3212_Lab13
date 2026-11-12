using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    internal class Bai4
    {
        public static void chay()
        {
            List<SinhVien> ds = new List<SinhVien>();
            ds.Add(new SinhVien("SV001", "Lê Đức Bình", new DateTime(2006, 4, 25), 9.5));
            ds.Add(new SinhVien("SV002", "Trần Thị Bình", new DateTime(2005, 8, 20), 7.2));
            ds.Add(new SinhVien());
            ds.Add(new SinhVien("SV004", "Phạm Văn Dũng", DateTime.Today.AddDays(5), 6.0));


            Console.WriteLine("Kiểm tra dữ liệu qua IValidatable:");
            foreach (SinhVien sv in ds)
            {
                IValidatable kiemTra = sv;
                string thongBao;
                if (kiemTra.IsValid(out thongBao))
                    Console.WriteLine("  [Hợp lệ]     " + sv.MaSV);
                else
                    Console.WriteLine("  [Không hợp lệ] " + sv.MaSV + " - " + thongBao);
            }

            Console.WriteLine("\nIn dữ liệu qua IPrintable (chỉ in sinh viên hợp lệ):");
            foreach (SinhVien sv in ds)
            {
                string thongBao;
                if (!sv.IsValid(out thongBao)) continue;
                IPrintable inRa = sv;
                Console.WriteLine("  " + inRa.ToDisplayText());
            }
        }
    }
}
