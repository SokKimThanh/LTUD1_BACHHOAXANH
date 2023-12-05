namespace LTUD1_MF_BHX
{
    public partial class FormNhaCungCap : Form
    {
        NhaCungCapController controller;
        public FormNhaCungCap()
        {
            InitializeComponent();
            controller = new NhaCungCapController(Utils.ConnectionString);

        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.DataSource;
        }
    }
}
