using System;
using System.Collections.Generic;

public class Student : Person
{
    private static IList<int> busyNumbers = new List<int>();
    private int classNumber;

    public Student(string name, int classNumber, string details = null)
        : base(name, details)
    {
        this.ClassNumber = classNumber;
        Student.busyNumbers.Add(this.ClassNumber);
    }

    public int ClassNumber
    {
        get
        {
            return this.classNumber;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Class number can not be negative!");
            }

            if (Student.busyNumbers.Contains(value))
            {
                throw new ArgumentException("This student number is already busy!");
            }

            this.classNumber = value;
        }
    }
}