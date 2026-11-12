namespace Lab03_OOPAdvanced
{
    internal class SinhVienChinhQuy : NguoiHoc
    {
        public override string LoaiSinhVien
        {
            get { return "Chính quy"; }
        }

        public override decimal TinhHocPhi()
        {
            return SoTinChi * 450000m;
        }
    }
}
