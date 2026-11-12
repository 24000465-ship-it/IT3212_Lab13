LAB 8 - MYSQLCOMMAND, MYSQLPARAMETER VA CAC PHUONG THUC THUC THI (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
=============================================================

0. Moi truong
   - MySQL Server 8.0 (thay SQL Server, da duoc giang vien dong y), instance MySQL80, localhost:3306.
   - Thu vien: MySql.Data (NuGet). Ten lop doi tuong ung: SqlCommand -> MySqlCommand,
     SqlParameter -> MySqlParameter, SqlDbType -> MySqlDbType, SqlDataReader -> MySqlDataReader.

1. Chuan bi CSDL
   - Chay Lab07_QLSinhVien.sql (Lab 7) de co database qlsinhvien va tai khoan lab7_app.
   - Mo MySQL Workbench bang tai khoan root, chay SQL\Lab08_QLSinhVien.sql:
     + them khoa OTO chua co sinh vien (de thu MAX tra ve NULL o Bai 7)
     + tao thu tuc sp_SinhVien_TheoKhoa (Bai 5) va sp_SinhVien_Them co tham so OUTPUT (Bai 9)
     + cap quyen EXECUTE cho lab7_app
   - File chay lai nhieu lan van khong loi (DROP PROCEDURE IF EXISTS, INSERT IGNORE).

2. Cach chay
   - Mo IT3212_Labs.sln, chuot phai Lab08_SqlCommand > Set as Startup Project, nhan Ctrl+F5.
   - Lan dau mo neu thieu thu vien: chuot phai Solution > Restore NuGet Packages.
   - Chuoi ket noi nam trong App.config (ten QLSinhVien), doc bang lop DbConnectionFactory (tu Lab 7).
   - O Diem TB go dau phay hoac dau cham deu duoc (8,5 hoac 8.5).

3. Cau truc ma nguon (Lab08_SqlCommand)
   - Form1.cs        : Bai 1 (ExecuteScalar dem sinh vien), Bai 2 (ExecuteReader doc danh sach vao ListBox)
   - frmSinhVien.cs  : Bai 3 (them bang tham so), Bai 4 (cap nhat diem), Bai 6 (tim theo ma),
                       Bai 8 (xoa co xac nhan, bat loi khoa ngoai), Bai 9 (them bang thu tuc, OUTPUT)
   - frmTheoKhoa.cs  : Bai 5 (goi sp_SinhVien_TheoKhoa), Bai 7 (MAX(DiemTB) theo khoa, xu ly NULL)
   - SqlHelper.cs    : Bai 10 - ExecuteScalar, ExecuteNonQuery, ExecuteReader, ExecuteDataTable,
                       luon giai phong ket noi (using, CommandBehavior.CloseConnection)
   - DbConnectionFactory.cs, App.config : ket noi (Lab 7)

4. Du lieu thu
   Bai 1 : Dem sinh vien -> 10
   Bai 2 : Doc danh sach -> 10 dong, sap theo HoTen
   Bai 3 : them SV011 Ly Thi Mai, Du Lich, 8,3 -> "Da them 1 ban ghi"
           them lai SV011 -> loi 1062 ; diem 12 -> bao diem phai tu 0 den 10
   Bai 4 : SV011 diem 9,1 -> "Cap nhat thanh cong" ; SV999 -> "Khong tim thay ma"
   Bai 5 : khoa Cong Nghe Thong Tin -> 4 sinh vien
   Bai 6 : SV003 -> hien chi tiet ; SV999 -> "Khong tim thay"
   Bai 7 : CNTT -> 9,00 ; Cong Nghe Ky Thuat O To -> chua co sinh vien (MAX tra ve NULL)
   Bai 8 : xoa SV001 -> loi khoa ngoai (con dang ky hoc phan) ; xoa SV011 -> da xoa
   Bai 9 : them SV012 bang thu tuc -> so sinh vien hien tai (OUTPUT) = 11
   (Sau khi chup anh, du lieu thu SV011, SV012 da duoc xoa, CSDL tro ve 10 sinh vien.)

5. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab8.docx (kem anh chup ket qua tung bai).
