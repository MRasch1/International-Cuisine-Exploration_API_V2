using ICE_Repo_V2.Models;
using ICE_Repo_V2.Context;
using ICE_Repo_V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Repositories
{
    public class FavoritesRepo
    {
        private readonly DataContext context;
        public FavoritesRepo(DataContext context)
        {
            this.context = context;
        }

        public Favorites Create(Favorites favorite)
        {
            context.Favorites.Add(favorite);
            context.SaveChanges();
            return favorite;
        }

        public List<Favorites> GetAll()
        {
            return context.Favorites.ToList();
        }
    }
}
