using LTUD1_MF_BHX.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_MF_BHX.ScreenDetail
{
    public partial class FormChiTietNhaCungCap : Form
    {
        public FormChiTietNhaCungCap()
        {
            InitializeComponent();
            DataGridViewHelper.ConfigureDataGridView(dataGridView1);
        }

        private void FormChiTietNhaCungCap_Load(object sender, EventArgs e)
        {
              
        }
    }
}
