using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = k; i <= n; i++)
            {

                if (i % 2 != 0)
                {
                    a += i;
                }
            }
            Console.WriteLine(a);

            Console.WriteLine("\n");

            int sum = 0;
            int[] arr = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int value = rnd.Next(-100, 101);
                arr[i] = value;
                sum += value;
            }
            double max = arr.Max();
            double min = arr.Min();
            double middle = sum / arr.Length;

            Console.WriteLine($"Min value: {min} Max value: {max} Middle value: {middle}");
        }
    }
}
