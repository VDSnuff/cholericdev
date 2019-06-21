using cholericdev.model;
using System.Collections.Generic;
using System.Text;

namespace cholericdev.data
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Update(User uodatedEvent);
        User Add(User newEvent);
        User Delete(int id);
        bool Commit();
    }

}
