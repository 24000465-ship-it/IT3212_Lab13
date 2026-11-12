-- =============================================================
-- LAB 7 - TAO CSDL, KET NOI ADO.NET (IT3212)
-- Sinh vien: Le Duc Binh - MSSV: 24000465
-- He quan tri: MySQL 8.0 (thay cho SQL Server, da duoc giang vien dong y)
-- File chay duoc nhieu lan, ke ca tren may chua co database QLSinhVien
-- =============================================================

-- ===== Bai 1: Tao database QLSinhVien =====
CREATE DATABASE IF NOT EXISTS QLSinhVien
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;
use qlsinhvien;


-- ===== Bai 2: Bang Khoa va SinhVien =====
create table if not exists Khoa (
	MaKhoa varchar(10) primary key,
    TenKhoa varchar(100) not null unique
);
create table if not exists SinhVien(
	MaSV varchar(15) primary key,
    HoTen varchar(100) not null,
    NgaySinh date not null,
    GioiTinh bit not null,
    MaKhoa varchar(10) not null,
    DiemTB decimal(4,2) not null default 0,
    Email varchar(100) null,
    constraint UQ_SinhVien_Email unique (Email),
    constraint CK_SinhVien_Diem check (DiemTB between 0 and 10 ),
    constraint FK_SinhVien_Khoa foreign key (MaKhoa) references Khoa (MaKhoa)
);

-- ===== Bai 3: Bang HocPhan va DangKy (quan he nhieu - nhieu) =====
create table if not exists HocPhan(
	MaHP varchar(10) primary key,
    TenHP varchar(120) not null,
    SoTinChi int not null check (SoTinChi between 1 and 6)
);

create table if not exists DangKy(
	MaSV varchar(15) not null,
    MaHP varchar(10) not null,
    HocKy int not null
    constraint CK_DangKy_HocKy check (HocKy between 1 and 3),
    NgayDangKy date not null default (current_date),
    Diem decimal(4,2) null check (Diem between 0 and 10 ),
    primary key (MaSV, MaHP),
    constraint FK_DangKy_HocPhan foreign key (MaHP) references HocPhan(MaHP),
    constraint FK_DangKy_SinhVien foreign key (MaSV) references SinhVien(MaSV)
);

-- ===== Bai 4: Du lieu mau =====
insert ignore into Khoa ( MaKhoa, TenKhoa)
values
	('CNTT', 'Công Nghệ Thông Tin'),
	('DL', 'Du Lịch'),
    ('MKT', 'Marketing');


insert ignore into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email)
VALUES
('SV001', 'Nguyễn Văn An',   '2005-01-15', 1, 'CNTT', 8.50, 'sv001@gmail.com'),
('SV002', 'Trần Thị Bình',   '2005-03-20', 0, 'CNTT', 7.80, 'sv002@gmail.com'),
('SV003', 'Lê Văn Cường',    '2004-07-10', 1, 'CNTT', 9.00, 'sv003@gmail.com'),
('SV004', 'Phạm Thị Dung',   '2005-11-05', 0, 'CNTT', 6.50, 'sv004@gmail.com'),
('SV005', 'Hoàng Văn Em',    '2005-06-25', 1, 'DL',   7.00, 'sv005@gmail.com'),
('SV006', 'Đỗ Thị Hoa',      '2004-09-12', 0, 'DL',   8.20, 'sv006@gmail.com'),
('SV007', 'Bùi Văn Hùng',    '2005-02-18', 1, 'DL',   6.80, 'sv007@gmail.com'),
('SV008', 'Vũ Thị Lan',      '2005-08-30', 0, 'MKT',  9.20, 'sv008@gmail.com'),
('SV009', 'Đặng Văn Minh',   '2004-12-01', 1, 'MKT',  7.50, 'sv009@gmail.com'),
('SV010', 'Nguyễn Thị Ngọc', '2005-04-14', 0, 'MKT',  8.70, 'sv010@gmail.com');



insert ignore into HocPhan (MaHP, TenHP, SoTinChi)
VALUES
('HP001', 'Cơ sở dữ liệu',       3),
('HP002', 'Lập trình C#',        4),
('HP003', 'Mạng máy tính',       3),
('HP004', 'Cấu trúc dữ liệu',    3),
('HP005', 'Phân tích thiết kế',  2);



insert ignore into DangKy (MaSV, MaHP, HocKy, Diem)
VALUES
('SV001', 'HP001', 1, 8.50),
('SV001', 'HP002', 1, 9.00),
('SV002', 'HP001', 1, 7.50),
('SV002', 'HP003', 1, 8.00),
('SV003', 'HP001', 2, 9.50),
('SV003', 'HP004', 2, 8.80),
('SV004', 'HP002', 1, 6.50),
('SV004', 'HP005', 1, 7.00),
('SV005', 'HP003', 2, 8.00),
('SV005', 'HP005', 2, 7.50),
('SV006', 'HP001', 1, 8.50),
('SV006', 'HP004', 1, 9.00),
('SV007', 'HP002', 2, 6.80),
('SV007', 'HP003', 2, 7.20),
('SV008', 'HP001', 1, 9.20),
('SV008', 'HP005', 1, 8.50),
('SV009', 'HP003', 2, 7.50),
('SV009', 'HP004', 2, 8.00),
('SV010', 'HP002', 1, 9.00),
('SV010', 'HP005', 1, 8.80);

-- ===== Bai 6: Rang buoc bo sung =====
-- Da khai bao ngay trong lenh tao bang:
--   UQ_SinhVien_Email : Email khong duoc trung
--   NgayDangKy        : DEFAULT (current_date) - khong ghi thi lay ngay hien tai
--   CK_DangKy_HocKy   : HocKy chi tu 1 den 3
-- Cac lenh thu du lieu vi pham (chay rieng tung lenh, se bao loi):
-- insert into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email)
--     values ('SV011', 'Lê Thị Trùng', '2005-05-05', 0, 'CNTT', 7.00, 'sv001@gmail.com');   -- loi 1062 UQ_SinhVien_Email
-- insert into DangKy (MaSV, MaHP, HocKy, Diem) values ('SV001', 'HP003', 4, 8.00);          -- loi 3819 CK_DangKy_HocKy
-- insert into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email)
--     values ('SV012', 'Trần Văn Điểm', '2005-05-05', 1, 'CNTT', 11.00, 'sv012@gmail.com'); -- loi 3819 CK_SinhVien_Diem
-- insert into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email)
--     values ('SV013', 'Phạm Văn Khoa', '2005-05-05', 1, 'XYZ', 7.00, 'sv013@gmail.com');   -- loi 1452 FK_SinhVien_Khoa

-- ===== Bai 7: Tai khoan rieng cho ung dung, quyen toi thieu =====
-- (chay bang tai khoan quan tri, vi du root)
CREATE USER IF NOT EXISTS 'lab7_app'@'localhost' IDENTIFIED BY 'DIEN_MAT_KHAU';
GRANT SELECT, INSERT, UPDATE, DELETE ON qlsinhvien.* TO 'lab7_app'@'localhost';

-- ===== Truy van kiem tra du lieu mau =====
select k.TenKhoa, count(s.MaSV) as SoSinhVien
from Khoa k left join SinhVien s on s.MaKhoa = k.MaKhoa
group by k.MaKhoa, k.TenKhoa;
