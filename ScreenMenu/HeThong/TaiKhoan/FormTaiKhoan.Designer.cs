namespace LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan
{
    partial class FormTaiKhoan
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
            groupBox1 = new GroupBox();
            dtpCreatedDate = new DateTimePicker();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtCCCD = new TextBox();
            txtNhapLaiMK = new TextBox();
            txtMK = new TextBox();
            txtTenTaiKhoan = new TextBox();
            label7 = new Label();
            txtMaTaiKhoan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSua = new Button();
            btnAdd = new Button();
            btnXoa = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvTaiKhoan = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dtpCreatedDate);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtNhapLaiMK);
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(txtTenTaiKhoan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMaTaiKhoan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 581);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.Format = DateTimePickerFormat.Short;
            dtpCreatedDate.Location = new Point(279, 108);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(237, 29);
            dtpCreatedDate.TabIndex = 27;
            dtpCreatedDate.Value = new DateTime(2023, 11, 16, 23, 58, 21, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(279, 399);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 29);
            txtEmail.TabIndex = 26;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(279, 358);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(237, 29);
            txtSDT.TabIndex = 25;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(279, 315);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(237, 29);
            txtCCCD.TabIndex = 24;
            // 
            // txtNhapLaiMK
            // 
            txtNhapLaiMK.Location = new Point(279, 270);
            txtNhapLaiMK.Name = "txtNhapLaiMK";
            txtNhapLaiMK.Size = new Size(237, 29);
            txtNhapLaiMK.TabIndex = 22;
            txtNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(279, 230);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(237, 29);
            txtMK.TabIndex = 23;
            txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(279, 189);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(237, 29);
            txtTenTaiKhoan.TabIndex = 21;
            txtTenTaiKhoan.TextChanged += txtTenTK_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 114);
            label7.Name = "label7";
            label7.Size = new Size(145, 21);
            label7.TabIndex = 19;
            label7.Text = "Ngày Tạo Tài khoản";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Enabled = false;
            txtMaTaiKhoan.Location = new Point(279, 151);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.Size = new Size(237, 29);
            txtMaTaiKhoan.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 407);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 18;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 366);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 17;
            label5.Text = "Số Điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 318);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 16;
            label4.Text = "CCCD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 270);
            label8.Name = "label8";
            label8.Size = new Size(137, 21);
            label8.TabIndex = 15;
            label8.Text = "Nhập lại Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 233);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 14;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 192);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 13;
            label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 156);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 12;
            label1.Text = "Mã tài khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 590);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 130);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnSua, 2, 0);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnXoa, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(624, 105);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Fill;
            btnSua.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(419, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(202, 99);
            btnSua.TabIndex = 36;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(202, 99);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(211, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(202, 99);
            btnXoa.TabIndex = 35;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvTaiKhoan, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1284, 729);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 81.3063049F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6936932F));
            tableLayoutPanel3.Size = new Size(636, 723);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(645, 3);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowTemplate.Height = 28;
            dgvTaiKhoan.Size = new Size(636, 723);
            dgvTaiKhoan.TabIndex = 1;
            dgvTaiKhoan.Click += dgvTaiKhoan_Click;
            // 
            // FormTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1284, 729);
            Controls.Add(tableLayoutPanel2);
            ForeColor = Color.White;
            Name = "FormTaiKhoan";
            Text = "Danh sách tài khoản";
            Load += FormTaiKhoan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DateTimePicker dtpCreatedDate;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtCCCD;
        private TextBox txtNhapLaiMK;
        private TextBox txtMK;
        private TextBox txtTenTaiKhoan;
        private Label label7;
        private TextBox txtMaTaiKhoan;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSua;
        private Button btnAdd;
        private Button btnXoa;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dgvTaiKhoan;
    }
}