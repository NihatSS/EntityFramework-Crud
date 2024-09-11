using EFConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=NIhat\\SQLEXPRESS;Database=PB102Db;Trusted_Connection=True;");
    }
}
