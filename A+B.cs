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
        }

        public static void Result()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);
        }

    }
}
