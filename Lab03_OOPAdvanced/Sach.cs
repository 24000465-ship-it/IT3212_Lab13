namespace Lab03_OOPAdvanced
{
    internal class Sach : TaiLieu
    {
        public string NhaXuatBan { get; private set; }
        public int SoTrang { get; private set; }

        public Sach(string ma, string tieuDe, string tacGia, int nam, string nhaXuatBan, int soTrang)
            : base(ma, tieuDe, tacGia, nam)
        {
            NhaXuatBan = nhaXuatBan;
            SoTrang = soTrang;
        }

        public override string LoaiTaiLieu
        {
            get { return "Sách"; }
        }

        protected override string ThongTinRieng()
        {
            return "NXB " + NhaXuatBan + ", " + SoTrang + " trang";
        }
    }
}
