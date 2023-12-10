using LTUD1_MF_BHX.BatLoiControl;
using LTUD1_MF_BHX.ScreenMenu.Nhap.ChiTietHoaDon;
using LTUD1_MF_BHX.ScreenMenu.Nhap.HoaDon;
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
    public partial class FormChiTietHoaDon : Form
    {
        HoaDonController hdConn;
        SanPhamController spConn;
        ChiTietHoaDonController ctConn;

        public FormChiTietHoaDon()
        {
            InitializeComponent();
            hdConn = new HoaDonController(Utils.ConnectionString);
            spConn = new SanPhamController(Utils.ConnectionString);
            ctConn = new ChiTietHoaDonController(Utils.ConnectionString);
            dgvCTHoaDon.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {


            try
            {
                hdConn.SelectAll();
                cboHoaDon.DataSource = hdConn.DataSource;
                cboHoaDon.DisplayMember = "MAHD";
                cboHoaDon.ValueMember = "MAHD";

                spConn.SelectAll();
                cboSanPham.DataSource = spConn.DataSource;
                cboSanPham.DisplayMember = "TENSP";
                cboSanPham.ValueMember = "MASP";

                ctConn.SelectByID(cboHoaDon.SelectedValue.ToString()!);
                dgvCTHoaDon.DataSource = ctConn.DataSource;

                /* txtThanhTien =  ctConn.TongTien(cboHoaDon.SelectedValue.ToString());*/
                txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString()!);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctConn.KTTonKho(cboSanPham.SelectedValue.ToString(),int.Parse(txtSoLuong.Text));
        }
    }
}
