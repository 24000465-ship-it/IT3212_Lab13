using System;
using System.Collections.Generic;
using System.Data;
using Lab11_CRUD_StoredProcedure.DTO;
using MySql.Data.MySqlClient;

namespace Lab11_CRUD_StoredProcedure.DAL
{
    public class KhoaDAL
    {
        public List<KhoaDTO> DanhSach()
        {
            List<KhoaDTO> ds = new List<KhoaDTO>();
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("sp_Khoa_DanhSach", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KhoaDTO khoa = new KhoaDTO();
                            khoa.MaKhoa = reader["MaKhoa"].ToString();
                            khoa.TenKhoa = reader["TenKhoa"].ToString();
                            khoa.SoSinhVien = Convert.ToInt32(reader["SoSinhVien"]);
                            ds.Add(khoa);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    throw LoiCsdl.ChuyenDoi(ex);
                }
            }
            return ds;
        }

        private int ThucThi(string tenThuTuc, string maKhoa, string tenKhoa)
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand(tenThuTuc, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_MaKhoa", MySqlDbType.VarChar, 10).Value = maKhoa;
                if (tenKhoa != null)
                    cmd.Parameters.Add("p_TenKhoa", MySqlDbType.VarChar, 100).Value = tenKhoa;
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    throw LoiCsdl.ChuyenDoi(ex);
                }
            }
        }

        public int Insert(KhoaDTO dto)
        {
            return ThucThi("sp_Khoa_Insert", dto.MaKhoa, dto.TenKhoa);
        }

        public int Update(KhoaDTO dto)
        {
            return ThucThi("sp_Khoa_Update", dto.MaKhoa, dto.TenKhoa);
        }

        public int Delete(string maKhoa)
        {
            return ThucThi("sp_Khoa_Delete", maKhoa, null);
        }
    }
}
