using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionBrewerySystem.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public int StockQuantity { get; set; }
        public int MinStockThreshold { get; set; }
    }
}
