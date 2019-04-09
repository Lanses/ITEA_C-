using System;
using Zoo;

namespace ZooConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var elephant = new Elephant();
            var bird = new Bird();

            var employee = new Employee(23, "Tom");
            var visitor = new Visitor(15, "Bill");

            employee.GoToTheZoo();
            visitor.GoToTheZoo();

            var herb = new Herb();
            var birdAviary = new Aviary();
            var elephantAviery = new Aviary();

            birdAviary.PlaceHerb(herb);
            birdAviary.PlaceAnimal(bird);
            elephantAviery.PlaceAnimal(elephant);

            Console.WriteLine(birdAviary.GetStatus());

            employee.FeedAnimal(elephant);
            employee.FeedAnimal(bird);

            visitor.Observe(elephant);
            visitor.Observe(bird);
        }
    }
}
