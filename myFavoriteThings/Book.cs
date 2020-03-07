using System;
using System.Collections.Generic;
using System.Text;

namespace myFavoriteThings
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void TheDeets()
        {
            Console.WriteLine($"{Title} is written by {Author}.");
        }
    }
}
