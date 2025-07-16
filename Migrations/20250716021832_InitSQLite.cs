using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PotionBrewerySystem.Migrations
{
    /// <inheritdoc />
    public partial class InitSQLite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    StockQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    MinStockThreshold = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientID);
                });

            migrationBuilder.CreateTable(
                name: "PotionRecipes",
                columns: table => new
                {
                    RecipeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    BrewingTimeSeconds = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotionRecipes", x => x.RecipeID);
                });

            migrationBuilder.CreateTable(
                name: "BrewedPotions",
                columns: table => new
                {
                    BrewedPotionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecipeID = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomName = table.Column<string>(type: "TEXT", nullable: false),
                    Attributes = table.Column<string>(type: "TEXT", nullable: false),
                    BrewedTime = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrewedPotions", x => x.BrewedPotionID);
                    table.ForeignKey(
                        name: "FK_BrewedPotions_PotionRecipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "PotionRecipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeIngredientID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecipeID = table.Column<int>(type: "INTEGER", nullable: false),
                    IngredientID = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.RecipeIngredientID);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_PotionRecipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "PotionRecipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientID", "MinStockThreshold", "Name", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 10, "Unicorn Hair", 100 },
                    { 2, 5, "Phoenix Feather", 50 },
                    { 3, 8, "Dragon Scale", 80 }
                });

            migrationBuilder.InsertData(
                table: "PotionRecipes",
                columns: new[] { "RecipeID", "BrewingTimeSeconds", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Restores health.", "Healing Elixir" },
                    { 2, 8, "Grants invisibility.", "Invisibility Brew" }
                });

            migrationBuilder.InsertData(
                table: "BrewedPotions",
                columns: new[] { "BrewedPotionID", "Attributes", "BrewedTime", "CustomName", "RecipeID" },
                values: new object[,]
                {
                    { 1, "Fire Resistance, Warmth", "2025-05-15T10:30:00.0000000", "Flame Elixir", 1 },
                    { 2, "Invisibility, Stealth Boost", "2025-05-16T14:00:00.0000000", "Shadow Draught", 2 },
                    { 3, "Fire Resistance, Warmth, Speed Boost", "2025-05-17T09:15:00.0000000", "Flame Elixir Plus", 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "RecipeIngredientID", "IngredientID", "Quantity", "RecipeID" },
                values: new object[,]
                {
                    { 1, 1, 3, 1 },
                    { 2, 3, 2, 1 },
                    { 3, 2, 4, 2 },
                    { 4, 3, 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrewedPotions_RecipeID",
                table: "BrewedPotions",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientID",
                table: "RecipeIngredients",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeID",
                table: "RecipeIngredients",
                column: "RecipeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrewedPotions");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "PotionRecipes");
        }
    }
}
