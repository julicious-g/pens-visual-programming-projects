namespace FinalProject.Models;

public class Item
{
    public string Id { get;  set; }
    public string Name { get;  set; }
}

public class PossessedItem
{
    public PossessedItem()
    {
    }

    public PossessedItem(Item item)
    {
        Item = item;
    }

    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string PlayerId { get; set; }
    public Player Player { get; set; }
    
    public string ItemId { get; set; }
    public Item Item { get; set; }
}

public class CommercialItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public int Price { get; set; }
    public int Point { get; set; }
    
    public string ItemId { get; set; }
    public Item Item { get; set; }
}