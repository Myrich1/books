using Books.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Books.DataAccess
{
    public class BookRepository : IBookRepository
    {
        public bool Delete(int bookID)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                int result = db.Execute("Delete from books_managment where id=p_id", new { BookID = bookID }, commandType: CommandType.Text);
                //executing delete operation  
                return result != 0;
            }
        }

        public List<Book> GetAll()
        {
            //connecting to data base
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                //getting all the information from the data base
                return db.Query<Book>("Select * from books_managment", commandType: CommandType.Text).ToList();
            }
        }
    

        public int Insert(Book obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                        db.Open();              
                    DynamicParameters p = new DynamicParameters();  //creating a dapper parameter 
                    p.Add("p_id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.AddDynamicParams(new { BookName = obj.bookName, BookAuthor = obj.bookAuthor, BookRepository = obj.bookRepository });
                    db.Execute("sp_Insert", p, commandType: CommandType.StoredProcedure); //executing stored procedure
                    return p.Get<int>("p_id");               
            }
        }

        public bool Update(Book obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                //updating/editing the data base via stored procedure
                int result = db.Execute("sp_Update", new { BookID = obj.bookID, BookName = obj.bookName, BookAuthor = obj.bookAuthor, BookRepository = obj.bookRepository }, commandType: CommandType.StoredProcedure);
                return result != 0;
            }
        }
    }
}
