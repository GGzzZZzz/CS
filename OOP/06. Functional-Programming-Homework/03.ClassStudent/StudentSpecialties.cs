using System;

public class StudentSpecialties
{
    private string specialtyName;
    private int facultyNumber;

    public StudentSpecialties(string specialtyName, int facultyNumber)
    {
        this.SpecialtyName = specialtyName;
        this.FacultyNumber = facultyNumber;
    }

    public string SpecialtyName
    {
        get
        {
            return this.specialtyName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("SpecialtyName", "Student's specialty can not be null or empty!");
            }

            this.specialtyName = value;
        }
    }

    public int FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Student's faculty number can not be negative!");
            }

            this.facultyNumber = value;
        }
    }
}