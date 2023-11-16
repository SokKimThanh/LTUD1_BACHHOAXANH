using System.Data;

namespace LTUD1_MF_BHX.CustomControl
{
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            ReadOnly = true;
        }
        public void LoadData(DataTable data)
        {
            DataSource = data;
        }
        public void VidDu()
        {
            //ErrDgv dgv = new ErrDgv();
            //DataTable data = GetData(); // Lấy dữ liệu từ nguồn dữ liệu của bạn
            //dgv.LoadData(data);
            //this.Controls.Add(dgv); // Thêm DataGridView vào form

        }
    }
}
