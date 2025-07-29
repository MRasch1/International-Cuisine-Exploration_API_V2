using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Models
{
    public class Recipes
    {
        public int RecipeId { get; set; }
        public int DishId { get; set; } /* Foreign key to Dishes table */
        public int UserId { get; set; } /* Foreign key to Users table */
        public string Instructions { get; set; }
        public int PrepTime { get; set; } // in minutes
        public int CookTime { get; set; } // in minutes
        public int Servings { get; set; } // number of servings
        public DateTime CreatedAt { get; set; } // timestamp for when the recipe was created
    }
}
