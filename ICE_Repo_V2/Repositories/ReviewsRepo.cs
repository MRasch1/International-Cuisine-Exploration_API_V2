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
    public class ReviewsRepo : IReviewsRepo
    {
        private readonly DataContext context;
        public ReviewsRepo(DataContext data)
        {
            this.context = data;
        }

        public Reviews Create(Reviews column)
        {
            context.Reviews.Add(column);
            context.SaveChanges();
            return column;
        }

        public List<Reviews> GetAll()
        {
            return context.Reviews.ToList();
        }

        public Reviews UpdateById(int id, Reviews updatedColumn)
        {
            var column = context.Reviews.FirstOrDefault(c => c.ReviewId == id);
            if (column != null)
            {

                column.Rating = updatedColumn.Rating;
                column.Comment = updatedColumn.Comment;
                context.SaveChanges();
            }
            return column;
        }

        public Reviews DeleteById(int id)
        {
            var column = context.Reviews.FirstOrDefault(c => c.ReviewId == id);
            if (column != null)
            {
                context.Reviews.Remove(column);
                context.SaveChanges();
            }
            return column;

        }
    }
}
