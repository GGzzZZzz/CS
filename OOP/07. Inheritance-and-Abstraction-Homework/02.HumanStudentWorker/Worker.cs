using System;

public class Worker : Human
{
    private double weekSalary;
    private byte workHoursPerDay;
    private double paymentPerHour;

    public Worker(string firstName, string lastName, double weekSalary, byte workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
        this.PaymentPerHour = this.CalculateMoneyPerHour();
    }

    public double WeekSalary
    {
        get
        {
            return this.weekSalary;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Week salary can not be negative!");
            }

            this.weekSalary = value;
        }
    }

    public byte WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }

        set
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentOutOfRangeException(
                    "Work hours can not be negative or bigger than 24!");
            }

            this.workHoursPerDay = value;
        }
    }

    public double PaymentPerHour
    {
        get { return this.paymentPerHour; }
        set { this.paymentPerHour = value; }
    }

    public double CalculateMoneyPerHour()
    {
        return this.WeekSalary / (this.WorkHoursPerDay * 7);
    }

    public override string ToString()
    {
        return base.ToString() + string.Format(
            " Week Salary:{0:F2}, Work Hours Per Day:{1}, Payment Per Hour:{2:F2}",
            this.WeekSalary,
            this.WorkHoursPerDay,
            this.PaymentPerHour);
    }
}