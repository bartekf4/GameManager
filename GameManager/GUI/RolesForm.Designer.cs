namespace GameManager.GUI
{
    partial class RolesForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.users_groupBox = new System.Windows.Forms.GroupBox();
            this.users_listBox = new System.Windows.Forms.ListBox();
            this.roles_groupBox = new System.Windows.Forms.GroupBox();
            this.role_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.assign = new System.Windows.Forms.TabPage();
            this.define = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.roles_define_groupBox = new System.Windows.Forms.GroupBox();
            this.define_listBox = new System.Windows.Forms.ListBox();
            this.canAdd_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.edit_groupBox = new System.Windows.Forms.GroupBox();
            this.canEdit_treeView = new System.Windows.Forms.TreeView();
            this.add_groupBox = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.manage = new System.Windows.Forms.TabPage();
            this.addROle_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.addNewRole_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.roleAddName_label = new System.Windows.Forms.Label();
            this.addNewRole_textBox = new System.Windows.Forms.TextBox();
            this.addNewRole_button = new System.Windows.Forms.Button();
            this.deleteRole_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.delete_button = new System.Windows.Forms.Button();
            this.delete_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.users_groupBox.SuspendLayout();
            this.roles_groupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.assign.SuspendLayout();
            this.define.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.roles_define_groupBox.SuspendLayout();
            this.canAdd_groupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.edit_groupBox.SuspendLayout();
            this.add_groupBox.SuspendLayout();
            this.manage.SuspendLayout();
            this.addROle_groupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.addNewRole_groupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.deleteRole_groupBox.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.users_groupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.roles_groupBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.36255F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // users_groupBox
            // 
            this.users_groupBox.Controls.Add(this.users_listBox);
            this.users_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_groupBox.Location = new System.Drawing.Point(3, 3);
            this.users_groupBox.Name = "users_groupBox";
            this.users_groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.users_groupBox.Size = new System.Drawing.Size(419, 457);
            this.users_groupBox.TabIndex = 0;
            this.users_groupBox.TabStop = false;
            this.users_groupBox.Text = "Users";
            // 
            // users_listBox
            // 
            this.users_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_listBox.FormattingEnabled = true;
            this.users_listBox.ItemHeight = 20;
            this.users_listBox.Location = new System.Drawing.Point(10, 30);
            this.users_listBox.Name = "users_listBox";
            this.users_listBox.Size = new System.Drawing.Size(399, 417);
            this.users_listBox.TabIndex = 0;
            this.users_listBox.SelectedIndexChanged += new System.EventHandler(this.users_listBox_SelectedIndexChanged);
            // 
            // roles_groupBox
            // 
            this.roles_groupBox.Controls.Add(this.role_checkedListBox);
            this.roles_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roles_groupBox.Location = new System.Drawing.Point(428, 3);
            this.roles_groupBox.Name = "roles_groupBox";
            this.roles_groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.roles_groupBox.Size = new System.Drawing.Size(419, 457);
            this.roles_groupBox.TabIndex = 1;
            this.roles_groupBox.TabStop = false;
            this.roles_groupBox.Text = "User\'s role";
            // 
            // role_checkedListBox
            // 
            this.role_checkedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.role_checkedListBox.FormattingEnabled = true;
            this.role_checkedListBox.Location = new System.Drawing.Point(10, 30);
            this.role_checkedListBox.Name = "role_checkedListBox";
            this.role_checkedListBox.Size = new System.Drawing.Size(399, 417);
            this.role_checkedListBox.TabIndex = 0;
            this.role_checkedListBox.SelectedIndexChanged += new System.EventHandler(this.role_checkedListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.assign);
            this.tabControl1.Controls.Add(this.define);
            this.tabControl1.Controls.Add(this.manage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 502);
            this.tabControl1.TabIndex = 1;
            // 
            // assign
            // 
            this.assign.Controls.Add(this.tableLayoutPanel1);
            this.assign.Location = new System.Drawing.Point(4, 29);
            this.assign.Name = "assign";
            this.assign.Padding = new System.Windows.Forms.Padding(3);
            this.assign.Size = new System.Drawing.Size(856, 469);
            this.assign.TabIndex = 0;
            this.assign.Text = "Assign users to roles";
            this.assign.UseVisualStyleBackColor = true;
            // 
            // define
            // 
            this.define.Controls.Add(this.tableLayoutPanel2);
            this.define.Location = new System.Drawing.Point(4, 29);
            this.define.Name = "define";
            this.define.Padding = new System.Windows.Forms.Padding(3);
            this.define.Size = new System.Drawing.Size(856, 469);
            this.define.TabIndex = 1;
            this.define.Text = "Define entitlements ";
            this.define.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.roles_define_groupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.canAdd_groupBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(850, 463);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // roles_define_groupBox
            // 
            this.roles_define_groupBox.Controls.Add(this.define_listBox);
            this.roles_define_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roles_define_groupBox.Location = new System.Drawing.Point(3, 3);
            this.roles_define_groupBox.Name = "roles_define_groupBox";
            this.roles_define_groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.roles_define_groupBox.Size = new System.Drawing.Size(419, 457);
            this.roles_define_groupBox.TabIndex = 0;
            this.roles_define_groupBox.TabStop = false;
            this.roles_define_groupBox.Text = "Role";
            // 
            // define_listBox
            // 
            this.define_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.define_listBox.FormattingEnabled = true;
            this.define_listBox.ItemHeight = 20;
            this.define_listBox.Location = new System.Drawing.Point(10, 30);
            this.define_listBox.Name = "define_listBox";
            this.define_listBox.Size = new System.Drawing.Size(399, 417);
            this.define_listBox.TabIndex = 0;
            // 
            // canAdd_groupBox
            // 
            this.canAdd_groupBox.Controls.Add(this.tableLayoutPanel3);
            this.canAdd_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canAdd_groupBox.Location = new System.Drawing.Point(428, 3);
            this.canAdd_groupBox.Name = "canAdd_groupBox";
            this.canAdd_groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.canAdd_groupBox.Size = new System.Drawing.Size(419, 457);
            this.canAdd_groupBox.TabIndex = 1;
            this.canAdd_groupBox.TabStop = false;
            this.canAdd_groupBox.Text = "Entitlements";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.edit_groupBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.add_groupBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(399, 417);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // edit_groupBox
            // 
            this.edit_groupBox.Controls.Add(this.canEdit_treeView);
            this.edit_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_groupBox.Location = new System.Drawing.Point(3, 3);
            this.edit_groupBox.Name = "edit_groupBox";
            this.edit_groupBox.Padding = new System.Windows.Forms.Padding(5);
            this.edit_groupBox.Size = new System.Drawing.Size(393, 202);
            this.edit_groupBox.TabIndex = 0;
            this.edit_groupBox.TabStop = false;
            this.edit_groupBox.Text = "Edit ";
            // 
            // canEdit_treeView
            // 
            this.canEdit_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canEdit_treeView.Location = new System.Drawing.Point(5, 25);
            this.canEdit_treeView.Name = "canEdit_treeView";
            this.canEdit_treeView.Size = new System.Drawing.Size(383, 172);
            this.canEdit_treeView.TabIndex = 0;
            // 
            // add_groupBox
            // 
            this.add_groupBox.Controls.Add(this.treeView);
            this.add_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_groupBox.Location = new System.Drawing.Point(3, 211);
            this.add_groupBox.Name = "add_groupBox";
            this.add_groupBox.Padding = new System.Windows.Forms.Padding(5);
            this.add_groupBox.Size = new System.Drawing.Size(393, 203);
            this.add_groupBox.TabIndex = 1;
            this.add_groupBox.TabStop = false;
            this.add_groupBox.Text = "Add";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(5, 25);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(383, 173);
            this.treeView.TabIndex = 0;
            // 
            // manage
            // 
            this.manage.Controls.Add(this.addROle_groupBox);
            this.manage.Location = new System.Drawing.Point(4, 29);
            this.manage.Name = "manage";
            this.manage.Padding = new System.Windows.Forms.Padding(10);
            this.manage.Size = new System.Drawing.Size(856, 469);
            this.manage.TabIndex = 2;
            this.manage.Text = "Manage the roles";
            this.manage.UseVisualStyleBackColor = true;
            // 
            // addROle_groupBox
            // 
            this.addROle_groupBox.Controls.Add(this.tableLayoutPanel4);
            this.addROle_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addROle_groupBox.Location = new System.Drawing.Point(10, 10);
            this.addROle_groupBox.Name = "addROle_groupBox";
            this.addROle_groupBox.Size = new System.Drawing.Size(836, 449);
            this.addROle_groupBox.TabIndex = 0;
            this.addROle_groupBox.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.addNewRole_groupBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.deleteRole_groupBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(830, 423);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // addNewRole_groupBox
            // 
            this.addNewRole_groupBox.Controls.Add(this.tableLayoutPanel5);
            this.addNewRole_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNewRole_groupBox.Location = new System.Drawing.Point(3, 3);
            this.addNewRole_groupBox.Name = "addNewRole_groupBox";
            this.addNewRole_groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.addNewRole_groupBox.Size = new System.Drawing.Size(409, 417);
            this.addNewRole_groupBox.TabIndex = 2;
            this.addNewRole_groupBox.TabStop = false;
            this.addNewRole_groupBox.Text = "Add a role";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.roleAddName_label, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.addNewRole_textBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.addNewRole_button, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.018568F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.98143F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(389, 377);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // roleAddName_label
            // 
            this.roleAddName_label.AutoSize = true;
            this.roleAddName_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleAddName_label.Location = new System.Drawing.Point(3, 0);
            this.roleAddName_label.Name = "roleAddName_label";
            this.roleAddName_label.Size = new System.Drawing.Size(188, 34);
            this.roleAddName_label.TabIndex = 1;
            this.roleAddName_label.Text = "Role\'s name ";
            this.roleAddName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewRole_textBox
            // 
            this.addNewRole_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNewRole_textBox.Location = new System.Drawing.Point(197, 3);
            this.addNewRole_textBox.Name = "addNewRole_textBox";
            this.addNewRole_textBox.Size = new System.Drawing.Size(189, 27);
            this.addNewRole_textBox.TabIndex = 1;
            this.addNewRole_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addNewRole_button
            // 
            this.addNewRole_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.addNewRole_button, 2);
            this.addNewRole_button.Location = new System.Drawing.Point(10, 44);
            this.addNewRole_button.Margin = new System.Windows.Forms.Padding(10);
            this.addNewRole_button.Name = "addNewRole_button";
            this.addNewRole_button.Size = new System.Drawing.Size(369, 35);
            this.addNewRole_button.TabIndex = 2;
            this.addNewRole_button.Text = "Confirm";
            this.addNewRole_button.UseVisualStyleBackColor = true;
            this.addNewRole_button.Click += new System.EventHandler(this.addNewRole_button_Click);
            // 
            // deleteRole_groupBox
            // 
            this.deleteRole_groupBox.Controls.Add(this.tableLayoutPanel6);
            this.deleteRole_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteRole_groupBox.Location = new System.Drawing.Point(418, 3);
            this.deleteRole_groupBox.Name = "deleteRole_groupBox";
            this.deleteRole_groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.deleteRole_groupBox.Size = new System.Drawing.Size(409, 417);
            this.deleteRole_groupBox.TabIndex = 3;
            this.deleteRole_groupBox.TabStop = false;
            this.deleteRole_groupBox.Text = "Delete a role";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.delete_button, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.delete_checkedListBox, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(389, 377);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Location = new System.Drawing.Point(10, 198);
            this.delete_button.Margin = new System.Windows.Forms.Padding(10);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(369, 29);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Confirm";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // delete_checkedListBox
            // 
            this.delete_checkedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_checkedListBox.FormattingEnabled = true;
            this.delete_checkedListBox.Location = new System.Drawing.Point(3, 3);
            this.delete_checkedListBox.Name = "delete_checkedListBox";
            this.delete_checkedListBox.Size = new System.Drawing.Size(383, 182);
            this.delete_checkedListBox.TabIndex = 2;
            this.delete_checkedListBox.SelectedIndexChanged += new System.EventHandler(this.delete_checkedListBox_SelectedIndexChanged);
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 502);
            this.Controls.Add(this.tabControl1);
            this.Name = "RolesForm";
            this.Text = "RolesForm";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.users_groupBox.ResumeLayout(false);
            this.roles_groupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.assign.ResumeLayout(false);
            this.define.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.roles_define_groupBox.ResumeLayout(false);
            this.canAdd_groupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.edit_groupBox.ResumeLayout(false);
            this.add_groupBox.ResumeLayout(false);
            this.manage.ResumeLayout(false);
            this.addROle_groupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.addNewRole_groupBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.deleteRole_groupBox.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox users_groupBox;
        private ListBox users_listBox;
        private GroupBox roles_groupBox;
        private CheckedListBox role_checkedListBox;
        private TabControl tabControl1;
        private TabPage assign;
        private TabPage define;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage manage;
        private GroupBox roles_define_groupBox;
        private ListBox define_listBox;
        private GroupBox canAdd_groupBox;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox edit_groupBox;
        private TreeView canEdit_treeView;
        private GroupBox add_groupBox;
        private TreeView treeView;
        private GroupBox addROle_groupBox;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox addNewRole_textBox;
        private GroupBox addNewRole_groupBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label roleAddName_label;
        private GroupBox deleteRole_groupBox;
        private TableLayoutPanel tableLayoutPanel6;
        private Button addNewRole_button;
        private Button delete_button;
        private CheckedListBox delete_checkedListBox;
    }
}