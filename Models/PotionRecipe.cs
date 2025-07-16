using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionBrewerySystem.Models
{
    public class PotionRecipe
    {
        [Key]
        public int RecipeID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public int BrewingTimeSeconds { get; set; }

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
    }
}
