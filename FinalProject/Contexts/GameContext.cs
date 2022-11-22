using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Contexts;

public class GameContext : DbContext
{
    public GameContext (DbContextOptions<GameContext> options)
        : base(options)
    {
    }
    
    public DbSet<Player> Players { get; set; }
    public DbSet<Point> Points { get; set; }
    public DbSet<PossessedItem> Inventories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<CommercialItem> Shops { get; set; }

    public async Task<Player> GetDefaultPlayer()
    {
        return (await Players
            .Include(p => p.Points)
            .Include(p => p.Inventories).ThenInclude(i => i.Item)
            .FirstOrDefaultAsync(p => p.Id.Equals(Player.DefaultPlayerId)))!;
    }

    public async Task<IEnumerable<CommercialItem>> GetShopItems()
    {
        return await Shops
            .Include(s => s.Item)
            .ToListAsync();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Point>().HasNoKey();
        // modelBuilder.Entity<Point>()
        //     .HasOne(p => p.Player)
        //     .WithMany(p => p.Points);
    }
}