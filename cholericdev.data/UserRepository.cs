using cholericdev.model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cholericdev.data
{
    public class UserRepository : IUserRepository
    {

        public UserRepository(CholericdevDbContext ctx, ILogger<UserRepository> logger)
        {
            this.ctx = ctx;
            this.logger = logger;
        }

        protected internal readonly CholericdevDbContext ctx;
        protected internal readonly ILogger<UserRepository> logger;

        public User Add(User newUser)
        {
            ctx.Add(newUser);
            return newUser;
        }

        public bool Commit()
        {
            return ctx.SaveChanges() > 0;
        }

        public User Delete(int id)
        {
            var deletedUser = GetById(id);
            if (deletedUser != null)
            {
                ctx.Users.Remove(deletedUser);
            }
            return deletedUser;
        }

        public IEnumerable<User> GetAll()
        {
            return ctx.Users.ToList();
        }

        public User GetById(int id)
        {
            return ctx.Users.Find(id);
        }

        public User Update(User updatedUser)
        {
            var entyti = ctx.Users.Attach(updatedUser);
            entyti.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updatedUser;
        }
    }

}
