using GameManager.DataHandlers;

namespace GameManager.GUI;

public partial class UserForm : Form
{
    private readonly bool _isNew;

    public UserForm(bool isNew = true)
    {
        _isNew = isNew;
        InitializeComponent();
        if (_isNew) return;

        var user = UsersHandler.GetByName(Globals.CurrentUser);
        textBox1.Text = user.Username;
        textBox2.Text = user.Email;

        textBox3.Text = string.Empty;
        label3.Text = @"Enter your current password";

        textBox1.Enabled = false;


        label4.Text = @"Enter new password";
        sign_up_button.Text = @"Edit";
    }

    private void sign_up_groupBox_Enter(object sender, EventArgs e)
    {
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void sign_up_button_Click(object sender, EventArgs e)
    {
        if (!_isNew)
        {
            var result = UsersHandler.UpdateUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (!result)
            {
                MessageBox.Show(@"Unable to authenticate. Try one more time.", @"Erroros companieros",
                    MessageBoxButtons.OK);
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
            }
        }


        if (UsersHandler.Exists(textBox1.Text))
            MessageBox.Show(@"User with such user name exists", @"Whoa!!", MessageBoxButtons.OK);
        else
            UsersHandler.AddUser(textBox1.Text, textBox2.Text, textBox3.Text, "Role");
    }
}