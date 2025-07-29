using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Models
{
    public class Favorites
    {
        public int Userid { get; set; } /* Foreign key to Users table */
        public int RecipeId { get; set; } /* Foreign key to Recipes table */

    }
}
