LAB 9 - DOC, TIM KIEM VA LOC DU LIEU BANG DATAREADER (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
=============================================================

0. Moi truong
   - MySQL Server 8.0 (thay SQL Server, da duoc giang vien dong y), instance MySQL80, localhost:3306.
   - Thu vien MySql.Data (NuGet): SqlDataReader -> MySqlDataReader, SqlCommand -> MySqlCommand.

1. Chuan bi CSDL
   - Chay lan luot: Lab07_QLSinhVien.sql, Lab08_QLSinhVien.sql, roi SQL\Lab09_QLSinhVien.sql.
   - Lab09_QLSinhVien.sql them 22 sinh vien (tong 32 sinh vien = 4 trang, moi trang 10 dong).
     Chay lai khong bi trung (INSERT IGNORE).

2. Cach chay
   - Mo IT3212_Labs.sln, chuot phai Lab09_DataReaderSearch > Set as Startup Project, nhan Ctrl+F5.
   - Lan dau mo neu thieu thu vien: chuot phai Solution > Restore NuGet Packages.
   - Chuoi ket noi nam trong App.config (ten QLSinhVien), tai khoan lab7_app.

3. Giao dien (frmTraCuu)
   - Bo loc: ma SV, ho ten, khoa (co "Tat ca"), gioi tinh, khoang diem, khoang tuoi, sap xep.
     Bo trong o nao thi khong loc theo o do.
   - DataGridView (mot trang 10 dong) + nut "< Truoc", "Sau >".
   - Vung "Thong tin chi tiet" cua dong dang chon, thanh trang thai o duoi.
   - Nut "Xuat CSV" xuat dung cac dong dang hien thi.

4. Du lieu thu
   Bai 1 : mo form -> 32 sinh vien, trang 1/4, kem ten khoa
   Bai 2 : ho ten "thi" -> cac sinh vien co chu "thi" trong ten
   Bai 3 : khoa Cong Nghe Thong Tin, diem 7 den 10
   Bai 4 : bam "Sau >" -> trang 2/4 ... trang 4/4 con 2 dong
   Bai 5 : chon mot dong -> vung chi tiet cap nhat, thanh trang thai "Dang chon: ..."
   Bai 6 : ho ten "van" + khoa O To + Nam + diem 5 den 9 -> 3 sinh vien ; diem "abc" -> bao loi
   Bai 7 : sap xep Diem TB giam dan / tang dan (chi cho chon cot trong danh sach co san)
   Bai 8 : tuoi tu 20 den 21 (tinh tuoi chinh xac theo ngay sinh)
   Bai 9 : ngay dd/MM/yyyy, diem 2 so le, tieu de tieng Viet; diem < 5 to hong, diem >= 8 to xanh
   Bai 10: loc khoa Du Lich -> Xuat CSV -> 8 dong, tieng Viet UTF-8

5. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab9.docx (kem anh chup ket qua tung bai).
