using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionBrewerySystem.Models
{
    public class RecipeIngredient
    {
        [Key]
        public int RecipeIngredientID { get; set; }

        [ForeignKey("PotionRecipe")]
        public int RecipeID { get; set; }

        [ForeignKey("Ingredient")]
        public int IngredientID { get; set; }

        public int Quantity { get; set; }

        public virtual Ingredient Ingredient { get; set; } = null!;
        public virtual PotionRecipe PotionRecipe { get; set; } = null!;
    }
}
