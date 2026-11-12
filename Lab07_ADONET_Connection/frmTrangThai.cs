using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab07_ADONET_Connection
{
    public partial class frmTrangThai : Form
    {
        private MySqlConnection _conn;
        private double _thoiGianMo = -1;
        private DateTime _lucKetNoi;

        public frmTrangThai()
        {
            InitializeComponent();
        }

        private void frmTrangThai_Load(object sender, EventArgs e)
        {
            try
            {
                _conn = DbConnectionFactory.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            HienThi();
        }

        private void HienThi()
        {
            if (_conn == null) return;
            bool dangMo = _conn.State == ConnectionState.Open;
            lblDataSource.Text = _conn.DataSource;
            lblDatabase.Text = _conn.Database;
            lblServerVersion.Text = dangMo ? _conn.ServerVersion : "(chỉ có khi đang mở kết nối)";
            lblState.Text = _conn.State.ToString();
            lblState.ForeColor = dangMo ? System.Drawing.Color.DarkGreen : System.Drawing.Color.Red;
            lblTimeout.Text = _conn.ConnectionTimeout + " giây";
            lblTaiKhoan.Text = DbConnectionFactory.ThongTin().UserID;
            lblThoiGianMo.Text = _thoiGianMo >= 0 ? _thoiGianMo.ToString("0.00") + " ms" : "...";
            lblLucKetNoi.Text = _thoiGianMo >= 0 ? _lucKetNoi.ToString("HH:mm:ss dd/MM/yyyy") : "...";
            btnMoKetNoi.Enabled = !dangMo;
            btnDongKetNoi.Enabled = dangMo;
        }

        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            if (_conn == null) return;
            try
            {
                Stopwatch dongHo = Stopwatch.StartNew();
                _conn.Open();
                dongHo.Stop();
                _thoiGianMo = dongHo.Elapsed.TotalMilliseconds;
                _lucKetNoi = DateTime.Now;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThi();
        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if (_conn == null) return;
            _conn.Close();
            HienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTrangThai_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_conn != null)
                _conn.Dispose();
        }
    }
}
