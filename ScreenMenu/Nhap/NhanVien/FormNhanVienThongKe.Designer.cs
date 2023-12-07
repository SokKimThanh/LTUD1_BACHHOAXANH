namespace LTUD1_MF_BHX.ScreenMenu.Nhap.NhanVien
{
    partial class FormNhanVienThongKe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dgvThongKeNV = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            btnThongKeSLNV = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKeNV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.Size = new Size(1029, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvThongKeNV);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(4, 109);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1021, 517);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê";
            // 
            // dgvThongKeNV
            // 
            dgvThongKeNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKeNV.Dock = DockStyle.Fill;
            dgvThongKeNV.Location = new Point(4, 26);
            dgvThongKeNV.Margin = new Padding(4);
            dgvThongKeNV.Name = "dgvThongKeNV";
            dgvThongKeNV.Size = new Size(1013, 487);
            dgvThongKeNV.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnThongKeSLNV);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 97);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(615, 36);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(137, 32);
            button2.TabIndex = 1;
            button2.Text = "Tắt form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnThoat_Click;
            // 
            // btnThongKeSLNV
            // 
            btnThongKeSLNV.Location = new Point(448, 36);
            btnThongKeSLNV.Margin = new Padding(4);
            btnThongKeSLNV.Name = "btnThongKeSLNV";
            btnThongKeSLNV.Size = new Size(159, 32);
            btnThongKeSLNV.TabIndex = 0;
            btnThongKeSLNV.Text = "Tìm kiếm";
            btnThongKeSLNV.UseVisualStyleBackColor = true;
            btnThongKeSLNV.Click += btnTimKiem;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 29);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormNhanVienThongKe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormNhanVienThongKe";
            Text = "FormNhanVienThongKe";
            Load += FormNhanVienThongKe_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKeNV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private DataGridView dgvThongKeNV;
        private Panel panel1;
        private Button button2;
        private Button btnThongKeSLNV;
        private TextBox textBox1;
    }
}