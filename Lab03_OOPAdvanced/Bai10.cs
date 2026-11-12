using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab03_OOPAdvanced
{
    internal class Bai10
    {
        static List<NguoiHoc> ds = new List<NguoiHoc>();

        public static void chay()
        {
            if (ds.Count == 0) TaoDuLieuMau();

            int luaChon;
            do
            {
                Console.WriteLine("\n===== QUẢN LÝ SINH VIÊN (NÂNG CẤP) =====");
                Console.WriteLine("1. Hiển thị danh sách");
                Console.WriteLine("2. Thêm sinh viên");
                Console.WriteLine("3. Tìm kiếm");
                Console.WriteLine("4. Thống kê theo loại");
                Console.WriteLine("5. Xuất dữ liệu (CSV)");
                Console.WriteLine("0. Quay lại menu chính");
                luaChon = NhapSoNguyen("Nhập lựa chọn: ");

                switch (luaChon)
                {
                    case 1: HienThi(ds); break;
                    case 2: Them(); break;
                    case 3: TimKiem(); break;
                    case 4: ThongKe(); break;
                    case 5: XuatDuLieu(); break;
                    case 0: break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            } while (luaChon != 0);
        }

        static void TaoDuLieuMau()
        {
            ds.Add(new SinhVienChinhQuy { MaSV = "SV001", HoTen = "Trần Thị Mai", SoTinChi = 18, DiemTB = 7.5 });
            ds.Add(new SinhVienLienThong { MaSV = "SV002", HoTen = "Nguyễn Văn An", SoTinChi = 15, DiemTB = 8.6 });
            ds.Add(new SinhVienVanBang2 { MaSV = "SV003", HoTen = "Lê Văn Cường", SoTinChi = 12, DiemTB = 6.2 });
            ds.Add(new SinhVienChinhQuy { MaSV = "SV004", HoTen = "Phạm Thị Dung", SoTinChi = 20, DiemTB = 9.1 });
            ds.Add(new SinhVienLienThong { MaSV = "SV005", HoTen = "Hoàng Văn Bảo", SoTinChi = 10, DiemTB = 5.4 });
        }

        static void HienThi(List<NguoiHoc> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }
            Console.WriteLine("{0,-6} {1,-16} {2,-12} {3,4} {4,6} {5,14}", "Mã SV", "Họ tên", "Loại", "TC", "Điểm", "Học phí");
            foreach (IPrintable sv in danhSach)
                Console.WriteLine(sv.ToDisplayText());
        }

        static void Them()
        {
            Console.WriteLine("Loại sinh viên: 1. Chính quy   2. Liên thông   3. Văn bằng 2");
            int loai = NhapSoNguyen("Chọn loại: ");
            NguoiHoc sv;
            switch (loai)
            {
                case 1: sv = new SinhVienChinhQuy(); break;
                case 2: sv = new SinhVienLienThong(); break;
                case 3: sv = new SinhVienVanBang2(); break;
                default: Console.WriteLine("Loại không hợp lệ!"); return;
            }

            Console.Write("Mã SV: ");
            string ma = Console.ReadLine().Trim();
            if (ma == "" || ds.Any(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Mã SV rỗng hoặc đã tồn tại.");
                return;
            }
            try
            {
                sv.MaSV = ma;
                Console.Write("Họ tên: ");
                sv.HoTen = Console.ReadLine();
                sv.SoTinChi = NhapSoNguyen("Số tín chỉ: ");
                sv.DiemTB = NhapSoThuc("Điểm TB: ");
                ds.Add(sv);
                Console.WriteLine("Đã thêm {0} ({1}), học phí {2:N0} đ.", sv.HoTen, sv.LoaiSinhVien, sv.TinhHocPhi());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Không thêm được: " + ex.Message);
            }
        }

        static void TimKiem()
        {
            Console.WriteLine("1. Theo mã SV   2. Theo tên (gần đúng)   3. Theo loại");
            int chon = NhapSoNguyen("Chọn: ");
            List<NguoiHoc> ketQua;
            if (chon == 1)
            {
                Console.Write("Mã SV: ");
                string ma = Console.ReadLine().Trim();
                ketQua = ds.Where(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else if (chon == 2)
            {
                Console.Write("Từ khóa: ");
                string tuKhoa = Console.ReadLine().Trim().ToLower();
                ketQua = ds.Where(x => x.HoTen.ToLower().Contains(tuKhoa)).ToList();
            }
            else if (chon == 3)
            {
                Console.WriteLine("1. Chính quy   2. Liên thông   3. Văn bằng 2");
                int loai = NhapSoNguyen("Chọn loại: ");
                if (loai == 1) ketQua = ds.OfType<SinhVienChinhQuy>().Cast<NguoiHoc>().ToList();
                else if (loai == 2) ketQua = ds.OfType<SinhVienLienThong>().Cast<NguoiHoc>().ToList();
                else if (loai == 3) ketQua = ds.OfType<SinhVienVanBang2>().Cast<NguoiHoc>().ToList();
                else
                {
                    Console.WriteLine("Loại không hợp lệ!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                return;
            }

            if (ketQua.Count == 0) Console.WriteLine("Không tìm thấy.");
            else HienThi(ketQua);
        }

        static void ThongKe()
        {
            Console.WriteLine("{0,-12} {1,8} {2,10} {3,16}", "Loại", "Số SV", "Điểm TB", "Tổng học phí");
            foreach (var nhom in ds.GroupBy(x => x.LoaiSinhVien))
            {
                Console.WriteLine("{0,-12} {1,8} {2,10:N2} {3,16:N0}",
                    nhom.Key, nhom.Count(), nhom.Average(x => x.DiemTB), nhom.Sum(x => x.TinhHocPhi()));
            }
            Console.WriteLine("{0,-12} {1,8} {2,10:N2} {3,16:N0}",
                "Tất cả", ds.Count, ds.Average(x => x.DiemTB), ds.Sum(x => x.TinhHocPhi()));
        }

        static void XuatDuLieu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("MaSV,HoTen,Loai,SoTinChi,DiemTB,HocPhi");
            foreach (IExportable sv in ds)
                sb.AppendLine(sv.ToCsv());

            Console.Write(sb.ToString());
            string duongDan = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DanhSachSinhVien.csv");
            try
            {
                File.WriteAllText(duongDan, sb.ToString(), new UTF8Encoding(true));
                Console.WriteLine("Đã xuất {0} sinh viên ra tệp: {1}", ds.Count, duongDan);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Không ghi được tệp: " + ex.Message);
            }
        }

        static int NhapSoNguyen(string thongBao)
        {
            int so;
            while (true)
            {
                Console.Write(thongBao);
                if (int.TryParse(Console.ReadLine(), out so)) return so;
                Console.WriteLine("Vui lòng nhập số nguyên!");
            }
        }

        static double NhapSoThuc(string thongBao)
        {
            double so;
            while (true)
            {
                Console.Write(thongBao);
                if (double.TryParse(Console.ReadLine(), out so)) return so;
                Console.WriteLine("Vui lòng nhập số!");
            }
        }
    }
}
