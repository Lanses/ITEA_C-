using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please fill the radius and height of the cylinder: "); 
            CylinderVolume();
        }

        public static void CylinderVolume() {
            var r = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            double result = Math.PI * r * r * h;

            Console.WriteLine(result);
        }
    }
}
