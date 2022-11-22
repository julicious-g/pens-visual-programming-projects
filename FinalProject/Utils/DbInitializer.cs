using FinalProject.Contexts;
using FinalProject.Models;

namespace FinalProject.Utils;

public static class DbInitializer
{
    public static void Initialize(GameContext context)
    {
        context.Database.EnsureCreated();

        if (!context.Players.Any())
        {
            context.Players.Add(Player.Default);
            context.SaveChanges();
        }



        if (!context.Items.Any())
        {
            context.Items.Add(new Item
            {
                Id = "Weapon1",
                Name = "Excalibur"
            });
            context.Items.Add(new Item
            {
                Id = "Armor1",
                Name = "Dragon Scale Armor"
            });

            context.Items.Add(new Item
            {
                Id = "Shield1",
                Name = "Paladin's Holy Shield"
            });
            context.SaveChanges();
        }
        
        
        if (!context.Shops.Any())
        {
            context.Shops.Add(new CommercialItem
            {
                ItemId = "Weapon1",
                Price = 1000,
                Point = 100
            });
            context.Shops.Add(new CommercialItem
            {
                ItemId = "Armor1",
                Price = 800,
                Point = 80
            });
            context.Shops.Add(new CommercialItem
            {
                ItemId = "Shield1",
                Price = 900,
                Point = 90
            });

            context.SaveChanges();
        }


    }
}