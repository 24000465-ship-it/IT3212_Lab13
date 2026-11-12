LAB 3 - KE THUA, DA HINH, LOP TRUU TUONG VA INTERFACE (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
=============================================================

1. Cach chay
   - Mo IT3212_Labs.sln bang Visual Studio 2022.
   - Chuot phai project Lab03_OOPAdvanced > Set as Startup Project.
   - Nhan Ctrl+F5 de chay (hoac F5 de debug).
   - Tai menu chinh, nhap so 1..10 de chay bai tuong ung, nhap 0 de thoat.
   - Luu y: may dat dinh dang Viet Nam thi so thap phan nhap bang dau phay (vd: 8,4).

2. Cau truc ma nguon (Lab03_OOPAdvanced)
   - Nguoi.cs, SinhVien.cs            : Bai 1, 2, 4 (ke thua, virtual/override, interface)
   - IValidatable.cs, IPrintable.cs   : Bai 4
   - NguoiHoc.cs (abstract), SinhVienChinhQuy.cs, SinhVienLienThong.cs,
     SinhVienVanBang2.cs, IExportable.cs : Bai 3, 5, 10
   - NhanVien.cs (abstract), NhanVienVanPhong.cs, NhanVienKinhDoanh.cs, GiangVien.cs : Bai 6
   - IMove.cs, XeMay.cs, OTo.cs, XeDap.cs                     : Bai 7
   - TaiLieu.cs (abstract), Sach.cs, TapChi.cs, LuanVan.cs     : Bai 8
   - IPayment.cs, ThanhToanTienMat.cs, ChuyenKhoan.cs, ViDienTu.cs, GiaoDich.cs : Bai 9
   - Bai1.cs ... Bai10.cs : chuong trinh chay thu tung bai
   - Program.cs           : menu chinh

3. Du lieu thu
   Bai 1 : SinhVien("SV001", "Le Duc Binh", 25/04/2006, 9,5) -> goi base(ten, ngaySinh)
   Bai 2 : MoTa() cua SinhVien = base.MoTa() + ma SV + diem
   Bai 3 : Chinh quy 18 TC x 450.000 = 8.100.000 ; Lien thong 15 TC x 520.000 = 7.800.000
   Bai 4 : 4 sinh vien, 2 hop le, 1 thieu ma, 1 ngay sinh o tuong lai
   Bai 5 : List<NguoiHoc> 4 sinh vien, tong hoc phi 31.140.000
   Bai 6 : 5 nhan vien (van phong, kinh doanh, giang vien), tong quy luong 47.763.800
   Bai 7 : quang duong 30 km ; 120 km ; nhap chu / so am -> nhap lai
   Bai 8 : 5 tai lieu ; tim "tap chi" -> 2 ket qua ; tim "xyz" -> khong tim thay
   Bai 9 : 8 giao dich (tien mat, chuyen khoan, vi MoMo), 3 thanh cong, 5 bi tu choi
   Bai 10: du lieu mau 5 sinh vien (3 loai)
           Them SV006 - Ngo Thi Hoa - Van bang 2 - 16 TC - 8,4
           Tim theo loai "Lien thong", theo ten "thi", theo ma "sv004"
           Thong ke theo loai ; xuat CSV ra tep DanhSachSinhVien.csv (canh file .exe)

4. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab3.docx (kem anh chup ket qua tung bai).
