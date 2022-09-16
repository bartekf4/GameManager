namespace GameManager.GUI
{
    partial class CategoriesForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.editCategory_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_categoryEdit_textBox = new System.Windows.Forms.TextBox();
            this.newName_categoryEdit_textBox = new System.Windows.Forms.TextBox();
            this.applyChanges_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.parentCategory_textBox = new System.Windows.Forms.TextBox();
            this.nameCategory_textBox = new System.Windows.Forms.TextBox();
            this.addCategory_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.editCategory_groupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(394, 444);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.editCategory_groupBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.65766F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.34234F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // editCategory_groupBox
            // 
            this.editCategory_groupBox.Controls.Add(this.tableLayoutPanel4);
            this.editCategory_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editCategory_groupBox.Location = new System.Drawing.Point(10, 266);
            this.editCategory_groupBox.Margin = new System.Windows.Forms.Padding(10);
            this.editCategory_groupBox.Name = "editCategory_groupBox";
            this.editCategory_groupBox.Size = new System.Drawing.Size(374, 168);
            this.editCategory_groupBox.TabIndex = 1;
            this.editCategory_groupBox.TabStop = false;
            this.editCategory_groupBox.Text = "Edit category";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.name_categoryEdit_textBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.newName_categoryEdit_textBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.applyChanges_button, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.delete_button, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(368, 142);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "New name";
            // 
            // name_categoryEdit_textBox
            // 
            this.name_categoryEdit_textBox.Location = new System.Drawing.Point(187, 8);
            this.name_categoryEdit_textBox.Name = "name_categoryEdit_textBox";
            this.name_categoryEdit_textBox.Size = new System.Drawing.Size(173, 27);
            this.name_categoryEdit_textBox.TabIndex = 2;
            // 
            // newName_categoryEdit_textBox
            // 
            this.newName_categoryEdit_textBox.Location = new System.Drawing.Point(187, 52);
            this.newName_categoryEdit_textBox.Name = "newName_categoryEdit_textBox";
            this.newName_categoryEdit_textBox.Size = new System.Drawing.Size(173, 27);
            this.newName_categoryEdit_textBox.TabIndex = 3;
            // 
            // applyChanges_button
            // 
            this.applyChanges_button.Location = new System.Drawing.Point(187, 96);
            this.applyChanges_button.Name = "applyChanges_button";
            this.applyChanges_button.Size = new System.Drawing.Size(173, 29);
            this.applyChanges_button.TabIndex = 4;
            this.applyChanges_button.Text = "Apply changes";
            this.applyChanges_button.UseVisualStyleBackColor = true;
            this.applyChanges_button.Click += new System.EventHandler(this.applyChanges_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(8, 96);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(94, 29);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add category";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.03911F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.96089F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.parentCategory_textBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.nameCategory_textBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.addCategory_button, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.21428F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.78571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(368, 210);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parent category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // parentCategory_textBox
            // 
            this.parentCategory_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentCategory_textBox.Location = new System.Drawing.Point(69, 8);
            this.parentCategory_textBox.Name = "parentCategory_textBox";
            this.parentCategory_textBox.Size = new System.Drawing.Size(291, 27);
            this.parentCategory_textBox.TabIndex = 3;
            // 
            // nameCategory_textBox
            // 
            this.nameCategory_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameCategory_textBox.Location = new System.Drawing.Point(69, 46);
            this.nameCategory_textBox.Name = "nameCategory_textBox";
            this.nameCategory_textBox.Size = new System.Drawing.Size(291, 27);
            this.nameCategory_textBox.TabIndex = 4;
            // 
            // addCategory_button
            // 
            this.addCategory_button.Location = new System.Drawing.Point(69, 174);
            this.addCategory_button.Name = "addCategory_button";
            this.addCategory_button.Size = new System.Drawing.Size(219, 28);
            this.addCategory_button.TabIndex = 1;
            this.addCategory_button.Text = "Add new category";
            this.addCategory_button.UseVisualStyleBackColor = true;
            this.addCategory_button.Click += new System.EventHandler(this.addCategory_button_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CategoriesForm";
            this.Text = "Categories";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.editCategory_groupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TreeView treeView1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox editCategory_groupBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label label4;
        private TextBox name_categoryEdit_textBox;
        private TextBox newName_categoryEdit_textBox;
        private Button applyChanges_button;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private TextBox parentCategory_textBox;
        private TextBox nameCategory_textBox;
        private Button addCategory_button;
        private Button delete_button;
    }
}