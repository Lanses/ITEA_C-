using System;

namespace PersonInfo
{
    public class InfoAboutStudent
    {
        private string name;
        private string lastname;

        public static void PreShow()
        {
            Console.WriteLine("Please fill name and last name of the student: ");
        }

        public static void NameAndLastName(string n, string ln)
        {
            //name = n;
            //lastname = ln;
            Console.WriteLine($"Name: {n} Last name: {ln}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            InfoAboutStudent test1 = new InfoAboutStudent();
            test1.PreShow();
            string name = Console.ReadLine();
            string lastname = Console.ReadLine();
            test1.NameAndLastName(name, lastname);

        }
    }
}