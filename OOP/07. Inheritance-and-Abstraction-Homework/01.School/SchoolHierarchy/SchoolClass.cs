using System;
using System.Collections.Generic;

public class SchoolClass : IDetail
{
    private static IList<string> busyIds = new List<string>();
    private string textId;
    private IList<Student> students;
    private IList<Teacher> teachers;
    private string details;

    public SchoolClass(
        string textId,
        IList<Student> students,
        IList<Teacher> teachers,
        string details = null)
    {
        this.TextId = textId;
        this.Students = students;
        this.Teachers = teachers;
        this.Details = details;
        SchoolClass.busyIds.Add(this.TextId);
    }

    public string TextId
    {
        get
        {
            return this.textId;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Unique text ID can not be null or empty!");
            }

            if (busyIds.Contains(value))
            {
                throw new ArgumentException("This class number is already busy!");
            }

            this.textId = value;
        }
    }

    public IList<Student> Students
    {
        get
        {
            return this.students;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Students can not be null!");
            }

            this.students = value;
        }
    }

    public IList<Teacher> Teachers
    {
        get
        {
            return this.teachers;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Teachers can not be null!");
            }

            this.teachers = value;
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