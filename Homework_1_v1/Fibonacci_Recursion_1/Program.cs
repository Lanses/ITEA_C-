using System;

public class Fibonacci_Recursion
{
    public static int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }

    public static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.Write(Fib(i));
            Console.Write("\n");
        } 
    }
}