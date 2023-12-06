using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_MF_BHX.Screen
{
    public partial class FormNhanVien : Form
    {
        NhanVienController nhanVienController = new NhanVienController(Utils.ConnectionString);
        public FormNhanVien()
        {
            InitializeComponent();

            dgvThongKeSLNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeSLNV.ForeColor = Color.Black;
            dgvThongKeSLNV.ReadOnly = true;
            dgvThongKeSLNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDSVNTheoCNPB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSVNTheoCNPB.ForeColor = Color.Black;
            dgvDSVNTheoCNPB.ReadOnly = true;
            dgvDSVNTheoCNPB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Thiết lập độ rộng của dòng đầu tiên là 25%
            tblNhanVien.RowStyles.Add(new RowStyle(SizeType.Absolute, 0));
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dgvThongKeSLNV.DataSource = nhanVienController.ThongKeNhanVien();
            dgvDSVNTheoCNPB.DataSource = nhanVienController.DanhSachNhanVienTheoChiNhanhPhongBan();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Thiết lập độ rộng của dòng thứ hai là 38%
            tblNhanVien.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
        }
    }
}
