using Interface;
using Interfaces_Practise;
using System;

namespace ProgramDuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            IMoving moving = new Moving();
            IShooting shooting = new Shooting();
            Console.WriteLine(moving);
        }
    }
}
