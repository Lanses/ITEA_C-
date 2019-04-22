using System;

namespace ConsoleApp4
{
    class Program
    {
        public static double Factorial(int x)
        {
            double result = 1;
            while (x != 1)
            {
                result = result * x;
                x = x - 1;
                Console.WriteLine(result);
            }
            return result;
        }


        static void Main(string[] args)
        {
            //Console.ReadLine();
            int x;
            x = int.Parse(Console.ReadLine());
            Factorial(x);
            
        }
    }
}
