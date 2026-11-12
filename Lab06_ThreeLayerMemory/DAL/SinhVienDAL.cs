using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.DAL
{
    public class SinhVienDAL
    {
        private static List<SinhVien> _data = null;

        public static string DuongDanFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sinhvien.csv");

        public SinhVienDAL()
        {
            if (_data == null)
            {
                _data = new List<SinhVien>();
                if (File.Exists(DuongDanFile))
                    DocFile();
                else
                {
                    TaoDuLieuMau();
                    LuuFile();
                }
            }
        }

        public List<SinhVien> GetAll()
        {
            return new List<SinhVien>(_data);
        }

        public SinhVien GetByMa(string maSV)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].MaSV == maSV) return _data[i];
            }
            return null;
        }

        public void Add(SinhVien sv)
        {
            _data.Add(sv);
            LuuFile();
        }

        public void Update(SinhVien sv)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].MaSV == sv.MaSV)
                {
                    _data[i] = sv;
                    break;
                }
            }
            LuuFile();
        }

        public void Delete(string maSV)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].MaSV == maSV)
                {
                    _data.RemoveAt(i);
                    break;
                }
            }
            LuuFile();
        }

        public void LuuFile()
        {
            List<string> dong = new List<string>();
            dong.Add("MaSV,HoTen,NgaySinh,GioiTinh,Khoa,DiemTB");
            for (int i = 0; i < _data.Count; i++)
            {
                SinhVien sv = _data[i];
                dong.Add(BoDauPhay(sv.MaSV) + "," + BoDauPhay(sv.HoTen) + "," + sv.NgaySinh.ToString("yyyy-MM-dd") + ","
                    + BoDauPhay(sv.GioiTinh) + "," + BoDauPhay(sv.Khoa) + "," + sv.DiemTB.ToString(CultureInfo.InvariantCulture));
            }
            File.WriteAllLines(DuongDanFile, dong.ToArray(), Encoding.UTF8);
        }

        private void DocFile()
        {
            string[] dong = File.ReadAllLines(DuongDanFile, Encoding.UTF8);
            for (int i = 1; i < dong.Length; i++)
            {
                string[] o = dong[i].Split(',');
                if (o.Length < 6) continue;
                try
                {
                    DateTime ngaySinh = DateTime.ParseExact(o[2], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    double diem = double.Parse(o[5], CultureInfo.InvariantCulture);
                    _data.Add(new SinhVien(o[0], o[1], ngaySinh, o[3], o[4], diem));
                }
                catch (Exception)
                {
                }
            }
        }

        private string BoDauPhay(string s)
        {
            if (s == null) return "";
            return s.Replace(",", " ");
        }

        private void TaoDuLieuMau()
        {
            _data.Add(new SinhVien("24000465", "Lê Đức Bình", new DateTime(2006, 4, 25), "Nam", "Công nghệ thông tin", 8.55));
            _data.Add(new SinhVien("24000466", "Trần Thị Mai", new DateTime(2005, 12, 30), "Nữ", "Công nghệ thông tin", 7.2));
            _data.Add(new SinhVien("24000470", "Hoàng Minh Đức", new DateTime(2006, 2, 11), "Nam", "Công nghệ thông tin", 9.2));
            _data.Add(new SinhVien("24000467", "Nguyễn Văn Bình", new DateTime(2006, 8, 2), "Nam", "Kinh tế", 6.4));
            _data.Add(new SinhVien("24000471", "Đỗ Thu Trang", new DateTime(2006, 6, 19), "Nữ", "Kinh tế", 8.1));
            _data.Add(new SinhVien("24000472", "Vũ Quang Huy", new DateTime(2005, 10, 7), "Nam", "Kinh tế", 4.5));
            _data.Add(new SinhVien("24000468", "Phạm Thu Hà", new DateTime(2005, 3, 14), "Nữ", "Ngôn ngữ Anh", 9.1));
            _data.Add(new SinhVien("24000473", "Bùi Ngọc Lan", new DateTime(2006, 1, 22), "Nữ", "Ngôn ngữ Anh", 7.8));
            _data.Add(new SinhVien("24000474", "Ngô Gia Bảo", new DateTime(2006, 9, 5), "Nam", "Ngôn ngữ Anh", 5.6));
        }
    }
}
