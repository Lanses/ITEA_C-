using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Librarian : Person
    {
        Book ProvideBook()
        {
            var book = new Book("Rey Bredberry", "Book");
            book.Author = "Stephen King";
            book.Title = "Four seasons";

            return book;
        }
    }
}
