using System;

internal class Trainer : Person
{
    public Trainer(string firstName, string lastName, int age)
        : base(firstName, lastName, age)
    {
    }

    public string CreateCourse(string courseName)
    {
        return courseName + " has been created";
    }
}