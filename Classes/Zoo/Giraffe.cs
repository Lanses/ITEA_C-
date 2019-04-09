using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Giraffe : Animal
    {
        public override void Eat(Food food)
        {
            Console.WriteLine("Giraffe had been feeded");
        }
    }
}
