using System;

internal class SeniorTrainer : Trainer
{
    public SeniorTrainer(string firstName, string lastName, int age)
        : base(firstName, lastName, age)
    {
    }

    public string DeleteCourse(string courseName)
    {
        return courseName + " has been deleted";
    }
}