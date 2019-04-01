using System;

namespace Calculating1
{
    class Program
    {
        static void Main(string[] args)
        {
            Result();
            Console.ReadLine();
            Console.ReadLine();

        }

        public static void Result()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            if (A >= B)
            {
                Console.WriteLine((A - B / 2) / (2 * Math.Pow(A + B, 2)));
            }
            else
            {
                Console.WriteLine(Math.Sqrt(A + Math.Pow(B + 1, 2)));
            }
        }

    }
}