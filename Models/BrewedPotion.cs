using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionBrewerySystem.Models
{
    public class BrewedPotion
    {
        [Key]
        public int BrewedPotionID { get; set; }

        [ForeignKey("PotionRecipe")]
        public int RecipeID { get; set; }

        public string CustomName { get; set; } = string.Empty;
        public string Attributes { get; set; } = string.Empty;
        public DateTime BrewedTime { get; set; }

        public virtual PotionRecipe PotionRecipe { get; set; } = null!;
    }
}
