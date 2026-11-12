using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab08_SqlCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int DemSinhVien()
        {
            using (MySqlConnection conn = DbConnectionFactory.Create())
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM SinhVien", conn))
            {
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void btnDemSV_Click(object sender, EventArgs e)
        {

            try
            {
                int soSV = DemSinhVien();
                lblSoSV.Text = "Số sinh viên " + soSV;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDocDS_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DbConnectionFactory.Create())
                using (MySqlCommand cmd = new MySqlCommand(
                "SELECT MaSV, HoTen, DiemTB FROM SinhVien ORDER BY HoTen", conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        lstSinhVien.Items.Clear();
                        while (reader.Read())
                        {
                            string line = string.Format("{0} - {1} - {2:N2}",
                            reader["MaSV"], reader["HoTen"], reader["DiemTB"]);
                            lstSinhVien.Items.Add(line);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.ShowDialog();
        }

        private void btnTheoKhoa_Click(object sender, EventArgs e)
        {
            frmTheoKhoa f = new frmTheoKhoa();
            f.ShowDialog();
        }
    }
}
