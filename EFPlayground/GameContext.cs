using Microsoft.EntityFrameworkCore;

namespace EFPlayground;

public class GameContext : DbContext
{
    public DbSet<Player> Players { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=[::1], 1401;Database=VisualProgramming;Trusted_Connection=True;Password=@Khadijah^21#;Integrated Security=false;TrustServerCertificate=True;User Id=sa");
        base.OnConfiguring(optionsBuilder);
    }
}

public class Player
{
    public string PlayerId { get; set; }
    public string Password { get; set; }

    public static Player New(string password)
    {
        return new Player
        {
            PlayerId = Guid.NewGuid().ToString(),
            Password = password
        };
    }
}