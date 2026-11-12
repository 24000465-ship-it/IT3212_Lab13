using System;
using System.Collections.Generic;
using System.Data;
using Lab11_CRUD_StoredProcedure.DTO;
using MySql.Data.MySqlClient;

namespace Lab11_CRUD_StoredProcedure.DAL
{
    public class SinhVienDAL
    {
        public List<SinhVienDTO> TimKiem(string tuKhoa, string maKhoa, bool hienDaXoa)
        {
            List<SinhVienDTO> ds = new List<SinhVienDTO>();
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("sp_SinhVien_TimKiem", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_TuKhoa", MySqlDbType.VarChar, 100).Value = tuKhoa;
                cmd.Parameters.Add("p_MaKhoa", MySqlDbType.VarChar, 10).Value = maKhoa;
                cmd.Parameters.Add("p_HienDaXoa", MySqlDbType.Byte).Value = hienDaXoa ? 1 : 0;
                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ds.Add(DocSinhVien(reader));
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

        private SinhVienDTO DocSinhVien(MySqlDataReader reader)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.MaSV = reader["MaSV"].ToString();
            sv.HoTen = reader["HoTen"].ToString();
            sv.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
            sv.GioiTinh = Convert.ToBoolean(reader["GioiTinh"]);
            sv.MaKhoa = reader["MaKhoa"].ToString();
            sv.TenKhoa = reader["TenKhoa"].ToString();
            sv.DiemTB = Convert.ToDecimal(reader["DiemTB"]);
            sv.Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString();
            sv.IsActive = Convert.ToBoolean(reader["IsActive"]);
            return sv;
        }

        private void ThemThamSo(MySqlCommand cmd, SinhVienDTO dto)
        {
            cmd.Parameters.Add("p_MaSV", MySqlDbType.VarChar, 15).Value = dto.MaSV;
            cmd.Parameters.Add("p_HoTen", MySqlDbType.VarChar, 100).Value = dto.HoTen;
            cmd.Parameters.Add("p_NgaySinh", MySqlDbType.Date).Value = dto.NgaySinh;
            cmd.Parameters.Add("p_GioiTinh", MySqlDbType.Bit).Value = dto.GioiTinh;
            cmd.Parameters.Add("p_MaKhoa", MySqlDbType.VarChar, 10).Value = dto.MaKhoa;
            cmd.Parameters.Add("p_DiemTB", MySqlDbType.Decimal).Value = dto.DiemTB;
            cmd.Parameters.Add("p_Email", MySqlDbType.VarChar, 100).Value =
                string.IsNullOrWhiteSpace(dto.Email) ? (object)DBNull.Value : dto.Email;
        }

        private int ThucThi(MySqlConnection conn, MySqlCommand cmd)
        {
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

        public int Insert(SinhVienDTO dto)
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("sp_SinhVien_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                ThemThamSo(cmd, dto);
                return ThucThi(conn, cmd);
            }
        }

        public int Update(SinhVienDTO dto)
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("sp_SinhVien_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                ThemThamSo(cmd, dto);
                return ThucThi(conn, cmd);
            }
        }

        public int Delete(string maSV)
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("sp_SinhVien_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_MaSV", MySqlDbType.VarChar, 15).Value = maSV;
                return ThucThi(conn, cmd);
            }
        }

        public int KhoiPhuc(string maSV)
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("sp_SinhVien_KhoiPhuc", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_MaSV", MySqlDbType.VarChar, 15).Value = maSV;
                return ThucThi(conn, cmd);
            }
        }

        public bool EmailDaTonTai(string email, string maSV)
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("sp_SinhVien_KiemTraEmail", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_Email", MySqlDbType.VarChar, 100).Value = email;
                cmd.Parameters.Add("p_MaSV", MySqlDbType.VarChar, 15).Value = maSV;
                try
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
                catch (MySqlException ex)
                {
                    throw LoiCsdl.ChuyenDoi(ex);
                }
            }
        }
    }
}
