using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Models
{
    public class Tags
    {
        public int TagId { get; set; } // Unique identifier for the tag
        public string TagName { get; set; } // Name of the tag (e.g., "Vegetarian", "Gluten-Free", etc.)
        public string Description { get; set; } // Optional description of the tag

        public ICollection<DishTag> DishTags { get; set; } // Navigation property for the many-to-many relationship with dishes
    }
}
