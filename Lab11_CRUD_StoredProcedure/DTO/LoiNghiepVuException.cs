using System;

namespace Lab11_CRUD_StoredProcedure.DTO
{
    public class LoiNghiepVuException : Exception
    {
        public LoiNghiepVuException(string thongBao) : base(thongBao)
        {
        }

        public LoiNghiepVuException(string thongBao, Exception loiGoc) : base(thongBao, loiGoc)
        {
        }
    }
}
