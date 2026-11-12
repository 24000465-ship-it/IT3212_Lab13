using System;
using Lab11_CRUD_StoredProcedure.DTO;
using MySql.Data.MySqlClient;

namespace Lab11_CRUD_StoredProcedure.DAL
{
    public static class LoiCsdl
    {
        public static Exception ChuyenDoi(MySqlException ex)
        {
            if (ex.Number >= 50000 && ex.Number < 50100)
                return new LoiNghiepVuException(ex.Message, ex);

            switch (ex.Number)
            {
                case 1062:
                    return new LoiNghiepVuException("Dữ liệu bị trùng với bản ghi đã có (mã hoặc email).", ex);
                case 1451:
                    return new LoiNghiepVuException("Không thể xóa vì dữ liệu đang được bảng khác sử dụng.", ex);
                case 1452:
                    return new LoiNghiepVuException("Mã khoa không tồn tại.", ex);
                case 3819:
                    return new LoiNghiepVuException("Dữ liệu vi phạm ràng buộc kiểm tra của CSDL.", ex);
            }
            return ex;
        }
    }
}
