namespace LTUD1_MF_BHX.ScreenMenu.HeThong
{
    partial class FormAccount
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
            txtTenDangNhap = new TextBox();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            txtCCCD = new TextBox();
            txtSDT = new TextBox();
            txtMatKhau = new TextBox();
            groupBox7 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(39, 31);
            txtTenDangNhap.Margin = new Padding(3, 2, 3, 2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            txtTenDangNhap.Size = new Size(228, 39);
            txtTenDangNhap.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(800, 450);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(39, 279);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(228, 39);
            txtEmail.TabIndex = 4;
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(39, 217);
            txtCCCD.Margin = new Padding(3, 2, 3, 2);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.PlaceholderText = "CCCD";
            txtCCCD.Size = new Size(228, 39);
            txtCCCD.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(39, 151);
            txtSDT.Margin = new Padding(3, 2, 3, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Số điện thoại";
            txtSDT.Size = new Size(228, 39);
            txtSDT.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(39, 88);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.Size = new Size(228, 39);
            txtMatKhau.TabIndex = 1;
            // 
            // groupBox7
            // 
            groupBox7.Location = new Point(8, 8);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(200, 100);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.SeaShell;
            button3.Location = new Point(5, 5);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(23, 91);
            button3.TabIndex = 2;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SeaShell;
            button2.Location = new Point(5, 5);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(23, 91);
            button2.TabIndex = 1;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(0, 340);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(800, 110);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(btnSua, 2, 0);
            tableLayoutPanel2.Controls.Add(btnXoa, 1, 0);
            tableLayoutPanel2.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel2.Location = new Point(3, 18);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 90);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            tableLayoutPanel2.SetColumnSpan(btnSua, 2);
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatAppearance.BorderSize = 3;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnSua.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.SeaShell;
            btnSua.Location = new Point(532, 4);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(258, 82);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            tableLayoutPanel2.SetColumnSpan(btnXoa, 2);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatAppearance.BorderSize = 3;
            btnXoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.SeaShell;
            btnXoa.Location = new Point(268, 4);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(256, 82);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            tableLayoutPanel2.SetColumnSpan(btnThem, 2);
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatAppearance.BorderSize = 3;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.SeaShell;
            btnThem.Location = new Point(4, 4);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(256, 82);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // FormAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAccount";
            Text = "FormQuanLyTaiKhoan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTenDangNhap;
        private GroupBox groupBox1;
        private GroupBox groupBox7;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button2;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private TextBox txtCCCD;
        private TextBox txtSDT;
    }
}