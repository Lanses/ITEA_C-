using System;

namespace Calculating1
{
    class Program
    {
        static void Main(string[] args)
        {
            Result();

        }

        public static void Result()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());

            if (A >= B)
            {
                Case1(A, B);
            }
            else
            {
                Case2(A, B);
            }
        }

        public static void Case1(int A, int B)
        {
            Console.WriteLine((A - B / 2) / (2 * Math.Pow(A + B, 2)));
        }

        public static void Case2(int A, double B)
        {
            Console.WriteLine(Math.Sqrt(A + Math.Pow(B + 1, 2)));
        }

    }
}