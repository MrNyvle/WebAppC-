using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Infrastructure;

public class GameDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=host.docker.internal,1433;Initial Catalog=MyDatabase;User ID=sa;Password=Password!123;Encrypt=False;");
        base.OnConfiguring(optionsBuilder);
    }
    
    public DbSet<GameModel> Games { get; set; }
}
