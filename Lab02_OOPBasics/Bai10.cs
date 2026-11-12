using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lab02_OOPBasics
{
    internal class Bai10
    {
        static List<SinhVien> ds = new List<SinhVien>();

        public static void chay()
        {
            if (ds.Count == 0) TaoDuLieuMau();

            int luaChon;
            do
            {
                Console.WriteLine("\n===== QUẢN LÝ SINH VIÊN =====");
                Console.WriteLine("1. Hiển thị danh sách");
                Console.WriteLine("2. Thêm sinh viên");
                Console.WriteLine("3. Sửa sinh viên");
                Console.WriteLine("4. Xóa sinh viên");
                Console.WriteLine("5. Tìm kiếm");
                Console.WriteLine("6. Sắp xếp");
                Console.WriteLine("7. Thống kê");
                Console.WriteLine("0. Quay lại menu chính");
                luaChon = NhapSoNguyen("Nhập lựa chọn: ");

                switch (luaChon)
                {
                    case 1: HienThiDanhSach(ds); break;
                    case 2: Them(); break;
                    case 3: Sua(); break;
                    case 4: Xoa(); break;
                    case 5: TimKiem(); break;
                    case 6: SapXep(); break;
                    case 7: ThongKe(); break;
                    case 0: break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            } while (luaChon != 0);
        }

        static void TaoDuLieuMau()
        {
            ds.Add(new SinhVien("SV001", "Trần Thị Mai", new DateTime(2005, 3, 15), 7.0));
            ds.Add(new SinhVien("SV002", "Nguyễn Văn An", new DateTime(2005, 8, 20), 9.2));
            ds.Add(new SinhVien("SV003", "Lê Văn Cường", new DateTime(2004, 12, 1), 5.5));
            ds.Add(new SinhVien("SV004", "Phạm Thị Dung", new DateTime(2003, 6, 10), 8.1));
            ds.Add(new SinhVien("SV005", "Hoàng Văn Bảo", new DateTime(2005, 1, 25), 3.8));
        }

        static void HienThiDanhSach(List<SinhVien> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }
            Console.WriteLine("{0,-4} {1,-8} {2,-18} {3,-11} {4,5} {5,6}  {6}", "STT", "Mã SV", "Họ tên", "Ngày sinh", "Tuổi", "Điểm", "Xếp loại");
            for (int i = 0; i < danhSach.Count; i++)
            {
                SinhVien sv = danhSach[i];
                Console.WriteLine("{0,-4} {1,-8} {2,-18} {3,-11:dd/MM/yyyy} {4,5} {5,6:N2}  {6}",
                    i + 1, sv.MaSV, sv.HoTen, sv.NgaySinh, sv.TinhTuoi(), sv.DiemTB, sv.XepLoai());
            }
        }

        static SinhVien TimTheoMa(string ma)
        {
            return ds.Find(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase));
        }

        static void Them()
        {
            Console.Write("Mã SV: ");
            string ma = Console.ReadLine().Trim();
            if (ma == "")
            {
                Console.WriteLine("Mã SV không được rỗng.");
                return;
            }
            if (TimTheoMa(ma) != null)
            {
                Console.WriteLine("Mã SV đã tồn tại.");
                return;
            }
            try
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = ma;
                Console.Write("Họ tên: ");
                sv.HoTen = Console.ReadLine();
                sv.NgaySinh = NhapNgay("Ngày sinh (dd/MM/yyyy): ");
                sv.DiemTB = NhapSoThuc("Điểm TB: ");
                ds.Add(sv);
                Console.WriteLine("Đã thêm sinh viên.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Không thêm được: " + ex.Message);
            }
        }

        static void Sua()
        {
            Console.Write("Nhập mã SV cần sửa: ");
            SinhVien sv = TimTheoMa(Console.ReadLine().Trim());
            if (sv == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên.");
                return;
            }
            Console.WriteLine("Để trống nếu muốn giữ nguyên giá trị cũ.");
            try
            {
                Console.Write("Họ tên [{0}]: ", sv.HoTen);
                string hoTen = Console.ReadLine();
                if (hoTen.Trim() != "") sv.HoTen = hoTen;

                Console.Write("Ngày sinh [{0:dd/MM/yyyy}]: ", sv.NgaySinh);
                string ngay = Console.ReadLine().Trim();
                if (ngay != "")
                {
                    DateTime ngaySinh;
                    if (DateTime.TryParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                        sv.NgaySinh = ngaySinh;
                    else
                        Console.WriteLine("Ngày sinh không hợp lệ, giữ nguyên giá trị cũ.");
                }

                Console.Write("Điểm TB [{0:N2}]: ", sv.DiemTB);
                string diem = Console.ReadLine().Trim();
                if (diem != "")
                {
                    double diemTB;
                    if (double.TryParse(diem, out diemTB))
                        sv.DiemTB = diemTB;
                    else
                        Console.WriteLine("Điểm không hợp lệ, giữ nguyên giá trị cũ.");
                }
                Console.WriteLine("Đã cập nhật sinh viên.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Không sửa được: " + ex.Message);
            }
        }

        static void Xoa()
        {
            Console.Write("Nhập mã SV cần xóa: ");
            SinhVien sv = TimTheoMa(Console.ReadLine().Trim());
            if (sv == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên.");
                return;
            }
            Console.Write("Xác nhận xóa {0} - {1} (y/n): ", sv.MaSV, sv.HoTen);
            if (Console.ReadLine().Trim().ToLower() == "y")
            {
                ds.Remove(sv);
                Console.WriteLine("Đã xóa.");
            }
            else
            {
                Console.WriteLine("Đã hủy.");
            }
        }

        static void TimKiem()
        {
            Console.WriteLine("1. Tìm theo mã SV");
            Console.WriteLine("2. Tìm theo tên (gần đúng)");
            int chon = NhapSoNguyen("Chọn: ");
            if (chon == 1)
            {
                Console.Write("Mã SV: ");
                SinhVien sv = TimTheoMa(Console.ReadLine().Trim());
                if (sv == null) Console.WriteLine("Không tìm thấy.");
                else HienThiDanhSach(new List<SinhVien> { sv });
            }
            else if (chon == 2)
            {
                Console.Write("Từ khóa: ");
                string tuKhoa = Console.ReadLine().Trim().ToLower();
                List<SinhVien> ketQua = ds.Where(x => x.HoTen.ToLower().Contains(tuKhoa)).ToList();
                if (ketQua.Count == 0) Console.WriteLine("Không tìm thấy.");
                else HienThiDanhSach(ketQua);
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
            }
        }

        static void SapXep()
        {
            Console.WriteLine("1. Theo điểm TB giảm dần");
            Console.WriteLine("2. Theo tên A -> Z");
            Console.WriteLine("3. Theo mã SV");
            int chon = NhapSoNguyen("Chọn: ");
            CultureInfo vi = new CultureInfo("vi-VN");
            switch (chon)
            {
                case 1:
                    ds.Sort((a, b) => b.DiemTB.CompareTo(a.DiemTB));
                    break;
                case 2:
                    ds.Sort((a, b) =>
                    {
                        int kq = string.Compare(LayTen(a.HoTen), LayTen(b.HoTen), vi, CompareOptions.None);
                        return kq != 0 ? kq : string.Compare(a.HoTen, b.HoTen, vi, CompareOptions.None);
                    });
                    break;
                case 3:
                    ds.Sort((a, b) => string.Compare(a.MaSV, b.MaSV, StringComparison.OrdinalIgnoreCase));
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }
            HienThiDanhSach(ds);
        }

        static string LayTen(string hoTen)
        {
            string[] tu = hoTen.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return tu[tu.Length - 1];
        }

        static void ThongKe()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }
            SinhVien caoNhat = ds.OrderByDescending(x => x.DiemTB).First();
            SinhVien thapNhat = ds.OrderBy(x => x.DiemTB).First();
            Console.WriteLine("Tổng số sinh viên : {0}", ds.Count);
            Console.WriteLine("Điểm TB cả lớp    : {0:N2}", ds.Average(x => x.DiemTB));
            Console.WriteLine("Điểm cao nhất     : {0:N2} ({1})", caoNhat.DiemTB, caoNhat.HoTen);
            Console.WriteLine("Điểm thấp nhất    : {0:N2} ({1})", thapNhat.DiemTB, thapNhat.HoTen);
            Console.WriteLine("Số lượng theo xếp loại:");
            string[] cacLoai = { "Xuất sắc", "Giỏi", "Khá", "Trung bình", "Yếu" };
            foreach (string loai in cacLoai)
            {
                Console.WriteLine("  - {0,-10}: {1}", loai, ds.Count(x => x.XepLoai() == loai));
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

        static DateTime NhapNgay(string thongBao)
        {
            DateTime ngay;
            while (true)
            {
                Console.Write(thongBao);
                if (DateTime.TryParseExact(Console.ReadLine().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngay)
                    && ngay < DateTime.Today)
                    return ngay;
                Console.WriteLine("Ngày không hợp lệ, nhập lại theo dạng dd/MM/yyyy!");
            }
        }
    }
}
