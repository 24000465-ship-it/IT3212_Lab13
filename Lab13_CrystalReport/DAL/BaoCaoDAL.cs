using System.Data;
using MySql.Data.MySqlClient;

namespace Lab13_CrystalReport.DAL
{
    public class BaoCaoDAL
    {
        private DataTable LayBang(string tenBang, string sql)
        {
            DataTable table = new DataTable(tenBang);
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
            {
                adapter.Fill(table);
            }
            return table;
        }

        public DataTable GetStudentReportData()
        {
            return LayBang("SinhVienReport", "SELECT * FROM vw_BaoCaoSinhVien ORDER BY TenKhoa, HoTen");
        }

        public DataTable GetFacultyReportData()
        {
            return LayBang("KhoaReport", "SELECT * FROM vw_BaoCaoKhoa ORDER BY TenKhoa");
        }

        public DataTable GetCourseReportData()
        {
            return LayBang("HocPhanReport", "SELECT * FROM vw_BaoCaoHocPhan ORDER BY TenHP");
        }
    }
}
