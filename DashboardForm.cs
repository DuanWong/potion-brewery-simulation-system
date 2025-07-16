using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PotionBrewerySystem.Models;

namespace PotionBrewerySystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadMostBrewedPotion();
            LoadMostUsedIngredient();
        }

        private void LoadMostBrewedPotion()
        {
            using (var context = new BreweryContext())
            {
                var mostBrewed = context.BrewedPotions
                    .GroupBy(p => p.CustomName)
                    .Select(g => new { PotionName = g.Key, Count = g.Count() })
                    .OrderByDescending(g => g.Count)
                    .FirstOrDefault();

                lblMostBrewedPotion.Text = mostBrewed != null
                    ? $"{mostBrewed.PotionName} ({mostBrewed.Count} times)"
                    : "No data";
            }
        }

        private void LoadMostUsedIngredient()
        {
            using (var context = new BreweryContext())
            {
                var mostUsed = context.RecipeIngredients
                    .GroupBy(ri => ri.Ingredient.Name)
                    .Select(g => new { Ingredient = g.Key, UsageCount = g.Count() })
                    .OrderByDescending(g => g.UsageCount)
                    .FirstOrDefault();

                lblMostUsedIngredient.Text = mostUsed != null
                    ? $"{mostUsed.Ingredient} ({mostUsed.UsageCount} uses)"
                    : "No data";
            }
        }

        private void btnGetCountInRange_Click(object sender, EventArgs e)
        {
            DateTime start = dateStart.Value.Date;
            DateTime end = dateEnd.Value.Date.AddDays(1).AddTicks(-1);

            using (var context = new BreweryContext())
            {
                int count = context.BrewedPotions
                    .Count(p => p.BrewedTime >= start && p.BrewedTime <= end);

                lblBrewedInRange.Text = $"{count} potions brewed.";
            }
        }

        private void btnOpenCustomization_Click(object sender, EventArgs e)
        {
            var customizationForm = new CustomizePotionForm();
            customizationForm.ShowDialog();
        }

        private void btnOpenIngredient_Click(object sender, EventArgs e)
        {
            var ingredientForm = new IngredientForm();
            ingredientForm.ShowDialog();
        }

        private void btnOpenRecipe_Click(object sender, EventArgs e)
        {
            var recipeForm = new RecipeForm();
            recipeForm.ShowDialog();
        }

        private void btnOpenBrew_Click(object sender, EventArgs e)
        {
            var potionBrewingForm = new PotionBrewingForm();
            potionBrewingForm.ShowDialog();
        }
    }
}
