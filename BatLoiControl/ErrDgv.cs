using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX.BatLoiControl
{
    internal class ErrDgv : DataGridView
    {
        public ErrDgv()
        {
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
            this.ReadOnly = true;
        }
        public void LoadData(DataTable data)
        {
            this.DataSource = data;
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
