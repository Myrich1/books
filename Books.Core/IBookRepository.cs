using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        int Insert(Book obj);
        bool Update(Book obj);
        bool Delete(int bookID);
    }
}
