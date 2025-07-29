using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Models
{
    public class DishTag
    {
        public int DishId { get; set; } // Foreign key to the Dishes table
        public Dishes Dish { get; set; } // Navigation property to the Dishes table

        public int TagId { get; set; } // Foreign key to the Tags table
        public Tags Tag { get; set; } // Navigation property to the Tags table
    }
}
