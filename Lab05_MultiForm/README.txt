LAB 5 - XU LY SU KIEN, KIEM TRA DU LIEU VA UNG DUNG DA FORM (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
=============================================================

1. Cach chay
   - Mo IT3212_Labs.sln bang Visual Studio 2022.
   - Chuot phai project Lab05_MultiForm > Set as Startup Project.
   - Nhan Ctrl+F5. Form Dang nhap hien truoc, dang nhap bang: admin / 123456
   - Dang nhap dung se mo form chinh frmMain (menu + thanh trang thai + dong ho).
   - O Diem TB nhap dau CHAM thap phan (vd: 8.5).

2. Cau truc ma nguon (Lab05_MultiForm)
   - Program.cs              : mo frmDangNhap, dung thi mo frmMain(tenDangNhap)
   - frmDangNhap.cs          : Bai 6 - sai 3 lan khoa nut dang nhap 30 giay (Timer dem nguoc)
   - frmMain.cs              : Bai 5, 9, 10 - form MDI, MenuStrip, StatusStrip, dong ho,
                               mo form con khong trung, hoi xac nhan khi dong (FormClosing)
   - frmSinhVien.cs          : Bai 1, 2, 3, 4, 7, 8 - nhap sinh vien, ErrorProvider,
                               KeyPress o diem, TextChanged dung chung, luu danh sach
   - frmChiTietSinhVien.cs   : Bai 4 - nhan doi tuong SinhVien qua constructor
   - frmTimKiem.cs           : Bai 7 - tra tu khoa qua property + DialogResult
   - frmChonKhoa.cs          : Bai 8 - nhan danh sach khoa, tra khoa duoc chon
   - frmKhoa.cs              : Bai 10 - danh muc khoa (them, xoa)
   - frmGioiThieu.cs         : Bai 10 - gioi thieu ung dung
   - SinhVien.cs             : lop SinhVien (tu Lab 2, them gioi tinh, khoa, anh)

3. Du lieu thu
   Bai 1 : bam Luu khi trong -> dau bao loi canh Ma SV, Ho ten, Diem TB
   Bai 2 : go "a8.5.5x" vao o diem -> chi con "8.55"
   Bai 3 : diem 12 -> trang thai do "Kiem tra diem" ; diem 8.55 -> xanh "hop le"
   Luu   : 24000465 Le Duc Binh 8.55 ; 24000466 Tran Thi Mai 7.2 ;
           24000467 Nguyen Van Binh 6.4 ; 24000468 Pham Thu Ha 9.1 ; luu trung 24000465 -> bao loi
   Bai 4 : chon sinh vien trong danh sach > Xem chi tiet (hoac nhap dup)
   Bai 6 : sai mat khau 3 lan -> khoa 30 giay, dem nguoc tung giay
   Bai 7 : tim theo ten "binh" -> 2 ket qua ; theo ma "468" -> 1 ket qua ; de trong -> bao
   Bai 8 : bam "..." canh o Khoa, chon "Ngon ngu Anh" -> o Khoa doi theo
   Bai 9 : Thoat -> hoi xac nhan; No thi khong dong, Yes thi dong
   Bai 10: menu Danh muc > Sinh vien / Khoa (mo lai khong bi trung), He thong > Gioi thieu

4. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab5.docx (kem anh chup ket qua tung bai).
