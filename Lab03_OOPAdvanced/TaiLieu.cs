using System;

namespace Lab03_OOPAdvanced
{
    internal abstract class TaiLieu : IPrintable
    {
        private string _tieuDe;

        public string MaTaiLieu { get; private set; }
        public string TacGia { get; private set; }
        public int NamXuatBan { get; private set; }

        public string TieuDe
        {
            get { return _tieuDe; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tiêu đề không được rỗng.");
                _tieuDe = value.Trim();
            }
        }

        protected TaiLieu(string maTaiLieu, string tieuDe, string tacGia, int namXuatBan)
        {
            if (namXuatBan < 1900 || namXuatBan > DateTime.Today.Year)
                throw new ArgumentException("Năm xuất bản không hợp lệ.");
            MaTaiLieu = maTaiLieu;
            TieuDe = tieuDe;
            TacGia = tacGia;
            NamXuatBan = namXuatBan;
        }

        public abstract string LoaiTaiLieu { get; }

        protected abstract string ThongTinRieng();

        public string ToDisplayText()
        {
            return string.Format("[{0}] {1} - {2} - {3} ({4}) | {5}",
                LoaiTaiLieu, MaTaiLieu, TieuDe, TacGia, NamXuatBan, ThongTinRieng());
        }
    }
}
