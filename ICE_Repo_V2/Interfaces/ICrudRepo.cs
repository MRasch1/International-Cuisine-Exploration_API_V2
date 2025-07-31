using ICE_Repo_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Interfaces
{
    public interface ICrudRepo<Crud>
    {
        Crud Create(Crud crud);
        List<Crud> GetAll();
        Crud UpdateById(int id, Crud updatedRow);
        Crud DeleteById(int id);
    }

    public interface ICountriesRepo : ICrudRepo<Countries> { }
    public interface ICuisinesRepo : ICrudRepo<Cuisines> { }
    public interface IDishesRepo : ICrudRepo<Dishes> { }
    public interface IDishTagRepo : ICrudRepo<DishTag> { }
    public interface IFavoritesRepo : ICrudRepo<Favorites> { }
    public interface IIngredientsRepo : ICrudRepo<Ingredients> { }
    public interface IRecipeIngridientsRepo : ICrudRepo<RecipeIngredients> { }
    public interface IRecipesRepo : ICrudRepo<Recipes> { }
    public interface IReviewsRepo : ICrudRepo<Reviews> { }
    public interface ITagsRepo : ICrudRepo<Tags> { }
    public interface IUsersRepo : ICrudRepo<Users> { }

}
