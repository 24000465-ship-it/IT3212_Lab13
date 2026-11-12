namespace Lab03_OOPAdvanced
{
    internal class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; private set; }
        public int ThangPhatHanh { get; private set; }

        public TapChi(string ma, string tieuDe, string tacGia, int nam, int soPhatHanh, int thangPhatHanh)
            : base(ma, tieuDe, tacGia, nam)
        {
            SoPhatHanh = soPhatHanh;
            ThangPhatHanh = thangPhatHanh;
        }

        public override string LoaiTaiLieu
        {
            get { return "Tạp chí"; }
        }

        protected override string ThongTinRieng()
        {
            return "Số " + SoPhatHanh + ", tháng " + ThangPhatHanh;
        }
    }
}
