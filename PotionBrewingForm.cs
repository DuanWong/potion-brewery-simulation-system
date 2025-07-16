using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PotionBrewerySystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PotionBrewerySystem
{
    public partial class PotionBrewingForm : Form
    {
        private List<PotionRecipe> allRecipes;
        private PotionRecipe selectedRecipe;

        public PotionBrewingForm()
        {
            InitializeComponent();
            LoadRecipes();
            comboRecipe.SelectedIndexChanged += comboRecipe_SelectedIndexChanged;
            btnCheckStock.Click += BtnCheckStock_Click;
            btnBrew.Click += BtnBrew_Click;
        }

        private void LoadRecipes()
        {
            using (var context = new BreweryContext())
            {
                allRecipes = context.PotionRecipes
                    .Select(r => new PotionRecipe
                    {
                        RecipeID = r.RecipeID,
                        Name = r.Name,
                        Description = r.Description,
                        Ingredients = r.Ingredients.Select(i => new RecipeIngredient
                        {
                            RecipeIngredientID = i.RecipeIngredientID,
                            Quantity = i.Quantity,
                            Ingredient = new Ingredient
                            {
                                IngredientID = i.Ingredient.IngredientID,
                                Name = i.Ingredient.Name,
                                StockQuantity = i.Ingredient.StockQuantity
                            }
                        }).ToList()
                    }).ToList();

                comboRecipe.DataSource = allRecipes;
                comboRecipe.DisplayMember = "Name";
                comboRecipe.ValueMember = "RecipeID";
                comboRecipe.SelectedIndex = 0; 
            }

            lblStatus.Text = "Please select a recipe.";
        }

        private void comboRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRecipe.SelectedItem is PotionRecipe selected)
            {
                using (var context = new BreweryContext())
                {
                    var fullRecipe = context.PotionRecipes
                        .Include(r => r.Ingredients)
                        .ThenInclude(ri => ri.Ingredient)
                        .FirstOrDefault(r => r.RecipeID == selected.RecipeID);

                    if (fullRecipe == null)
                    {
                        MessageBox.Show("Recipe not found.");
                        return;
                    }

                    gridIngredients.Rows.Clear();
                    gridIngredients.Columns.Clear();

                    gridIngredients.Columns.Add("Name", "Ingredient");
                    gridIngredients.Columns.Add("Required", "Required Qty");
                    gridIngredients.Columns.Add("Stock", "In Stock");

                    foreach (var ri in fullRecipe.Ingredients)
                    {
                        var ingredient = ri.Ingredient;
                        if (ingredient == null)
                        {
                            MessageBox.Show("Missing ingredient in this recipe.");
                            return;
                        }

                        gridIngredients.Rows.Add(ingredient.Name, ri.Quantity, ingredient.StockQuantity);
                    }

                    selectedRecipe = fullRecipe;

                    lblStatus.Text = "Ready to check stock.";
                    btnBrew.Enabled = false; 
                }
            }
        }

        private void BtnCheckStock_Click(object sender, EventArgs e)
        {
            if (selectedRecipe == null) return;

            bool hasStock = selectedRecipe.Ingredients.All(i => i.Quantity <= i.Ingredient.StockQuantity);

            if (hasStock)
            {
                lblStatus.Text = "All ingredients available.";
                btnBrew.Enabled = true;
            }
            else
            {
                lblStatus.Text = "Not enough ingredients in stock.";
                btnBrew.Enabled = false;
            }
        }

        private async void BtnBrew_Click(object sender, EventArgs e)
        {
            btnBrew.Enabled = false;
            btnCheckStock.Enabled = false;
            comboRecipe.Enabled = false;
            lblStatus.Text = "Brewing in progress...";
            progressBrew.Value = 0;

            for (int i = 0; i <= 100; i += 5)
            {
                progressBrew.Value = i;
                await Task.Delay(100);
            }

            using (var context = new BreweryContext())
            {
                foreach (var recipeIngredient in selectedRecipe.Ingredients)
                {
                    var ingredientId = recipeIngredient.IngredientID;
                    var dbIngredient = context.Ingredients.FirstOrDefault(i => i.IngredientID == ingredientId);

                    if (dbIngredient == null)
                    {
                        MessageBox.Show($"Ingredient ID {ingredientId} not found in DB.");
                        return;
                    }
                    dbIngredient.StockQuantity -= recipeIngredient.Quantity;
                }

                var brewedPotion = new BrewedPotion
                {
                    RecipeID = selectedRecipe.RecipeID,
                    BrewedTime = DateTime.Now,
                    CustomName = selectedRecipe.Name + " Potion",
                    Attributes = "Default Attributes"
                };

                context.BrewedPotions.Add(brewedPotion);
                context.SaveChanges();
            }

            lblStatus.Text = "Potion brewed successfully!";
            btnCheckStock.Enabled = true;
            comboRecipe.Enabled = true;
            progressBrew.Value = 100;
        }
    }
}
