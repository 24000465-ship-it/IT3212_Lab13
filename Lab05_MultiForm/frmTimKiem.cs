using System;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmTimKiem : Form
    {
        // Kết quả trả về cho form gọi
        public string TuKhoa { get; private set; }
        public bool TimTheoMa { get; private set; }

        public frmTimKiem()
        {
            InitializeComponent();
            TuKhoa = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa!", "Thông báo");
                txtTuKhoa.Focus();
                return;
            }
            TuKhoa = txtTuKhoa.Text.Trim();
            TimTheoMa = radTheoMa.Checked;
            this.DialogResult = DialogResult.OK;   // đóng form và báo cho form gọi là đã bấm Tìm
        }
    }
}
