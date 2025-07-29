using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Models
{
    public class RecipeIngredients
    {
        public int RecipeId { get; set; } /* Foreign key to Recipes table */
        public int IngredientId { get; set; } /* Foreign key to Ingredients table */
        public int Quantity { get; set; } // quantity of the ingredient
        public string Unit { get; set; } // unit of measurement (e.g., grams, cups, tablespoons)
    }
}
