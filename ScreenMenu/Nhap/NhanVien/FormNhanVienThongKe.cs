using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_MF_BHX.ScreenMenu.Nhap.NhanVien
{
    public partial class FormNhanVienThongKe : Form
    {
        NhanVienController controller = new NhanVienController(Utils.ConnectionString);
        public FormNhanVienThongKe()
        {
            InitializeComponent();
        }

        private void FormNhanVienThongKe_Load(object sender, EventArgs e)
        {
            dgvThongKeNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeNV.ForeColor = Color.Black;
            dgvThongKeNV.ReadOnly = true;
            dgvThongKeNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKeNV.DataSource = controller.ThongKeNhanVien();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
