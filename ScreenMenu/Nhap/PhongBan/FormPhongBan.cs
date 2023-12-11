using LTUD1_MF_BHX.BatLoiControl;
using LTUD1_MF_BHX.Model;
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

namespace LTUD1_MF_BHX.ScreenMenu.Nhap.PhongBan
{
    public partial class FormPhongBan : Form
    {
        PhongBanController controller;
        public FormPhongBan()
        {
            InitializeComponent();
            controller = new PhongBanController(Utils.ConnectionString);
            DataGridViewHelper.ConfigureDataGridView(dgvPB);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            controller.SelectAll();
            dgvPB.DataSource = controller.DataSource;
            controller.SelectMaCN();
            cbbMaCN.DataSource = controller.DataSource;
            cbbMaCN.DisplayMember = "TENCN";
            cbbMaCN.ValueMember = "MACN";
        }

        private void dgvPB_Click(object sender, EventArgs e)
        {
            int dong = dgvPB.CurrentCell.RowIndex;
            txtMaPB.Text = dgvPB.Rows[dong].Cells[0].Value.ToString();
            txtTenPB.Text = dgvPB.Rows[dong].Cells[1].Value.ToString();
            cbbMaCN.Text = dgvPB.Rows[dong].Cells[2].Value.ToString();
        }
        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrTxt.CheckControlValue(txtMaPB))
                {
                    MessageBox.Show("txtMaPB", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTxt.CheckControlValue(txtTenPB))
                {
                    MessageBox.Show("txtTenPB", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PhongBan phongBan = new PhongBan();
                phongBan.MaPB = txtMaPB.Text;
                phongBan.TenPB = txtTenPB.Text;
                phongBan.MaCN = cbbMaCN.SelectedValue.ToString();
                controller.Insert(phongBan);
                controller.SelectAll();
                dgvPB.DataSource = controller.DataSource;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnXoa(object sender, EventArgs e)
        {
            PhongBan phongBan = new PhongBan();
            phongBan.MaPB = txtMaPB.Text;
            controller.Delete(phongBan.MaPB);
            controller.SelectAll();
            dgvPB.DataSource = controller.DataSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhongBan phongBan = new PhongBan();
            phongBan.MaPB = txtMaPB.Text;
            phongBan.TenPB = txtTenPB.Text;
            phongBan.MaCN = cbbMaCN.Text;
            controller.Update(phongBan);
            controller.SelectAll();
            dgvPB.DataSource = controller.DataSource;
        }

        private void txtMaPB_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                MessageBox.Show("txtMaPB", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtTenPB_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                MessageBox.Show("txtTenPB", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
