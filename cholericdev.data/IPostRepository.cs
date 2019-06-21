using cholericdev.model;
using System.Collections.Generic;
using System.Text;

namespace cholericdev.data
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAll();
        Post GetById(int id);
        Post Update(Post uodatedEvent);
        Post Add(Post newEvent);
        Post Delete(int id);
        bool Commit();
    }

}
