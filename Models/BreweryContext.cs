using Microsoft.EntityFrameworkCore;

namespace PotionBrewerySystem.Models
{
    public class BreweryContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<PotionRecipe> PotionRecipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<BrewedPotion> BrewedPotions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PotionBrewery.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.PotionRecipe)
                .WithMany(r => r.Ingredients)
                .HasForeignKey(ri => ri.RecipeID);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany()
                .HasForeignKey(ri => ri.IngredientID);

            modelBuilder.Entity<BrewedPotion>()
                .HasOne(bp => bp.PotionRecipe)
                .WithMany()
                .HasForeignKey(bp => bp.RecipeID);

            modelBuilder.Entity<BrewedPotion>()
                .Property(bp => bp.BrewedTime)
                .HasConversion(
                    v => v.ToString("o"),  // to database (string)
                    v => DateTime.Parse(v) // from database (string back to DateTime)
                );

            //Seed Data
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientID = 1, Name = "Unicorn Hair", StockQuantity = 100, MinStockThreshold = 10 },
                new Ingredient { IngredientID = 2, Name = "Phoenix Feather", StockQuantity = 50, MinStockThreshold = 5 },
                new Ingredient { IngredientID = 3, Name = "Dragon Scale", StockQuantity = 80, MinStockThreshold = 8 }
            );

            modelBuilder.Entity<PotionRecipe>().HasData(
                new PotionRecipe { RecipeID = 1, Name = "Healing Elixir", Description = "Restores health.", BrewingTimeSeconds = 5 },
                new PotionRecipe { RecipeID = 2, Name = "Invisibility Brew", Description = "Grants invisibility.", BrewingTimeSeconds = 8 }
            );

            modelBuilder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient { RecipeIngredientID = 1, RecipeID = 1, IngredientID = 1, Quantity = 3 },
                new RecipeIngredient { RecipeIngredientID = 2, RecipeID = 1, IngredientID = 3, Quantity = 2 },
                new RecipeIngredient { RecipeIngredientID = 3, RecipeID = 2, IngredientID = 2, Quantity = 4 },
                new RecipeIngredient { RecipeIngredientID = 4, RecipeID = 2, IngredientID = 3, Quantity = 3 }
            );

            modelBuilder.Entity<BrewedPotion>().HasData(
                new BrewedPotion
                {
                    BrewedPotionID = 1,
                    RecipeID = 1, 
                    CustomName = "Flame Elixir",
                    Attributes = "Fire Resistance, Warmth",
                    BrewedTime = new DateTime(2025, 5, 15, 10, 30, 0)
                },
                new BrewedPotion
                {
                    BrewedPotionID = 2,
                    RecipeID = 2, 
                    CustomName = "Shadow Draught",
                    Attributes = "Invisibility, Stealth Boost",
                    BrewedTime = new DateTime(2025, 5, 16, 14, 0, 0)
                },
                new BrewedPotion
                {
                    BrewedPotionID = 3,
                    RecipeID = 1,
                    CustomName = "Flame Elixir Plus",
                    Attributes = "Fire Resistance, Warmth, Speed Boost",
                    BrewedTime = new DateTime(2025, 5, 17, 9, 15, 0)
                }
            );
        }
    }
}
