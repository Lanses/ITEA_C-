using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public string Author { get; private set; }
        public string Title;

        private int _numberOfPages;
        private DateTime _dateOfPublication;
        private string Category;

        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }

        public Book(string author)
        {
            Author = author;
        }

        void Read()
        {

        }
    }
}
