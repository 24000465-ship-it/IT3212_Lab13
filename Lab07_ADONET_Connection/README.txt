LAB 7 - TAO CSDL, TONG QUAN ADO.NET VA KET NOI CSDL (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
=============================================================

0. He quan tri CSDL
   - Dung MySQL Server 8.0 thay cho SQL Server (da duoc giang vien dong y).
   - Instance: MySQL80 (dich vu Windows ten MySQL80), may chu localhost, cong 3306.
   - Cong cu thao tac: MySQL Workbench 8.0 (thay cho SSMS).
   - Thu vien ket noi C#: MySql.Data (NuGet, cua Oracle) thay cho System.Data.SqlClient.

1. Tao CSDL
   - Mo MySQL Workbench, dang nhap bang tai khoan quan tri (root).
   - File > Open SQL Script > chon SQL\Lab07_QLSinhVien.sql > bam nut tia set (Execute) de chay ca file.
   - File tao database qlsinhvien, 4 bang (Khoa, SinhVien, HocPhan, DangKy), du lieu mau
     (3 khoa, 10 sinh vien, 5 hoc phan, 20 luot dang ky) va tai khoan lab7_app (Bai 7).
   - File chay lai nhieu lan van khong loi (IF NOT EXISTS, INSERT IGNORE).

2. Chay chuong trinh
   - Mo IT3212_Labs.sln bang Visual Studio 2022.
   - Chuot phai project Lab07_ADONET_Connection > Set as Startup Project.
   - Lan dau mo, neu thieu thu vien: chuot phai Solution > Restore NuGet Packages.
   - Nhan Ctrl+F5. Bam "Kiem tra ket noi" hoac "Trang thai ket noi".

3. Cach thay chuoi ket noi (Bai 8)
   - Chuoi ket noi KHONG viet trong code, ma nam trong file App.config:
       <connectionStrings>
         <add name="QLSinhVien"
              connectionString="Server=localhost;Port=3306;Database=qlsinhvien;Uid=lab7_app;Pwd=...;CharSet=utf8mb4;"
              providerName="MySql.Data.MySqlClient" />
       </connectionStrings>
   - Server / Port : may chu va cong MySQL (doi neu MySQL cai o may khac hoac cong khac).
   - Database      : ten database (qlsinhvien).
   - Uid / Pwd     : tai khoan va mat khau. Mac dinh dung tai khoan rieng lab7_app (tao o Bai 7).
                     Muon dung tai khoan khac thi doi 2 gia tri nay.
   - Sau khi build, co the sua truc tiep file bin\Debug\Lab07_ADONET_Connection.exe.config
     ma khong can build lai.
   - Lop DbConnectionFactory doc chuoi nay bang ConfigurationManager.ConnectionStrings["QLSinhVien"].

4. Cau truc ma nguon (Lab07_ADONET_Connection)
   - DbConnectionFactory.cs : tao MySqlConnection tu chuoi ket noi trong App.config (Bai 5, 8)
   - Form1.cs               : hien thong tin ket noi, nut Kiem tra ket noi (Bai 5)
   - frmTrangThai.cs        : Bai 9 - DataSource, Database, ServerVersion, State,
                              ConnectionTimeout, tai khoan, thoi gian mo ket noi
   - App.config             : chuoi ket noi QLSinhVien (Bai 8)
   - SQL\Lab07_QLSinhVien.sql   : script tao CSDL (Bai 1 - 4, 6, 7)
   - SQL\QLSinhVien_backup.sql  : ban sao luu CSDL tao bang mysqldump (Bai 10)

5. Du lieu thu
   Bai 6 : email trung sv001@gmail.com -> loi 1062 UQ_SinhVien_Email
           hoc ky 4 -> loi 3819 CK_DangKy_HocKy ; diem 11 -> loi 3819 CK_SinhVien_Diem
           ma khoa XYZ -> loi 1452 FK_SinhVien_Khoa ; xoa khoa CNTT con sinh vien -> loi 1451
           them dang ky khong ghi ngay -> NgayDangKy tu lay ngay hien tai
   Bai 7 : lab7_app chi co SELECT, INSERT, UPDATE, DELETE tren qlsinhvien
           DROP TABLE -> loi 1142 ; vao database sys -> loi 1044
   Bai 9 : bam Mo ket noi -> State = Open, hien ServerVersion 8.0.44 ; Dong ket noi -> State = Closed
   Bai 10: sao luu -> xoa dang ky SV010-HP005 (con 19) -> phuc hoi -> du 20, ban ghi quay lai
           Sao luu : mysqldump -u root -p --single-transaction --databases qlsinhvien > QLSinhVien_backup.sql
           Phuc hoi: mysql -u root -p < QLSinhVien_backup.sql

6. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab7.docx (kem so do quan he va anh chup ket qua).
