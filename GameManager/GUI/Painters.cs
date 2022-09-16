using GameManager.Data.Models;
using GameManager.DataHandlers;
using Object = GameManager.Data.Models.Object;

namespace GameManager.GUI;

internal static class Painters
{
    public static void FillRoles(CheckedListBox checkedListBox)
    {
        checkedListBox.Items.Clear();
        checkedListBox.DisplayMember = "Name";

        var roles = RolesHandler.GetAllRoles();
        foreach (var role in roles) checkedListBox.Items.Add(role, CheckState.Unchecked);
    }

    public static void FillAuthors(ListBox listBox)
    {
        listBox.DisplayMember = "username";

        var authors = ObjectHandler.GetAuthors();
        foreach (var author in authors) listBox.Items.Add(author);
    }

    public static void FillRoles(ListBox listBox)
    {
        listBox.Items.Clear();
        listBox.DisplayMember = "Name";

        var roles = RolesHandler.GetAllRoles();
        foreach (var role in roles) listBox.Items.Add(role);
    }


    public static void FillUsers(ListBox listBox)
    {
        listBox.Items.Clear();
        listBox.DisplayMember = "Username";
        var users = UsersHandler.GetAllUsers();
        foreach (var user in users) listBox.Items.Add(user);
    }


    public static void FillProperties(ListBox listBox, List<ObjectProperty> objectProperties)
    {
        foreach (var property in objectProperties) listBox.Items.Add(property.ToString());
    }

    public static void FillCategories(TreeView treeView, bool checkboxes = false)
    {
        if (checkboxes) treeView.CheckBoxes = checkboxes;

        treeView.Nodes.Clear();


        var startingCategory = CategoryHandler.GetByName("Starting");
        if (startingCategory != null)
        {
            treeView.Nodes.Add(new TreeNode
                {Name = startingCategory.Name, Tag = startingCategory, Text = startingCategory.Name});


            var tree = CategoryHandler.GetTree(startingCategory);
            foreach (var category in tree)
            {
                var parentCategory = CategoryHandler.GetParent(category);
                if (parentCategory == null) continue;
                var child = new TreeNode {Name = category.Name, Tag = category, Text = category.Name};
                if (treeView.Nodes.Find(parentCategory.Name, true).Any())
                {
                    treeView.Nodes.Find(parentCategory.Name, true).First().Nodes.Add(child);
                }
                else
                {
                    var parent = new TreeNode
                        {Name = parentCategory.Name, Tag = parentCategory, Text = parentCategory.Name};
                    parent.Nodes.Add(child);
                    treeView.Nodes.Add(parent);
                }
            }
        }


        treeView.ExpandAll();
    }

    public static Image ByteArrayToImage(byte[] source)
    {
        var ms = new MemoryStream(source);
        var ret = Image.FromStream(ms);
        return ret;
    }

    public static void FillBestObjects(TableLayoutPanel tableLayoutPanel, int number)
    {
        var cols = 2;
        tableLayoutPanel.AutoScroll = true;
        tableLayoutPanel.Controls.Clear();
        tableLayoutPanel.ColumnStyles.Clear();
        tableLayoutPanel.RowStyles.Clear();
        if (number == 0) return;
        var objects = ObjectHandler.GetBest(number);
        // tableLayoutPanel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
        tableLayoutPanel.Dock = DockStyle.Fill;
        if (!objects.Any()) return;
        var rows = objects.Count;
        tableLayoutPanel.RowCount = rows;


        foreach (var obj in objects)
        {
            var objTableLayoutPanel = new TableLayoutPanel();
            objTableLayoutPanel.Padding = new Padding(5);
            objTableLayoutPanel.RowCount = 1;
            objTableLayoutPanel.ColumnCount = 3;
            objTableLayoutPanel.Dock = DockStyle.Fill;
            objTableLayoutPanel.Controls.Add(new PictureBox
            {
                Image = ByteArrayToImage(obj.Photo), SizeMode = PictureBoxSizeMode.Zoom, Dock = DockStyle.Fill
            });
            objTableLayoutPanel.Controls.Add(new Label
                {Text = obj.Name, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill});
            var detailsButton = new Button {Text = @"Details", Dock = DockStyle.Fill, Tag = obj};

            detailsButton.Click += DetailsButtonOnClick;
            objTableLayoutPanel.Controls.Add(detailsButton);


            tableLayoutPanel.Controls.Add(objTableLayoutPanel);
        }


        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));


        for (var i = 0; i < rows; ++i) tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
    }

    public static void FillObjects(TableLayoutPanel tableLayoutPanel, List<Category> categories,
        string searchPhrase = "", int cols = 2)
    {
        tableLayoutPanel.AutoScroll = true;
        tableLayoutPanel.Controls.Clear();
        tableLayoutPanel.ColumnStyles.Clear();
        tableLayoutPanel.RowStyles.Clear();
        var objects = ObjectHandler.GetObjects(categories, searchPhrase);
        // tableLayoutPanel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
        tableLayoutPanel.Dock = DockStyle.Fill;
        if (!objects.Any()) return;
        var rows = (objects.Count + cols - 1) / 2;
        tableLayoutPanel.RowCount = rows;


        foreach (var obj in objects)
        {
            var objTableLayoutPanel = new TableLayoutPanel();
            objTableLayoutPanel.Padding = new Padding(5);
            objTableLayoutPanel.RowCount = 1;
            objTableLayoutPanel.ColumnCount = 3;
            objTableLayoutPanel.Dock = DockStyle.Fill;
            objTableLayoutPanel.Controls.Add(new PictureBox
            {
                Image = ByteArrayToImage(obj.Photo), SizeMode = PictureBoxSizeMode.Zoom, Dock = DockStyle.Fill
            });
            objTableLayoutPanel.Controls.Add(new Label
                {Text = obj.Name, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill});
            var detailsButton = new Button {Text = @"Details", Dock = DockStyle.Fill, Tag = obj};

            detailsButton.Click += DetailsButtonOnClick;
            objTableLayoutPanel.Controls.Add(detailsButton);


            tableLayoutPanel.Controls.Add(objTableLayoutPanel);
        }


        for (var i = 0; i < cols; ++i) tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / cols));

        for (var i = 0; i < rows; ++i) tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
    }

    private static void DetailsButtonOnClick(object? sender, EventArgs e)
    {
        var o = (Button) sender!;
        var objectForm = new ObjectForm((Object?) o.Tag);
        objectForm.Show();
    }
}