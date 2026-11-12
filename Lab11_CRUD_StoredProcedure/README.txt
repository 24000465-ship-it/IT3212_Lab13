LAB 11 - CRUD THAM SO HOA VA STORED PROCEDURE (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
=====================================================

0. Moi truong
   - MySQL Server 8.0 (thay SQL Server, da duoc giang vien dong y), instance MySQL80, localhost:3306.
   - Thu vien MySql.Data (NuGet): SqlCommand -> MySqlCommand, SqlDbType -> MySqlDbType.
   - THROW 5000x cua SQL Server -> SIGNAL SQLSTATE '45000' SET MYSQL_ERRNO = 5000x trong MySQL.

1. Chuan bi CSDL
   - Sao luu truoc:  mysqldump -u root -p --routines --databases qlsinhvien > qlsinhvien_backup.sql
   - Chay SQL\Lab11_QLSinhVien.sql bang tai khoan root (sau cac file SQL cua Lab 7, 8, 9).
     Script them cot IsActive, kiem tra rang buoc UQ_SinhVien_Email va tao cac thu tuc:
       sp_SinhVien_Insert, sp_SinhVien_Update, sp_SinhVien_Delete (xoa mem), sp_SinhVien_KhoiPhuc,
       sp_SinhVien_TimKiem, sp_SinhVien_KiemTraEmail,
       sp_Khoa_DanhSach, sp_Khoa_Insert, sp_Khoa_Update, sp_Khoa_Delete.
     Chay lai nhieu lan khong loi.
   - Ma loi nghiep vu: 50001 trung ma SV, 50002 khong tim thay SV, 50003 trung email,
     50004 khoa khong ton tai, 50011 trung ma khoa, 50012 trung ten khoa,
     50013 khong tim thay khoa, 50014 khoa dang co sinh vien.

2. Cach chay
   - Mo IT3212_Labs.sln, chuot phai Lab11_CRUD_StoredProcedure > Set as Startup Project, nhan Ctrl+F5.
   - Lan dau mo neu thieu thu vien: chuot phai Solution > Restore NuGet Packages.
   - Chuoi ket noi nam trong App.config (ten QLSinhVien), tai khoan lab7_app (chi co quyen SELECT,
     INSERT, UPDATE, DELETE, EXECUTE).

3. Cau truc thu muc (kien truc 3 lop)
   - DTO : SinhVienDTO, KhoaDTO, LoiNghiepVuException (khong tham chieu WinForms)
   - DAL : DbConnectionFactory, SinhVienDAL, KhoaDAL (goi Stored Procedure, tham so hoa), LoiCsdl
   - BUS : SinhVienBUS, KhoaBUS (kiem tra nghiep vu truoc khi goi DAL)
   - GUI : frmMain, frmSinhVien, frmKhoa, XuLyLoi (thong bao loi va ghi nhat ky)
   - Form khong co cau SQL nao.

4. Du lieu thu
   Bai 1 : them SV033 Do Minh Quan, 12/03/2005, Du Lich, 7.5 -> "Them thanh cong"
           them lai SV001 -> "Ma sinh vien da ton tai." (loi 50001 tu thu tuc)
   Bai 2 : chon SV033, doi khoa Marketing, diem 8,25 -> "Cap nhat thanh cong"
           sua SV999 -> "Khong tim thay sinh vien." (loi 50002)
   Bai 3 : SinhVienDAL.Insert dung CommandType.StoredProcedure va using
   Bai 4 : ho ten rong / sinh nam 2015 / diem 12 / email "trang@" -> bao loi tu BUS
   Bai 5 : form chi lay du lieu tu control, goi BUS, tai lai luoi
   Bai 6 : them khoa NN "Ngon Ngu Anh" -> sua ten -> xoa ; xoa CNTT -> khong cho xoa vi dang co 11 sinh vien
   Bai 7 : tu khoa "thi" + khoa CNTT -> 5 sinh vien ; de trong -> tat ca
   Bai 8 : them SV034 voi email sv001@gmail.com -> "Email ... da duoc sinh vien khac su dung."
   Bai 9 : xoa SV033 -> bien khoi danh sach ; tick "Hien ca sinh vien da xoa" -> dong mau xam,
           trang thai "Da xoa" ; bam "Khoi phuc SV da xoa" -> tro lai
   Bai 10: diem "abc" -> loi nhap lieu ; trung ma -> loi nghiep vu ; sai cong ket noi -> loi CSDL.
           Loi nghiep vu va loi CSDL duoc ghi chi tiet vao bin\Debug\Logs\loi_yyyyMMdd.log
           (nut "Xem nhat ky loi" o form chinh).

   Sau khi thu, cac dong SV033 va khoa NN da duoc xoa, CSDL con 32 sinh vien, 4 khoa nhu ban dau.

5. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab11.docx (kem anh chup ket qua tung bai).
