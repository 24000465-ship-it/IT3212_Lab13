-- =============================================================
-- LAB 8 - MYSQLCOMMAND, MYSQLPARAMETER VA CAC PHUONG THUC THUC THI (IT3212)
-- Sinh vien: Le Duc Binh - MSSV: 24000465
-- Chay SAU file Lab07_QLSinhVien.sql, bang tai khoan quan tri (root).
-- File chay lai nhieu lan van khong loi.
-- =============================================================
use qlsinhvien;

-- Khoa chua co sinh vien nao, dung de thu truong hop MAX(DiemTB) tra ve NULL (Bai 7)
insert ignore into Khoa (MaKhoa, TenKhoa) values ('OTO', 'Công Nghệ Kỹ Thuật Ô Tô');

-- ===== Bai 5: Thu tuc tim sinh vien theo khoa =====
drop procedure if exists sp_SinhVien_TheoKhoa;
DELIMITER $$
create procedure sp_SinhVien_TheoKhoa(in p_MaKhoa varchar(10))
begin
    select MaSV, HoTen, NgaySinh, DiemTB
    from SinhVien
    where MaKhoa = p_MaKhoa
    order by HoTen;
end $$
DELIMITER ;

-- ===== Bai 9: Thu tuc them sinh vien, tra so luong qua tham so OUTPUT =====
drop procedure if exists sp_SinhVien_Them;
DELIMITER $$
create procedure sp_SinhVien_Them(
    in p_MaSV varchar(15),
    in p_HoTen varchar(100),
    in p_NgaySinh date,
    in p_GioiTinh bit,
    in p_MaKhoa varchar(10),
    in p_DiemTB decimal(4,2),
    in p_Email varchar(100),
    out p_SoLuong int)
begin
    insert into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email)
    values (p_MaSV, p_HoTen, p_NgaySinh, p_GioiTinh, p_MaKhoa, p_DiemTB, p_Email);
    select count(*) into p_SoLuong from SinhVien;
end $$
DELIMITER ;

-- Cho tai khoan ung dung (Lab 7) quyen chay thu tuc
GRANT EXECUTE ON qlsinhvien.* TO 'lab7_app'@'localhost';

-- Thu goi thu tuc
call sp_SinhVien_TheoKhoa('CNTT');
