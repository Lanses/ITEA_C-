using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Librarian : Person
    {
        Book ProvideBook()
        {
            return new Book();
        }
    }
}
