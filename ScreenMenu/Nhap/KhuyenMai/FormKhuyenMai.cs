using LTUD1_MF_BHX.Connection;
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
    public partial class FormKhuyenMai : Form
    {
        KhuyenMaiController controller;
        public FormKhuyenMai()
        {
            InitializeComponent();
            controller = new KhuyenMaiController(Utils.ConnectionString);
            cboMaKM.DataSource = controller.sp_cbo_hinhthuckm();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            controller.Insert(new KhuyenMai(cboMaKM.Text,dtpNgayBD.Value,dtpNgayKT.Value,tbTenSP.Text));
                    
        }
    }
}
