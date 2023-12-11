namespace LTUD1_MF_BHX.ScreenDetail
{
    partial class FormChiTietHoaDon
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
            groupBox13 = new GroupBox();
            cboSanPham = new ComboBox();
            groupBox9 = new GroupBox();
            cboHoaDon = new ComboBox();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtCapNhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtThanhTien = new TextBox();
            button1 = new Button();
            txtSoLuong = new TextBox();
            groupBox3 = new GroupBox();
            dgvCTHoaDon = new DataGridView();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHoaDon).BeginInit();
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
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1284, 729);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 723);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mặt hàng";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox13, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox9, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 35);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0161953F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.9838F));
            tableLayoutPanel2.Size = new Size(373, 685);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(cboSanPham);
            groupBox13.Dock = DockStyle.Fill;
            groupBox13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox13.ForeColor = Color.White;
            groupBox13.Location = new Point(3, 78);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(367, 604);
            groupBox13.TabIndex = 20;
            groupBox13.TabStop = false;
            groupBox13.Text = "Sản phẩm";
            // 
            // cboSanPham
            // 
            cboSanPham.Dock = DockStyle.Fill;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(3, 29);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(361, 33);
            cboSanPham.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(cboHoaDon);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(3, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(367, 69);
            groupBox9.TabIndex = 16;
            groupBox9.TabStop = false;
            groupBox9.Text = "Hóa đơn";
            // 
            // cboHoaDon
            // 
            cboHoaDon.Dock = DockStyle.Fill;
            cboHoaDon.FormattingEnabled = true;
            cboHoaDon.Location = new Point(3, 29);
            cboHoaDon.Name = "cboHoaDon";
            cboHoaDon.Size = new Size(361, 33);
            cboHoaDon.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 854);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
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
            tableLayoutPanel4.Location = new Point(388, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(893, 723);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 581);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(887, 139);
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
            tableLayoutPanel1.Controls.Add(txtCapNhat, 0, 0);
            tableLayoutPanel1.Controls.Add(btnXoa, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.Size = new Size(881, 101);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCapNhat
            // 
            txtCapNhat.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(txtCapNhat, 2);
            txtCapNhat.Dock = DockStyle.Fill;
            txtCapNhat.FlatAppearance.BorderSize = 3;
            txtCapNhat.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            txtCapNhat.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            txtCapNhat.FlatStyle = FlatStyle.Flat;
            txtCapNhat.ForeColor = Color.SeaShell;
            txtCapNhat.Location = new Point(297, 5);
            txtCapNhat.Margin = new Padding(5);
            txtCapNhat.Name = "txtCapNhat";
            txtCapNhat.Size = new Size(282, 91);
            txtCapNhat.TabIndex = 2;
            txtCapNhat.Text = "Cập nhật đơn hàng";
            txtCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(btnXoa, 2);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatAppearance.BorderSize = 3;
            btnXoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.SeaShell;
            btnXoa.Location = new Point(5, 5);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(282, 91);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa sản phẩm";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(btnThem, 2);
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatAppearance.BorderSize = 3;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.SeaShell;
            btnThem.Location = new Point(589, 5);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(287, 91);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm sản phẩm ";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel5.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(893, 578);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel6);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(3, 465);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(887, 110);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kiểm tra tồn kho";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel6.Controls.Add(txtThanhTien, 2, 0);
            tableLayoutPanel6.Controls.Add(button1, 1, 0);
            tableLayoutPanel6.Controls.Add(txtSoLuong, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel6.Location = new Point(3, 35);
            tableLayoutPanel6.Margin = new Padding(5);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(881, 72);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Dock = DockStyle.Fill;
            txtThanhTien.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtThanhTien.Location = new Point(589, 3);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.PlaceholderText = "Tạm tính";
            txtThanhTien.Size = new Size(289, 39);
            txtThanhTien.TabIndex = 5;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SeaShell;
            button1.Location = new Point(298, 5);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(283, 62);
            button1.TabIndex = 4;
            button1.Text = "Kiểm tra tồn kho";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Fill;
            txtSoLuong.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(3, 3);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.PlaceholderText = "Nhập số lượng mua hàng";
            txtSoLuong.Size = new Size(287, 39);
            txtSoLuong.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvCTHoaDon);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(887, 456);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách";
            // 
            // dgvCTHoaDon
            // 
            dgvCTHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHoaDon.Dock = DockStyle.Left;
            dgvCTHoaDon.Location = new Point(3, 35);
            dgvCTHoaDon.Name = "dgvCTHoaDon";
            dgvCTHoaDon.RowHeadersWidth = 51;
            dgvCTHoaDon.RowTemplate.Height = 29;
            dgvCTHoaDon.Size = new Size(878, 418);
            dgvCTHoaDon.TabIndex = 0;
            // 
            // FormChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1284, 729);
            Controls.Add(tableLayoutPanel3);
            Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FormChiTietHoaDon";
            Text = "Xử lý đơn hàng(Hóa đơn chi tiết)";
            Load += FormChiTietHoaDon_Load;
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox13.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnXoa;
        private Button btnThem;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button1;
        private TextBox txtSoLuong;
        private GroupBox groupBox9;
        private TextBox txtThanhTien;
        private GroupBox groupBox13;
        private ComboBox cboSanPham;
        private Button txtCapNhat;
        private DataGridView dgvCTHoaDon;
        private ComboBox cboHoaDon;
    }
}