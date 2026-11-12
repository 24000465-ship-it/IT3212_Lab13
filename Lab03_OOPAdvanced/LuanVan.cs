namespace Lab03_OOPAdvanced
{
    internal class LuanVan : TaiLieu
    {
        public string Truong { get; private set; }
        public string NguoiHuongDan { get; private set; }

        public LuanVan(string ma, string tieuDe, string tacGia, int nam, string truong, string nguoiHuongDan)
            : base(ma, tieuDe, tacGia, nam)
        {
            Truong = truong;
            NguoiHuongDan = nguoiHuongDan;
        }

        public override string LoaiTaiLieu
        {
            get { return "Luận văn"; }
        }

        protected override string ThongTinRieng()
        {
            return Truong + ", GVHD: " + NguoiHuongDan;
        }
    }
}
