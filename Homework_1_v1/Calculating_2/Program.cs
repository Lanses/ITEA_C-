using System;

namespace Calculating_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Result();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }


        public static void Result()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            if (A > C)
            {
                Console.WriteLine((A + B) / 5 + Math.Pow(Math.Sin(C), 2));
            }
            else
            {
                Console.WriteLine(Math.Sqrt(Math.Abs(B + (Math.Pow(Math.Cos(C), 2)))));
            }
        }

    }
}