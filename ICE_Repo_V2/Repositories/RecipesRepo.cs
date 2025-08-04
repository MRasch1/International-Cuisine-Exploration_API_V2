using ICE_Repo_V2.Models;
using ICE_Repo_V2.Interfaces;
using ICE_Repo_V2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Repositories
{
    public class RecipesRepo : IRecipesRepo
    {
        private readonly DataContext context;
        public RecipesRepo(DataContext data)
        {
            this.context = data;
        }

        public Recipes Create(Recipes recipe)
        {
            context.Recipes.Add(recipe);
            context.SaveChanges();
            return recipe;
        }

        public List<Recipes> GetAll()
        {
            return context.Recipes.ToList();
        }

        public Recipes UpdateById(int id, Recipes updatedRecipe)
        {
            var recipe = context.Recipes.FirstOrDefault(r => r.RecipeId == id);
            if (recipe != null)
            {
                recipe.Instructions = updatedRecipe.Instructions;
                recipe.PrepTime = updatedRecipe.PrepTime;
                recipe.CookTime = updatedRecipe.CookTime;
                recipe.Servings = updatedRecipe.Servings;
                context.SaveChanges();
            }
            return recipe;
        }

        public Recipes DeleteById(int id)
        {
            var recipe = context.Recipes.FirstOrDefault(r => r.RecipeId == id);
            if (recipe != null)
            {
                context.Recipes.Remove(recipe);
                context.SaveChanges();
            }
            return recipe;
        }
    }
}
