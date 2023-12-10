using System.Data;

namespace LTUD1_MF_BHX
{
    public partial class FormNhaCungCap : Form
    {
        NhaCungCapController nccController;
        public FormNhaCungCap()
        {
            InitializeComponent();
            nccController = new NhaCungCapController(Utils.ConnectionString);

        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.ForeColor = Color.Black;
            dgvNhaCungCap.ReadOnly = true;
            dgvNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhaCungCap.MultiSelect = false;


            nccController.SelectAll();
            dgvNhaCungCap.DataSource = nccController.DataSource;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhaCungCap_Click(object sender, EventArgs e)
        {
            // Khởi tạo số dòng đang chọn
            int dong = dgvNhaCungCap.CurrentCell.RowIndex;
            // lấy ra mã
            string manv = dgvNhaCungCap.Rows[dong].Cells[0].Value.ToString()!;
            // khởi tạo đối tượng bằng mã
            DataTable dt = nccController.SelectByID(manv!);
            DataRow dr = dt.Rows[0];
            NhanVien nv = (NhanVien)nccController.FromDataRow(dr);
           
            // cập nhật lại trang thái các nút
            UpdateButtonStates("datagridview_selected");
        }

        
    }
}
