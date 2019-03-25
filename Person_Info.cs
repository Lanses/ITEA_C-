using System;

namespace PersonInfo
{
    public class InfoAboutStudents {
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
            InfoAboutStudents test1 = new InfoAboutStudents();
            test1.PreShow();
            string name = Console.ReadLine();
            string lastname = Console.ReadLine();
            test1.NameAndLastName(name, lastname);
            
        }
    }
}
