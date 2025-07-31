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
    public class TagsRepo : ITagsRepo
    {
        private readonly DataContext context;
        public TagsRepo(DataContext data)
        {
            this.context = data;
        }

        public Tags Create(Tags column)
        {
            context.Tags.Add(column);
            context.SaveChanges();
            return column;
        }

        public List<Tags> GetAll()
        {
            return context.Tags.ToList();
        }

        public Tags UpdateById(int id, Tags updatedColumn)
        {
            var column = context.Tags.FirstOrDefault(c => c.TagId == id);
            if (column != null)
            {
                column.TagName = updatedColumn.TagName;
                column.Description = updatedColumn.Description;
                context.SaveChanges();
            }
            return column;
        }

        public Tags DeleteById(int id)
        {
            var column = context.Tags.FirstOrDefault(c => c.TagId == id);
            if (column != null)
            {
                context.Tags.Remove(column);
                context.SaveChanges();
            }
            return column;
        }
    }
}
