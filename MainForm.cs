using System.ComponentModel;

namespace Password_Manager;

public partial class MainForm : Form
{
    private DataContext dbContext;
    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        dbContext = new DataContext();
        
        // Note(Pete): Uncomment this if you need to update the database schema.
        // dbContext.Database.EnsureDeleted();
        dbContext.Database.EnsureCreated();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);
        
        dbContext.Dispose();
    }
}
