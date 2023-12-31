﻿using LTUD1_MF_BHX.ScreenMenu.Nhap.DiaDiem;
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
    public partial class FormDiaDiem : Form
    {
        DiaDiemController DiaDiemController;
        public FormDiaDiem()
        {
            InitializeComponent();
            DiaDiemController = new DiaDiemController(Utils.ConnectionString);
            dgvDD.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void FormDiaDiem_Load(object sender, EventArgs e)
        {
            try
            {
                DiaDiemController.SelectAll();
                dgvDD.DataSource = DiaDiemController.DataSource;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DiaDiem diaDiem = new DiaDiem();
            diaDiem.MaCN = txtMaCN.Text;
            diaDiem.TenCN = txtTenCN.Text;
            diaDiem.DiaChi = txtDC.Text;
            DiaDiemController.Insert(diaDiem);
            DiaDiemController.SelectAll();
            dgvDD.DataSource = DiaDiemController.DataSource;
        }
        private void dgvDD_Click(object sender, EventArgs e)
        {
            int dong = dgvDD.CurrentCell.RowIndex;
            txtMaCN.Text = dgvDD.Rows[dong].Cells[0].Value.ToString();
            txtTenCN.Text = dgvDD.Rows[dong].Cells[1].Value.ToString();
            txtDC.Text = dgvDD.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DiaDiem diaDiem = new DiaDiem();
            diaDiem.MaCN = txtMaCN.Text;
            diaDiem.TenCN = txtTenCN.Text;
            diaDiem.DiaChi = txtDC.Text;
            DiaDiemController.Update(diaDiem);
            DiaDiemController.SelectAll();
            dgvDD.DataSource = DiaDiemController.DataSource;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DiaDiem diaDiem = new DiaDiem();
            diaDiem.MaCN = txtMaCN.Text;
            DiaDiemController.Delete(diaDiem.MaCN);
            DiaDiemController.SelectAll();
            dgvDD.DataSource = DiaDiemController.DataSource;
        }
    }
}
