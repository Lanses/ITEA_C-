using System;
using Library;

namespace LibraryUser
{
    class Program
    {
        static void Main(string[] args)
        {
            var librarian = new Librarian();
            librarian.GetAge();
        }
    }
}
