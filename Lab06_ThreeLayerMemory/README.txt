LAB 6 - DATAGRIDVIEW, LISTVIEW, TREEVIEW VA MO HINH 3 LOP CHUA KET NOI CSDL (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
=============================================================

1. Cach chay
   - Mo IT3212_Labs.sln bang Visual Studio 2022.
   - Chuot phai project Lab06_ThreeLayerMemory > Set as Startup Project.
   - Nhan Ctrl+F5. Form chinh frmMain hien ra, moi nut mo form cua mot bai.
   - O Diem TB go dau phay hoac dau cham deu duoc (vd: 8,5 hoac 8.5).
   - O Don gia nhap so nguyen (vd: 1290000).
   - Du lieu sinh vien luu o tep bin\Debug\sinhvien.csv. Muon quay ve du lieu mau
     thi xoa tep nay roi chay lai.

2. Cau truc ma nguon (moi thu muc la mot namespace)
   - DTO\SinhVien.cs, Khoa.cs, SanPham.cs : lop du lieu
   - DAL\SinhVienDAL.cs   : giu danh sach sinh vien trong bo nho, luu/doc CSV (Bai 9)
     DAL\KhoaDAL.cs       : danh sach 3 khoa
     DAL\SanPhamDAL.cs    : danh sach san pham
   - BUS\SinhVienBUS.cs   : kiem tra trung ma, thieu du lieu; tim kiem, loc, nhom theo khoa
     BUS\SanPhamBUS.cs    : kiem tra, tim kiem, sap xep, tong gia tri ton
   - GUI\frmMain          : form chinh
     GUI\frmSinhVien      : Bai 1, 2, 5 - DataGridView + BindingList, them/sua/xoa qua BUS
     GUI\frmListView      : Bai 3, 8 - ListView Details/LargeIcon + ImageList
     GUI\frmCayKhoa       : Bai 4 - TreeView Khoa - Sinh vien
     GUI\frmSanPham       : Bai 6 - quan ly san pham
     GUI\frmDanhMuc       : Bai 7 - TreeView danh muc + ContextMenuStrip
   - Luong goi: Form (GUI) -> BUS -> DAL. Form khong thao tac truc tiep voi danh sach (Bai 10).

3. Du lieu thu
   Du lieu mau: 3 khoa (CNTT, Kinh te, Ngon ngu Anh), moi khoa 3 sinh vien; 6 san pham.
   Bai 1 : mo form Sinh vien -> 9 dong, tieu de cot tieng Viet
   Bai 2 : them 24000480 Tran Van Nam, diem 7,5 -> 10 dong
           chon 24000480, sua diem 9,3, khoa Ngon ngu Anh -> dong duoc cap nhat
           chon 24000472, Xoa, Yes -> con 9 dong ; tim "binh" -> 2 ket qua
   Bai 3 : ListView 5 cot; chon dong -> hien chi tiet; loc "Ngon ngu Anh" -> 4 sinh vien
   Bai 4 : chon 24000468 - Pham Thu Ha -> hien chi tiet ; chon node Kinh te -> so sinh vien
   Bai 5 : them trung ma 24000465 -> bao trung ; ho ten rong -> bao loi ; diem 12 -> bao loi
   Bai 6 : tong ban dau 321.460.000 d ; them SP07 Ban phim co AKKO 3087 1290000 x 12
           sua SP03 so luong 6 ; xoa SP02 -> tong 293.000.000 d ; tim "laptop" -> 2 ket qua
           sap xep "Gia tri ton giam dan" ; don gia "abc" -> bao loi
   Bai 7 : chuot phai vao cay -> menu Them danh muc / Them san pham / Doi ten / Xoa
           (F2 = doi ten, Delete = xoa)
   Bai 8 : ListView co bieu tuong XS, G, K, TB, Y theo xep loai; doi sang "Bieu tuong lon"
   Bai 9 : sau khi them/sua/xoa, tat chuong trinh roi mo lai -> du lieu doc lai tu sinhvien.csv

4. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab6.docx (kem anh chup ket qua tung bai).
