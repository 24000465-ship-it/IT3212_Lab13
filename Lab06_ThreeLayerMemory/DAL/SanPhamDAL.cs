using System.Collections.Generic;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.DAL
{
    public class SanPhamDAL
    {
        private static List<SanPham> _data = null;

        public SanPhamDAL()
        {
            if (_data == null)
            {
                _data = new List<SanPham>();
                _data.Add(new SanPham("SP01", "iPhone 15", "Điện thoại", 21990000, 5));
                _data.Add(new SanPham("SP02", "Samsung Galaxy A55", "Điện thoại", 9490000, 8));
                _data.Add(new SanPham("SP03", "Dell Inspiron 15", "Laptop", 15990000, 4));
                _data.Add(new SanPham("SP04", "MacBook Air M2", "Laptop", 24990000, 2));
                _data.Add(new SanPham("SP05", "Chuột Logitech M331", "Phụ kiện", 390000, 25));
                _data.Add(new SanPham("SP06", "Tai nghe Sony WH-CH520", "Phụ kiện", 1190000, 10));
            }
        }

        public List<SanPham> GetAll()
        {
            return new List<SanPham>(_data);
        }

        public void Add(SanPham sp)
        {
            _data.Add(sp);
        }

        public void Update(SanPham sp)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].MaSP == sp.MaSP)
                {
                    _data[i] = sp;
                    break;
                }
            }
        }

        public void Delete(string maSP)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].MaSP == maSP)
                {
                    _data.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
