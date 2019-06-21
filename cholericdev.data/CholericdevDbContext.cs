using cholericdev.model;
using Microsoft.EntityFrameworkCore;
using System;

namespace cholericdev.data
{
    public class CholericdevDbContext : DbContext
    {
        public CholericdevDbContext(DbContextOptions<CholericdevDbContext> options)
           : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
