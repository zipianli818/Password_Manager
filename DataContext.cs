using Microsoft.EntityFrameworkCore;
using Password_Manager.Models;

namespace Password_Manager;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Folder> Folders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($@"Data Source={Application.UserAppDataPath}\database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Put default or test entries here.
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "test", Password = "123" });
    }
}