using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_MF_BHX.ScreenMenu.Nhap
{
    public partial class FormSanPham : Form
    {
        SanPhamController spConn;
        KhuyenMaiController kmConn;
        DanhMucController loaiConn;
        NhaCungCapController nCCConn;
        public FormSanPham()
        {
            InitializeComponent();
            spConn = new SanPhamController(Utils.ConnectionString);
            kmConn = new KhuyenMaiController(Utils.ConnectionString);
            loaiConn = new DanhMucController(Utils.ConnectionString);
            nCCConn = new NhaCungCapController(Utils.ConnectionString);
            dgvDanhSachSP.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            spConn.SelectAll();
            dgvDanhSachSP.DataSource = spConn.DataSource;

            kmConn.SelectAll();
            cboKM.DataSource = kmConn.DataSource;
            cboKM.DisplayMember = "makm";

            loaiConn.SelectAll();
            cboLoaiSP.DataSource = loaiConn.DataSource;
            cboLoaiSP.DisplayMember = "TENLOAI";

            nCCConn.SelectAll();
            cboNCC.DataSource = nCCConn.DataSource;
            cboNCC.DisplayMember = "TENNCC";
        }
    }
}
