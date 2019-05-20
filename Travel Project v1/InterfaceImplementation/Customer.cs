using Interfaces;
using System;

namespace InterfaceImplementation
{
    public class Customer : IPerson
    {
        public string Name { get; }

        public string LastName { get; }

        public Customer(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
