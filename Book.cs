using System;
using System.Collections.Generic;
namespace _48
{
    class Book //สร้าง ClassBook 
    {
        private string BookName;
        private string BookID;
        private List<Book> BookList;

        public Book(string BookName,string BookID)
        {
            this.BookName = BookName;
            this.BookID = BookID;
            this.BookList = new List<Book>();
        }
        public void Combine()
        {
            Console.WriteLine("Book ID: {0}", this.BookID);
            Console.WriteLine("Book Name: {0}", this.BookName);
        }
        
        
    }
}
