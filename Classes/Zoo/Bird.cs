using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Bird : Animal
    {
        public override void Eat(Food food)
        {
            Console.WriteLine("Bird had been feeded");
        }
    }
}
