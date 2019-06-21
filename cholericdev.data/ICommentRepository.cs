using cholericdev.model;
using System.Collections.Generic;
using System.Text;

namespace cholericdev.data
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAll();
        Comment GetById(int id);
        Comment Update(Comment uodatedEvent);
        Comment Add(Comment newEvent);
        Comment Delete(int id);
        bool Commit();
    }

}
