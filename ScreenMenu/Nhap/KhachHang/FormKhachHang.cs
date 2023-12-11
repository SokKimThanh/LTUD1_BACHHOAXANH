using LTUD1_MF_BHX.BatLoiControl;
using LTUD1_MF_BHX.controller;
using LTUD1_MF_BHX.Model;

namespace LTUD1_MF_BHX.ScreenMenu.Nhap
{
    public partial class FormKhachHang : Form
    {
        KhachHangController khachHangController;
        public FormKhachHang()
        {

            InitializeComponent();

            khachHangController = new KhachHangController(Utils.ConnectionString);
            dgvKH.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            khachHangController.SelectAll();
            dgvKH.DataSource = khachHangController.DataSource;
        }

        private void dgvKH_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (ErrTxt.CheckControlValue(txtMa))
                {
                    MessageBox.Show("txtMaKH", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                if (ErrTxt.CheckControlValue(txtxHoTen))
                {
                    MessageBox.Show("txtHoTen", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTxt.CheckControlValue(txtSDT))
                {
                    MessageBox.Show("txtSDT", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                if (ErrTxt.CheckControlValue(txtDTL))
                {
                    MessageBox.Show("txtDRL", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                KhachHang kh = new KhachHang();
                kh.Ma = txtMa.Text;
                kh.Ten = txtxHoTen.Text;
                kh.Sdt = int.Parse(txtSDT.Text);
                kh.Diem = int.Parse(txtDTL.Text);
                khachHangController.Insert(kh);
                khachHangController.SelectAll();
                dgvKH.DataSource = khachHangController.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Ma = txtMa.Text;
            khachHangController.Delete(kh.Ma);
            khachHangController.SelectAll();
            dgvKH.DataSource = khachHangController.DataSource;
        }

        private void dgvKH_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMa.Text = dgvKH.Rows[dong].Cells[0].Value.ToString();
            txtxHoTen.Text = dgvKH.Rows[dong].Cells[1].Value.ToString();
            txtSDT.Text = dgvKH.Rows[dong].Cells[2].Value.ToString();
            txtDTL.Text = dgvKH.Rows[dong].Cells[3].Value.ToString();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                MessageBox.Show("txtHoMaKH", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtxHoTen_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                MessageBox.Show("txtHoTenKH", "chỉ được nhập chữ hoặc số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender) || ErrTxt.NoText_TextChange(sender))
            {
                MessageBox.Show("txtSDT", "chỉ được nhập số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtDTL_TextChanged(object sender, EventArgs e)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender) || ErrTxt.NoText_TextChange(sender))
            {
                MessageBox.Show("txtDRL", "chỉ được nhập số!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
