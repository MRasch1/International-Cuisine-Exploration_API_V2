using ICE_Repo_V2.Context;
using ICE_Repo_V2.Interfaces;
using ICE_Repo_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Repositories
{
    public class IngredientsRepo
    {
        private readonly DataContext context;
        public IngredientsRepo(DataContext data)
        {
            this.context = data;
        }

        public Ingredients Create(Ingredients ingredient)
        {
            context.Ingredients.Add(ingredient);
            context.SaveChanges();
            return ingredient;
        }

        public List<Ingredients> GetAll()
        {
            return context.Ingredients.ToList();
        }

        public Ingredients UpdateById(int id, Ingredients updatedIngredient)
        {
            var ingredient = context.Ingredients.FirstOrDefault(i => i.IngredientId == id);
            if (ingredient != null)
            {
                ingredient.IngredientName = updatedIngredient.IngredientName;
                ingredient.Description = updatedIngredient.Description;
                context.SaveChanges();
            }
            return ingredient;
        }

        public Ingredients DeleteById(int id)
        {
            var ingredient = context.Ingredients.FirstOrDefault(i => i.IngredientId == id);
            if (ingredient != null)
            {
                context.Ingredients.Remove(ingredient);
                context.SaveChanges();
            }
            return ingredient;
        }
    }
}
