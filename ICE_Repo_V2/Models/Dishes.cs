using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Models
{
    public class Dishes
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public int CuisineId { get; set; } /* Foreign key to Cusines table */
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
