using System;
using System.Linq;

public class AnimalsTest
{
    public static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Dog("Sharo", 3, "male"),
            new Dog("Balkan", 2, "male"),
            new Dog("Lisa", 3, "female"),
            new Dog("Djessy", 1, "female"),
            new Dog("Lucky", 4, "male"),
            new Frog("Kermit", 59, "male"),
            new Frog("Jaburana", 10, "female"),
            new Frog("Jabcho", 7, "male"),
            new Frog("Kvakcho", 2, "male"),
            new Frog("Bradavichka", 5, "female"),
            new Kitten("Kitty", 1),
            new Kitten("Pussy", 4),
            new Kitten("Maca", 2),
            new Kitten("Roshka", 2),
            new Kitten("Pisana", 3),
            new Tomcat("Puhcho", 4),
            new Tomcat("Roshlio", 7),
            new Tomcat("Kotiyo", 3),
            new Tomcat("Marcho", 1),
            new Tomcat("Pisko", 5),
        };

        var groupedByAverage =
            from animal in animals
            group animal by (animal is Cat)  ? typeof(Cat) : animal.GetType() into gr
            select new { GroupName = gr.Key, AverageAge = gr.Average(animal => animal.Age) };

        foreach (var animal in groupedByAverage)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine();

        foreach (Animal animal in animals)
        {
            animal.ProduceSound();
        }
    }
}