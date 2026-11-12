using System;

namespace Lab02_OOPBasics
{
    internal class HinhChuNhat
    {
        private double _chieuDai;
        private double _chieuRong;

        public double ChieuDai
        {
            get { return _chieuDai; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Chiều dài phải là số dương.");
                _chieuDai = value;
            }
        }

        public double ChieuRong
        {
            get { return _chieuRong; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Chiều rộng phải là số dương.");
                _chieuRong = value;
            }
        }

        public HinhChuNhat() : this(1, 1)
        {
        }

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public double ChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }

        public double DienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public void HienThi()
        {
            Console.WriteLine("Dài = {0:N2}, Rộng = {1:N2} => Chu vi = {2:N2}, Diện tích = {3:N2}", ChieuDai, ChieuRong, ChuVi(), DienTich());
        }
    }
}
