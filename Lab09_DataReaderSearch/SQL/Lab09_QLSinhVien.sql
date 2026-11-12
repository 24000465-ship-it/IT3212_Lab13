-- =============================================================
-- LAB 9 - DOC, TIM KIEM VA LOC DU LIEU BANG DATAREADER (IT3212)
-- Sinh vien: Le Duc Binh - MSSV: 24000465
-- Chay SAU Lab07_QLSinhVien.sql va Lab08_QLSinhVien.sql.
-- Bo sung 22 sinh vien de du lieu du 4 trang (moi trang 10 dong). Chay lai khong bi trung.
-- =============================================================
use qlsinhvien;

insert ignore into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email)
VALUES
('SV011', 'Trương Văn Hải',    '2005-02-11', 1, 'CNTT', 4.20, 'sv011@gmail.com'),
('SV012', 'Lý Thị Mai',        '2005-06-10', 0, 'DL',   8.30, 'sv012@gmail.com'),
('SV013', 'Đinh Quốc Khánh',   '2004-10-25', 1, 'OTO',  6.90, 'sv013@gmail.com'),
('SV014', 'Mai Thị Thu',       '2006-01-30', 0, 'MKT',  7.10, NULL),
('SV015', 'Cao Văn Phúc',      '2003-12-19', 1, 'OTO',  5.40, 'sv015@gmail.com'),
('SV016', 'Lương Thị Hằng',    '2005-07-07', 0, 'CNTT', 9.50, 'sv016@gmail.com'),
('SV017', 'Phan Đức Thắng',    '2004-03-03', 1, 'CNTT', 3.80, 'sv017@gmail.com'),
('SV018', 'Hồ Thị Kim Anh',    '2005-09-21', 0, 'DL',   7.70, 'sv018@gmail.com'),
('SV019', 'Tạ Minh Tuấn',      '2006-04-15', 1, 'OTO',  8.10, NULL),
('SV020', 'Kiều Thị Yến',      '2004-08-08', 0, 'MKT',  6.20, 'sv020@gmail.com'),
('SV021', 'Doãn Văn Lực',      '2003-05-27', 1, 'OTO',  4.70, 'sv021@gmail.com'),
('SV022', 'Quách Thị Ngân',    '2005-11-12', 0, 'CNTT', 8.90, 'sv022@gmail.com'),
('SV023', 'Văn Đức Toàn',      '2006-02-02', 1, 'DL',   5.90, 'sv023@gmail.com'),
('SV024', 'Lâm Thị Phương',    '2004-06-18', 0, 'MKT',  9.00, 'sv024@gmail.com'),
('SV025', 'Thái Văn Sơn',      '2005-03-29', 1, 'CNTT', 7.30, NULL),
('SV026', 'Ông Thị Diệu',      '2004-12-05', 0, 'DL',   2.90, 'sv026@gmail.com'),
('SV027', 'Chu Văn Bảo',       '2006-07-23', 1, 'OTO',  6.60, 'sv027@gmail.com'),
('SV028', 'La Thị Hồng Nhung', '2005-10-01', 0, 'MKT',  8.40, 'sv028@gmail.com'),
('SV029', 'Từ Văn Nam',        '2003-09-14', 1, 'CNTT', 5.10, 'sv029@gmail.com'),
('SV030', 'Giang Thị Thảo',    '2005-05-05', 0, 'DL',   9.30, 'sv030@gmail.com'),
('SV031', 'Âu Văn Đạt',        '2004-01-17', 1, 'OTO',  7.80, 'sv031@gmail.com'),
('SV032', 'Nguyễn Thị Bích',   '2006-08-26', 0, 'CNTT', 6.40, 'sv032@gmail.com');

select count(*) as TongSinhVien from SinhVien;
