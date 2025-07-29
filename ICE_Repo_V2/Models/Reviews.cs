using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Models
{
    public class Reviews
    {
        public int ReviewId { get; set; } // Unique identifier for the review
        public int UserId { get; set; } // Foreign key to Users table
        public int RecipeId { get; set; } // Foreign key to Recipes table
        public int Rating { get; set; } // Rating given by the user (e.g., 1 to 5 stars)
        public string Comment { get; set; } // Optional comment provided by the user
        public DateTime CreatedAt { get; set; } // Timestamp for when the review was created
    }
}
