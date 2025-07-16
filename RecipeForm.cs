using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PotionBrewerySystem.Models;
using Microsoft.EntityFrameworkCore;

public partial class RecipeForm : Form
{
    private List<(int IngredientId, string IngredientName, int Quantity)> ingredientList;

    public RecipeForm()
    {
        InitializeComponent();
        ingredientList = new List<(int, string, int)>();
        LoadIngredients();
        LoadRecipes();

        recipeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        recipeGrid.SelectionChanged += recipeGrid_SelectionChanged;
    }

    private void LoadIngredients()
    {
        using (var context = new BreweryContext())
        {
            var ingredients = context.Ingredients.ToList();
            ingredientCombo.DataSource = ingredients;
            ingredientCombo.DisplayMember = "Name"; 
            ingredientCombo.ValueMember = "IngredientID";
        }
    }

    private void LoadRecipes()
    {
        using (var context = new BreweryContext())
        {
            var recipes = context.PotionRecipes
                .Select(r => new { r.RecipeID, r.Name, r.BrewingTimeSeconds })
                .ToList();

            recipes.Insert(0, new { RecipeID = 0, Name = "(New Recipe)", BrewingTimeSeconds = 1 });

            recipeGrid.DataSource = recipes;
        }

        if (recipeGrid.Columns["RecipeID"] != null)
        {
            recipeGrid.Columns["RecipeID"].ReadOnly = true;
        }

        if (recipeGrid.Rows.Count > 0)
        {
            recipeGrid.ClearSelection();
            recipeGrid.Rows[0].Selected = true;
        }
    }


    private void btnAddIngredient_Click(object sender, EventArgs e)
    {
        if (ingredientCombo.SelectedItem is Ingredient selectedIngredient)
        {
            int quantity = (int)quantityNumeric.Value;

            if (ingredientList.Any(i => i.IngredientId == selectedIngredient.IngredientID))
            {
                MessageBox.Show("This ingredient is already added.", "Info");
                return;
            }

            ingredientList.Add((selectedIngredient.IngredientID, selectedIngredient.Name, quantity));
            RefreshIngredientGrid();
        }
    }

    private void RefreshIngredientGrid()
    {
        recipeIngredientsGrid.Rows.Clear();
        foreach (var item in ingredientList)
        {
            recipeIngredientsGrid.Rows.Add(item.IngredientId, item.IngredientName, item.Quantity);
        }
    }

    private void btnSaveRecipe_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string description = txtDescription.Text.Trim();
        int brewingTime = (int)numBrewingTime.Value;

        if (string.IsNullOrWhiteSpace(name) || ingredientList.Count == 0)
        {
            MessageBox.Show("Please enter a recipe name and add at least one ingredient.", "Validation Error");
            return;
        }

        int selectedId = recipeGrid.SelectedRows.Count > 0
            ? (int)recipeGrid.SelectedRows[0].Cells["RecipeID"].Value
            : 0;

        bool isCreatingNew = selectedId == 0;

        using (var context = new BreweryContext())
        {
            PotionRecipe recipe;

            if (!isCreatingNew)
            {
                recipe = context.PotionRecipes
                    .Include(r => r.Ingredients)
                    .FirstOrDefault(r => r.RecipeID == selectedId);

                if (recipe == null)
                {
                    MessageBox.Show("Recipe not found.", "Error");
                    return;
                }

                recipe.Name = name;
                recipe.Description = description;
                recipe.BrewingTimeSeconds = brewingTime;

                context.RecipeIngredients.RemoveRange(recipe.Ingredients);
            }
            else
            {
                recipe = new PotionRecipe
                {
                    Name = name,
                    Description = description,
                    BrewingTimeSeconds = brewingTime
                };
                context.PotionRecipes.Add(recipe);
            }

            recipe.Ingredients = ingredientList.Select(i => new RecipeIngredient
            {
                IngredientID = i.IngredientId,
                Quantity = i.Quantity
            }).ToList();

            context.SaveChanges();

            MessageBox.Show(isCreatingNew ? "New recipe saved successfully!" : "Recipe updated successfully!", "Success");

            ClearForm();
            LoadRecipes();
        }
    }



    private void ClearForm()
    {
        txtName.Clear();
        txtDescription.Clear();
        numBrewingTime.Value = 1;
        ingredientList.Clear();
        RefreshIngredientGrid();
    }

    private void btnDeleteRecipe_Click(object sender, EventArgs e)
    {
        if (recipeGrid.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a recipe to delete.", "Info");
            return;
        }

        int selectedId = (int)recipeGrid.SelectedRows[0].Cells["RecipeID"].Value;

        using (var context = new BreweryContext())
        {
            var recipe = context.PotionRecipes.Find(selectedId);
            if (recipe != null)
            {
                var ingredients = context.RecipeIngredients.Where(ri => ri.RecipeID == selectedId).ToList();
                context.RecipeIngredients.RemoveRange(ingredients);

                context.PotionRecipes.Remove(recipe);
                context.SaveChanges();

                MessageBox.Show("Recipe deleted.", "Success");
                LoadRecipes();
            }
        }
    }

    private void recipeGrid_SelectionChanged(object sender, EventArgs e)
    {
        if (recipeGrid.SelectedRows.Count == 0) return;

        int selectedId = (int)recipeGrid.SelectedRows[0].Cells["RecipeID"].Value;

        if (selectedId == 0)
        {
            ClearForm();
            return;
        }

        using (var context = new BreweryContext())
        {
            var recipe = context.PotionRecipes
                .Include(r => r.Ingredients)
                .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefault(r => r.RecipeID == selectedId);

            if (recipe != null)
            {
                txtName.Text = recipe.Name;
                txtDescription.Text = recipe.Description;
                numBrewingTime.Value = recipe.BrewingTimeSeconds;

                ingredientList.Clear();
                foreach (var ri in recipe.Ingredients)
                {
                    ingredientList.Add((ri.IngredientID, ri.Ingredient.Name, ri.Quantity));
                }
                RefreshIngredientGrid();
            }
        }
    }
}