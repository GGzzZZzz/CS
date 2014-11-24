using System;
using System.Collections.Generic;
using System.Linq;

public class HumanTest
{
    public static void Main()
    {
        IList<Student> students = new List<Student>
        {
            new Student("Drago", "Mechkarov", 12345),
            new Student("Zdravka", "Gabareva", 9876543),
            new Student("Gancho", "Grozev", 525781),
            new Student("Grozdanka", "Krivoshieva", 967433),
            new Student("Boncho", "Nedelchev", 994492536),
            new Student("Stavri", "Glushkov", 1638936111),
            new Student("Biniyo", "Binev", 83660),
            new Student("Mitiyo", "Kirev", 551922),
            new Student("Zheliyo", "Koichev", 822124),
            new Student("Rusi", "Velchev", 7742300)
        };

        var sortedStudents =
            from student in students
            orderby student.FacultyNumber
            select student;

        Console.WriteLine("Students");

        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }

        IList<Worker> workers = new List<Worker>
        {
            new Worker("Stamat", "Kolev", 250.20, 12),
            new Worker("Ignat", "Karaivanov", 218.10, 9),
            new Worker("Bozhil", "Penchev", 320.76, 16),
            new Worker("Boicho", "Karov", 200.09, 8),
            new Worker("Pencho", "Tenev", 200.09, 8),
            new Worker("Bozhin", "Valchev", 305.12, 15),
            new Worker("Groziyo", "Prodanov", 250.20, 12),
            new Worker("Kiro", "Zheliyazkov", 350.63, 20),
            new Worker("Marin", "Tanev", 334.11, 18),
            new Worker("Koliyo", "Dobrev", 301.02, 14),
        };

        var sortedWorkers =
            from worker in workers
            orderby worker.PaymentPerHour descending
            select worker;

        Console.WriteLine("\nWorkers");

        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine(worker);
        }

        List<Human> humans = new List<Human>();
        humans.AddRange(students);
        humans.AddRange(workers);

        var sortedHumans =
            from human in humans
            orderby human.FirstName, human.LastName
            select human;

        Console.WriteLine("\nHumans");

        foreach (var human in sortedHumans)
        {
            Console.WriteLine(human.GetType() + " " + human);
        }
    }
}