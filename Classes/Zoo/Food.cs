using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Food
    {
        public Food(int callories)
        {
            Callories = callories;
        }
        public int Callories { get; private set; }
    }
}
