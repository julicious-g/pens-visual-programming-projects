namespace MVCCore.Models;

public class GameModel
{
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public string Genre { get; set; }
    public string Platform { get; set; }
}