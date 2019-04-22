using InterfaceImplementation;
using Interfaces;
using SomeStuff;
using System;

namespace Travel_Project_v1
{
    class Program
    {
        static void Main(string[] args)
        {

            IPerson customer = new Customer("Peter", "Clarkson");

            Console.WriteLine($"Hello, {customer}");

            var information = new Info();
            information.InfoMessage();


            Console.WriteLine("Please fill departure country: ");
            var _departureCountry = Console.ReadLine();
            Console.WriteLine("\n");



            Console.WriteLine("Please fill destination country: ");
            var _destinationCountry = Console.ReadLine();
            Console.WriteLine("\n");



            Console.WriteLine("Please enter number of persons: ");
            var _numberOfPersons = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (_numberOfPersons <= 1)
            {
                Console.WriteLine($"Hello, total price of your ticket is: ");
            }
            else
            {
                Console.WriteLine($"Hello, total price of your tickets is: ");
            }
            Console.ReadLine();


        }
    }
}
