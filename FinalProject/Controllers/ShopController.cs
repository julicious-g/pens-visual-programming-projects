using FinalProject.Contexts;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers;

public class ShopController : Controller
{

    private readonly GameContext _context;

    public ShopController(GameContext context)
    {
        _context = context;
    }
    // GET
    public async Task<IActionResult> Index()
    {
        var items = await _context.GetShopItems();
        return View(items);
    }

    public async Task<IActionResult> Purchase(string itemId)
    {
        await using (var transaction = _context.Database.BeginTransaction())
        {
            var player = await _context.GetDefaultPlayer();
            var shopItem = await _context
                .Shops
                .Include(s => s.Item)
                .FirstOrDefaultAsync(s => s.ItemId.Equals(itemId));

            player.Cash -= shopItem.Price;
            player.Points.Add(new Point()
            {
                Amount = shopItem.Point
            });
            player.Inventories.Add(new PossessedItem(shopItem.Item));

            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        

        return RedirectToAction("Index");
    }
}