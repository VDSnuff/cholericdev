using cholericdev.model;
using System.Collections.Generic;
using System.Text;

namespace cholericdev.data
{
    public interface ICategporyRepository
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        Category Update(Category uodatedEvent);
        Category Add(Category newEvent);
        Category Delete(int id);
        bool Commit();
    }

}
