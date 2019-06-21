using cholericdev.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace cholericdev.data
{
    public class PostRepository : IPostRepository
    {

        public PostRepository(CholericdevDbContext ctx, ILogger<PostRepository> logger)
        {
            this.ctx = ctx;
            this.logger = logger;
        }

        protected internal readonly CholericdevDbContext ctx;
        protected internal readonly ILogger<PostRepository> logger;

        public Post Add(Post newPost)
        {
            ctx.Add(newPost);
            return newPost;
        }

        public bool Commit()
        {
            return ctx.SaveChanges() > 0;
        }

        public Post Delete(int id)
        {
            var deletedPost = GetById(id);
            if (deletedPost != null)
            {
                ctx.Posts.Remove(deletedPost);
            }
            return deletedPost;
        }

        public IEnumerable<Post> GetAll()
        {
            return ctx.Posts.Include(u => u.User).Include(c => c.Comments).Include(c => c.Category).ToList();
        }

        public Post GetById(int id)
        {
            return ctx.Posts.Find(id);
        }

        public Post Update(Post updatedPost)
        {
            var entyti = ctx.Posts.Attach(updatedPost);
            entyti.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updatedPost;
        }
    }

}
