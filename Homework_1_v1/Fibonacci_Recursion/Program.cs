using System;

namespace Fibonacci_Recursion
{
    class Program
    {
        public static double Fibonacci_Recursion(int x)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} \n {1} \n", a, b);
            while (x != 1) {
                c = a + b;
                Console.Write(" {0}", c);
                Console.Write("\n");
                a = b;
                b = c;
                x = x - 1;
            }
            return c;
        }



        static void Main(string[] args)
        {
            //Console.ReadLine();
            int x;
            x = int.Parse(Console.ReadLine());
            Fibonacci_Recursion(x);

        }
    }
}
