using System.Configuration;
using MySql.Data.MySqlClient;

namespace Lab10_DisconnectedData
{
    public static class DbConnectionFactory
    {
        private const string TenChuoiKetNoi = "QLSinhVien";

        private static string ConnectionString
        {
            get
            {
                ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings[TenChuoiKetNoi];
                if (cs == null)
                    throw new ConfigurationErrorsException("Không tìm thấy chuỗi kết nối '" + TenChuoiKetNoi + "' trong App.config.");
                return cs.ConnectionString;
            }
        }

        public static MySqlConnection Create()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
