namespace GameManager.GUI
{
    partial class MainForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.welcome_label = new System.Windows.Forms.Label();
            this.signout_pictureBox = new System.Windows.Forms.PictureBox();
            this.profile_label = new System.Windows.Forms.Label();
            this.roles_label = new System.Windows.Forms.Label();
            this.categories_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label7 = new System.Windows.Forms.Label();
            this.itms_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.authors_listBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signout_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.21285F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.78715F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Controls.Add(this.welcome_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.signout_pictureBox, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.profile_label, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.roles_label, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.categories_label, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.add_button, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(815, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome_label.Location = new System.Drawing.Point(15, 12);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(259, 31);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signout_pictureBox
            // 
            this.signout_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signout_pictureBox.Image = global::GameManager.Properties.Resources._switch;
            this.signout_pictureBox.Location = new System.Drawing.Point(776, 15);
            this.signout_pictureBox.Name = "signout_pictureBox";
            this.signout_pictureBox.Size = new System.Drawing.Size(24, 25);
            this.signout_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signout_pictureBox.TabIndex = 1;
            this.signout_pictureBox.TabStop = false;
            this.signout_pictureBox.Click += new System.EventHandler(this.signOut_pictureBox_Click);
            // 
            // profile_label
            // 
            this.profile_label.AutoSize = true;
            this.profile_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_label.Location = new System.Drawing.Point(719, 12);
            this.profile_label.Name = "profile_label";
            this.profile_label.Size = new System.Drawing.Size(51, 31);
            this.profile_label.TabIndex = 2;
            this.profile_label.Text = "Profile";
            this.profile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profile_label.Click += new System.EventHandler(this.profile_label_Click);
            this.profile_label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.profile_label_MouseClick);
            // 
            // roles_label
            // 
            this.roles_label.AutoSize = true;
            this.roles_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roles_label.Location = new System.Drawing.Point(513, 12);
            this.roles_label.Name = "roles_label";
            this.roles_label.Size = new System.Drawing.Size(68, 31);
            this.roles_label.TabIndex = 3;
            this.roles_label.Text = "Roles";
            this.roles_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roles_label.Click += new System.EventHandler(this.roles_label_Click);
            // 
            // categories_label
            // 
            this.categories_label.AutoSize = true;
            this.categories_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categories_label.Location = new System.Drawing.Point(587, 12);
            this.categories_label.Name = "categories_label";
            this.categories_label.Size = new System.Drawing.Size(126, 31);
            this.categories_label.TabIndex = 4;
            this.categories_label.Text = "Categories";
            this.categories_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categories_label.Click += new System.EventHandler(this.categories_label_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(280, 15);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(227, 25);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add object";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.itms_tableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(815, 383);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.search_textBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.treeView1, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.authors_listBox, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(271, 383);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search";
            // 
            // search_textBox
            // 
            this.search_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_textBox.Location = new System.Drawing.Point(13, 33);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(245, 27);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(13, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Categories";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(13, 108);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(245, 143);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(13, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Authors";
            // 
            // itms_tableLayoutPanel
            // 
            this.itms_tableLayoutPanel.AutoScroll = true;
            this.itms_tableLayoutPanel.ColumnCount = 1;
            this.itms_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itms_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itms_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.itms_tableLayoutPanel.Name = "itms_tableLayoutPanel";
            this.itms_tableLayoutPanel.RowCount = 1;
            this.itms_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.42559F));
            this.itms_tableLayoutPanel.Size = new System.Drawing.Size(540, 383);
            this.itms_tableLayoutPanel.TabIndex = 0;
            // 
            // authors_listBox
            // 
            this.authors_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authors_listBox.FormattingEnabled = true;
            this.authors_listBox.ItemHeight = 20;
            this.authors_listBox.Location = new System.Drawing.Point(13, 281);
            this.authors_listBox.Name = "authors_listBox";
            this.authors_listBox.Size = new System.Drawing.Size(245, 89);
            this.authors_listBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signout_pictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label welcome_label;
        private PictureBox signout_pictureBox;
        private Label profile_label;
        private Label roles_label;
        private Label categories_label;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private TextBox search_textBox;
        private Label label6;
        private TreeView treeView1;
        private Label label7;
        private TableLayoutPanel itms_tableLayoutPanel;
        private Button add_button;
        private ListBox authors_listBox;
    }
}