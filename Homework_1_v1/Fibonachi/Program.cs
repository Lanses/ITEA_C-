﻿using System;

namespace ConsoleApp3
{
    class Program
    {

        public static void Fibonacci(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }


        static void Main(string[] args)
        {
            Fibonacci(10);
            Console.Write("\n");
        }
    }
}