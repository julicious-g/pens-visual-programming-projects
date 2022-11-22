namespace FinalProject.Models;

public class Player
{
    public static string DefaultPlayerId { get; private set; } = "DefaultPlayerId";

    public static Player Default => new Player
    {
        Id = DefaultPlayerId,
        Username = "Default_Player"
    };

    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string Username { get; private set; }
    public int Level { get; private set; } = 1;
    public int Experience { get; private set; } = 0;
    public int Cash { get; set; } = 10000;

    public ICollection<PossessedItem> Inventories { get; set; }
    public ICollection<Point> Points { get; set; }
}