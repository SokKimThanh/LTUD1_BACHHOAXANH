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


            hdConn.SelectAll();
            cboHoaDon.DataSource = hdConn.DataSource;
            cboHoaDon.DisplayMember = "MAHD";
            cboHoaDon.ValueMember = "MAHD";

            spConn.SelectAll();
            cboSanPham.DataSource = spConn.DataSource;
            cboSanPham.DisplayMember = "TENSP";
            cboSanPham.ValueMember = "MASP";

            ctConn.SelectByID(cboHoaDon.SelectedValue.ToString());
            dgvCTHoaDon.DataSource = ctConn.DataSource;

            /* txtThanhTien =  ctConn.TongTien(cboHoaDon.SelectedValue.ToString());*/
            txtThanhTien.Text = ctConn.TongTien(cboHoaDon.SelectedValue.ToString());

        }

        private void btnKTTonKho_Click(object sender, EventArgs e)
        {
            ctConn.KTTonKho(cboSanPham.SelectedValue.ToString(), int.Parse(txtSoLuong.Text));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaHD = cboHoaDon.SelectedValue.ToString();
            cthd.MaSP = cboSanPham.SelectedValue.ToString();
            cthd.SoLuong = int.Parse(txtSoLuong.Text);

            try
            {
                ctConn.Insert(cthd);
                FormChiTietHoaDon_Load(sender, e);
                if (ctConn.KTMASP(cthd.MaSP) == false)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = cboHoaDon.SelectedValue.ToString();
                cthd.MaSP = cboSanPham.SelectedValue.ToString();
                cthd.SoLuong = int.Parse(txtSoLuong.Text);
                ctConn.Update(cthd);
                FormChiTietHoaDon_Load(sender, e);

                MessageBox.Show("Sửa sản phẩm thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = cboHoaDon.SelectedValue.ToString();
                cthd.MaSP = cboSanPham.SelectedValue.ToString();
                ctConn.Delete(cthd);
                FormChiTietHoaDon_Load(sender, e);

                MessageBox.Show("Xoa sản phẩm thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
