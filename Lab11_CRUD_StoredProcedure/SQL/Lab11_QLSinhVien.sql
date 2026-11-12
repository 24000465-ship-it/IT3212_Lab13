-- =============================================================
-- LAB 11 - CRUD THAM SO HOA VA STORED PROCEDURE (IT3212)
-- Sinh vien: Le Duc Binh - MSSV: 24000465
-- Chay SAU cac file Lab07, Lab08, Lab09 _QLSinhVien.sql, bang tai khoan quan tri (root).
-- Nen sao luu truoc khi chay:  mysqldump -u root -p --routines --databases qlsinhvien > backup.sql
-- File chay lai nhieu lan van khong loi.
-- Ma loi nghiep vu (MYSQL_ERRNO) dung khoang 50001 - 50099, tuong tu THROW 5000x cua SQL Server.
-- =============================================================
use qlsinhvien;

-- ===== Bai 9: Cot IsActive cho xoa mem =====
set @co = (select count(*) from information_schema.COLUMNS
           where TABLE_SCHEMA = 'qlsinhvien' and TABLE_NAME = 'SinhVien' and COLUMN_NAME = 'IsActive');
set @lenh = if(@co = 0, 'alter table SinhVien add column IsActive tinyint(1) not null default 1', 'select 1');
prepare st from @lenh; execute st; deallocate prepare st;

-- Cac chuong trinh cu (Lab 10 dung CommandBuilder) co the gui IsActive = NULL khi them dong: tu dat ve 1
drop trigger if exists trg_SinhVien_IsActive;
DELIMITER $$
create trigger trg_SinhVien_IsActive before insert on SinhVien
for each row
begin
    if new.IsActive is null then
        set new.IsActive = 1;
    end if;
end $$
DELIMITER ;

-- ===== Bai 8: Rang buoc email duy nhat (Lab 7 da tao, kiem tra lai) =====
set @co = (select count(*) from information_schema.STATISTICS
           where TABLE_SCHEMA = 'qlsinhvien' and TABLE_NAME = 'SinhVien' and INDEX_NAME = 'UQ_SinhVien_Email');
set @lenh = if(@co = 0, 'alter table SinhVien add constraint UQ_SinhVien_Email unique (Email)', 'select 1');
prepare st from @lenh; execute st; deallocate prepare st;

-- ===== Bai 1: Them sinh vien =====
drop procedure if exists sp_SinhVien_Insert;
DELIMITER $$
create procedure sp_SinhVien_Insert(
    in p_MaSV varchar(15),
    in p_HoTen varchar(100),
    in p_NgaySinh date,
    in p_GioiTinh bit,
    in p_MaKhoa varchar(10),
    in p_DiemTB decimal(4,2),
    in p_Email varchar(100))
begin
    if exists (select 1 from SinhVien where MaSV = p_MaSV) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50001, MESSAGE_TEXT = 'Mã sinh viên đã tồn tại.';
    end if;
    if not exists (select 1 from Khoa where MaKhoa = p_MaKhoa) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50004, MESSAGE_TEXT = 'Khoa không tồn tại.';
    end if;
    if p_Email is not null and exists (select 1 from SinhVien where Email = p_Email) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50003, MESSAGE_TEXT = 'Email đã được sinh viên khác sử dụng.';
    end if;
    insert into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email, IsActive)
    values (p_MaSV, p_HoTen, p_NgaySinh, p_GioiTinh, p_MaKhoa, p_DiemTB, p_Email, 1);
end $$
DELIMITER ;

-- ===== Bai 2: Cap nhat sinh vien (khong doi khoa chinh) =====
drop procedure if exists sp_SinhVien_Update;
DELIMITER $$
create procedure sp_SinhVien_Update(
    in p_MaSV varchar(15),
    in p_HoTen varchar(100),
    in p_NgaySinh date,
    in p_GioiTinh bit,
    in p_MaKhoa varchar(10),
    in p_DiemTB decimal(4,2),
    in p_Email varchar(100))
begin
    if not exists (select 1 from SinhVien where MaSV = p_MaSV and IsActive = 1) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50002, MESSAGE_TEXT = 'Không tìm thấy sinh viên.';
    end if;
    if not exists (select 1 from Khoa where MaKhoa = p_MaKhoa) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50004, MESSAGE_TEXT = 'Khoa không tồn tại.';
    end if;
    if p_Email is not null and exists (select 1 from SinhVien where Email = p_Email and MaSV <> p_MaSV) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50003, MESSAGE_TEXT = 'Email đã được sinh viên khác sử dụng.';
    end if;
    update SinhVien
    set HoTen = p_HoTen, NgaySinh = p_NgaySinh, GioiTinh = p_GioiTinh,
        MaKhoa = p_MaKhoa, DiemTB = p_DiemTB, Email = p_Email
    where MaSV = p_MaSV;
end $$
DELIMITER ;

-- ===== Bai 2 + Bai 9: Xoa sinh vien (xoa mem: IsActive = 0) =====
drop procedure if exists sp_SinhVien_Delete;
DELIMITER $$
create procedure sp_SinhVien_Delete(in p_MaSV varchar(15))
begin
    if not exists (select 1 from SinhVien where MaSV = p_MaSV and IsActive = 1) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50002, MESSAGE_TEXT = 'Không tìm thấy sinh viên.';
    end if;
    update SinhVien set IsActive = 0 where MaSV = p_MaSV;
end $$
DELIMITER ;

-- ===== Bai 9: Khoi phuc sinh vien da xoa mem =====
drop procedure if exists sp_SinhVien_KhoiPhuc;
DELIMITER $$
create procedure sp_SinhVien_KhoiPhuc(in p_MaSV varchar(15))
begin
    if not exists (select 1 from SinhVien where MaSV = p_MaSV and IsActive = 0) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50002, MESSAGE_TEXT = 'Không tìm thấy sinh viên đã xóa.';
    end if;
    update SinhVien set IsActive = 1 where MaSV = p_MaSV;
end $$
DELIMITER ;

-- ===== Bai 7: Tim kiem theo tu khoa va khoa, tham so rong thi tra tat ca =====
drop procedure if exists sp_SinhVien_TimKiem;
DELIMITER $$
create procedure sp_SinhVien_TimKiem(
    in p_TuKhoa varchar(100),
    in p_MaKhoa varchar(10),
    in p_HienDaXoa tinyint)
begin
    select sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.MaKhoa, k.TenKhoa, sv.DiemTB, sv.Email, sv.IsActive
    from SinhVien sv
    join Khoa k on sv.MaKhoa = k.MaKhoa
    where (p_TuKhoa is null or p_TuKhoa = ''
           or sv.MaSV like concat('%', p_TuKhoa, '%')
           or sv.HoTen like concat('%', p_TuKhoa, '%')
           or sv.Email like concat('%', p_TuKhoa, '%'))
      and (p_MaKhoa is null or p_MaKhoa = '' or sv.MaKhoa = p_MaKhoa)
      and (p_HienDaXoa = 1 or sv.IsActive = 1)
    order by sv.MaSV;
end $$
DELIMITER ;

-- ===== Bai 8: Kiem tra email da duoc nguoi khac dung chua =====
drop procedure if exists sp_SinhVien_KiemTraEmail;
DELIMITER $$
create procedure sp_SinhVien_KiemTraEmail(in p_Email varchar(100), in p_MaSV varchar(15))
begin
    select count(*) from SinhVien where Email = p_Email and MaSV <> ifnull(p_MaSV, '');
end $$
DELIMITER ;

-- ===== Bai 6: CRUD bang Khoa =====
drop procedure if exists sp_Khoa_DanhSach;
DELIMITER $$
create procedure sp_Khoa_DanhSach()
begin
    select k.MaKhoa, k.TenKhoa, count(sv.MaSV) as SoSinhVien
    from Khoa k
    left join SinhVien sv on sv.MaKhoa = k.MaKhoa
    group by k.MaKhoa, k.TenKhoa
    order by k.TenKhoa;
end $$
DELIMITER ;

drop procedure if exists sp_Khoa_Insert;
DELIMITER $$
create procedure sp_Khoa_Insert(in p_MaKhoa varchar(10), in p_TenKhoa varchar(100))
begin
    if exists (select 1 from Khoa where MaKhoa = p_MaKhoa) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50011, MESSAGE_TEXT = 'Mã khoa đã tồn tại.';
    end if;
    if exists (select 1 from Khoa where TenKhoa = p_TenKhoa) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50012, MESSAGE_TEXT = 'Tên khoa đã tồn tại.';
    end if;
    insert into Khoa (MaKhoa, TenKhoa) values (p_MaKhoa, p_TenKhoa);
end $$
DELIMITER ;

drop procedure if exists sp_Khoa_Update;
DELIMITER $$
create procedure sp_Khoa_Update(in p_MaKhoa varchar(10), in p_TenKhoa varchar(100))
begin
    if not exists (select 1 from Khoa where MaKhoa = p_MaKhoa) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50013, MESSAGE_TEXT = 'Không tìm thấy khoa.';
    end if;
    if exists (select 1 from Khoa where TenKhoa = p_TenKhoa and MaKhoa <> p_MaKhoa) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50012, MESSAGE_TEXT = 'Tên khoa đã tồn tại.';
    end if;
    update Khoa set TenKhoa = p_TenKhoa where MaKhoa = p_MaKhoa;
end $$
DELIMITER ;

drop procedure if exists sp_Khoa_Delete;
DELIMITER $$
create procedure sp_Khoa_Delete(in p_MaKhoa varchar(10))
begin
    if not exists (select 1 from Khoa where MaKhoa = p_MaKhoa) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50013, MESSAGE_TEXT = 'Không tìm thấy khoa.';
    end if;
    if exists (select 1 from SinhVien where MaKhoa = p_MaKhoa) then
        signal sqlstate '45000' set MYSQL_ERRNO = 50014, MESSAGE_TEXT = 'Không thể xóa khoa đang có sinh viên.';
    end if;
    delete from Khoa where MaKhoa = p_MaKhoa;
end $$
DELIMITER ;

GRANT EXECUTE ON qlsinhvien.* TO 'lab7_app'@'localhost';

-- Thu goi thu tuc
call sp_SinhVien_TimKiem('', '', 0);
call sp_Khoa_DanhSach();
