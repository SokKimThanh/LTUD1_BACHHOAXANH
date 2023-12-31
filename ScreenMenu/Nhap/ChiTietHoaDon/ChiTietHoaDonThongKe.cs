﻿using LTUD1_MF_BHX.ScreenMenu.Nhap.HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_MF_BHX.ScreenMenu.Nhap.ChiTietHoaDon
{
    public partial class ChiTietHoaDonThongKe : Form
    {
        ChiTietHoaDonController ctConn;
        HoaDonController hdConn;
        public ChiTietHoaDonThongKe()
        {
            InitializeComponent();
            ctConn = new ChiTietHoaDonController(Utils.ConnectionString);
            hdConn = new HoaDonController(Utils.ConnectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hdConn.SelectAll();
            cboHD.DataSource = hdConn.DataSource;
            cboHD.DisplayMember = "MAHD";
            cboHD.ValueMember = "MAHD";

            ctConn.SelectByID(cboHD.SelectedValue.ToString());
            dgvDanhSach.DataSource = ctConn.DataSource;
        }

        private void cboHD_TextChanged(object sender, EventArgs e)
        {
            ctConn.SelectByID(cboHD.SelectedValue.ToString());
            dgvDanhSach.DataSource = ctConn.DataSource;
        }
    }
}
