namespace LTUD1_MF_BHX.Screen.HeThong
{
    partial class FormCaiDat
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
            TreeNode treeNode1 = new TreeNode("Đổi mật khẩu");
            TreeNode treeNode2 = new TreeNode("Quên mật khẩu");
            TreeNode treeNode3 = new TreeNode("Thiết lập tài khoản", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Tài khoản chi tiết");
            TreeNode treeNode5 = new TreeNode("Quản trị tài khoản");
            TreeNode treeNode6 = new TreeNode("Quản lý tài khoản", new TreeNode[] { treeNode4, treeNode5 });
            tvSettingList = new TreeView();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // tvSettingList
            // 
            tvSettingList.BackColor = Color.DarkSlateGray;
            tvSettingList.Dock = DockStyle.Left;
            tvSettingList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tvSettingList.ForeColor = Color.LightCyan;
            tvSettingList.Location = new Point(0, 0);
            tvSettingList.Name = "tvSettingList";
            treeNode1.Name = "nodeChangePassword";
            treeNode1.Text = "Đổi mật khẩu";
            treeNode2.Name = "nodeForgotPassword";
            treeNode2.Text = "Quên mật khẩu";
            treeNode3.Name = "nodeAccountSetting";
            treeNode3.Text = "Thiết lập tài khoản";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Tài khoản chi tiết";
            treeNode5.Name = "nodeAccountList";
            treeNode5.Text = "Quản trị tài khoản";
            treeNode6.Name = "nodeAccountCRUD";
            treeNode6.Text = "Quản lý tài khoản";
            tvSettingList.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode6 });
            tvSettingList.Size = new Size(211, 570);
            tvSettingList.TabIndex = 0;
            tvSettingList.AfterSelect += tvSettingList_AfterSelect;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(211, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 570);
            panel1.TabIndex = 1;
            // 
            // FormCaiDat
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(914, 570);
            Controls.Add(panel1);
            Controls.Add(tvSettingList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCaiDat";
            Text = "Cài đặt";
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvSettingList;
        private Panel panel1;
    }
}