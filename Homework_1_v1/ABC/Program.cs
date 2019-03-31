using System;

namespace ConsoleApp1
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
            if (A < 0)
            {
                Console.WriteLine(A + B + C);
            }
            else if (A > 0 && C != 0)
            {
                Console.WriteLine((A * B) / C);
            }
            else
            {
                Console.WriteLine("42");
            }
        }

    }
}