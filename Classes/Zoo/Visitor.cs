using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Visitor : Person
    {
        public Visitor(int age, string name) : base(age, name)
        {
        }

        public void Observe(Animal animal)
        {

        }
    }

    
}
