using Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Practise
{
    public class Shooting : IShooting
    {
        public virtual void Shoot()
        {
            Console.WriteLine("I am shooting");
        }
    }
}
