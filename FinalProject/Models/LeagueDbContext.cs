using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using System.Collections.Generic;

public class LeagueDbContext : DbContext
{
    public LeagueDbContext(DbContextOptions<LeagueDbContext> options)
        : base(options) { }

    public DbSet<Champions> Champs { get; set; }// DbSet for Champions entity
    public DbSet<Lanes> Lane { get; set; } // DbSet for Lanes entity

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data for "Lane"
        modelBuilder.Entity<Lanes>().HasData(
           new Lanes { LaneID = 1, Lane = "Top"},
           new Lanes { LaneID = 2, Lane = "Jungle"},
           new Lanes { LaneID = 3, Lane = "Mid"},
           new Lanes { LaneID = 4, Lane = "Adc"},
           new Lanes { LaneID = 5, Lane = "Support"}
           );

        // Seed data for "Champions"
        modelBuilder.Entity<Champions>().HasData(
            new Champions
            {
                ChampId = 1,
                Name = "Aatrox",
                LaneID = 1
            },
            new Champions
            {
                ChampId = 2,
                Name = "Ahri",
                LaneID = 3
            },
            new Champions
            {
                ChampId = 3,
                Name = "Akali",
                LaneID = 3
            },
            new Champions
            {
                ChampId = 4,
                Name = "Akshan",
                LaneID = 4
            },
            new Champions
            {
                ChampId = 5,
                Name = "Alistar",
                LaneID = 5
            },
            new Champions
            {
                ChampId = 6,
                Name = "Amumu",
                LaneID = 2
            },
            new Champions
            {
                ChampId = 7,
                Name = "Anivia",
                LaneID = 3
            },
            new Champions
            {
                ChampId = 8,
                Name = "Annie",
                LaneID = 3
            },
            new Champions
            {
                ChampId = 9,
                Name = "Aphelios",
                LaneID = 4
            },
            new Champions
            {
                ChampId = 10,
                Name = "Ashe",
                LaneID = 4
            }

        );
    }
}
