using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Classes
{
    internal class Libaray
    {
        public string Name { get; }
        private List<Book>_books=new List<Book>();
        public Libaray(string name)
        {
            Name = name;
        }
        public int Counter => _books.Count;
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        //-------With Index
        public Book? this[int index]
        {
            get
            {
                if (index >= 0 && index < _books.Count)
                    return _books[index];
                return null;
            }          
        }
        //-------With ISBN
        public Book? this[string isbn]
        {
            get
            {
                foreach(var book in _books)
                {
                    if(book.ISBN==isbn)
                        return book;
                }
                return null;
            }
        }
    }
}
