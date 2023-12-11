using LTUD1_MF_BHX.Model;
using LTUD1_MF_BHX.ScreenMenu.Nhap.ChiTietHoaDon;
using LTUD1_MF_BHX.ScreenMenu.Nhap.NhaCungCapCT;
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
        ChiTietNhaCCController controller;
        public FormChiTietNhaCungCap()
        {
            InitializeComponent();
            controller = new ChiTietNhaCCController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvChiTietNCC);
        }
        private void FormChiTietNhaCungCap_Load(object sender, EventArgs e)
        {
            controller.SelectAll();
            dgvChiTietNCC.DataSource = controller.DataSource;
            controller.SelectAllNhaCunCapCBO();
            cboNCC.DataSource = controller.DataSource;
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.ValueMember = "MANCC";
            controller.selectSanPhamCBO();
            cboSanPham.DataSource = controller.DataSource;
            cboSanPham.DisplayMember = "TENSP";
            cboSanPham.ValueMember = "MASP";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvChiTietNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
