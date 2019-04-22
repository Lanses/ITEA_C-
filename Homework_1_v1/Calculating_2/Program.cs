using System;

namespace Calculating_2
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
            var C = int.Parse(Console.ReadLine());
            if (A > C)
            {
                Case1(A, B, C);
            }
            else
            {
                Case2(A, B, C);
            }
        }


        public static void Case1(int A, int B, int C)
        {
            Console.WriteLine((A + B) / 5 + Math.Pow(Math.Sin(C), 2));
        }

        public static void Case2(int A, int  B, double C)
        {
            Console.WriteLine(Math.Sqrt(Math.Abs(B + (Math.Pow(Math.Cos(C), 2)))));
        }

    }
}