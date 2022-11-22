using FinalProject.Contexts;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers;

public class PlayerController : Controller
{
    private readonly GameContext _context;

    public PlayerController(GameContext context)
    {
        _context = context;
    }
    // GET
    public async Task<IActionResult> Index()
    {
        var defaultPlayer = await _context.GetDefaultPlayer();
        return View(defaultPlayer);
    }

    public async Task<IActionResult> Inventory()
    {
        var defaultPlayer = await _context.GetDefaultPlayer();
        return View(defaultPlayer);
    }

    
}