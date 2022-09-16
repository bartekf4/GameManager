using GameManager.Data.Models;
using GameManager.DataHandlers;

namespace GameManager.GUI;

public partial class MainForm : Form
{
    private List<Category> _checkedCategories;
    private string _searchPhrase = string.Empty;

    public MainForm()
    {
        InitializeComponent();
        PaintForm();
    }


    private void PaintForm()
    {
        Painters.FillAuthors(authors_listBox);
        Painters.FillCategories(treeView1, true);
        treeView1.Nodes.Find("Starting", false).First().Checked = true;
        CheckAllChildNodes(treeView1.Nodes.Find("Starting", false).First(), true);
        GetCheckedNodes();
        if (_checkedCategories != null) Painters.FillObjects(itms_tableLayoutPanel, _checkedCategories);
        welcome_label.Text += @" " + Globals.CurrentUser + @"!";
    }

    private static IEnumerable<TreeNode> GetAllNodes(TreeView self)
    {
        var result = new List<TreeNode>();
        foreach (TreeNode child in self.Nodes) result.AddRange(GetAllNodes(child));

        return result;
    }

    private static IEnumerable<TreeNode> GetAllNodes(TreeNode self)
    {
        var result = new List<TreeNode> {self};
        foreach (TreeNode child in self.Nodes) result.AddRange(GetAllNodes(child));

        return result;
    }


    private void profile_label_MouseClick(object sender, MouseEventArgs e)
    {
        var profile = new UserForm(false);
        profile.ShowDialog();
    }

    private void GetCheckedNodes()
    {
        var allNodes = GetAllNodes(treeView1);
        _checkedCategories = allNodes.Where(node => node.Checked.Equals(true)).ToList()
            .Select(x => x.Tag as Category).ToList()!;
    }


    private void add_button_Click(object sender, EventArgs e)
    {
        var objectForm = new ObjectForm();
        objectForm.ShowDialog();
        Painters.FillObjects(itms_tableLayoutPanel, _checkedCategories);
    }

    private void categories_label_Click(object sender, EventArgs e)
    {
        var categoriesForm = new CategoriesForm();
        categoriesForm.ShowDialog();
    }

    private void profile_label_Click(object sender, EventArgs e)
    {
        var profile = new UserForm(false);
        profile.ShowDialog();
    }

    private void signOut_pictureBox_Click(object sender, EventArgs e)
    {
        var form1 = new WelcomeForm();
        form1.ShowDialog();
        Close();
    }


    private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
    {
        GetCheckedNodes();
        Painters.FillObjects(itms_tableLayoutPanel, _checkedCategories);
        // The code only executes if the user caused the checked state to change.
        if (e.Action == TreeViewAction.Unknown) return;
        if (e.Node != null && e.Node.Nodes.Count > 0)
            /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
            CheckAllChildNodes(e.Node, e.Node.Checked);
    }

    private static void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
    {
        foreach (TreeNode node in treeNode.Nodes)
        {
            node.Checked = nodeChecked;
            if (node.Nodes.Count > 0)
                // If the current node has child nodes, call the CheckAllChildNodes method recursively.
                CheckAllChildNodes(node, nodeChecked);
        }
    }

    private void search_textBox_TextChanged(object sender, EventArgs e)
    {
        _searchPhrase = search_textBox.Text;
        Painters.FillObjects(itms_tableLayoutPanel, _checkedCategories, _searchPhrase);
    }

    private void roles_label_Click(object sender, EventArgs e)
    {
        var roles = new RolesForm();
        roles.Show();
    }
}