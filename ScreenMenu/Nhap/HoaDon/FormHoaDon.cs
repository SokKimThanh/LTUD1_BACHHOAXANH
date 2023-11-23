using LTUD1_MF_BHX.Connection;
using LTUD1_MF_BHX.controller;
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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            HoaDonController = new HoaDonController(Utils.ConnectionString);
            dgvHD.DefaultCellStyle.ForeColor = Color.Black;
        }
        HoaDonController HoaDonController;
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonController.SelectAll();
            dgvHD.DataSource = HoaDonController.DataSource;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
