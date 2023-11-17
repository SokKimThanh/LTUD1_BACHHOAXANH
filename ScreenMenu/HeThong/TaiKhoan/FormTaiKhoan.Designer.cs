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
            btnSua = new Button();
            btnXoa = new Button();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(700, 355);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.Format = DateTimePickerFormat.Short;
            dtpCreatedDate.Location = new Point(148, 19);
            dtpCreatedDate.Margin = new Padding(3, 2, 3, 2);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(208, 23);
            dtpCreatedDate.TabIndex = 27;
            dtpCreatedDate.Value = new DateTime(2023, 11, 16, 23, 58, 21, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 257);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 26;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(148, 218);
            txtSDT.Margin = new Padding(3, 2, 3, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(208, 23);
            txtSDT.TabIndex = 25;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(148, 179);
            txtCCCD.Margin = new Padding(3, 2, 3, 2);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(208, 23);
            txtCCCD.TabIndex = 24;
            // 
            // txtNhapLaiMK
            // 
            txtNhapLaiMK.Location = new Point(148, 144);
            txtNhapLaiMK.Margin = new Padding(3, 2, 3, 2);
            txtNhapLaiMK.Name = "txtNhapLaiMK";
            txtNhapLaiMK.Size = new Size(208, 23);
            txtNhapLaiMK.TabIndex = 22;
            txtNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(148, 113);
            txtMK.Margin = new Padding(3, 2, 3, 2);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(208, 23);
            txtMK.TabIndex = 23;
            txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(148, 83);
            txtTenTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(208, 23);
            txtTenTaiKhoan.TabIndex = 21;
            txtTenTaiKhoan.TextChanged += txtTenTK_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 24);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 19;
            label7.Text = "Ngày Tạo Tài khoản";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Enabled = false;
            txtMaTaiKhoan.Location = new Point(148, 53);
            txtMaTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.Size = new Size(208, 23);
            txtMaTaiKhoan.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 255);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 18;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 223);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 17;
            label5.Text = "Số Điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 185);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 16;
            label4.Text = "CCCD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 147);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 15;
            label8.Text = "Nhập lại Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 118);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 14;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 85);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 13;
            label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 57);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 12;
            label1.Text = "Mã tài khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 288);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(700, 67);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác dữ liệu";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(242, 29);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 28);
            btnSua.TabIndex = 33;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(130, 29);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 28);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 29);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 28);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 355);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTaiKhoan";
            Text = "Danh sách tài khoản";
            Load += FormTaiKhoan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
        private Button btnSua;
        private Button btnXoa;
        private Button btnAdd;
    }
}