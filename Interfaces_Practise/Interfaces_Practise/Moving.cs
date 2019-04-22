using Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Practise
{
    public class Moving : IMoving
    {
        public virtual void Move()
        {
            Console.WriteLine("I am moving");
        }
    }
}
