using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Home_Task_14._07._2023.Model
{
    internal class MyContext: DbContext
    {
        public MyContext(): base("MyLibrary") { }
        public DbSet<Books> books { get; set; }

        public List<Books> GetAllBooks() 
        {
            return books.ToList();
        }
        public void AddBook (Books book)
        {
            books.Add(book);
        }
        public bool DeleteBook (Books a)
        {
            foreach (var b in books)
                if (b.Id == a.Id)
                {
                    books.Remove(b);
                    return true;
                }
            return false;
        }
        public void EditBook (Books a)
        {
            foreach (var b in books)
                if (b.Id == a.Id)
                {
                    b.Name = a.Name;
                    b.Author = a.Author;
                    b.Publisher = a.Publisher;
                    b.Category = a.Category;
                    b.Pages = a.Pages;
                }
        }
        public List<Books> FindBook(string a)
        {          
                List<Books> FoundBooks = new List<Books>();
                if (a != " " && a.Length != 0)
                    foreach (var book in books)
                        if (book.Author == a || book.Name==a || book.Category==a || book.Publisher==a)
                        FoundBooks.Add(book); 
                return FoundBooks;
        }

    }
}
