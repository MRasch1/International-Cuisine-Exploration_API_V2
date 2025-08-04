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


    }
}
