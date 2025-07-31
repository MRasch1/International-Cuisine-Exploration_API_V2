using ICE_Repo_V2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<Countries> Countries { get; set; }
        public DbSet<Cuisines> Cuisines { get; set; }
        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<DishTag> DishTags { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
