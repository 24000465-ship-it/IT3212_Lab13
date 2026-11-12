using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_OOPAdvanced
{
    internal class Nguoi
    {
        private string _hoTen;
        public string HoTen
        {
            get { return _hoTen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Họ tên không được rỗng. ");
                _hoTen = value.Trim();
            }
        }
        public DateTime NgaySinh { get; set; }

        
        public Nguoi (string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;

        }
        public virtual string MoTa()
        {
            return HoTen + " - " + NgaySinh.ToString("dd/MM/yyyy");
        }


    }
}
