using Autofac;
using Books.Core;
using Books.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Business
{
    public class BookService  //for easy change of the dataAccess to any ORM or to any data base
    {
        static IContainer _container;
        static BookService()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<BookRepository>().As<IBookRepository>();
            _container=builder.Build();
        }
        public static bool Delete(int bookID)
        {
            return _container.Resolve<IBookRepository>().Delete(bookID);
        }
        public static List<Book> GetAll()
        {
            return _container.Resolve<IBookRepository>().GetAll();
        }
        public static Book Save(Book obj, EntityState state)
        {
            if (state == EntityState.Added)
                obj.bookID = _container.Resolve<IBookRepository>().Insert(obj);
            else
                _container.Resolve<IBookRepository>().Update(obj);
            return obj;
        }
    }
}
