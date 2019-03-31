using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Result();          
            Console.ReadLine();
        }

        public static void Result()
        {
            var a = Console.ReadLine();
            var numbersOfSymbols = a.Length;
            if (numbersOfSymbols >= 7)
            {
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine(a.Substring(0,2));
            }
        }

    }
}
