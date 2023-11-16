using LTUD1_MF_BHX.BatLoiControl;
using LTUD1_MF_BHX.connection;
using LTUD1_MF_BHX.Connection;

namespace LTUD1_MF_BHX.ScreenMenu.HeThong
{
    public partial class FormAccount : Form
    {
        AccountController controller;
        public FormAccount()
        {
            InitializeComponent();
            KhoiTao();

        }

        private void KhoiTao()
        {
            controller = new AccountController(Utils.ConnectionString);
        }

        protected void buttonCreate_Click(object sender, EventArgs e)
        {
            // Create
            try
            {
                Account acc = new Account();
                this.controller.Insert(acc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void buttonRead_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void buttonUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
