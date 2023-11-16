using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan
{
    public partial class FormTaiKhoan : Form
    {
        TaiKhoanController controller;
        CustomDataGridView dgv;

        public FormTaiKhoan()
        {
            InitializeComponent();
            controller = new TaiKhoanController(Utils.ConnectionString);
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
                controller.Insert(new TaiKhoan(txtTenTK.Text, txtMK.Text, txtMaTK.Text, DateTime.Parse(dtpCreatedDate.Value.ToShortDateString()), txtSDT.Text, txtCCCD.Text, txtEmail.Text));
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
                controller.Delete(txtMaTK.Text);
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
                controller.Update(new TaiKhoan(txtTenTK.Text, txtMK.Text, txtMaTK.Text, txtSDT.Text, txtCCCD.Text, txtEmail.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong > 0)
            {
                string s = dgv.Rows[dong].Cells[0].Value.ToString()!;
                DataRow row = controller.SelectByID(s!).Rows[0];

                TaiKhoan o = (TaiKhoan)controller.FromDataRow(row);
                txtMaTK.Text = o.MaTaiKhoan;
                txtTenTK.Text = o.TenTaiKhoan;
                txtSDT.Text = o.Phone;
                txtEmail.Text = o.Email;
                txtCCCD.Text = o.Cccd;
                txtMK.Text = o.MatKhau;

            }

        }
    }
}
