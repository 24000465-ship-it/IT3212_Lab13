using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab10_DisconnectedData
{
    public partial class frmXml : Form
    {
        private DataSet ds;
        private string duongDan;

        public frmXml()
        {
            InitializeComponent();
        }

        private void frmXml_Load(object sender, EventArgs e)
        {
            duongDan = Path.Combine(Application.StartupPath, "QLSinhVien.xml");
            lblDuongDan.Text = "Tệp XML: " + duongDan;
        }

        private void HienDataSet(string nguon)
        {
            dgvKhoa.DataSource = ds.Tables["Khoa"];
            dgvSinhVien.DataSource = ds.Tables["SinhVien"];
            GiaoDien.DatTieuDe(dgvKhoa);
            GiaoDien.DatTieuDe(dgvSinhVien);

            string quanHe = ds.Relations.Count > 0 ? ds.Relations[0].RelationName : "(không có)";
            lblThongTin.Text = nguon + ": Khoa " + ds.Tables["Khoa"].Rows.Count + " dòng, SinhVien "
                + ds.Tables["SinhVien"].Rows.Count + " dòng, quan hệ " + quanHe
                + ".\nKiểu cột DiemTB: " + ds.Tables["SinhVien"].Columns["DiemTB"].DataType.Name
                + ", NgaySinh: " + ds.Tables["SinhVien"].Columns["NgaySinh"].DataType.Name;
        }

        private void btnNapCSDL_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet("QLSinhVien");
                using (MySqlConnection conn = DbConnectionFactory.Create())
                {
                    new MySqlDataAdapter("SELECT * FROM Khoa ORDER BY MaKhoa", conn).Fill(ds, "Khoa");
                    new MySqlDataAdapter("SELECT * FROM SinhVien ORDER BY MaSV", conn).Fill(ds, "SinhVien");
                }
                ds.Relations.Add(new DataRelation("FK_Khoa_SinhVien",
                    ds.Tables["Khoa"].Columns["MaKhoa"],
                    ds.Tables["SinhVien"].Columns["MaKhoa"]));
                HienDataSet("Nạp từ CSDL");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void btnGhiXml_Click(object sender, EventArgs e)
        {
            if (ds == null)
            {
                MessageBox.Show("Hãy nạp dữ liệu trước khi ghi XML.", "Ghi XML");
                return;
            }
            try
            {
                ds.WriteXml(duongDan, XmlWriteMode.WriteSchema);
                FileInfo tep = new FileInfo(duongDan);
                MessageBox.Show("Đã ghi DataSet kèm schema ra tệp:\n" + duongDan + "\n(" + tep.Length / 1024 + " KB)", "Ghi XML");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Không ghi được tệp: " + ex.Message, "Lỗi");
            }
        }

        private void btnDocXml_Click(object sender, EventArgs e)
        {
            if (!File.Exists(duongDan))
            {
                MessageBox.Show("Chưa có tệp XML. Hãy nạp từ CSDL rồi ghi XML trước.", "Đọc XML");
                return;
            }
            try
            {
                DataSet dsMoi = new DataSet();
                dsMoi.ReadXml(duongDan, XmlReadMode.ReadSchema);
                ds = dsMoi;
                HienDataSet("Đọc từ tệp XML, không mở kết nối CSDL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đọc được tệp: " + ex.Message, "Lỗi");
            }
        }
    }
}
