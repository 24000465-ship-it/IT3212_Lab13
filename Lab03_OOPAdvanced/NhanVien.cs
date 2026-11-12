using System;

namespace Lab03_OOPAdvanced
{
    internal abstract class NhanVien
    {
        private string _hoTen;
        private decimal _luongCoBan;

        public string MaNV { get; set; }

        public string HoTen
        {
            get { return _hoTen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Họ tên không được rỗng.");
                _hoTen = value.Trim();
            }
        }

        public decimal LuongCoBan
        {
            get { return _luongCoBan; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Lương cơ bản phải lớn hơn 0.");
                _luongCoBan = value;
            }
        }

        protected NhanVien(string maNV, string hoTen, decimal luongCoBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        public abstract string ChucVu { get; }

        public abstract decimal TinhLuong();

        public abstract string CongThuc();

        public virtual void HienThi()
        {
            Console.WriteLine("{0,-5} {1,-16} {2,-12} {3,14:N0}  {4}", MaNV, HoTen, ChucVu, TinhLuong(), CongThuc());
        }
    }
}
