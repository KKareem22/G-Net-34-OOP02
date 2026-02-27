using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Classes
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Book(string isbn,string title)
        {
            ISBN = isbn;
            Title = title;
        }
        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}";
        }
    }
}
