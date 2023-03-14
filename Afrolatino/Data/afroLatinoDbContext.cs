using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Afrolatino.Models;

namespace Afrolatino.Data;

public class AfroLatinoContext : DbContext
{
    public DbSet<Event> Events { get; set; } = null!;

    public string DbPath { get; private set; }

    public AfroLatinoContext()
    {
        // Path to SQLite database file
        DbPath = "afrolatino.db";
    }

    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        //options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}