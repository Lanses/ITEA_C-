using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Elephant : Animal
    {
        public override void Eat(Food food)
        {
            Console.WriteLine("An elephant had been feeded");
        }
    }
}
