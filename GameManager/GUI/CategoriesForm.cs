using GameManager.Data.Models;
using GameManager.DataHandlers;

namespace GameManager.GUI;

public partial class CategoriesForm : Form
{
    public CategoriesForm()
    {
        InitializeComponent();
        Painters.FillCategories(treeView1);
    }

    private void addCategory_button_Click(object sender, EventArgs e)
    {
        var parent = treeView1.SelectedNode.Text;
        var name = nameCategory_textBox.Text;
        CategoryHandler.AddCategory(name, parent,
            UsersHandler.GetByName(Globals.CurrentUser));
        Painters.FillCategories(treeView1);
    }

    private void applyChanges_button_Click(object sender, EventArgs e)
    {
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
        parentCategory_textBox.Text = treeView1.SelectedNode.Text;
        name_categoryEdit_textBox.Text = treeView1.SelectedNode.Text;
    }

    private void delete_button_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            @"Are you sure you want to delete the category? This action cannot be reversed.", @"Confirm"
            , MessageBoxButtons.YesNo);
        switch (result)
        {
            case DialogResult.Yes:
            {
                CategoryHandler.DeleteCategory(treeView1.SelectedNode.Tag as Category ??
                                               throw new InvalidOperationException("Cannot delete the category"));
                Painters.FillCategories(treeView1);
                break;
            }
            case DialogResult.No:
            {
                break;
            }
        }
    }
}