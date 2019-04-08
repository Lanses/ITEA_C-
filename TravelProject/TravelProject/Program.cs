using System;

namespace TravelProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please fill departure country: ");
            var _departureCountry = Console.ReadLine();
            Console.WriteLine("\n");


            Console.WriteLine("Please fill departure city: ");
            var _departureCity = Console.ReadLine();
            Console.WriteLine("\n");


            Console.WriteLine("Please fill destination country: ");
            var _destinationCountry = Console.ReadLine();
            Console.WriteLine("\n");


            Console.WriteLine("Please fill destination city: ");
            var _destinationCity = Console.ReadLine();
            Console.WriteLine("\n");


            Console.WriteLine("Please enter number of vacation days: ");
            var _numberOfDays = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Please enter number of persons: ");
            var _numberOfPersons = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            DataBase price = new DataBase();
            price.Price();
        }
    }
}
