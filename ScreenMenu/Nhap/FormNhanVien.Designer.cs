namespace LTUD1_MF_BHX.Screen
{
    partial class FormNhanVien
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
            groupBox18 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            groupBox19 = new GroupBox();
            textBox5 = new TextBox();
            groupBox20 = new GroupBox();
            textBox6 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            groupBox15 = new GroupBox();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            chTenNCC = new ColumnHeader();
            chDiaChi = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox14 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox9 = new GroupBox();
            textBox1 = new TextBox();
            groupBox8 = new GroupBox();
            textBox2 = new TextBox();
            groupBox7 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox6 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox5 = new GroupBox();
            comboBox2 = new ComboBox();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            tableLayoutPanel7.SuspendLayout();
            groupBox19.SuspendLayout();
            groupBox20.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox15.SuspendLayout();
            groupBox14.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox18
            // 
            groupBox18.Location = new Point(0, 0);
            groupBox18.Name = "groupBox18";
            groupBox18.Size = new Size(200, 100);
            groupBox18.TabIndex = 0;
            groupBox18.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(groupBox19, 0, 2);
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(textBox5);
            groupBox19.Dock = DockStyle.Fill;
            groupBox19.ForeColor = Color.White;
            groupBox19.Location = new Point(3, 3);
            groupBox19.Name = "groupBox19";
            groupBox19.Size = new Size(194, 94);
            groupBox19.TabIndex = 12;
            groupBox19.TabStop = false;
            groupBox19.Text = "Họ tên";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(3, 22);
            textBox5.Margin = new Padding(5);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Họ và tên";
            textBox5.Size = new Size(188, 26);
            textBox5.TabIndex = 5;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(textBox6);
            groupBox20.Dock = DockStyle.Fill;
            groupBox20.ForeColor = Color.White;
            groupBox20.Location = new Point(3, 86);
            groupBox20.Name = "groupBox20";
            groupBox20.Size = new Size(194, 77);
            groupBox20.TabIndex = 11;
            groupBox20.TabStop = false;
            groupBox20.Text = "Số điện thoại";
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(3, 22);
            textBox6.Margin = new Padding(5);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "số điện thoại";
            textBox6.Size = new Size(188, 26);
            textBox6.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(groupBox15, 0, 0);
            tableLayoutPanel5.Controls.Add(groupBox14, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(388, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(893, 723);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(listView2);
            groupBox15.Dock = DockStyle.Fill;
            groupBox15.ForeColor = Color.White;
            groupBox15.Location = new Point(3, 3);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new Size(887, 572);
            groupBox15.TabIndex = 7;
            groupBox15.TabStop = false;
            groupBox15.Text = "Danh sách";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, chTenNCC, chDiaChi, columnHeader2 });
            listView2.Dock = DockStyle.Fill;
            listView2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(3, 35);
            listView2.Margin = new Padding(5);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(881, 534);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IDNhaCungCap";
            columnHeader1.Width = 0;
            // 
            // chTenNCC
            // 
            chTenNCC.Text = "Tên Nhà Cung Cấp";
            chTenNCC.Width = 200;
            // 
            // chDiaChi
            // 
            chDiaChi.DisplayIndex = 3;
            chDiaChi.Text = "Địa chỉ";
            chDiaChi.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "Số ĐT";
            columnHeader2.Width = 200;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(tableLayoutPanel6);
            groupBox14.Dock = DockStyle.Fill;
            groupBox14.ForeColor = Color.White;
            groupBox14.Location = new Point(3, 581);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(887, 139);
            groupBox14.TabIndex = 8;
            groupBox14.TabStop = false;
            groupBox14.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 6;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.Controls.Add(button1, 0, 0);
            tableLayoutPanel6.Controls.Add(button4, 0, 0);
            tableLayoutPanel6.Controls.Add(button5, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel6.Location = new Point(3, 35);
            tableLayoutPanel6.Margin = new Padding(5);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel6.Size = new Size(881, 101);
            tableLayoutPanel6.TabIndex = 0;
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
            button1.Location = new Point(297, 5);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(136, 91);
            button1.TabIndex = 2;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.SeaShell;
            button4.Location = new Point(151, 5);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(136, 91);
            button4.TabIndex = 1;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.SeaShell;
            button5.Location = new Point(5, 5);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(136, 91);
            button5.TabIndex = 0;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1284, 729);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 723);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox9, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox8, 0, 4);
            tableLayoutPanel2.Controls.Add(groupBox7, 0, 3);
            tableLayoutPanel2.Controls.Add(groupBox6, 0, 5);
            tableLayoutPanel2.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(373, 685);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(textBox1);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(3, 231);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(367, 108);
            groupBox9.TabIndex = 12;
            groupBox9.TabStop = false;
            groupBox9.Text = "Họ tên";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 35);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Họ và tên";
            textBox1.Size = new Size(361, 39);
            textBox1.TabIndex = 5;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox2);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.ForeColor = Color.White;
            groupBox8.Location = new Point(3, 459);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(367, 108);
            groupBox8.TabIndex = 11;
            groupBox8.TabStop = false;
            groupBox8.Text = "Số điện thoại";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 35);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "số điện thoại";
            textBox2.Size = new Size(361, 39);
            textBox2.TabIndex = 9;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dateTimePicker1);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(3, 345);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(367, 108);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(3, 35);
            dateTimePicker1.Margin = new Padding(6, 4, 6, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(361, 39);
            dateTimePicker1.TabIndex = 19;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(richTextBox1);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(3, 573);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(367, 109);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "Địa chỉ";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(361, 71);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox2);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.ForeColor = Color.Snow;
            groupBox5.Location = new Point(3, 117);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(367, 108);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Trưởng phòng ";
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 35);
            comboBox2.Margin = new Padding(5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(361, 40);
            comboBox2.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = Color.Snow;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(367, 108);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Phòng ban";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 35);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(361, 40);
            comboBox1.TabIndex = 0;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1284, 729);
            Controls.Add(tableLayoutPanel3);
            Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "FormNhanVien";
            Text = "Nhập thông tin nhân viên";
            Load += FormNhanVien_Load;
            tableLayoutPanel7.ResumeLayout(false);
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            groupBox20.ResumeLayout(false);
            groupBox20.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            groupBox15.ResumeLayout(false);
            groupBox14.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox18;
        private TableLayoutPanel tableLayoutPanel7;
        private GroupBox groupBox19;
        private TextBox textBox5;
        private GroupBox groupBox20;
        private TextBox textBox6;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox15;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader chTenNCC;
        private ColumnHeader chDiaChi;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox14;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button1;
        private Button button4;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox9;
        private TextBox textBox1;
        private GroupBox groupBox8;
        private TextBox textBox2;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private RichTextBox richTextBox1;
        private GroupBox groupBox5;
        private ComboBox comboBox2;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
    }
}