﻿using Microsoft.EntityFrameworkCore;
using MVCCore.Models;

namespace MVCCore.Repositories;

public class GameContext : DbContext
{
    public GameContext(DbContextOptions<GameContext> options) : base(options)
    {
    }

    public DbSet<GameModel> Games { get; set; }
}