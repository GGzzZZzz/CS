using System;

public class Student : Human
{
    private int facultyNumber;

    public Student(string firstName, string lastName, int facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public int FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }

        set
        {
            if (value.ToString().Length < 5 || value.ToString().Length > 10)
            {
                throw new ArgumentOutOfRangeException(
                   "facultyNumber", "Faculty number should be 5 - 10 digits long!");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + string.Format("Faculty Number:{0}", this.FacultyNumber);
    }
}