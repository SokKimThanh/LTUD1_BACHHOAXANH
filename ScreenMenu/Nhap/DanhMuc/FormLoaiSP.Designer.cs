﻿namespace LTUD1_MF_BHX.ScreenMenu.Nhap.DanhMuc
{
    partial class FormLoaiSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox7 = new GroupBox();
            txtGhiChu = new TextBox();
            txgroupbox = new GroupBox();
            txtMaLoai = new TextBox();
            groupBox5 = new GroupBox();
            txtTenMaLoai = new TextBox();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            groupBox10 = new GroupBox();
            dgvDS = new DataGridView();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox7.SuspendLayout();
            txgroupbox.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1145, 612);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 606);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox7, 0, 2);
            tableLayoutPanel2.Controls.Add(txgroupbox, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1052628F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1052628F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65.7894745F));
            tableLayoutPanel2.Size = new Size(331, 580);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtGhiChu);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(3, 201);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(325, 376);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(3, 38);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(361, 39);
            txtGhiChu.TabIndex = 0;
            // 
            // txgroupbox
            // 
            txgroupbox.Controls.Add(txtMaLoai);
            txgroupbox.Dock = DockStyle.Fill;
            txgroupbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txgroupbox.ForeColor = Color.White;
            txgroupbox.Location = new Point(3, 3);
            txgroupbox.Name = "txgroupbox";
            txgroupbox.Size = new Size(325, 93);
            txgroupbox.TabIndex = 3;
            txgroupbox.TabStop = false;
            txgroupbox.Text = "Mã loại sản phẩm";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Dock = DockStyle.Fill;
            txtMaLoai.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaLoai.Location = new Point(3, 35);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(319, 47);
            txtMaLoai.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTenMaLoai);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(3, 102);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(325, 93);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tên sản phẩm";
            // 
            // txtTenMaLoai
            // 
            txtTenMaLoai.Dock = DockStyle.Fill;
            txtTenMaLoai.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenMaLoai.Location = new Point(3, 35);
            txtTenMaLoai.Name = "txtTenMaLoai";
            txtTenMaLoai.Size = new Size(319, 47);
            txtTenMaLoai.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 854);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(346, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(796, 606);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 487);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(790, 116);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel1.Controls.Add(btnSua, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.Size = new Size(784, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Enabled = false;
            btnXoa.FlatAppearance.BorderSize = 3;
            btnXoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.SeaShell;
            btnXoa.Location = new Point(265, 5);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 80);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.Dock = DockStyle.Fill;
            btnSua.Enabled = false;
            btnSua.FlatAppearance.BorderSize = 3;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnSua.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.SeaShell;
            btnSua.Location = new Point(135, 5);
            btnSua.Margin = new Padding(5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 80);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatAppearance.BorderSize = 3;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.SeaShell;
            btnThem.Location = new Point(5, 5);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 80);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(groupBox10, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(790, 478);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(dgvDS);
            groupBox10.Dock = DockStyle.Fill;
            groupBox10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox10.ForeColor = Color.White;
            groupBox10.Location = new Point(3, 3);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(784, 472);
            groupBox10.TabIndex = 7;
            groupBox10.TabStop = false;
            groupBox10.Text = "Danh sách";
            // 
            // dgvDS
            // 
            dgvDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(6, 35);
            dgvDS.Name = "dgvDS";
            dgvDS.ReadOnly = true;
            dgvDS.RowHeadersWidth = 51;
            dgvDS.RowTemplate.Height = 29;
            dgvDS.Size = new Size(869, 525);
            dgvDS.TabIndex = 0;
            dgvDS.Click += dgvDS_Click;
            dgvDS.DoubleClick += dgvHTKM_DoubleClick;
            // 
            // FormLoaiSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1145, 612);
            Controls.Add(tableLayoutPanel3);
            Name = "FormLoaiSP";
            Text = "Loại_sp";
            Load += FormLoaisp_Load;
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            txgroupbox.ResumeLayout(false);
            txgroupbox.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox7;
        private TextBox txtGhiChu;
        private GroupBox txt;
        private TextBox txtMaLoai;
        private GroupBox groupBox5;
        private TextBox txtTenMaLoai;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox10;
        private DataGridView dgvDS;
        private GroupBox txgroupbox;
    }
}