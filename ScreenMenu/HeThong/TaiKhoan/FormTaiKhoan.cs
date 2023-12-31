﻿using LTUD1_MF_BHX.Model;
using System.ComponentModel.Design.Serialization;
using System.Data;

namespace LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan
{
    public partial class FormTaiKhoan : Form
    {
        AccountController controller;


        public FormTaiKhoan()
        {
            InitializeComponent();
            controller = new AccountController(Utils.ConnectionString);
            // data grid view setting
            DataGridViewHelper.ConfigureDataGridView(dgvTaiKhoan);
            dgvTaiKhoan.Click += new EventHandler(dgvTaiKhoan_Click!);
        }



        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                controller.SelectAll();
                dgvTaiKhoan.DataSource = controller.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Insert(new Account(txtTenTaiKhoan.Text, txtMK.Text, Utils.GenerateRandomAlphanumericString(11), DateTime.Parse(dtpCreatedDate.Value.ToShortDateString()), txtSDT.Text, txtCCCD.Text, txtEmail.Text));
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            try
            {
                controller.SelectAll();
                dgvTaiKhoan.DataSource = controller.DataSource;
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
                controller.Delete(txtTenTaiKhoan.Text);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                controller.Update(new Account(txtTenTaiKhoan.Text, txtMK.Text, Utils.GenerateRandomAlphanumericString(11), txtSDT.Text, txtCCCD.Text, txtEmail.Text));
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void txtTenTK_TextChanged(object sender, EventArgs e)
        {

        }

         

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            int dong = dgvTaiKhoan.CurrentCell.RowIndex;
            txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[dong].Cells[0].Value.ToString();
            DataRow row = controller.SelectByID(txtTenTaiKhoan.Text!).Rows[0];

            Account o = (Account)controller.FromDataRow(row);
            if (o != null)
            {
                txtTenTaiKhoan.Text = o.TenTaiKhoan;
                txtSDT.Text = o.Phone;
                txtEmail.Text = o.Email;
                txtCCCD.Text = o.Cccd;
                txtMK.Text = o.MatKhau;
            }
        }
    }
}