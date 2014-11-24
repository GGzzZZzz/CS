using System;
using System.Collections.Generic;
using System.Linq;

public class StudentTest
{
    public static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student(
                "Ivan",
                "Rakidzhiev",
                22,
                803213,
                "+3592 29 45 49",
                "vankata_party@gmail.com",
                new List<int> { 2, 3, 5, 2 },
                1, 
                "Hooligans"),
                new Student(
                "Nina",
                "Frenska",
                19,
               862014,
                "+359395001248",
                "nina_payner@gmail.com",
                new List<int> { 6, 6, 4, 5, 6 },
                2, 
                "Hot Chicks"),
                new Student(
                "Petyr",
                "Manekenov",
                28,
                111512,
                "+3592883645",
                "pepi_pichaga@yahoo.com",
                new List<int> { 6, 5, 5, 6 },
                2, 
                "Hooligans"),
                new Student(
                "Kolio",
                "Tenekedzhiev",
                18,
                463613,
                "02/55-44-33",
                "night_racer@abv.bg",
                new List<int> { 3, 4 },
                13, 
                "Boosters"),
                new Student(
                "Zdravko",
                "Jelyazkov",
                23,
                096414,
                "+359888880088",
                "napompan_batka@mail.bg",
                null,
                2, 
                "Boosters"),
        };

        /* Problem 4 - Print all students from group number 2.
         * Use a LINQ query.
         * Order the students by FirstName.*/
        var sortedByGroupNum =
            from student in students
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;

        foreach (var student in sortedByGroupNum)
        {
            Console.WriteLine(student.ToString());
            Console.WriteLine();
        }

        Console.WriteLine();

        ///* Problem 5 - Print all students whose first name is before their last name alphabetically. Use a LINQ query.*/
        var sortedByNames =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

        foreach (var student in sortedByNames)
        {
            Console.WriteLine(student);
            Console.WriteLine();
        }

        Console.WriteLine();

        ///* Problem 6 - Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.*/
        var sortedByAge =
            from student in students
            where student.Age >= 18 || student.Age <= 24
            select new { student.FirstName, student.LastName, student.Age };

        foreach (var student in sortedByAge)
        {
            Console.WriteLine(
                "First Name:{0}, Last Name:{1}, Age:{2}",
                student.FirstName,
                student.LastName,
                student.Age);
            Console.WriteLine();
        }

        Console.WriteLine();

        /* Problem 7 - Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.*/

        var sortedLambda = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName);

        var sortedQuery =
            from student in students
            orderby student.FirstName descending,
            student.LastName descending
            select student;

        foreach (var student in sortedQuery)
        {
            Console.WriteLine(student);
            Console.WriteLine();
        }

        Console.WriteLine();

        /*Problem 8 - Print all students that have email @abv.bg. Use LINQ.*/
        var sortedByEmail =
            from student in students
            where student.Email.Contains("@abv.bg")
            select student;

        foreach (var student in sortedByEmail)
        {
            Console.WriteLine(student);
            Console.WriteLine();
        }

        Console.WriteLine();

        /*Problem 9 - Print all students with phones in Sofia (starting with 02 / +3592 / +359 2).
         * Use LINQ.*/

        var sortedByPhone =
            from student in students
            where student.Phone.StartsWith("02") ||
            student.Phone.StartsWith("+3592") ||
            student.Phone.StartsWith("+359 2")
            select student;

        foreach (var student in sortedByPhone)
        {
            Console.WriteLine(student);
            Console.WriteLine();
        }

        Console.WriteLine();

        /*Problem 10 - Print all students that have at least one mark Excellent (6).
         * Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.*/
        var excelentStudents =
            from student in students
            where student.Marks.Contains(6)
            select new { student.FirstName, student.LastName, student.Marks };

        foreach (var student in excelentStudents)
        {
            Console.WriteLine("{0} ( {1} )", student.FirstName + " " + student.LastName, string.Join(", ", student.Marks));
        }

        Console.WriteLine();

        /*Problem 11 - Write a similar program to the previous one to extract the students with exactly two marks "2". Use extension methods.*/
        var weakStudents = students.Where(student => student.Marks.Where(mark => mark == 2).Count() == 2);

        foreach (var student in weakStudents)
        {
            Console.WriteLine("{0} ( {1} )", student.FirstName + " " + student.LastName, string.Join(", ", student.Marks));
        }

        Console.WriteLine();

        /*Problem 12 - Extract and print the Marks of the students that enrolled in 2014
         * (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).*/
        var enrolledStudents =
            from student in students
            where student.FacultyNumber.ToString().EndsWith("14")
            select student.Marks;

        var enrolledStudentsLambda = students.Where(student => student.FacultyNumber.ToString().EndsWith("14"));

        foreach (var marks in enrolledStudents)
        {
            Console.WriteLine("( {0} )", string.Join(", ", marks));
            Console.WriteLine();
        }

        Console.WriteLine();

        /*Problem 13 - Add a GroupName property to Student. Write a program that extracts all students grouped by GroupName and then prints them on the console. Print all group names along with the students in each group. Use the "group by into" LINQ operator.*/
        var groupedByGroupName =
            from student in students
            group student by student.GroupName into groupName
            select new { GroupName = groupName.Key, Students = groupName };

        foreach (var item in groupedByGroupName)
        {
            Console.WriteLine(item.GroupName + ":\n" + string.Join("\n", item.Students));
            Console.WriteLine();
        }

        Console.WriteLine();

        /*Problem 14 - Create a class StudentSpecialty that holds specialty name and faculty number. Create a list of student specialties, where each specialty corresponds to a certain student (via the faculty number). Print all student names alphabetically along with their faculty number and specialty name. Use the "join" LINQ operator.*/
        List<StudentSpecialties> specialties = new List<StudentSpecialties>
        {
            new StudentSpecialties("Web Developer", 803213),
            new StudentSpecialties("Web Developer", 862014),
            new StudentSpecialties("PHP Developer", 111512),
            new StudentSpecialties("PHP Developer", 463613),
            new StudentSpecialties("QA Engineer", 096414),
        };

        var joinedLists =
            from student in students
            join specialty in specialties
            on student.FacultyNumber equals specialty.FacultyNumber
            orderby student.FirstName, student.LastName
            select new
            {
                student.FirstName,
                student.LastName,
                student.FacultyNumber,
                specialty.SpecialtyName
            };

        foreach (var item in joinedLists)
        {
            Console.WriteLine("{0} {1} {2} {3}", item.FirstName, item.LastName, item.FacultyNumber, item.SpecialtyName);
        }
    }
}