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
            dgvTaiKhoan = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dtpCreatedDate = new DateTimePicker();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtCCCD = new TextBox();
            txtNhapLaiMK = new TextBox();
            txtMK = new TextBox();
            txtTenTK = new TextBox();
            label7 = new Label();
            txtMaTK = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTaiKhoan.Dock = DockStyle.Right;
            dgvTaiKhoan.Location = new Point(412, 0);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvTaiKhoan.RowTemplate.Height = 28;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.ShowEditingIcon = false;
            dgvTaiKhoan.Size = new Size(388, 450);
            dgvTaiKhoan.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpCreatedDate);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtNhapLaiMK);
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(txtTenTK);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMaTK);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 450);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 85);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác dữ liệu";
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.Format = DateTimePickerFormat.Short;
            dtpCreatedDate.Location = new Point(169, 24);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(237, 26);
            dtpCreatedDate.TabIndex = 27;
            dtpCreatedDate.Value = new DateTime(2023, 11, 16, 23, 58, 21, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 325);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 26);
            txtEmail.TabIndex = 26;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(169, 276);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(237, 26);
            txtSDT.TabIndex = 25;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(169, 227);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(237, 26);
            txtCCCD.TabIndex = 24;
            // 
            // txtNhapLaiMK
            // 
            txtNhapLaiMK.Location = new Point(169, 183);
            txtNhapLaiMK.Name = "txtNhapLaiMK";
            txtNhapLaiMK.Size = new Size(237, 26);
            txtNhapLaiMK.TabIndex = 22;
            txtNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(169, 143);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(237, 26);
            txtMK.TabIndex = 23;
            txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenTK
            // 
            txtTenTK.Location = new Point(169, 105);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(237, 26);
            txtTenTK.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 30);
            label7.Name = "label7";
            label7.Size = new Size(128, 19);
            label7.TabIndex = 19;
            label7.Text = "Ngày Tạo Tài khoản";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaTK
            // 
            txtMaTK.Enabled = false;
            txtMaTK.Location = new Point(169, 56);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(237, 26);
            txtMaTK.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 323);
            label6.Name = "label6";
            label6.Size = new Size(41, 19);
            label6.TabIndex = 18;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 283);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 17;
            label5.Text = "Số Điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 234);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 16;
            label4.Text = "CCCD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 186);
            label8.Name = "label8";
            label8.Size = new Size(122, 19);
            label8.TabIndex = 15;
            label8.Text = "Nhập lại Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 150);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 14;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 108);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 13;
            label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 63);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 12;
            label1.Text = "Mã tài khoản";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(276, 37);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 36);
            btnSua.TabIndex = 33;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(148, 37);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 36);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 36);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // FormTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvTaiKhoan);
            Name = "FormTaiKhoan";
            Text = "Danh sách tài khoản";
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTaiKhoan;
        private GroupBox groupBox1;
        private DateTimePicker dtpCreatedDate;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtCCCD;
        private TextBox txtNhapLaiMK;
        private TextBox txtMK;
        private TextBox txtTenTK;
        private Label label7;
        private TextBox txtMaTK;
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