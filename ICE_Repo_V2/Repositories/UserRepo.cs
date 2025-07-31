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
    public class UserRepo : UsersRepo
    {
        private readonly DataContext context;
        public UserRepo(DataContext data)
        {
            this.context = data;
        }

        public Users Create(Users column)
        {
            context.Users.Add(column);
            context.SaveChanges();
            return column;
        }

        public List<Users> GetAll()
        {
            return context.Users.ToList();
        }

        public Users UpdateById(int id, Users updatedColumn)
        {
            var column = context.Users.FirstOrDefault(c => c.UserId == id);

            if (column != null)
            {
                column.Username = updatedColumn.Username;
                column.Email = updatedColumn.Email;
                column.PasswordHash = updatedColumn.PasswordHash;

                context.SaveChanges();
            }

            return column;
        }

        public Users DeleteById(int id)
        {
            var column = context.Users.FirstOrDefault(c => c.UserId == id);

            if (column != null)
            {
                context.Users.Remove(column);
                context.SaveChanges();
            }
            return column;
        }

    }
}
