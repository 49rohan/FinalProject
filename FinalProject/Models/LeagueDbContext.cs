using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class LeagueDbContext : DbContext
{
    public LeagueDbContext(DbContextOptions<LeagueDbContext> options)
        : base(options) { }

    public DbSet<Champions> Champs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Champions>().HasData(
            new Champions { ChampId = 1, Name = "Aatrox" },
            new Champions { ChampId = 2, Name = "Ahri" },
            new Champions { ChampId = 3, Name = "Akali" },
            new Champions { ChampId = 4, Name = "Akshan" },
            new Champions { ChampId = 5, Name = "Alistar" },
            new Champions { ChampId = 6, Name = "Amumu" },
            new Champions { ChampId = 7, Name = "Anivia" },
            new Champions { ChampId = 8, Name = "Annie" },
            new Champions { ChampId = 9, Name = "Aphelios" },
            new Champions { ChampId = 10, Name = "Ashe" }

        );
    }
}
