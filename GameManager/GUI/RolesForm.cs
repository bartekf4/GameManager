using GameManager.Data.Models;
using GameManager.DataHandlers;

namespace GameManager.GUI;

public partial class RolesForm : Form
{
    private string _roleNameToBeAdded;
    private Role _roleSelected;

    private Role _roleToBeDeleted;
    private User _userSelected;

    public RolesForm()
    {
        InitializeComponent();
        _roleSelected = role_checkedListBox.SelectedItem as Role;
        _userSelected = users_listBox.SelectedItem as User;
    }


    private void RefreshForm()
    {
        Painters.FillUsers(users_listBox);
        Painters.FillRoles(role_checkedListBox);
        Painters.FillRoles(delete_checkedListBox);
        Painters.FillRoles(define_listBox);
    }


    private void RolesForm_Load(object sender, EventArgs e)
    {
        RefreshForm();
    }

    private void users_listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        _userSelected = users_listBox.SelectedItem as User ?? throw new InvalidOperationException();
        RefreshForm();

        var role = RolesHandler.GetUsersRole(_userSelected);
        if (role == null) return;
        role_checkedListBox.Items.IndexOf(role);
    }

    private void role_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        _roleSelected = role_checkedListBox.SelectedItem as Role ?? throw new InvalidOperationException();
        UsersHandler.UpdateRole(_userSelected, _roleSelected);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        _roleNameToBeAdded = addNewRole_textBox.Text;
    }

    private void addNewRole_button_Click(object sender, EventArgs e)
    {
        RolesHandler.Add(_roleNameToBeAdded);
        addNewRole_textBox.Text = string.Empty;
        MessageBox.Show(@"New role with name " + _roleNameToBeAdded + @" has been added properly.", @"Success",
            MessageBoxButtons.OK);
        RefreshForm();
    }

    private void delete_button_Click(object sender, EventArgs e)
    {
        var res = MessageBox.Show(@"Are you sure you want to delete role: " + _roleToBeDeleted.Name +
                                  @"? This action cannot be reversed.", @"Just to confirm",
            MessageBoxButtons.OKCancel);

        switch (res)
        {
            case DialogResult.OK:
                RolesHandler.Delete(_roleToBeDeleted);
                MessageBox.Show(@"Role deleted:" + _roleToBeDeleted.Name, "", MessageBoxButtons.OK);
                break;
            case DialogResult.Cancel:
                break;
        }

        RefreshForm();
    }

    private void delete_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        _roleToBeDeleted =
            delete_checkedListBox.SelectedItem as Role ?? throw new InvalidOperationException();
    }
}