LAB 10 - DATAADAPTER, DATATABLE, DATASET VA DU LIEU NGAT KET NOI (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
=========================================================================

0. Moi truong
   - MySQL Server 8.0 (thay SQL Server, da duoc giang vien dong y), instance MySQL80, localhost:3306.
   - Thu vien MySql.Data (NuGet): SqlDataAdapter -> MySqlDataAdapter, SqlCommandBuilder -> MySqlCommandBuilder.

1. Chuan bi CSDL
   - Dung lai CSDL qlsinhvien cua cac lab truoc (chay Lab07, Lab08, Lab09 _QLSinhVien.sql neu chua co).
   - Lab nay khong can them du lieu moi.
   - Sao luu truoc khi thu Bai 5 (cap nhat that vao CSDL):
     mysqldump -u root -p qlsinhvien > qlsinhvien_backup.sql

2. Cach chay
   - Mo IT3212_Labs.sln, chuot phai Lab10_DisconnectedData > Set as Startup Project, nhan Ctrl+F5.
   - Lan dau mo neu thieu thu vien: chuot phai Solution > Restore NuGet Packages.
   - Chuoi ket noi nam trong App.config (ten QLSinhVien), tai khoan lab7_app.
   - Form chinh frmMain co 5 nut mo cac form bai tap.

3. Cac form
   - frmKhoaSinhVien : Bai 1 - 4 (Fill DataTable, DataSet 2 bang, DataRelation, DataView)
   - frmCapNhat      : Bai 5, 7, 8 (MySqlCommandBuilder + Update, RowState/GetChanges, AcceptChanges/RejectChanges)
   - frmBangDiem     : Bai 6 (DataTable tao bang code, cot tinh XepLoai bang Expression)
   - frmXml          : Bai 9 (WriteXml kem schema, ReadXml khong can ket noi)
   - frmHopNhat      : Bai 10 (Merge hai DataTable, xu ly trung khoa)

4. Du lieu thu
   Bai 1 : bam "Bai 1: Fill DataTable" -> 32 dong, 7 cot
   Bai 2 : bam "Bai 2: Nap DataSet" -> Khoa 4 dong, SinhVien 32 dong
   Bai 3 : chon khoa OTO -> 6 sinh vien con (GetChildRows)
   Bai 4 : khoa Cong Nghe Thong Tin, diem tu 7 -> 6 sinh vien, diem giam dan
   Bai 5 : sua diem SV032 thanh 6.90 + them SV033 -> Luu -> "Da cap nhat 2 thay doi"
           diem 11 -> bao loi CHECK CK_SinhVien_Diem
   Bai 6 : them SV005 diem 9,2 -> Gioi ; them trung ma SV001 -> bao trung ma
   Bai 7 : sua 1 dong, them 1 dong, xoa 1 dong -> Added 1, Modified 1, Deleted 1
   Bai 8 : Hoan tac -> du lieu tro ve nhu luc nap ; Chap nhan cuc bo -> bam Luu khong gui gi ve CSDL
   Bai 9 : Nap tu CSDL -> Ghi XML -> dong form, mo lai -> Doc XML (khong ket noi CSDL)
   Bai 10: Tao hai nguon -> Merge co khoa chinh: 8 dong ; bo khoa chinh: 10 dong (trung SV001, SV002)

   Sau khi thu Bai 5 da xoa SV033 va tra diem SV032 ve 6.40, CSDL giong ban sao luu.

5. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab10.docx (kem anh chup ket qua tung bai).
