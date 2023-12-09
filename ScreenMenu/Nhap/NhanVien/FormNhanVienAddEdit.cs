using LTUD1_MF_BHX.BatLoiControl;
using LTUD1_MF_BHX.ScreenMenu.Nhap.NhanVien;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button.RadioButton;

namespace LTUD1_MF_BHX.Screen
{
    public partial class FormNhanVienAddEdit : Form
    {
        NhanVienController nvController = new NhanVienController(Utils.ConnectionString);
        public FormNhanVienAddEdit()
        {
            InitializeComponent();

            // combobox phong ban setting
            cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;

            // data grid view nhanvien setting
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ForeColor = Color.Black;
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.MultiSelect = false;

            // data grid view nhan vien event
            dgvNhanVien.Click += dgvNhanVien_Click!;

            // radio group button event
            // Gán sự kiện CheckedChanged cho các RadioButton
            rbNam.CheckedChanged += new EventHandler(radioButtons_CheckedChanged!);
            rbNu.CheckedChanged += new EventHandler(radioButtons_CheckedChanged!);

            rbNam.Checked = true;

           
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {   

                nvController.SelectAll();
                dgvNhanVien.DataSource = nvController.DataSource;
                //dgvNhanVien.Columns["NhanVienID"].Width = 0;
                //dgvNhanVien.Columns["PhongBanID"].Width = 0;

                DataTable dt = nvController.GetDanhSachPhongBan();
                cboPhongBan.DataSource = dt;
                cboPhongBan.ValueMember = "MAPB";
                cboPhongBan.DisplayMember = "TENPHG";

                // crud button setting state
                UpdateButtonStates("form_loaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Tìm newid cuối của danh sách
        /// </summary>
        /// <param name="prefix">ví dụ: nv0312312</param>
        /// <param name="id_cuoi">ví dụ: 01232123</param>
        /// <returns></returns>
        private string generateID(string prefix, string id_cuoi)
        {
            // idIncrease: bỏ 2 kí tự đầu và chuyển sang số, rồi cộng lên 1
            int idIncrease = Convert.ToInt32(id_cuoi.Trim().Substring(2)) + 1;
            // newid: định dạng số kết quả thành 9 số dạng chuỗi
            string newid = prefix + string.Format("{0:000000000}", idIncrease);
            // newid: trả về kết quả
            return newid;//ví dụ nv0123456789
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiem tra nhap thong tin
                if (ErrTxt.CheckControlValue(txtHoTenNV))
                {
                    MessageBox.Show("txtHoTenNV", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTxt.CheckControlValue(txtLuong))
                {
                    MessageBox.Show("txtLuong", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(txtSDT))
                {
                    MessageBox.Show("txtSDT", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(rtbDiaChi))
                {
                    MessageBox.Show("rtbDiaChi", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(rptNgaySinh))
                {
                    MessageBox.Show("rptNgaySinh", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Random d = new Random();
                nvController.SelectAll();
                //DataRow dongcuoicung = nvController.DataSource.Rows[nvController.DataSource.Rows.Count - 1];
                DataRow dongdautien = nvController.DataSource.Rows[0];
                // id tự động tăng
                //string id_cuoi = (string)dongcuoicung["NhanVienID"];
                string id_dau = (string)dongdautien["NhanVienID"];
                string maNV = generateID("nv", id_dau);

                string hotennv = txtHoTenNV.Text;
                float luong = float.Parse(txtLuong.Text);
                int sdtnv = int.Parse(txtSDT.Text);
                string diachinv = rtbDiaChi.Text;
                DateTime ngaysinh = rptNgaySinh.Value;
                string mapb = cboPhongBan.SelectedValue.ToString()!;
                string gioitinh = rbNam.Checked ? "nam" : rbNu.Checked ? "nu" : string.Empty;
                NhanVien o = new NhanVien(maNV, hotennv, diachinv, luong, sdtnv, ngaysinh, mapb, gioitinh);
                nvController.Insert(o);
                nvController.SelectAll();
                dgvNhanVien.DataSource = nvController.DataSource;
                UpdateButtonStates("refresh_clicked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rtbDiaChi.Text = ex.Message;
            }


        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNhanVien.CurrentCell.RowIndex;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string manv = dgvNhanVien.Rows[dong]
                                         .Cells[0].Value
                                         .ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                DataTable dt = nvController.SelectByID(manv!);
                DataRow dr = dt.Rows[0];
                NhanVien nv = (NhanVien)nvController.FromDataRow(dr);
                txtHoTenNV.Text = nv.Hotennv;
                txtLuong.Text = nv.Luong.ToString();
                txtSDT.Text = nv.Sdtnv.ToString();
                rtbDiaChi.Text = nv.Diachinv;
                cboPhongBan.SelectedValue = nv.Mapb;// chay duoc
                rptNgaySinh.Value = nv.Ngaysinh;//  chay duoc
                if (nv.Gioitinh.Equals("nam"))
                {
                    rbNam.Checked = true;
                }
                else if (nv.Gioitinh.Equals("nu"))
                {
                    rbNu.Checked = true;
                }
                UpdateButtonStates("datagridview_selected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdateButtonStates(string state)
        {
            switch (state)
            {
                case "datagridview_selected":
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnRefresh.Enabled = true;
                    break;
                case "refresh_clicked":
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRefresh.Enabled = true;
                    refresh();
                    break;
                case "form_loaded":
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRefresh.Enabled = true;
                    break;
                case "adding_textChanged":
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRefresh.Enabled = true;
                    break;
                default:
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRefresh.Enabled = false;
                    break;
            }
        }
        public void refresh()
        {
            txtHoTenNV.Text = string.Empty;
            rptNgaySinh.Text = string.Empty;
            rtbDiaChi.Text = string.Empty;
            txtLuong.Text = string.Empty;
            txtSDT.Text = string.Empty;
            cboPhongBan.SelectedIndex = 0;
            nvController.SelectAll();
            dgvNhanVien.DataSource = nvController.DataSource;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateButtonStates("refresh_clicked");
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStates("adding_textChanged");
        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            //System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)sender;

            //if (rbNam.Checked)
            //{
            //    rtbDiaChi.Text = "nam";
            //}
            //else if (rbNu.Checked)
            //{
            //    rtbDiaChi.Text = "nu";
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                string manv = dgvNhanVien.Rows[dong].Cells[0].Value.ToString()!;
                nvController.Delete(manv!);
                UpdateButtonStates("refresh_clicked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiem tra nhap thong tin
                if (ErrTxt.CheckControlValue(txtHoTenNV))
                {
                    MessageBox.Show("txtHoTenNV", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ErrTxt.CheckControlValue(txtLuong))
                {
                    MessageBox.Show("txtLuong", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(txtSDT))
                {
                    MessageBox.Show("txtSDT", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(rtbDiaChi))
                {
                    MessageBox.Show("rtbDiaChi", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (ErrTxt.CheckControlValue(rptNgaySinh))
                {
                    MessageBox.Show("rptNgaySinh", "Bắt buộc nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Random d = new Random();

                int dong = dgvNhanVien.CurrentCell.RowIndex;
                string maNV = dgvNhanVien.Rows[dong].Cells[0].Value.ToString()!;

                string hotennv = txtHoTenNV.Text;
                float luong = float.Parse(txtLuong.Text);
                int sdtnv = int.Parse(txtSDT.Text);
                string diachinv = rtbDiaChi.Text;
                DateTime ngaysinh = rptNgaySinh.Value;
                string mapb = cboPhongBan.SelectedValue.ToString()!;
                string gioitinh = rbNam.Checked ? "nam" : rbNu.Checked ? "nu" : string.Empty;
                NhanVien o = new NhanVien(maNV, hotennv, diachinv, luong, sdtnv, ngaysinh, mapb, gioitinh);
                nvController.Update(o);
               
                UpdateButtonStates("refresh_clicked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rtbDiaChi.Text = ex.Message;
            }
        }
    }
}
