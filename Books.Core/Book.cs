using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core
{
    public  class Book //reference to mySql data base
    {
        public int bookID { get; set; }
        //Refference to id in mySQL
        public string bookName { get; set; }
        //Refference to book_name in mySQL
        public string bookAuthor { get; set; }
        //Refference to book_author in mySQL
        public string bookRepository { get; set; }
        //Refference to book_repository in mySQL
    }
}
