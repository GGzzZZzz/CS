using System;
using System.Collections.Generic;

public class SchoolTest
{
    public static void Main()
    {
        Person person = new Person("Dragan");
        person.SayHello();

        IList<Student> nerdStudents = new List<Student>
        {
            new Student("Jeko", 232),
            new Student("Paco", 45655),
            new Student("Kolio", 111222),
            new Student("Ginka", 67686),
            new Student("Ganka", 67123)
        };

        IList<Student> houligansStudents = new List<Student>
        {
            new Student("Bobi", 67),
            new Student("Radi", 6210),
            new Student("Gogo", 373),
            new Student("Raya", 12),
            new Student("Niya", 084)
        };

        IList<Discipline> disciplines = new List<Discipline>
        {
            new Discipline("Physics", 44, nerdStudents, "very funny"),
            new Discipline("Calculus", 456, houligansStudents, "hard to learn"),
            new Discipline("Chemistry", 09, houligansStudents)
        };

        IList<Teacher> teachers = new List<Teacher>
        {
            new Teacher("Glavorezov", disciplines, "always requiring"),
            new Teacher("Ochilatkova", disciplines),
            new Teacher("Dvoikov", disciplines)
        };

        SchoolClass nerds = new SchoolClass("nerds class", nerdStudents, teachers, "the best class ever");
        SchoolClass houligans = new SchoolClass("weak class", houligansStudents, teachers, "the bad class ever");

        School school = new School(new List<SchoolClass> { nerds, houligans });

        foreach (Student student in nerdStudents)
        {
            foreach (Teacher teacher in teachers)
            {
                teacher.SayHello();
            }

            student.SayHello();
        }
    }
}