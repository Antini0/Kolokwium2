using DefaultNamespace;
using kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Data;

public class dbContext : DbContext
{
    public dbContext()
    {

    }

    public dbContext(DbContextOptions<dbContext> options) : base(options)
    {

    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Character_title> CharacterTitles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>().HasData(new List<Item>
        {
            new Item
            {
                IdItem = 1,
                Name = "okulary",
                Weight = 20
            },
            new Item
            {
                IdItem = 2,
                Name = "pilka",
                Weight = 15
            }
        });

        modelBuilder.Entity<Title>().HasData(new List<Title>
        {
            new Title
            {
                IdTitle = 1,
                Name = "dada"
            },
            new Title
            {
                IdTitle = 2,
                Name = "fafa"
            }
        });

        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>
        {
            new Backpack
            {
                IdCharacter = 1,
                IdItem = 1,
                Ammount = 2
            },
            new Backpack
            {
                IdCharacter = 1,
                IdItem = 2,
                Ammount = 1
            }
        });

        modelBuilder.Entity<Character>().HasData(new List<Character>
        {
            new Character
            {
                IdCharacter = 1,
                FirstName = "jan",
                LastName = "nowak",
                CurrentWeight = 67,
                MaxWeight = 80
            },
            new Character
            {
                IdCharacter = 2,
                FirstName = "stefan",
                LastName = "koski",
                CurrentWeight = 55,
                MaxWeight = 60
            }  
        });

        modelBuilder.Entity<Character_title>().HasData(new List<Character_title>
        {
           new Character_title
           {
               IdCharacter = 2,
               IdTitle = 2,
               AccuiredAt = new DateTime(2024, 3, 1, 13, 25, 13)
           },
           new Character_title
           {
               IdCharacter = 1,
               IdTitle = 1,
               AccuiredAt = new DateTime(2023, 5, 1, 13, 25, 13)
           }
        });
    }
}