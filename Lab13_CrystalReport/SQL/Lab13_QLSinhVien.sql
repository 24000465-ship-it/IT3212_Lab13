-- =============================================================
-- LAB 13 - TAO BAO CAO CO BAN BANG CRYSTAL REPORT (IT3212)
-- Sinh vien: Le Duc Binh - MSSV: 24000465
-- Chay SAU cac file SQL cua Lab 7, 8, 9, 11 bang tai khoan quan tri (root).
-- MySQL khong co CREATE OR ALTER VIEW, dung CREATE OR REPLACE VIEW (tac dung tuong duong).
-- File chay lai nhieu lan van khong loi.
-- =============================================================
use qlsinhvien;

-- ===== Bai 2: Nguon du lieu bao cao danh sach sinh vien =====
-- Chi lay sinh vien dang hoat dong (IsActive = 1, cot them o Lab 11)
create or replace view vw_BaoCaoSinhVien as
select sv.MaSV, sv.HoTen, sv.NgaySinh,
       case sv.GioiTinh when 1 then 'Nam' else 'Nữ' end as GioiTinh,
       k.MaKhoa, k.TenKhoa, sv.DiemTB, sv.Email
from SinhVien sv
join Khoa k on sv.MaKhoa = k.MaKhoa
where sv.IsActive = 1;

-- ===== Bai 6: Nguon du lieu bao cao danh sach khoa kem so sinh vien =====
create or replace view vw_BaoCaoKhoa as
select k.MaKhoa, k.TenKhoa,
       count(sv.MaSV) as SoSinhVien,
       ifnull(round(avg(sv.DiemTB), 2), 0) as DiemTrungBinh
from Khoa k
left join SinhVien sv on sv.MaKhoa = k.MaKhoa and sv.IsActive = 1
group by k.MaKhoa, k.TenKhoa;

-- ===== Bai 8: Nguon du lieu bao cao danh sach hoc phan =====
create or replace view vw_BaoCaoHocPhan as
select MaHP, TenHP, SoTinChi
from HocPhan;

-- Cho tai khoan ung dung (Lab 7) quyen doc view
GRANT SELECT ON qlsinhvien.* TO 'lab7_app'@'localhost';

-- Thu xem du lieu
select * from vw_BaoCaoSinhVien order by TenKhoa, HoTen;
select * from vw_BaoCaoKhoa order by TenKhoa;
select * from vw_BaoCaoHocPhan order by TenHP;
