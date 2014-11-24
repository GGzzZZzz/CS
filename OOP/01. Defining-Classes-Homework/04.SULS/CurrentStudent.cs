using System;

internal class CurrentStudent : Student
{
    private string currentCourse;

    public CurrentStudent(string firstName, string lastName, int age, int studentNumber, float averageGrade, string currentCourse)
        : base(firstName, lastName, age, studentNumber, averageGrade)
    {
        this.CurrentCourse = currentCourse;
    }

    public string CurrentCourse
    {
        get
        {
            return this.currentCourse;
        }

        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Current course can not be shorter than 3 symbols!", "value");
            }

            this.currentCourse = value;
        }
    }
}