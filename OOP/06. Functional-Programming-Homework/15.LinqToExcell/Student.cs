using System;
using System.Linq;
using System.Text;

public class Student
{
    private int id;
    private string firstName;
    private string lastName;
    private string email;
    private string gender;
    private string studentType;
    private int examResult;
    private int homeworkSent;
    private int homeworkEval;
    private float teamwork;
    private int attendances;
    private float bonus;
    private float result;

    public Student(int id, string firstName, string lastName, string email, string gender, string studentType, int examResult, int homeworkSent, int homeworkEval, float teamwork, int attendances, float bonus)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Gender = gender;
        this.StudentType = studentType;
        this.ExamResult = examResult;
        this.HomeworkSent = homeworkSent;
        this.HomeworkEval = homeworkEval;
        this.Teamwork = teamwork;
        this.Attendances = attendances;
        this.Bonus = bonus;
        this.Result = (float)CalculateResult();
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string StudentType { get; set; }
    public int ExamResult { get; set; }
    public int HomeworkSent { get; set; }
    public int HomeworkEval { get; set; }
    public float Teamwork { get; set; }
    public int Attendances { get; set; }
    public float Bonus { get; set; }
    public float Result { get; private set; }

    public double CalculateResult()
    {
        return (this.ExamResult + this.HomeworkSent + this.HomeworkEval + this.Teamwork + this.Attendances + this.Bonus) / 5;
    }

    public override string ToString()
    {
        return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}", this.Id, this.FirstName, this.LastName, this.Email, this.Gender, this.StudentType, this.ExamResult, this.HomeworkSent, this.HomeworkEval, this.Teamwork, this.Attendances, this.Bonus, this.Result);
    }
}