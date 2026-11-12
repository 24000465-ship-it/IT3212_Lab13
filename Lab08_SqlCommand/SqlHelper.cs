using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Lab08_SqlCommand
{
    public static class SqlHelper
    {
        public static MySqlParameter ThamSo(string ten, MySqlDbType kieu, object giaTri)
        {
            MySqlParameter p = new MySqlParameter(ten, kieu);
            p.Value = giaTri ?? DBNull.Value;
            return p;
        }

        private static MySqlCommand TaoLenh(string sql, MySqlConnection conn, MySqlParameter[] thamSo)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (thamSo != null)
            {
                for (int i = 0; i < thamSo.Length; i++)
                {
                    cmd.Parameters.Add(thamSo[i]);
                }
            }
            return cmd;
        }

        public static object ExecuteScalar(string sql, params MySqlParameter[] thamSo)
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = TaoLenh(sql, conn, thamSo))
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public static int ExecuteNonQuery(string sql, params MySqlParameter[] thamSo)
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = TaoLenh(sql, conn, thamSo))
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static MySqlDataReader ExecuteReader(string sql, params MySqlParameter[] thamSo)
        {
            MySqlConnection conn = DbConnectionFactory.Create();
            try
            {
                MySqlCommand cmd = TaoLenh(sql, conn, thamSo);
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                conn.Dispose();
                throw;
            }
        }

        public static DataTable ExecuteDataTable(string sql, params MySqlParameter[] thamSo)
        {
            using (MySqlDataReader reader = ExecuteReader(sql, thamSo))
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
    }
}
