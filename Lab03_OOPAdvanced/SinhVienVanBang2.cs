namespace Lab03_OOPAdvanced
{
    internal class SinhVienVanBang2 : NguoiHoc
    {
        public override string LoaiSinhVien
        {
            get { return "Văn bằng 2"; }
        }

        public override decimal TinhHocPhi()
        {
            return SoTinChi * 480000m + 1000000m;
        }
    }
}
