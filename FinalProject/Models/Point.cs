namespace FinalProject.Models;

public class Point
{
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public int Amount { get; set; }
    public string Acquire_At { get; private set; } = DateTime.UtcNow.ToString();
    
    public string PlayerId { get; private set; }
    public Player Player { get; set; }
}