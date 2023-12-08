using LTUD1_MF_BHX.ScreenMenu.Nhap.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_MF_BHX.Screen
{
    public partial class FormNhanVienAddEdit : Form
    {
        NhanVienController nvController = new NhanVienController(Utils.ConnectionString);
        public FormNhanVienAddEdit()
        {
            InitializeComponent();


            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ForeColor = Color.Black;
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                nvController.SelectAll();
                dgvNhanVien.DataSource = nvController.DataSource;
                DataTable dt = nvController.DanhSachPhongBan();
                cboPhongBan.DataSource = dt;
                cboPhongBan.ValueMember = "MAPB";
                cboPhongBan.DisplayMember = "TENPHG";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
             
        }
        private string generateID(string id_cuoi)
        {
            int bonsocuoi = Convert.ToInt32(id_cuoi.Substring(2)) + 1;
            string manv = "nv" + String.Format("{0:0000}", bonsocuoi);
            return manv;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Random d = new Random();
                nvController.SelectAll();
                DataRow dongcuoicung = nvController.DataSource.Rows[nvController.DataSource.Rows.Count - 1];
                string id_cuoi = (string)dongcuoicung["MANV"];
                string maNV = generateID(id_cuoi);
                string hotennv = txtHoTenNV.Text;
                float luong = float.Parse(txtLuong.Text);
                int sdtnv = int.Parse(txtSDT.Text);
                string diachinv = rtbDiaChi.Text;

                string mapb = cboPB.SelectedValue.ToString();
                NhanVien o = new NhanVien(maNV, hotennv, diachinv, luong, sdtnv, dtpNgaySinh.Value, mapb, null);
                nvController.Insert(o);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSVNTheoCNPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                string manv = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                DataTable dt = nvController.SelectByID(manv);
                DataRow dr = dt.Rows[0];
                NhanVien nv = (NhanVien)nvController.FromDataRow(dr);
                txtHoTenNV.Text = nv.Hotennv;
                txtLuong.Text = nv.Luong.ToString();
                txtSDT.Text = nv.Sdtnv.ToString();
                rtbDiaChi.Text = nv.Diachinv;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }
    }
}
