using System;

namespace ConsoleApp6
{
    class Person
    {
        public string name;
        public int age;

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Alexander = new Person();

            Alexander.name = "Alexander";
            Alexander.age = 21;
            Alexander.GetInfo();

            Console.Read();
        }
    }
}