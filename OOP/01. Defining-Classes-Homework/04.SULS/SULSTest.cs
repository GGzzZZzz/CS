using System;
using System.Collections.Generic;
using System.Linq;

internal class SULSTest
{
    public static void Main()
    {
        SeniorTrainer nakov = new SeniorTrainer(
            "Svetlin",
            "Nakov",
            22); // forever young :D
        Trainer vGeorgiev = new JuniorTrainer(
            "Vladimir",
            "Georgiev",
            20);

        Student graduated = new GraduateStudent(
            "Ivan",
            "Ivanov",
            25,
            2213435,
            (float)5.60);
        Student dropoutedOne = new DropoutStudent(
            "Vasil",
            "Vasilev",
            21,
            11643,
            (float)2.41,
            "unpaid semester");

        DropoutStudent dropoutedTwo = new DropoutStudent(
            "Nikolay",
            "Nikolov",
            26,
            4566789,
            (float)2.25,
            "bad results");

        Student currentOne = new OnsiteStudent("Petyr", "Petrov", 19, 411313, (float)4.67, "OOP", 2);
        Student currentTwo = new OnlineStudent(
            "Stoyan",
            "Stoyanov",
            32,
            2323439,
            (float)5.19,
            "Java Basics");

        List<Person> persons = new List<Person>() { nakov, vGeorgiev, graduated, dropoutedOne, dropoutedTwo, currentOne, currentTwo };

        Console.WriteLine("Current students:");

        // sort and call ToString method
        persons.Where(p => p is CurrentStudent).OrderBy(p => ((CurrentStudent)p).AverageGrade).ToList().ForEach(p => Console.WriteLine(p.ToString()));

        // create/delete courses
        Console.WriteLine("Created/deleted courses:");
        Console.WriteLine(vGeorgiev.CreateCourse("OPP"));
        Console.WriteLine(nakov.DeleteCourse("Java Basics"));

        Console.WriteLine();

        // reaply students
        Console.WriteLine("Reaply students:");
        Console.WriteLine(dropoutedTwo.Reaplly());
    }
}