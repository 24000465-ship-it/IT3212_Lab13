LAB 13 - TAO BAO CAO CO BAN BANG CRYSTAL REPORT (IT3212)
Sinh vien: Le Duc Binh - MSSV: 24000465
========================================================

0. Moi truong da dung
   - Visual Studio 2022 Community, .NET Framework 4.7.2.
   - SAP Crystal Reports, developer version for Microsoft Visual Studio SP40 (64-bit),
     phien ban cai dat 13.0.40.5789, thu vien CrystalDecisions.* 13.0.4000.0.
     Bo cai: CRforVS6413SP40_0-80007712.EXE tai tu origin.softwaredownloads.sap.com.
   - Runtime: SAP Crystal Reports runtime engine for .NET Framework 64-bit (SP40, cai kem bo cai tren).
   - MySQL Server 8.0 (thay SQL Server, da duoc giang vien dong y), thu vien MySql.Data.

1. Chuan bi CSDL
   - Chay SQL\Lab13_QLSinhVien.sql bang tai khoan root (sau cac file SQL cua Lab 7, 8, 9, 11).
     Script tao 3 view: vw_BaoCaoSinhVien, vw_BaoCaoKhoa, vw_BaoCaoHocPhan.
     MySQL khong co CREATE OR ALTER VIEW nen dung CREATE OR REPLACE VIEW.
   - Du lieu: 32 sinh vien dang hoc, 4 khoa, 5 hoc phan.

2. Cach chay
   - Mo IT3212_Labs.sln, chuot phai Lab13_CrystalReport > Set as Startup Project, nhan Ctrl+F5.
   - Project dat Platform target = x64 vi may chi cai runtime Crystal 64-bit.
     Neu chay x86 phai cai them "CR for Visual Studio SP40 CR Runtime 32-bit".
   - Lan dau mo neu thieu thu vien: chuot phai Solution > Restore NuGet Packages.

3. Cau truc
   - DAL\BaoCaoDAL.cs        : lay DataTable tu cac view (ten bang khop voi report)
   - Reports\*.rpt           : CrystalReportSinhVien, CrystalReportKhoa, CrystalReportHocPhan
   - GUI\frmMain             : menu Bao cao, Kiem tra moi truong
   - GUI\frmBaoCao...        : CrystalReportViewer + nut Tai lai, Xuat PDF, In
   - Images\logo.png         : logo dung trong report (da nhung vao file .rpt)

4. Du lieu thu
   Bai 1 : He thong > Kiem tra moi truong -> Crystal Reports 13.0.4000.0, tien trinh 64-bit
   Bai 2 : SELECT * FROM vw_BaoCaoSinhVien -> 32 dong, co ten khoa, gioi tinh Nam/Nu
   Bai 3 : BaoCaoDAL.GetStudentReportData() -> DataTable "SinhVienReport"
   Bai 4 : Bao cao > Danh sach sinh vien -> 2 trang, sap xep theo khoa, ho ten
   Bai 5 : nut Xuat PDF -> DanhSachSinhVien.pdf
   Bai 6 : Bao cao > Danh sach khoa -> 4 khoa, tong 32 sinh vien
   Bai 7 : tieu de, logo, ngay lap, so trang "Trang x / y", duong ke, ngay dd/MM/yyyy, diem 2 so le
   Bai 8 : Bao cao > Danh sach hoc phan -> 5 hoc phan sap xep theo ten, tong 15 tin chi
   Bai 9 : mo mot bao cao nhieu lan chi co 1 form; dong form thi ReportDocument duoc Close + Dispose
   Bai 10: xem truoc tren viewer, in qua "Microsoft Print to PDF", xuat PDF;
           cau hinh x86 khong co runtime 32-bit -> bao loi than thien.

5. Tep PDF mau (thu muc PDF_Mau trong bai nop)
   DanhSachSinhVien.pdf, DanhSachKhoa.pdf, DanhSachHocPhan.pdf, InThu_MicrosoftPrintToPDF.pdf

6. Phan da hoan thanh
   - Bai 1 - 5 (co huong dan): hoan thanh.
   - Bai 6 - 10 (tu thuc hien): hoan thanh.
   - Bao cao: 24000465_LeDucBinh_Lab13.docx.

Luu y: trong ban tren GitHub, mat khau tai khoan lab7_app trong App.config da duoc thay bang DIEN_MAT_KHAU.
Khi chay hay dien mat khau dat o script Lab07_QLSinhVien.sql.
