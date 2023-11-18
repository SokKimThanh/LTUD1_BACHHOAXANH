using System.ComponentModel.Design.Serialization;
using System.Data;

namespace LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan
{
    public partial class FormTaiKhoan : Form
    {
        AccountController controller;
        CustomDataGridView dgv;

        public FormTaiKhoan()
        {
            InitializeComponent();
            controller = new AccountController(Utils.ConnectionString);
            dgv = new CustomDataGridView();
            this.Controls.Add(dgv);
            dgv.CellContentClick += customDataGridView1_CellContentClick!;
            dgv.Dock = DockStyle.Right;
        }



        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                controller.SelectAll();
                this.dgv.DataSource = controller.DataSource;
                txtMaTaiKhoan.Text = Utils.GenerateRandomAlphanumericString(11);
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
                controller.Insert(new Account(txtTenTaiKhoan.Text, txtMK.Text, txtMaTaiKhoan.Text, DateTime.Parse(dtpCreatedDate.Value.ToShortDateString()), txtSDT.Text, txtCCCD.Text, txtEmail.Text));
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
                this.dgv.DataSource = controller.DataSource;
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
                controller.Delete(txtMaTaiKhoan.Text);
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
                controller.Update(new Account(txtTenTaiKhoan.Text, txtMK.Text, txtMaTaiKhoan.Text, txtSDT.Text, txtCCCD.Text, txtEmail.Text));
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;


            txtMaTaiKhoan.Text = dgv.Rows[dong].Cells[0].Value.ToString();
            DataRow row = controller.SelectByID(txtMaTaiKhoan.Text!).Rows[0];

            Account o = (Account)controller.FromDataRow(row);
            if (o != null)
            {
                txtMaTaiKhoan.Text = o.MaTaiKhoan;
                txtTenTaiKhoan.Text = o.TenTaiKhoan;
                txtSDT.Text = o.Phone;
                txtEmail.Text = o.Email;
                txtCCCD.Text = o.Cccd;
                txtMK.Text = o.MatKhau;
            } 
        }

        private void txtTenTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            txtMaTaiKhoan.Text = Utils.GenerateRandomAlphanumericString(11);
        }
    }
}