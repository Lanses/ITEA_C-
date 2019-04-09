using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        private int _requiredCallories = 15000;
        public virtual void Eat(Food food)
        {
            if (food.Callories <= _requiredCallories)
            {
                Console.WriteLine("Not enough food for animal, require more callories");
            }
            else Console.WriteLine();
        }
    }
}
