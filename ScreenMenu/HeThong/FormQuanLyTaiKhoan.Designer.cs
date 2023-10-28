namespace LTUD1_MF_BHX.ScreenMenu.HeThong
{
    partial class FormQuanLyTaiKhoan
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
            ColumnHeader chPhoneNumber;
            textBox1 = new TextBox();
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            groupBox7 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button4 = new Button();
            btnThem = new Button();
            chIdAccount = new ColumnHeader();
            chUsername = new ColumnHeader();
            chPassword = new ColumnHeader();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            chCCCD = new ColumnHeader();
            chEmail = new ColumnHeader();
            chPhoneNumber = new ColumnHeader();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(45, 39);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tên đăng nhập";
            textBox1.Size = new Size(260, 39);
            textBox1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { chIdAccount, chPassword, chUsername, chPhoneNumber, chCCCD, chEmail });
            listView1.Dock = DockStyle.Left;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HoverSelection = true;
            listView1.Location = new Point(0, 0);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(532, 570);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(532, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 570);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
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
            groupBox2.Location = new Point(532, 431);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 139);
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
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Controls.Add(button4, 1, 0);
            tableLayoutPanel2.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Margin = new Padding(5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(376, 114);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            tableLayoutPanel2.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SeaShell;
            button1.Location = new Point(253, 5);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(118, 104);
            button1.TabIndex = 2;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            tableLayoutPanel2.SetColumnSpan(button4, 2);
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.SeaShell;
            button4.Location = new Point(129, 5);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(114, 104);
            button4.TabIndex = 1;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
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
            btnThem.Location = new Point(5, 5);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 104);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // chIdAccount
            // 
            chIdAccount.Width = 0;
            // 
            // chUsername
            // 
            chUsername.DisplayIndex = 1;
            chUsername.Text = "Tên đăng nhập";
            chUsername.Width = 132;
            // 
            // chPassword
            // 
            chPassword.DisplayIndex = 2;
            chPassword.Text = "Mật khẩu";
            chPassword.Width = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(45, 111);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mật khẩu";
            textBox2.Size = new Size(260, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(45, 191);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Số điện thoại";
            textBox3.Size = new Size(260, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(45, 275);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "CCCD";
            textBox4.Size = new Size(260, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(45, 354);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email";
            textBox5.Size = new Size(260, 39);
            textBox5.TabIndex = 4;
            // 
            // chPhoneNumber
            // 
            chPhoneNumber.Text = "Số điện thoại";
            chPhoneNumber.Width = 132;
            // 
            // chCCCD
            // 
            chCCCD.Text = "CCCD";
            chCCCD.Width = 132;
            // 
            // chEmail
            // 
            chEmail.Text = "Email";
            chEmail.Width = 132;
            // 
            // FormQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(914, 570);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            ForeColor = SystemColors.ControlText;
            Name = "FormQuanLyTaiKhoan";
            Text = "FormQuanLyTaiKhoan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private ListView listView1;
        private GroupBox groupBox1;
        private ColumnHeader chIdAccount;
        private ColumnHeader chUsername;
        private ColumnHeader chPassword;
        private GroupBox groupBox7;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button2;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button4;
        private Button btnThem;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private ColumnHeader chCCCD;
        private ColumnHeader chEmail;
    }
}