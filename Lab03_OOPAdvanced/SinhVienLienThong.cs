namespace Lab03_OOPAdvanced
{
    internal class SinhVienLienThong : NguoiHoc
    {
        public override string LoaiSinhVien
        {
            get { return "Liên thông"; }
        }

        public override decimal TinhHocPhi()
        {
            return SoTinChi * 520000m;
        }
    }
}
