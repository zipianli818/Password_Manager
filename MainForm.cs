using Password_Manager.Controls;
using Password_Manager.Models;
using System.ComponentModel;

namespace Password_Manager;

public partial class MainForm : Form
{
    private DataContext _dbContext;
    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _dbContext = new DataContext();

        // Note(Pete): Uncomment this if you need to update the database schema.
        //_dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();

        // Debug
        //var testUser = _dbContext.Users.First();
        //var accountsForm = new AccountsForm(testUser);
        //accountsForm.Show(this);
        //Hide();
    }

    /// <summary>
    /// Using a slightly different implementation for Hide because the topmost form in the application cannot be hidden normally.
    /// </summary>
    public new void Hide()
    {
        Visible = false;
        Opacity = 0;
        ShowInTaskbar = false;
    }

    public new void Show()
    {
        Visible = true;
        Opacity = 1;
        ShowInTaskbar = true;

        emailTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);

        _dbContext.Dispose();
    }

    private void createAccountButton_Click(object sender, EventArgs e)
    {
        CreateUserForm.ShowModal("Create User", true, (user) =>
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            var accountsForm = new AccountsForm(user);
            accountsForm.Show(this);
            Hide();
        });
    }

    private void signInButton_Click(object sender, EventArgs e)
    {
        var email = emailTextBox.Text;
        var password = passwordTextBox.Text;
        var user = _dbContext.Users.FirstOrDefault(u => u.Username == email && u.Password == password);
        if (user is null)
        {
            MessageBox.Show("Email or password is incorrect.");
            return;
        }

        var accountsForm = new AccountsForm(user);
        accountsForm.Show(this);
        Hide();
    }
}
