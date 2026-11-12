using System;
using System.Collections.Generic;
using Lab06_ThreeLayerMemory.DAL;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAL _dal = new SanPhamDAL();

        public List<SanPham> GetAll()
        {
            return _dal.GetAll();
        }

        private SanPham GetByMa(string maSP)
        {
            List<SanPham> ds = _dal.GetAll();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaSP == maSP) return ds[i];
            }
            return null;
        }

        public void Add(SanPham sp)
        {
            KiemTra(sp);
            if (GetByMa(sp.MaSP) != null)
                throw new InvalidOperationException("Mã sản phẩm " + sp.MaSP + " đã tồn tại.");
            _dal.Add(sp);
        }

        public void Update(SanPham sp)
        {
            KiemTra(sp);
            if (GetByMa(sp.MaSP) == null)
                throw new InvalidOperationException("Không tìm thấy sản phẩm có mã " + sp.MaSP + ".");
            _dal.Update(sp);
        }

        public void Delete(string maSP)
        {
            if (GetByMa(maSP) == null)
                throw new InvalidOperationException("Không tìm thấy sản phẩm có mã " + maSP + ".");
            _dal.Delete(maSP);
        }

        private void KiemTra(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new ArgumentException("Thiếu mã sản phẩm.");
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Thiếu tên sản phẩm.");
            if (string.IsNullOrWhiteSpace(sp.DanhMuc))
                throw new ArgumentException("Thiếu danh mục.");
            if (sp.DonGia <= 0)
                throw new ArgumentException("Đơn giá phải lớn hơn 0.");
            if (sp.SoLuong < 0)
                throw new ArgumentException("Số lượng không được âm.");
        }

        public List<SanPham> TimKiem(string tuKhoa)
        {
            List<SanPham> ds = _dal.GetAll();
            List<SanPham> ketQua = new List<SanPham>();
            string k = tuKhoa.Trim().ToLower();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaSP.ToLower().Contains(k) || ds[i].TenSP.ToLower().Contains(k)
                    || ds[i].DanhMuc.ToLower().Contains(k))
                    ketQua.Add(ds[i]);
            }
            return ketQua;
        }

        public List<SanPham> SapXep(List<SanPham> ds, int kieu)
        {
            List<SanPham> kq = new List<SanPham>(ds);
            for (int i = 0; i < kq.Count - 1; i++)
            {
                for (int j = i + 1; j < kq.Count; j++)
                {
                    if (CanDoiCho(kq[i], kq[j], kieu))
                    {
                        SanPham tam = kq[i];
                        kq[i] = kq[j];
                        kq[j] = tam;
                    }
                }
            }
            return kq;
        }

        private bool CanDoiCho(SanPham a, SanPham b, int kieu)
        {
            if (kieu == 0) return string.Compare(a.TenSP, b.TenSP, StringComparison.CurrentCulture) > 0;
            if (kieu == 1) return a.DonGia > b.DonGia;
            if (kieu == 2) return a.DonGia < b.DonGia;
            return a.ThanhTien < b.ThanhTien;
        }

        public decimal TongGiaTriTon(List<SanPham> ds)
        {
            decimal tong = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                tong += ds[i].ThanhTien;
            }
            return tong;
        }

        public List<string> GetDanhSachDanhMuc()
        {
            List<SanPham> ds = _dal.GetAll();
            List<string> dm = new List<string>();
            for (int i = 0; i < ds.Count; i++)
            {
                if (!dm.Contains(ds[i].DanhMuc))
                    dm.Add(ds[i].DanhMuc);
            }
            return dm;
        }

        public Dictionary<string, List<SanPham>> NhomTheoDanhMuc()
        {
            Dictionary<string, List<SanPham>> nhom = new Dictionary<string, List<SanPham>>();
            List<SanPham> ds = _dal.GetAll();
            for (int i = 0; i < ds.Count; i++)
            {
                if (!nhom.ContainsKey(ds[i].DanhMuc))
                    nhom.Add(ds[i].DanhMuc, new List<SanPham>());
                nhom[ds[i].DanhMuc].Add(ds[i]);
            }
            return nhom;
        }

        public void DoiTen(SanPham sp, string tenMoi)
        {
            if (string.IsNullOrWhiteSpace(tenMoi))
                throw new ArgumentException("Tên không được rỗng.");
            sp.TenSP = tenMoi.Trim();
            _dal.Update(sp);
        }

        public void DoiTenDanhMuc(string tenCu, string tenMoi)
        {
            if (string.IsNullOrWhiteSpace(tenMoi))
                throw new ArgumentException("Tên danh mục không được rỗng.");
            List<SanPham> ds = _dal.GetAll();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].DanhMuc == tenCu)
                {
                    ds[i].DanhMuc = tenMoi.Trim();
                    _dal.Update(ds[i]);
                }
            }
        }

        public void XoaDanhMuc(string tenDanhMuc)
        {
            List<SanPham> ds = _dal.GetAll();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].DanhMuc == tenDanhMuc)
                    _dal.Delete(ds[i].MaSP);
            }
        }

        public string TaoMaMoi()
        {
            int so = 1;
            while (GetByMa("SP" + so.ToString("00")) != null)
            {
                so++;
            }
            return "SP" + so.ToString("00");
        }
    }
}
