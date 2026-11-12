using System;

namespace Lab03_OOPAdvanced
{
    internal abstract class NguoiHoc : IPrintable, IExportable
    {
        private string _hoTen;
        private int _soTinChi;
        private double _diemTB;

        public string MaSV { get; set; }

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

        public int SoTinChi
        {
            get { return _soTinChi; }
            set
            {
                if (value < 0 || value > 40)
                    throw new ArgumentException("Số tín chỉ phải từ 0 đến 40.");
                _soTinChi = value;
            }
        }

        public double DiemTB
        {
            get { return _diemTB; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Điểm TB phải từ 0 đến 10.");
                _diemTB = value;
            }
        }

        public abstract string LoaiSinhVien { get; }

        public abstract decimal TinhHocPhi();

        public virtual string ToDisplayText()
        {
            return string.Format("{0,-6} {1,-16} {2,-12} {3,4} {4,6:N2} {5,14:N0}",
                MaSV, HoTen, LoaiSinhVien, SoTinChi, DiemTB, TinhHocPhi());
        }

        public string ToCsv()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}",
                MaSV, HoTen, LoaiSinhVien, SoTinChi, DiemTB.ToString(System.Globalization.CultureInfo.InvariantCulture), TinhHocPhi());
        }
    }
}
