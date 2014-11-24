using System;

internal class Student : Person
{
    private int studentNumber;
    private float averageGrade;

    public Student(string firstName, string lastName, int age, int studentNumber, float averageGrade)
        : base(firstName, lastName, age)
    {
        this.StudentNumber = studentNumber;
        this.AverageGrade = averageGrade;
    }

    public int StudentNumber
    {
        get
        {
            return this.studentNumber;
        }

        set
        {
            if (value.ToString().Length < 5)
            {
                throw new ArgumentException("Student number can not be shorter than 5 symbols!", "value");
            }

            this.studentNumber = value;
        }
    }

    public float AverageGrade
    {
        get
        {
            return this.averageGrade;
        }

        set
        {
            if (value < 2.00)
            {
                throw new ArgumentException("Average grade can not be smaller than 2.00!", "value");
            }

            this.averageGrade = value;
        }
    }
}