using System;

namespace PersonInfo
{
    public class InfoAboutStudent {
        public string name;
        public string lastname;

        public void PreShow() {
            Console.WriteLine("Please fill name and last name of the student: ");
        }

        public void NameAndLastName(string n, string ln) {
            name = n;
            lastname = ln;
            Console.WriteLine($"Name: {n} Last Name: {ln}");
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
