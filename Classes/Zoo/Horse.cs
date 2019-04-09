using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Horse : Animal
    {
        public override void Eat(Food food)
        {
            Console.WriteLine("Horse had been feeded");
        }
    }
}
