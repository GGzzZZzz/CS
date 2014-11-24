using System;
using System.Collections.Generic;

public class Discipline : IDetail
{
    private string name;
    private int numberOfLectures;
    private IList<Student> students;
    private string details;

    public Discipline(string name, int numberOfLectures, IList<Student> students, string details = null)
    {
        this.Name = name;
        this.NumberOfLectures = numberOfLectures;
        this.students = students;
        this.Details = details;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Discipline's name can not be null or empty!");
            }

            this.name = value;
        }
    }

    public int NumberOfLectures
    {
        get
        {
            return this.numberOfLectures;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Number of lectures can not be negative!");
            }

            this.numberOfLectures = value;
        }
    }

    public IList<Student> Students
    {
        get
        {
            return this.students;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Students can not be null!");
            }

            this.students = value;
        }
    }

    public string Details
    {
        get
        {
            return this.details;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Detail can not be empty!");
            }

            this.details = value;
        }
    }
}