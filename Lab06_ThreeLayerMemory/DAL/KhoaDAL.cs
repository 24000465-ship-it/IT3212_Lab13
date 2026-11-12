using System.Collections.Generic;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.DAL
{
    public class KhoaDAL
    {
        private static List<Khoa> _data = null;

        public KhoaDAL()
        {
            if (_data == null)
            {
                _data = new List<Khoa>();
                _data.Add(new Khoa("CNTT", "Công nghệ thông tin"));
                _data.Add(new Khoa("KT", "Kinh tế"));
                _data.Add(new Khoa("NNA", "Ngôn ngữ Anh"));
            }
        }

        public List<Khoa> GetAll()
        {
            return new List<Khoa>(_data);
        }
    }
}
