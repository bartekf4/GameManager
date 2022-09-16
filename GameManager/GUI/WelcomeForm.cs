using GameManager.Contexts;
using GameManager.Data.Models;
using GameManager.DataHandlers;
using GameManager.Properties;

namespace GameManager.GUI;

public partial class Form1 : Form
{
    private int itemsNumber;

    public Form1()
    {
        InitializeComponent();
        UsersHandler.AdminCheckIfExistsOrAdd();
        UsersHandler.GuestCheckIfExistsOrAdd();
        CategoryHandler.EnsureStartingCategoryExists();

        
        numberOfItems_numericUpDown.Maximum = ObjectHandler.Count();

        if (ObjectHandler.Count() >= 5)
        {
            numberOfItems_numericUpDown.Value = 5;
            
        }
        else
        {
            numberOfItems_numericUpDown.Value = ObjectHandler.Count();
        }
        
        itemsNumber = (int) numberOfItems_numericUpDown.Value;
        Painters.FillBestObjects(tableLayoutPanel5, itemsNumber);
        var a = new Main();
        a.Show();
    }

    private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var register = new UserForm();
        register.ShowDialog();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void main_label_MouseClick(object sender, MouseEventArgs e)
    {
        Globals.CurrentUser = "guest";
    }

    private void login_button_MouseClick(object sender, MouseEventArgs e)
    {
        if (UsersHandler.Exists(textBox1.Text) == false)
        {
            MessageBox.Show(@"User authentication", @"No such a user", MessageBoxButtons.OK);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        if (UsersHandler.Authenticate(textBox1.Text, textBox2.Text))
        {
            Globals.CurrentUser = textBox1.Text;

            var main = new Main();
            main.Show();
        }
    }

    private void email_label_Click(object sender, EventArgs e)
    {
    }

    private void guest_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Globals.CurrentUser = "guest";
        var a = new Main();
        a.Show();
    }

    private void numberOfItems_numericUpDown_ValueChanged(object sender, EventArgs e)
    {
        this.itemsNumber = (int) numberOfItems_numericUpDown.Value;
        Painters.FillBestObjects(tableLayoutPanel5,itemsNumber);

    }
}