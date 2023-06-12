using Microsoft.EntityFrameworkCore;

namespace TreeNotes.Models;

public class SubnetContextDb:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-BN9S4D3;Initial Catalog=TreeNotes;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");

    }
    public DbSet<Subnotes> Subnotes { get; set; }
}