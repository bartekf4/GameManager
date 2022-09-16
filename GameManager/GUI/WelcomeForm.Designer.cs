namespace GameManager.GUI;

partial class WelcomeForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.itemsPerPage_label = new System.Windows.Forms.Label();
            this.numberOfItems_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.login_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.guest_linkLabel = new System.Windows.Forms.LinkLabel();
            this.ranking_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfItems_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.login_groupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(830, 464);
            this.splitContainer1.SplitterDistance = 516;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.itemsPerPage_label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.numberOfItems_numericUpDown, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.758621F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.24138F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(516, 464);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // itemsPerPage_label
            // 
            this.itemsPerPage_label.AutoSize = true;
            this.itemsPerPage_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsPerPage_label.Location = new System.Drawing.Point(3, 0);
            this.itemsPerPage_label.Name = "itemsPerPage_label";
            this.itemsPerPage_label.Size = new System.Drawing.Size(252, 36);
            this.itemsPerPage_label.TabIndex = 0;
            this.itemsPerPage_label.Text = "Number of bets objects on page";
            this.itemsPerPage_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfItems_numericUpDown
            // 
            this.numberOfItems_numericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfItems_numericUpDown.Location = new System.Drawing.Point(261, 3);
            this.numberOfItems_numericUpDown.Name = "numberOfItems_numericUpDown";
            this.numberOfItems_numericUpDown.Size = new System.Drawing.Size(252, 27);
            this.numberOfItems_numericUpDown.TabIndex = 1;
            this.numberOfItems_numericUpDown.ValueChanged += new System.EventHandler(this.numberOfItems_numericUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 422);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Best objects";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(504, 396);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.login_groupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.02299F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // login_groupBox
            // 
            this.login_groupBox.Controls.Add(this.tableLayoutPanel2);
            this.login_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_groupBox.Location = new System.Drawing.Point(7, 7);
            this.login_groupBox.Margin = new System.Windows.Forms.Padding(7);
            this.login_groupBox.Name = "login_groupBox";
            this.login_groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.login_groupBox.Size = new System.Drawing.Size(296, 450);
            this.login_groupBox.TabIndex = 0;
            this.login_groupBox.TabStop = false;
            this.login_groupBox.Text = "Login";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.email_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.password_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.login_button, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.guest_linkLabel, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 410);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_label.Location = new System.Drawing.Point(3, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(132, 57);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "Email or login";
            this.email_label.Click += new System.EventHandler(this.email_label_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_label.Location = new System.Drawing.Point(3, 57);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(132, 57);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.login_button, 2);
            this.login_button.Location = new System.Drawing.Point(3, 117);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(270, 29);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.login_button_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(141, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(141, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.linkLabel, 2);
            this.linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel.Location = new System.Drawing.Point(3, 346);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(270, 20);
            this.linkLabel.TabIndex = 5;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Don\'t have an account? Sign up.";
            this.linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel.UseWaitCursor = true;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // guest_linkLabel
            // 
            this.guest_linkLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.guest_linkLabel, 2);
            this.guest_linkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guest_linkLabel.LinkColor = System.Drawing.Color.Brown;
            this.guest_linkLabel.Location = new System.Drawing.Point(3, 389);
            this.guest_linkLabel.Name = "guest_linkLabel";
            this.guest_linkLabel.Size = new System.Drawing.Size(270, 21);
            this.guest_linkLabel.TabIndex = 7;
            this.guest_linkLabel.TabStop = true;
            this.guest_linkLabel.Text = "Preview as a guest";
            this.guest_linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guest_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guest_linkLabel_LinkClicked);
            // 
            // ranking_tableLayoutPanel
            // 
            this.ranking_tableLayoutPanel.ColumnCount = 2;
            this.ranking_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ranking_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ranking_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ranking_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ranking_tableLayoutPanel.Name = "ranking_tableLayoutPanel";
            this.ranking_tableLayoutPanel.RowCount = 2;
            this.ranking_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ranking_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ranking_tableLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.ranking_tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 464);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WelcomeForm";
            this.Text = "Game Manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfItems_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.login_groupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private SplitContainer splitContainer1;
    private TableLayoutPanel tableLayoutPanel1;
    private GroupBox login_groupBox;
    private TableLayoutPanel tableLayoutPanel2;
    private Label email_label;
    private Label password_label;
    private Button login_button;
    private TextBox textBox1;
    private TextBox textBox2;
    private LinkLabel linkLabel;
    private LinkLabel guest_linkLabel;
    private TableLayoutPanel tableLayoutPanel3;
    private Label itemsPerPage_label;
    private NumericUpDown numberOfItems_numericUpDown;
    private TableLayoutPanel ranking_tableLayoutPanel;
    private TableLayoutPanel tableLayoutPanel4;
    private GroupBox groupBox1;
    private TableLayoutPanel tableLayoutPanel5;
}