using LTUD1_MF_BHX.Model;
using LTUD1_MF_BHX.ScreenMenu.Nhap.ChiTietHoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_MF_BHX.ScreenDetail
{
    public partial class FormChiTietNhaCungCap : Form
    {
        ChiTietHoaDonController controller;
        public FormChiTietNhaCungCap()
        {
            InitializeComponent();
            controller = new ChiTietHoaDonController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvChiTietNCC);
        }
        private void FormChiTietNhaCungCap_Load(object sender, EventArgs e)
        {
            controller.SelectAll();
            dgvChiTietNCC.DataSource = controller.DataSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            controller.SelectAll();
            dgvChiTietNCC.DataSource = controller.DataSource;
        }
    }
}
